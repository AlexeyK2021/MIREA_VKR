using Microsoft.AspNetCore.Mvc;
using opcUaWebMVC.Models;

namespace opcUaWebMVC.Controllers;

public class UserController : Controller
{
    [HttpGet]
    public IActionResult AddUserPage()
    {
        return View();
    }

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

    public IActionResult UserList()
    {
        var users = new List<User>();
        using (ApplicationContext db = new ApplicationContext())
        {
            users = db.Users.ToList();
        }

        return View(users);
    }

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