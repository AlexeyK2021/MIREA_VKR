using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using opcUaWebMVC.Models;

namespace opcUaWebMVC.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;

    // public AuthController(ILogger<AuthController> logger)
    // {
    //     _logger = logger;
    // }

    [HttpPost]
    public IActionResult AuthPage(string login, string passwd)
    {
        Console.WriteLine($"Login:{login}, passwd:{passwd}");
        foreach (var user in UserRepository.users)
        {
            if (user.login.Equals(login) && user.passwd.Equals(passwd))
            {
                Console.WriteLine("Login Success :)");
                return Redirect("/Home/Index");
            }
        }
        Console.WriteLine("Login Failed :(");
        return Redirect("/Auth/AuthPage");
    }

    [HttpGet]
    public IActionResult AuthPage()
    {
        return View("AuthPage");
    }
}