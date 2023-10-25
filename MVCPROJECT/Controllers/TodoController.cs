using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCPROJECT.Models;

namespace MVCPROJECT.Controllers;

public class TodoController : Controller
{

    public TodoController ()
    {
    }

    public IActionResult Index()
    {
        return View();
    }

   [HttpGet]
    public IActionResult Todo()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Todo(int id, string title, string description)
    {
        ViewBag.AddedItem = new { Id = id, Title = title, Description = description };
        return View();
    }
}
