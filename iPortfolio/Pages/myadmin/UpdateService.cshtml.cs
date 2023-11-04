using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class UpdateServiceModel : PageModel
    {
        AppDbContext db;
        public Service service { get; set; }
        public UpdateServiceModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet(int Id)
        {
            service = db.tbl_Service.Find(Id);
        }
        public IActionResult OnPost(Service service)
        {
            db.tbl_Service.Update(service);
            db.SaveChanges();
            return RedirectToPage("ShowService");
        }
    }
}
