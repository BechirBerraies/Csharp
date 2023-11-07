omar_daly12 — Aujourd’h
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

