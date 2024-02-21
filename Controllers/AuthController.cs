using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using opcUaWebMVC.Models;

namespace opcUaWebMVC.Controllers;

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

public class AuthController : Controller
{
    // private readonly ILogger<AuthController> _logger;

    // public AuthController(ILogger<AuthController> logger)
    // {
    //     _logger = logger;
    // }

    [HttpPost]
    public IActionResult AuthPage(string login, string passwd)
    {
        Console.WriteLine($"Login:{login}, passwd:{passwd}");
        var users = new List<User>();
        using (ApplicationContext db = new ApplicationContext())
        {
            users = db.Users.ToList();
            foreach (var user in users)
            {
                if (user.login.Equals(login) && user.passwd.Equals(passwd))
                {
                    Console.WriteLine("Login Success :)");
                    UserSingleton.GetInstance().currentUser = user;
                    return Redirect("/Home/Index");
                }
            }
        }

        Console.WriteLine("Login Failed :(");
        return Redirect("/Auth/AuthPage");
    }

    [HttpGet]
    public IActionResult AuthPage()
    {
        Console.WriteLine($"Current user {UserSingleton.GetInstance().currentUser?.name}");
        return View("AuthPage");
    }

    public IActionResult Logout()
    {
        UserSingleton.GetInstance().currentUser = null;
        return Redirect("/Auth/AuthPage");
    }
}