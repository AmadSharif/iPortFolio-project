using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class ShowFactsModel : PageModel
    {
        AppDbContext db;
        public List<Facts> facts { get; set; }
        public ShowFactsModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            facts = db.tbl_Facts.ToList();
        }
        public IActionResult OnGetDelete(int Id)
        {
            var itemToDel = db.tbl_Facts.Find(Id);
            db.tbl_Facts.Remove(itemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowFacts");
        }
    }
}
