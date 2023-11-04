using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class AddTestimonialModel : PageModel
    {
        AppDbContext db;
        IWebHostEnvironment env;
        public Testimonial testimonial{ get; set; }
        public AddTestimonialModel(AppDbContext _db, IWebHostEnvironment env)
        {
            db = _db;
            this.env = env;

        }
        public void OnGet()
        {
        }
        public void OnPost(Testimonial testimonial)
        {
            string ImageName = testimonial.Photo.FileName.ToString();
            var FolderPath = Path.Combine(env.WebRootPath, "imagestestimonial");
            var ImagePath = Path.Combine(FolderPath, ImageName);
            FileStream fs = new FileStream(ImagePath, FileMode.Create);
            testimonial.Photo.CopyTo(fs);   
            fs.Dispose();
            testimonial.Image = ImageName;
            db.tbl_Testimonial.Add(testimonial);
            db.SaveChanges();
        }
    }
}
