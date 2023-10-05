using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;


namespace ProjectName.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public static List<Song> AllSongsList = new List<Song>();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    // METHOD GET : / : Create A Song
    public IActionResult Index()
    {
        return View();
    }
    // Method POST : songs/create :Create a Song 
    // NEver Ever Render with Post request ==> Always Redirect
    // [HttpPost("/songs/create")]
    // public IActionResult CreateSong(string Title, string Singer, int ReleaseYear, bool IsExplicit)
    // {
    //     System.Console.WriteLine($"Title : {Title}\n Singer : {Singer}\n ReleaseYear : {ReleaseYear}\n IsExplicit : {IsExplicit}\n  ");
    //     ViewBag.Title = Title;
    //     ViewBag.Singer = Singer;
    //     ViewBag.ReleaseYear = ReleaseYear;
    //     ViewBag.IsExplicit = IsExplicit;
    //     return RedirectToAction("AllSongs");
    // }



    // NEver Ever Render with Post request ==> Always Redirect
    [HttpPost("/songs/create")]
    public IActionResult CreateSong(Song newSong)
    {
        if(ModelState.IsValid){

        System.Console.WriteLine($"Title : {newSong.Title}\n Singer : {newSong.Singer}\n ReleaseYear : {newSong.ReleaseYear}\n IsExplicit : {newSong.IsExplicit}\n  ");
        AllSongsList.Add(newSong);
        return RedirectToAction("AllSongs");
        }
        return View("Index");
    }



    // MEthod Get : /allSongs : Display all Songs 
    public IActionResult AllSongs()
    {
        return View(AllSongsList);
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
