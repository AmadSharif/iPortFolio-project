using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace iPortfolio.Pages.myadmin
{
    public class AddProfileModel : PageModel
    {
        AppDbContext db;
        IWebHostEnvironment env;
        public Profile profile { get; set; }
        public AddProfileModel(AppDbContext _db, IWebHostEnvironment env)
        {
            db = _db;
            this.env = env;

        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(Profile profile)
        {
            if (ModelState.IsValid) 
            {
                string ImageName = profile.Photo.FileName.ToString();
                var FolderPath = Path.Combine(env.WebRootPath, "images");
                var ImagePath = Path.Combine(FolderPath, ImageName);
                FileStream fs = new FileStream(ImagePath, FileMode.Create);
                profile.Photo.CopyTo(fs);
                fs.Dispose();
                profile.Image = ImageName;
                db.tbl_Profile.Add(profile);
                db.SaveChanges();
            }
            return Page();
            


            
        }
    }
}
