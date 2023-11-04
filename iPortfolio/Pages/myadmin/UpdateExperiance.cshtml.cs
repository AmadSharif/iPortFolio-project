using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class UpdateExperianceModel : PageModel
    {
        AppDbContext db;
        public Experiance experiance { get; set; }
        public UpdateExperianceModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet(int Id)
        {
            experiance = db.tbl_Experiance.Find(Id);
        }
        public IActionResult OnPost(Experiance experiance)
        {
            db.tbl_Experiance.Update(experiance);
            db.SaveChanges();
            return RedirectToPage("ShowExperiance");
        }
    }
}
