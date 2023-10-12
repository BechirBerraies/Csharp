using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LoginProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http; //session 4 


namespace LoginProject.Controllers;

public class HomeController : Controller
{
    private MyContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }



    [HttpPost("users/create")]
    public IActionResult Register(User newUser)
    {
        if (ModelState.IsValid){
            // Email Exist ?
            if(_context.Users.Any(u => u.Email == newUser.Email))
            {
                //true
                ModelState.AddModelError("Email","Email already used");
                return View("Index");
            }
            else{
                //false 
                //Hash PAssword
            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
            //2 - Add
            _context.Add(newUser); 
            //3 -Save
            _context.SaveChanges();
            HttpContext.Session.SetInt32("userId",newUser.UserId);
            
            }
        }
            return RedirectToAction("Privacy");
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        if(HttpContext.Session.GetInt32("userId")== null)
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