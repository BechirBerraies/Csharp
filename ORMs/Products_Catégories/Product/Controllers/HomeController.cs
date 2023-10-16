using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Product.Models;

namespace Product.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;


    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }


    





// ***************************************PRODUCT ********************************
    


        public IActionResult Index()
    {
        List<Produit> AllProducts = _context.Produits.ToList();
        ViewBag.AllProducts = AllProducts;
        return View();
    }


    [HttpGet("produit/{id}")]
    public IActionResult ViewProduct(int id)
    {

    
        return View();
    }

    
    
    [HttpPost("produit/create")]
    public IActionResult CreateProduct(Produit newProduit)
    {
        if(ModelState.IsValid)
        {
            //1 Add 
            _context.Add(newProduit);

            //2 Save 
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        List<Produit> AllProducts = _context.Produits.ToList();
        ViewBag.AllProducts = AllProducts;
        return RedirectToAction("Index");
    }





// **************************************CATEGORIES ******************************
   
       public IActionResult Privacy()
    {
        List<Categories> AllCategories = _context.Categories.ToList();
        ViewBag.AllCategories = AllCategories;
        return View();
    }


   
   
[HttpPost("category/create")]
    public IActionResult CreateCategory(Categories newCategory)
    {
        if(ModelState.IsValid)
        {
            //1 Add 
            _context.Add(newCategory);

            //2 Save 
            _context.SaveChanges();
            return RedirectToAction("Privacy");
        }
        List<Categories> AllCategories = _context.Categories.ToList();
        ViewBag.AllCategories = AllCategories;
        return RedirectToAction("Privacy");
    }



// ********************************* ASSOCIATE *******************************

[HttpPost("association/create")]
public IActionResult Associate(Association newAssociation)
{
    if(ModelState.IsValid)
    {
    //1 Add 
        _context.Add(newAssociation);

    //2 Save
    _context.SaveChanges();
    return RedirectToAction("ViewProduct");
    }
return RedirectToAction("ViewProduct");
    
}






    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


















}
