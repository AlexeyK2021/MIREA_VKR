using Microsoft.AspNetCore.Mvc;
using opcUaWebMVC.Models;

namespace opcUaWebMVC.Controllers;

/// <summary>
/// Controller-класс для обработки пользователей
/// </summary>
public class UserController : Controller
{
    /// <summary>
    /// Метод возврата страницы создания нового пользователя
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public IActionResult AddUserPage()
    {
        return View();
    }

    /// <summary>
    /// Метод добавления нового пользователя в БД
    /// </summary>
    /// <param name="name">Имя пользователя</param>
    /// <param name="login">Логин пользователя для входа</param>
    /// <param name="passwd">Пароль пользователя для входа</param>
    /// <param name="admin">Переменная для задания пользователю админского статуса</param>
    /// <returns>Переадрессация на страницу-список пользователей</returns>
    [HttpPost]
    public IActionResult AddUserPage(string name, string login, string passwd, bool admin)
    {
        var newUser = new User(name, login, passwd, admin);
        using (ApplicationContext db = new ApplicationContext())
        {
            db.Users.Add(newUser);
            db.SaveChanges();
        }

        return Redirect("/User/UserList");
    }

    /// <summary>
    /// Метод возврата страницы-списка пользователей
    /// </summary>
    /// <returns></returns>
    public IActionResult UserList()
    {
        var users = new List<User>();
        using (ApplicationContext db = new ApplicationContext())
        {
            users = db.Users.ToList();
        }

        return View(users);
    }

    /// <summary>
    /// Метод страницы изменения пользователя
    /// </summary>
    /// <param name="id">ID-номер пользователя для изменения</param>
    /// <returns></returns>
    [HttpGet]
    public IActionResult EditUser(int id)
    {
        var users = new List<User>();

        using (ApplicationContext db = new ApplicationContext())
        {
            users = db.Users.ToList();
        }

        foreach (var user in users)
        {
            if (user.id == id)
            {
                return View(user);
            }
        }

        return Redirect("/User/UserList");
    }

    /// <summary>
    /// Метод сохранения изменений пользователя в БД
    /// </summary>
    /// <param name="name">Имя пользователя</param>
    /// <param name="login">Логин пользователя для входа</param>
    /// <param name="passwd">Пароль пользователя для входа</param>
    /// <param name="admin">Статус админа (да/нет)</param>
    /// <param name="id">ID-номер пользователя</param>
    /// <param name="action">Действие кнопок (изменить/удалить)</param>
    /// <returns></returns>
    [HttpPost]
    public IActionResult EditUser(string name, string login, string passwd, bool admin, int id, string action)
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            var users = db.Users.ToList();
            foreach (var user in users)
            {
                if (user.id == id)
                {
                    if (action == "Save")
                    {
                        user.name = name;
                        user.login = login;
                        user.passwd = passwd;
                        user.isAdmin = admin;
                        db.SaveChanges();
                    }
                    else if (action == "Delete")
                    {
                        db.Users.Remove(user);
                        db.SaveChanges();
                    }

                    break;
                }
            }
        }

        return Redirect("/User/UserList");
    }
}