using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.controllers;


public class FirstController : Controller
{
    //Routes
    /*

    path = url
    python
    app.route('/users',methods=['GET])
    def users():
        return smt
    
    */
    //Method Get
    [HttpGet]
    //! http://localhost:5052/
    [Route("first")]
    //! Associated function 
    public string Index()
    {
        return "Hello From first Controller";
    }

    //second route
    //! http://localhost:5052/html
    [HttpGet("html")]
    public string Html()
    {
        return "<h1>This is h1 tag from first controlle </h1>";
    }

    // Third route 
    [HttpGet("/params/{username}/{age}")]
    public string Parmas(string username, int age )
    {
        return $"Username : {username}\n Age :  {age}";
    }
    [HttpGet("")]
    public ViewResult Indexx()
    {
        return View("index");
    }
    [HttpGet("dashboard")]
    public ViewResult Dashboard()
    {
        return View("Dashboard");
    }
    [HttpGet("second/{name}/{favNumber}")]
    public ViewResult Second(string name, int favNumber)
    {

        System.Console.WriteLine($"User NAme : {name} \nFavorite Number : {favNumber}");
        ViewBag.Name = name;
        ViewBag.FavNumber = favNumber;

        return View();
    }
    [HttpPost("process")]
    public IActionResult Process(string name , int favNumber)
    {
        if(name == "")
        {
            return RedirectToAction("Dashboard");
        }

        System.Console.WriteLine($"From Fata \n Name : {name}\n Favorite Number {favNumber}");
        ViewBag.Name= name;
        ViewBag.favNumber = favNumber;
        return View("Second");
    }
    //garde route - catch all route
    [HttpGet("{**path}")]
    public ViewResult Error()
    {
        return View();
    }
}