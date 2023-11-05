using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class ShowMessagesModel : PageModel
    {
        AppDbContext db;
        public List<Contact> contact { get; set; }
        public ShowMessagesModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            contact = db.tbl_Contact.ToList();
        }
        public IActionResult OnGetDelete(int Id)
        {
            var itemToDel = db.tbl_Contact.Find(Id);
            db.tbl_Contact.Remove(itemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowMessages");
        }
    }
}
