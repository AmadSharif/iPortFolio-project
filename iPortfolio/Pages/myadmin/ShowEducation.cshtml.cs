using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class ShowEducationModel : PageModel
    {
        AppDbContext db;
        public List<Education> education { get; set; }
        public ShowEducationModel(AppDbContext _db)
        {
            db = _db;  
        }
        public void OnGet()
        {
            education = db.tbl_Education.ToList();
        }
        public IActionResult OnGetDelete(int Id)
        {
            var itemToDel = db.tbl_Education.Find(Id);
            db.tbl_Education.Remove(itemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowEducation");

        }
    }
}
