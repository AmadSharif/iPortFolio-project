using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class UpdateEducationModel : PageModel
    {
        AppDbContext db;
        public Education education { get; set; }
        public UpdateEducationModel(AppDbContext _db)
        {
            db = _db; 
        }
        public void OnGet(int Id)
        {
            education = db.tbl_Education.Find(Id);
 
        }
        public IActionResult OnPost(Education education) 
        { 
            db.tbl_Education.Update(education);
            db.SaveChanges();
            return RedirectToPage("ShowEducation");
        }    
    }
}
