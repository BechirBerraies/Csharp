using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LogReg.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace LogReg.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpPost("logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

    [HttpPost("users/login")]
    public IActionResult Login(LoginUser loginUser)
    {
        if (ModelState.IsValid)
        {
            // User Registered ?
            User? userFromDb = _context.Users.FirstOrDefault(u => u.Email == loginUser.LoginEmail);
            if (userFromDb is null)
            {
                ModelState.AddModelError("LoginEmail", "Email dose not exist !");
                return View("Index");
            }
            else
            {
                // Initialize hasher object
                var hasher = new PasswordHasher<LoginUser>();

                // verify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(loginUser, userFromDb.Password, loginUser.LoginPassword);

                // result can be compared to 0 for failure
                if (result == 0)
                {
                    // handle failure (this should be similar to how "existing email" is handled)
                    ModelState.AddModelError("LoginPassword", "Wrong Password !");
                    return View("Index");
                }
                else
                {
                    HttpContext.Session.SetInt32("userId", userFromDb.UserId);
                    HttpContext.Session.SetString("username", userFromDb.FirstName);
                    return RedirectToAction("Privacy");
                }
            }
        }
        return View("Index");

    }





// Registration
[HttpPost("users/create")]
    public IActionResult Register(User newUser)
    {
        if (ModelState.IsValid)
        {
            // Email Exist ?
            if (_context.Users.Any(u => u.Email == newUser.Email))
            {
                // True
                ModelState.AddModelError("Email", "Email already in use .");
                return View("Index");
            }
            else
            {
                // False
                // 1 - Hash Password
                var Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                // 2 - Add 
                _context.Add(newUser);
                // 3 - Save
                _context.SaveChanges();
                HttpContext.Session.SetInt32("userId", newUser.UserId);
                HttpContext.Session.SetString("username", newUser.FirstName);
                // HttpContext.Session.
                return RedirectToAction("Privacy");
            }
        }
        return View("Index");
    }


    
    //*********************************************** POST *************************************

    public IActionResult AllPosts()
    {
    if(HttpContext.Session.GetInt32("userId") == null)
        {
            return RedirectToAction("Index");
        }

        List<Post> AllPostsWithPoster = _context.Posts.Include(p => p.PostLikes).ToList();
        AllPostsView AllPostsView = new()
        {
            AllPosts = AllPostsWithPoster

        };
        return View(AllPostsView);
    }

    [HttpPost("posts/create")]
    public IActionResult CreatePost(Post newPost)
    {
        if(ModelState.IsValid)
        {
            //1 Add 
            _context.Add(newPost);

            //2 Save 
            _context.SaveChanges();
            return RedirectToAction("Privacy");
        }
        List<Post> AllPosts = _context.Posts.Where(p => p.UserId == newPost.UserId).ToList();
        ViewBag.AllPosts = AllPosts;
        return RedirectToAction("Privacy");
    }






 //*********************************************** PROFILE *************************************

public IActionResult Profile()
    {
        if (HttpContext.Session.GetInt32("userId") == null)
        {
            return RedirectToAction("Index");
        }
        int? userId = (int)HttpContext.Session.GetInt32("userId");
        User? user = _context.Users.Include(u => u.MyPosts).ThenInclude(p => p.PostLikes).FirstOrDefault(u => u.UserId == userId);
        return View(user);
    }













//*********************************************** POST *************************************




    public IActionResult Index()
    {
        if(HttpContext.Session.GetInt32("userId") is not null)
        {
            return RedirectToAction("Privacy");
        }
        return View();
    }

    public IActionResult Privacy()
    {
        if (HttpContext.Session.GetInt32("userId") == null)
        {
            return RedirectToAction("Index");
        }
        int? userId = (int)HttpContext.Session.GetInt32("userId");
        User? user = _context.Users.FirstOrDefault(u => u.UserId == userId);
        List<Post> AllPosts = _context.Posts.Where(p => p.UserId == userId).ToList();
        ViewBag.AllPosts = AllPosts;
        return View();
    }

// *********************************************** LIKES *************************************



[HttpPost("likes/create")]
public IActionResult Like(Like newLike)
{
    if(ModelState.IsValid)
    {
    //1 Add 
        _context.Add(newLike);

    //2 Save
    _context.SaveChanges();
    return RedirectToAction("AllPosts");
    }
return RedirectToAction("AllPosts");
    
}


    
[HttpPost("likes/destroy")]
public IActionResult UnLike(Like LikeToDelete)
{
    if(ModelState.IsValid)
    {
    //1 Add 
        _context.Remove(LikeToDelete);

    //2 Save
    _context.SaveChanges();
    return RedirectToAction("AllPosts");
    }
return RedirectToAction("AllPosts");
    
}












    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


