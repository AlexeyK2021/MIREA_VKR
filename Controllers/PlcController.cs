using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using opcUaWebMVC.Models.Database;

namespace opcUaWebMVC.Controllers;

/// <summary>
/// Controller-класс для работы с ПЛК
/// </summary>
public class PlcController : Controller
{
    /// <summary>
    /// Метод ответа пользователю страницей для добавления нового ПЛК
    /// </summary>
    /// <returns>Страница для добавления ПЛК</returns>
    // [HttpGet]
    // public IActionResult AddPlcPage()
    // {
    //     using (ApplicationContext db = new ApplicationContext())
    //     {
    //         ViewBag.locations = db.Locations.ToList();
    //     }
    //
    //     return View();
    // }

    /// <summary>
    /// Метод для внесения ПЛК в БД
    /// </summary>
    /// <param name="ip">IP-адрес ПЛК</param>
    /// <param name="port">Порт OPC UA ПЛК</param>
    /// <param name="locationId">ID расположения ПЛК</param>
    /// <param name="name">Имя ПЛК</param>
    /// <returns>Переадрессация на страницу со списком ПЛК</returns>
    // [HttpPost]
    // public IActionResult AddPlcPage(string ip, string port, int locationId, string name)
    // {
    //     var plc = new Plc(ip, port, locationId, name);
    //     Console.WriteLine(plc.ToString());
    //     using (ApplicationContext db = new ApplicationContext())
    //     {
    //         db.Plcs.Add(plc);
    //         db.SaveChanges();
    //     }
    //
    //     return Redirect("/Plc/PlcList");
    // }

    /// <summary>
    /// Метод возврата страницы со списком ПЛК
    /// </summary>
    /// <returns>Страница-список ПЛК</returns>
    // public IActionResult PlcList()
    // {
    //     var plcs = new List<Plc>();
    //     using (ApplicationContext db = new ApplicationContext())
    //     {
    //         plcs = db.Plcs.Include(plc => plc.location).ToList();
    //     }
    //
    //     return View(plcs);
    // }

    /// <summary>
    /// Метод отправки страницы изменения данных о ПЛК
    /// </summary>
    /// <param name="id">ID-номер ПЛК для изменения данных</param>
    /// <returns>Переадрессация на страницу-список ПЛК</returns>
    // [HttpGet]
    // public IActionResult EditPlc(int id)
    // {
    //     var plcs = new List<Plc>();
    //     var locations = new List<Location>();
    //     using (ApplicationContext db = new ApplicationContext())
    //     {
    //         plcs = db.Plcs.Include(plc => plc.location).ToList();
    //         locations = db.Locations.ToList();
    //     }
    //
    //     foreach (var plc in plcs)
    //     {
    //         if (plc.id == id)
    //         {
    //             ViewBag.plc = plc;
    //             ViewBag.locations = locations;
    //             return View();
    //         }
    //     }
    //
    //     return Redirect("/Plc/PlcList");
    // }

    /// <summary>
    /// Метод внесения новых данных о ПЛК в БД
    /// </summary>
    /// <param name="name">Имя ПЛК</param>
    /// <param name="locationId">Расположение ПЛК</param>
    /// <param name="ip">IP-адрес ПЛК</param>
    /// <param name="port">Порт OPC UA ПЛК</param>
    /// <param name="id">ID-номер ПЛК</param>
    /// <param name="action">Параметр для определения действия (изменение/удаление)</param>
    /// <returns>Переадрессация на страницу-список ПЛК</returns>
    // [HttpPost]
    // public IActionResult EditPlc(string name, int locationId, string ip, string port, int id, string action)
    // {
    //     Console.WriteLine($"name={name}; location={locationId}; ip={ip}; port={port}; id={id}; ");
    //     var plcs = new List<Plc>();
    //     using (ApplicationContext db = new ApplicationContext())
    //     {
    //         plcs = db.Plcs.ToList();
    //         foreach (var plc in plcs)
    //         {
    //             if (plc.id == id)
    //             {
    //                 if (action == "Save")
    //                 {
    //                     plc.name = name;
    //                     plc.locationId = locationId;
    //                     plc.ip = ip;
    //                     plc.port = port;
    //                     db.SaveChanges();
    //                 }
    //                 else if (action == "Delete")
    //                 {
    //                     db.Plcs.Remove(plc);
    //                     db.SaveChanges();
    //                 }
    //             }
    //         }
    //     }
    //
    //     return Redirect("/Plc/PlcList");
    // }
}