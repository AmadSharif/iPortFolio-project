using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class AddExperianceModel : PageModel
    {
        AppDbContext db;
        public Experiance experiance { get; set; }
        public AddExperianceModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
           
        }
        public IActionResult OnPost(Experiance experiance)


        {
            if (ModelState.IsValid)
            {
                db.tbl_Experiance.Add(experiance);
                db.SaveChanges();
                return RedirectToPage("ShowExperiance");
            }

            return Page();
          
        }
    }
}
