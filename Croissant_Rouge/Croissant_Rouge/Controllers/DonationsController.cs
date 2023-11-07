using Croissant_Rouge.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace Croissant_Rouge.Controllers;

public class DonationsController : Controller

{
    private readonly MyContext _context;
    public DonationsController(MyContext context)
    {
        _context = context;
    }

//********************************************************************************* All Donations Filtred by Category For Admin

    [HttpGet("Donations")]
    public IActionResult AllDonations()
    {
        if (HttpContext.Session.GetInt32("userId") == null)
        {
            return RedirectToAction("LogReg", "Users");
        }
        List<Donation> AllDonations = _context.Donations.Include(donnation => donnation.Donner).ToList();

        return View(AllDonations);
    }
//******************************************************************************************************************************

    [HttpGet("/Donation")]
    public IActionResult Donation()
    {
     /if (HttpContext.Session.GetInt32("userId") == null)
        {
            return RedirectToAction("");
        }/
     return View();
    }

    [HttpPost("Donation/create")]
    public IActionResult CreateDonation(Donation newDonation, IFormFile imageFile)
    {

        if (ModelState.IsValid)

        {

            if (imageFile != null && imageFile.Length > 0)
            {
                // Check the file format, size, or perform any other validation you need.
                if (IsImageValid(imageFile))
                {
                    // Generate a unique file name to avoid conflicts.
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);

                    // Define the path where you want to save the uploaded image. Make sure this directory exists.
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads"); // The path to the "uploads" folder.

                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    string fullPath = Path.Combine(path, fileName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        imageFile.CopyTo(stream);
                    }

                    // Save the image file path to the newDonation object.
                    newDonation.Picture = "/uploads/" + fileName;
                }
                else
                {
                    ModelState.AddModelError("imageFile", "Invalid image format or size.");
                    Console.WriteLine($"ERRORS---- {ModelState}");
                    return View("Donation");
                }
            }

            _context.Add(newDonation);
            _context.SaveChanges();
            return RedirectToAction("MyProfile", new { DonationId = newDonation.DonationId });
        }

        return View("Donation");
    }


}