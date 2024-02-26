using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using opcUaWebMVC.Models.Database;

namespace opcUaWebMVC.Controllers;

public class PlcController : Controller
{
    [HttpGet]
    public IActionResult AddPlcPage()
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            ViewBag.locations = db.Locations.ToList();
        }

        return View();
    }

    [HttpPost]
    public IActionResult AddPlcPage(string ip, string port, int locationId, string name)
    {
        var plc = new Plc(ip, port, locationId, name);
        Console.WriteLine(plc.ToString());
        using (ApplicationContext db = new ApplicationContext())
        {
            db.Plcs.Add(plc);
            db.SaveChanges();
        }

        return Redirect("/Plc/PlcList");
    }

    public IActionResult PlcList()
    {
        var plcs = new List<Plc>();
        using (ApplicationContext db = new ApplicationContext())
        {
            plcs = db.Plcs.Include(plc => plc.location).ToList();
        }

        return View(plcs);
    }

    [HttpGet]
    public IActionResult EditPlc(int id)
    {
        var plcs = new List<Plc>();
        var locations = new List<Location>();
        using (ApplicationContext db = new ApplicationContext())
        {
            plcs = db.Plcs.Include(plc => plc.location).ToList();
            locations = db.Locations.ToList();
        }

        foreach (var plc in plcs)
        {
            if (plc.id == id)
            {
                ViewBag.plc = plc;
                ViewBag.locations = locations;
                return View();
            }
        }

        return Redirect("/Plc/PlcList");
    }

    [HttpPost]
    public IActionResult EditPlc(string name, int locationId, string ip, string port, int id, string action)
    {
        Console.WriteLine($"name={name}; location={locationId}; ip={ip}; port={port}; id={id}; ");
        var plcs = new List<Plc>();
        using (ApplicationContext db = new ApplicationContext())
        {
            plcs = db.Plcs.ToList();
            foreach (var plc in plcs)
            {
                if (plc.id == id)
                {
                    if (action == "Save")
                    {
                        plc.name = name;
                        plc.locationId = locationId;
                        plc.ip = ip;
                        plc.port = port;
                        db.SaveChanges();
                    }
                    else if (action == "Delete")
                    {
                        db.Plcs.Remove(plc);
                        db.SaveChanges();
                    }
                }
            }
        }

        return Redirect("/Plc/PlcList");
    }
    
}