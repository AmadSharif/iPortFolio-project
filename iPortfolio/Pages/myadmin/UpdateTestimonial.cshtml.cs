using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class ShowTestimonialModel : PageModel
    {
        AppDbContext db;
        IWebHostEnvironment env;
        public Testimonial testimonial{ get; set; }
        public ShowTestimonialModel(AppDbContext _db,IWebHostEnvironment env)
        {
            db = _db;
            this.env = env;
        }
        public void OnGet()
        {
            testimonial = db.tbl_Testimonial.FirstOrDefault();
        }
        public IActionResult OnPost(Testimonial testimonial)
        {
            if(testimonial.Photo is null)
            {
                db.tbl_Testimonial.Update(testimonial);
                db.SaveChanges();   
            }
            else
            {
                string ImageName = testimonial.Photo.FileName;
                DeleteFile(testimonial.Image);
                var FolderPath = Path.Combine(env.WebRootPath, "imagestestimonial");
                var ImagePath = Path.Combine(FolderPath, ImageName);
                var myFileSteam = new FileStream(ImagePath,FileMode.Create);
                testimonial.Photo.CopyTo(myFileSteam);
                myFileSteam.Dispose();
                testimonial.Image = ImageName;
                db.tbl_Testimonial.Update(testimonial);
                db.SaveChanges();
            }
            return RedirectToPage("UpdateTestimonial");
        }// End of Onpost

        private void DeleteFile(string OldImageName)
        {
            var FolderPath = Path.Combine(env.WebRootPath, "imagestestimonial");
            var ImagePath = Path.Combine(FolderPath, OldImageName);

            FileInfo fileInfo = new FileInfo(ImagePath);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }

        }
    }
}
