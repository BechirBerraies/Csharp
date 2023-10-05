using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.controllers;

public class MyController : Controller 
{
[HttpGet]
[Route("")]

public ViewResult Index()
{
        return View("Dashboard");
}
[HttpGet("/result")]
public ViewResult Result()
{
    return View("Result");
}






[HttpPost("result")]
public IActionResult Result(string name , string location, string language, string text)
{
    ViewBag.Name= name;
    ViewBag.location = location;
    ViewBag.language = language;
    ViewBag.text =text;
    
    System.Console.WriteLine($"From Fata \n Name : {name}\n Location : {location}\n Language: {language}\n Text : {text} ");
    return View("Result");
}







}