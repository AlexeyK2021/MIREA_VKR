using Microsoft.AspNetCore.Mvc;

namespace opcUaWebMVC.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;
    private string? loggedUsername = null;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult AuthPage(string login, string passwd)
    {
        loggedUsername = login;
        Console.Write($"Login:{login}, passwd:{passwd}");
        return Redirect("/Home/Index");
    }

    [HttpGet]
    public IActionResult AuthPage()
    {
        return View(viewName: "AuthPage");
    }
}