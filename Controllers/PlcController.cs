using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using opcUaWebMVC.Models.Database;

namespace opcUaWebMVC.Controllers;

/// <summary>
/// Controller-класс для работы с ПЛК
/// </summary>
public class PlcController : Controller
{
    [HttpGet]
    public IActionResult AddPlcPage()
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            ViewBag.tanks = db.Tanks.ToList();
        }

        return View();
    }
    
    [HttpPost]
    public IActionResult AddPlcPage(string model, string ip, string port, int tankId)
    {
        var plc = new Plc(model, ip, port, tankId);
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
            plcs = db.Plcs
                .Include(plc => plc.tank)
                .Include(plc => plc.sensors)
                .ToList();
        }
    
        return View(plcs);
    }
    
    [HttpGet]
    public IActionResult EditPlc(int id)
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            var plcs = db.Plcs.Include(plc => plc.tank).ToList();
            var tanks = db.Tanks.ToList();
            foreach (var plc in plcs)
            {
                if (plc.id == id)
                {
                    ViewBag.plc = plc;
                    ViewBag.tanks = tanks;
                    return View();
                }
            }
            return Redirect("/Plc/PlcList");
        }
    }
    
    [HttpPost]
    public IActionResult EditPlc(string model, int tankId, string ip, string port, int id, string action)
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            var plcs = db.Plcs.ToList();
            foreach (var plc in plcs)
            {
                if (plc.id == id)
                {
                    if (action == "Save")
                    {
                        plc.model = model;
                        plc.tankId = tankId;
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