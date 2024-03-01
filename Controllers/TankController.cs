using Microsoft.AspNetCore.Mvc;
using opcUaWebMVC.Models.Database;

namespace opcUaWebMVC.Controllers;

/// <summary>
/// Controller-класс для работы с автономными емкостями.
/// </summary>
public class TankController : Controller
{
    [HttpGet]
    public IActionResult AddTankPage()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddTankPage(string name, string? description)
    {
        var tank = new Tank(name, description);
        using (ApplicationContext db = new ApplicationContext())
        {
            db.Tanks.Add(tank);
            db.SaveChanges();
        }

        return Redirect("/Tank/TanksList");
    }

    [HttpGet]
    public IActionResult TanksList()
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            return View(db.Tanks.ToList());
        }
    }

    [HttpGet]
    public IActionResult EditTank(int id)
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            var locs = db.Tanks.ToList();

            foreach (var loc in locs)
            {
                if (loc.id == id)
                {
                    return View(loc);
                }
            }

            return Redirect("/Tank/TanksList");
        }
    }

    [HttpPost]
    public IActionResult EditTank(string name, int id, string action)
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            var tanks = db.Tanks.ToList();
            foreach (var tank in tanks)
            {
                if (tank.id == id)
                {
                    if (action == "Save")
                    {
                        tank.name = name;
                        db.SaveChanges();
                    }
                    else if (action == "Delete")
                    {
                        db.Tanks.Remove(tank);
                        db.SaveChanges();
                    }
                }
            }
        }

        return Redirect("/Tank/TanksList");
    }
}