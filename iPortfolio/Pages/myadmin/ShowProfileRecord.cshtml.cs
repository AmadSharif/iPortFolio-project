using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class ShowProfileModel : PageModel
    {
        AppDbContext db;
        IWebHostEnvironment env;
        public Profile profile { get; set; }
        public ShowProfileModel(AppDbContext _db, IWebHostEnvironment env)
        {
            db = _db;

            this.env = env;

        }
        public void OnGet()
        {
            profile = db.tbl_Profile.FirstOrDefault();
        }
        public IActionResult OnPost(Profile profile)
        {
             if(profile.Photo is null)
            {
                db.tbl_Profile.Update(profile);
                db.SaveChanges();
            }
            else
            {
                string ImageName = profile.Photo.FileName;
                DeleteFile(profile.Image);
                var FolderPath = Path.Combine(env.WebRootPath, "images");
                var ImagePath = Path.Combine(FolderPath, ImageName);
                var myFileStream = new FileStream(ImagePath, FileMode.Create);
                profile.Photo.CopyTo(myFileStream);
                myFileStream.Dispose();
                profile.Image = ImageName;
                db.tbl_Profile.Update(profile);
                db.SaveChanges();
            }
            return RedirectToPage("ShowProfileRecord");
        } //end of onPost

        private void DeleteFile(string OldImageName)
        {
            var FolderPath = Path.Combine(env.WebRootPath, "images");
            var ImagePath = Path.Combine(FolderPath,OldImageName);

            FileInfo fileInfo = new FileInfo(ImagePath);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }
        }
    }
}
