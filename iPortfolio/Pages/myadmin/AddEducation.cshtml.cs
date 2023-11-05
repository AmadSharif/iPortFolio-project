using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class AddEducationModel : PageModel
    {
        AppDbContext db;
        public Education education { get; set; }
        public AddEducationModel(AppDbContext _db)
        {

            this.db = _db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(Education education)
        {

            if(va)
            db.tbl_Education.Add(education);
            db.SaveChanges();
            return RedirectToPage("ShowEducation");    
        }
    }
}
