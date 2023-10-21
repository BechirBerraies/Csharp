using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BeltExam.Models;
using Microsoft.EntityFrameworkCore;

namespace BeltExam.Controllers;

public class ProjectsController : Controller
{


    private readonly MyContext _context;
    public ProjectsController(MyContext context)
    {
        _context = context;
    }


    [HttpGet("/projects/new")]
    public IActionResult Project()
    {
        if (HttpContext.Session.GetInt32("userId") == null)
        {
            return RedirectToAction("LogReg", "Users");
        }
        int? userId = (int)HttpContext.Session.GetInt32("userId");
        return View("Project");
    }

    [HttpPost("project/create")]
    public IActionResult CreateProject(Project newProject)
    {

        if (ModelState.IsValid)
        {
        int? userId = (int)HttpContext.Session.GetInt32("userId");
        User? user = _context.Users.FirstOrDefault(u => u.UserId == userId);
                //1 Add 
                _context.Add(newProject);
                //2 Save 
                _context.SaveChanges();
                return Redirect($"/projects/{newProject.ProjectId}");
            
        }
        return View("Project");
    }




/// View 


[HttpGet("/projects/{id}")]
    public IActionResult ViewProject(int id)
    {
        if (HttpContext.Session.GetInt32("userId") == null)
        {
            return RedirectToAction("LogReg");
        }
        Project? OneProject = _context.Projects
                                    .Include(proj => proj.Supporters)
                                    .ThenInclude(proj => proj.User)
                                    .FirstOrDefault(proj => proj.ProjectId == id);
        return View(OneProject);
    }


[HttpPost("project/delete")]
public IActionResult DeleteProject(int ProjId)
{
    Project? ProjectToDelete = _context.Projects
    .FirstOrDefault(proj => proj.ProjectId == ProjId);
    //1 Add 
        _context.Remove(ProjectToDelete);
    //2 Save
    _context.SaveChanges();
    return RedirectToAction("Dashboard", "Users");
    
}










    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
