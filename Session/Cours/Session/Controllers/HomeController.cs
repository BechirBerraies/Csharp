using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Session.Models;

// Session Configuration
using Microsoft.AspNetCore.Http;

namespace Session.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        HttpContext.Session.SetString("username" , "Jhon");
        HttpContext.Session.SetInt32("age", 40);
        System.Console.WriteLine($"Username : {HttpContext.Session.GetString("username")}\nAge : {HttpContext.Session.GetInt32("age")}");
        return View();
    }
    [HttpPost("users/create")]
    public IActionResult CreateUser(string name, int age , string favFood)
    {
        System.Console.WriteLine($"Name : {name}\n Age : {age}\n Favorite Food : {favFood} ");
        HttpContext.Session.SetInt32("userAge", age);
        HttpContext.Session.SetString("name", name);
        HttpContext.Session.SetString("favFood", favFood);

        return RedirectToAction("Privacy");
    }

    [HttpPost("session/clear")]
    public IActionResult ClearSession()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

    public IActionResult Privacy()
    {
        if(HttpContext.Session.GetString("name") == null)
        {
            return RedirectToAction("Index");
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
