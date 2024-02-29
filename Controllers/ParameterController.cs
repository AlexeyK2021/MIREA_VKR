using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using opcUaWebMVC.Models.Database;

namespace opcUaWebMVC.Controllers;

public class ParameterController : Controller
{
    [HttpGet]
    public IActionResult ParametersList()
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            return View(db.ControlParameters
                .Include(parameter => parameter.opcName)
                .Include(parameter => parameter.type)
                .Include(parameter => parameter.sensor)
                .ToList());
        }
    }

    [HttpGet]
    public IActionResult AddParameter()
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            ViewBag.types = db.ParameterType.ToList();
            return View();
        }
    }

    [HttpPost]
    public IActionResult AddParameter(string name, float min, float max, string opcMin, string opcMax,
        string opcCurr, int typeId)
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            var opcNames = new ParamOpcNames(opcMin, opcMax, opcCurr);
            db.ParamOpcNames.Add(opcNames);
            db.SaveChanges();
            var newParameter = new ControlParameter(name, min, max, typeId);
            newParameter.opcName = opcNames;
            db.ControlParameters.Add(newParameter);
            db.SaveChanges();
        }

        return Redirect("/Parameter/ParametersList");
    }

    public IActionResult EditParameter()
    {
        throw new NotImplementedException();
    }
}