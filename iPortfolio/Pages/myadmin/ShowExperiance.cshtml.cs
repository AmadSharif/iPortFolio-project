using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class ShowExperianceModel : PageModel
    {
        AppDbContext db;
        public List<Experiance> experiance { get; set; }
        public ShowExperianceModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            experiance = db.tbl_Experiance.ToList();
        }
        public IActionResult OnGetDelete(int Id)
        {
            var itemToDel = db.tbl_Experiance.Find(Id);
            db.tbl_Experiance.Remove(itemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowExperiance");
        }
    }
}
