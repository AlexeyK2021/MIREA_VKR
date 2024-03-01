using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using opcUaWebMVC.Models.Database;

namespace opcUaWebMVC.Controllers;

public class SensorController : Controller
{
    [HttpGet]
    public IActionResult SensorList()
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            return View(db.Sensors
                .Include(sensor => sensor.sensorChecks)
                .Include(sensor => sensor.plc)
                .Include(sensor => sensor.plc.tank)
                .Include(sensor => sensor.controlParameter)
                .ToList());
        }
    }

    [HttpGet]
    public IActionResult AddSensor()
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            ViewBag.plcs = db.Plcs
                .Include(plc => plc.tank)
                .ToList();
            ViewBag.parameters = db.ControlParameters
                .Include(parameter => parameter.type)
                .ToList();
            return View();
        }
    }

    [HttpPost]
    public IActionResult AddSensor(string name, string model, int plcId, int paramId)
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            var newSensor = new Sensor(name, model, plcId, paramId);
            db.Sensors.Add(newSensor);
            db.SaveChanges();
        }

        return Redirect("/Sensor/SensorList");
    }

    [HttpGet]
    public IActionResult EditSensor(int id)
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            ViewBag.plcs = db.Plcs.Include(plc => plc.tank).ToList();
            ViewBag.parameters = db.ControlParameters.Include(parameter => parameter.type).ToList();

            var sensors = db.Sensors.ToList();
            foreach (var sensor in sensors)
            {
                if (sensor.id == id)
                {
                    ViewBag.sensor = sensor;
                }
            }

            return View();
        }
    }

    [HttpPost]
    public IActionResult EditSensor(string name, string model, int plcId, int paramId, int id, string action)
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            var sensors = db.Sensors.ToList();
            if (action == Locale.Language.EditSensorSaveButton)
            {
                foreach (var s in sensors)
                {
                    if (s.id == id)
                    {
                        s.model = model;
                        s.name = name;
                        s.plcId = plcId;
                        s.controlParameterId = paramId;
                        db.SaveChanges();
                    }
                }
            }
        }
        return Redirect("/Sensor/SensorList");
    }
}