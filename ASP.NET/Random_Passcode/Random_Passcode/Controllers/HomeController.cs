﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Random_Passcode.Models;

namespace Random_Passcode.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    // Method Post 
    [httpPost("random")]
    public IActionResult Result()
    {
         Random rnd = new Random();
    int cd = rnd.Next(0,10);
    }




    public IActionResult Index()
    {
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}



