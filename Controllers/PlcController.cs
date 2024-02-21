using Microsoft.AspNetCore.Mvc;
using opcUaWebMVC.Models.Database;

namespace opcUaWebMVC.Controllers;

public class PlcController: Controller
{

    [HttpGet]
    public IActionResult AddPlcPage()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult AddPlcPage(string ip, string port, string location)
    {
        var plc = new Plc(ip, port, location);
        Console.WriteLine(plc);
        using (ApplicationContext db = new ApplicationContext())
        {
            db.Plcs.Add(plc);
            db.SaveChanges();
        }
        return Redirect("/Home/Index");
    }
    
    public IActionResult PlcList()
    {
        var plcs = new List<Plc>();
        using (ApplicationContext db = new ApplicationContext())
        {
            plcs = db.Plcs.ToList();
        }
        return View(plcs);
    }
}