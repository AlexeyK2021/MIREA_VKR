using Microsoft.AspNetCore.Mvc;
using opcUaWebMVC.Models.Database;

namespace opcUaWebMVC.Controllers;

/// <summary>
/// Controller-класс для работы с расположением (location) ПЛК.
/// </summary>
public class LocationController : Controller
{
    
    /// <summary>
    /// Метод ответа страницей создания расположения пользователю
    /// </summary>
    /// <returns>Страница создания расположения (location)</returns>
    [HttpGet]
    public IActionResult AddLocationPage()
    {
        return View();
    }

    
    /// <summary>
    /// Метод создания расположения ПЛК
    /// </summary>
    /// <param name="name">Имя расположения</param>
    /// <returns>Переадрессация на список расположений</returns>
    [HttpPost]
    public IActionResult AddLocationPage(string name)
    {
        var loc = new Tank(name);
        Console.WriteLine(loc.ToString());
        // using (ApplicationContext db = new ApplicationContext())
        // {
        //     db.Locations.Add(loc);
        //     db.SaveChanges();
        // }

        return Redirect("/Location/LocationList");
    }

    /// <summary>
    /// Метод ответа пользователю страницей списка расположений
    /// </summary>
    /// <returns>Страница списка расроложений</returns>
    // [HttpGet]
    // public IActionResult LocationList()
    // {
    //     using (ApplicationContext db = new ApplicationContext())
    //     {
    //         return View(db.Locations.ToList());
    //     }
    // }

    /// <summary>
    /// Метод изменения параметров расположения
    /// </summary>
    /// <param name="id">ID-номер расположения</param>
    /// <returns>Переадрессация на список расположений</returns>
    // [HttpGet]
    // public IActionResult EditLocation(int id)
    // {
    //     var locs = new List<Location>();
    //     using (ApplicationContext db = new ApplicationContext())
    //     {
    //         locs = db.Locations.ToList();
    //     }
    //
    //     foreach (var loc in locs)
    //     {
    //         if (loc.id == id)
    //         {
    //             return View(loc);
    //         }
    //     }
    //     return Redirect("/Location/LocationList");
    // }
    /// <summary>
    /// Метод сохранения иззменений расположения
    /// </summary>
    /// <param name="name"Имя расположения</param>
    /// <param name="id">ID-номер расположения</param>
    /// <param name="action">Параметр для определения действия (изменение/удаление)</param>
    /// <returns>Переадрессация на список расположений</returns>
    // [HttpPost]
    // public IActionResult EditLocation(string name, int id, string action)
    // {
    //     using (ApplicationContext db = new ApplicationContext())
    //     {
    //         var locations = db.Locations.ToList();
    //         foreach (var loc in locations)
    //         {
    //             if (loc.id == id)
    //             {
    //                 if (action == "Save")
    //                 {
    //                     loc.name = name;
    //                     db.SaveChanges();
    //                 }
    //                 else if (action == "Delete")
    //                 {
    //                     db.Locations.Remove(loc);
    //                     db.SaveChanges();
    //                 }
    //             }
    //         }
    //     }
    //
    //     return Redirect("/Location/LocationList");
    // }
}