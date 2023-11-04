using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class ShowServiceModel : PageModel
    {
        AppDbContext db;
        public List<Service> service { get; set; }
        public ShowServiceModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            service=db.tbl_Service.ToList();
        }
        public IActionResult OnGetDelete(int Id)
        {
            var itemToDel = db.tbl_Service.Find(Id);
            db.tbl_Service.Remove(itemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowService");
        }
    }
}
