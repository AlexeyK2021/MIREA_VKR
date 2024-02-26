using Microsoft.AspNetCore.Mvc;
using opcUaWebMVC.Models.Database;

namespace opcUaWebMVC.Controllers;

public class LocationController : Controller
{
    [HttpGet]
    public IActionResult AddLocationPage()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddLocationPage(string name)
    {
        var loc = new Location(name);
        Console.WriteLine(loc.ToString());
        using (ApplicationContext db = new ApplicationContext())
        {
            db.Locations.Add(loc);
            db.SaveChanges();
        }

        return Redirect("/Plc/PlcList");
    }

    [HttpGet]
    public IActionResult LocationList()
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            return View(db.Locations.ToList());
        }
    }

    [HttpGet]
    public IActionResult EditLocation(int id)
    {
        var locs = new List<Location>();
        using (ApplicationContext db = new ApplicationContext())
        {
            locs = db.Locations.ToList();
        }

        foreach (var loc in locs)
        {
            if (loc.id == id)
            {
                return View(loc);
            }
        }
        return Redirect("/Location/LocationList");
    }
    [HttpPost]
    public IActionResult EditLocation(string name, int id, string action)
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            var locations = db.Locations.ToList();
            foreach (var loc in locations)
            {
                if (loc.id == id)
                {
                    if (action == "Save")
                    {
                        loc.name = name;
                        db.SaveChanges();
                    }
                    else if (action == "Delete")
                    {
                        db.Locations.Remove(loc);
                        db.SaveChanges();
                    }
                }
            }
        }

        return Redirect("/Location/LocationList");
    }
}