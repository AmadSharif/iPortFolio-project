using iPortfolio.Model;
using iPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class AddServiceModel : PageModel
    {
        AppDbContext db;
        public Service service { get; set; }
        public AddServiceModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(Service service)
        {
            db.tbl_Service.Add(service);
            db.SaveChanges();
            return RedirectToPage("ShowService");
        }
    }
}
