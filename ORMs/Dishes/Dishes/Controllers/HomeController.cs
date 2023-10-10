using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dishes.Models;

namespace Dishes.Controllers;

public class HomeController : Controller
{
    private MyContext _context;
    private readonly ILogger<HomeController> _logger;



    
    [HttpPost("dishes/create")]
    public IActionResult CreateDish(Dish newDish)
{
    if (ModelState.IsValid)
    {
        //1 - Add
        _context.Add(newDish);
        //2 - Save
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    return View("Privacy");
}

    [HttpPost("Home/DeleteDish")]
    public IActionResult DeleteDish(int dishId)
    {
        Dish? DishToDelete = _context.Dishes.FirstOrDefault(s => s.DishId == dishId);
        // 1 - Delete
        _context.Dishes.Remove(DishToDelete);
        // 2 - Save
        _context.SaveChanges();
        return RedirectToAction("Index");
    }


    

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context; 
    }

    public IActionResult Index()
    {
        List<Dish> AllDishes = _context.Dishes.ToList();
        return View(AllDishes);
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    [HttpGet("Dish/{dishId}/view")]
    public IActionResult Regard(int dishId)
    {
        Dish? DishtoShow = _context.Dishes.FirstOrDefault(d => d.DishId == dishId);
        ViewBag.DishtoShow = DishtoShow;
        return View();
    }


       [HttpGet("dish/{dishId}/edit")]
    public IActionResult Edit(int dishId)
    {
        Dish? DishtoEdit = _context.Dishes.FirstOrDefault(q => q.DishId == dishId);
        return View(DishtoEdit);
    }

    [HttpPost("")]
    public IActionResult UpdateDish(Dish editedDish)
    {
        Dish? DishToUpdate = _context.Dishes.FirstOrDefault(q => q.DishId == editedDish.DishId);
        if (ModelState.IsValid)
        {
            DishToUpdate.Name = editedDish.Name;
            DishToUpdate.Chef = editedDish.Chef;
            DishToUpdate.Tastiness = editedDish.Tastiness;
            DishToUpdate.Calories = editedDish.Calories;
            DishToUpdate.Description = editedDish.Description;
            DishToUpdate.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View("Edit", DishToUpdate);
    }











    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
