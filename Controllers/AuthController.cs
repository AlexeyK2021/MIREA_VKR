using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using opcUaWebMVC.Models;

namespace opcUaWebMVC.Controllers;

/// <summary>
/// Singleton-класс для хранения текущего пользователя
/// </summary>
public class UserSingleton
{
    private static UserSingleton? instance;
    public User? currentUser { get; set; }

    private UserSingleton()
    {
    }

    public static UserSingleton GetInstance()
    {
        if (instance == null)
        {
            instance = new UserSingleton();
        }

        return instance;
    }
}

/// <summary>
/// Controller-класс для обработки страницы авторизации пользователя
/// </summary>
public class AuthController : Controller
{
    /// <summary>
    /// Метод для получения данных входа пользователя. Сравнивает данные с БД
    /// </summary>
    /// <param name="login">Логин пользователя</param>
    /// <param name="passwd">Пароль пользователя</param>
    /// <returns>Переадрессация на главную страницу или страницу входа</returns>
    [HttpPost]
    public IActionResult AuthPage(string login, string passwd)
    {
        Logger.debug("AuthPage", $"Login:{login}, passwd:{passwd}");
        var users = new List<User>();
        using (ApplicationContext db = new ApplicationContext())
        {
            users = db.Users.ToList();
            foreach (var user in users)
            {
                if (user.login.Equals(login) && user.passwd.Equals(passwd))
                {
                    Logger.debug("AuthPage", "Login Success :)");
                    UserSingleton.GetInstance().currentUser = user;
                    return Redirect("/Home/Index");
                }
            }
        }

        return Redirect("/Auth/AuthPage");
    }

    /// <summary>
    /// Метод ответа пользователю. Отправляет страницу пользователю
    /// </summary>
    /// <returns>View страницы входа</returns>
    [HttpGet]
    public IActionResult AuthPage()
    {
        return View();
    }


    /// <summary>
    /// Метод выхода из системы
    /// </summary>
    /// <returns>Переадрессация на страницу входа</returns>
    public IActionResult Logout()
    {
        UserSingleton.GetInstance().currentUser = null;
        return Redirect("/Auth/AuthPage");
    }
}