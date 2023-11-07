using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class AddFactsModel : PageModel
    {
        AppDbContext db;
        public Facts facts { get; set; }
        public AddFactsModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(Facts facts) 
        {
            if (ModelState.IsValid)
            {
                db.tbl_Facts.Add(facts);
                db.SaveChanges();
                return RedirectToPage("ShowFacts");
            }
            return Page();
           
        }
    }
}
