using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BeltExam.Models;
using Microsoft.EntityFrameworkCore;

namespace BeltExam.Controllers;

public class SupportsController : Controller
{


    private readonly MyContext _context;
    public SupportsController(MyContext context)
    {
        _context = context;
    }



[HttpPost("support/create")]
public IActionResult Support(Support newSupport)
{
    if(ModelState.IsValid)
    {
        int? userId = (int)HttpContext.Session.GetInt32("userId");
        // if(newSupport.UserId == userId){
        //     ModelState.AddModelError("Amount", "You Can't Support Your Own Project");
        //     return Redirect($"/projects/{newSupport.ProjectId}");
        // }
        // else{

    //1 Add 
        _context.Add(newSupport);

    //2 Save
    _context.SaveChanges();
    return RedirectToAction("ViewProject","Projects",new {id = newSupport.ProjectId});
        // }
    }
    Project project = _context.Projects.Include(proj => proj.Supporters)
                                    .ThenInclude(proj => proj.User)
                                    .FirstOrDefault(proj => proj.ProjectId == newSupport.ProjectId);
    return View("~/Views/Projects/ViewProject.cshtml", project) ;   
}







    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
