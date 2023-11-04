using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class UpdateFactsModel : PageModel
    {
        AppDbContext db;
        public Facts facts { get; set; }
        public UpdateFactsModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet(int Id)
        {
            facts = db.tbl_Facts.Find(Id);
        }
        public IActionResult OnPost(Facts facts) 
        {
          db.tbl_Facts.Update(facts);
          db.SaveChanges();
          return RedirectToPage("ShowFacts");
        }
    }
}
