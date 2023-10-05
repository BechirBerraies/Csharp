using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Survey.Models;

namespace Survey.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

public static List<Student> AllStudents = new List<Student>();


    // GET A
    public IActionResult Index()
    {
        return View("Index");
    }

    // POST method 
    [HttpPost("/student/create")]
    public IActionResult CreateStudent(Student newStudent)
    {
        if(ModelState.IsValid){

        System.Console.WriteLine($"Title : {newStudent.Name}\n Singer : {newStudent.Location}\n ReleaseYear : {newStudent.Language}\n IsExplicit : {newStudent.Comment}\n  ");
        AllStudents.Add(newStudent);
        return RedirectToAction("AllStudents");
        }
        return View("Index");
    }

    [HttpGet("/Home/AllStudents")]
    public IActionResult StudentPAge()
    {

        return View(AllStudents);
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
