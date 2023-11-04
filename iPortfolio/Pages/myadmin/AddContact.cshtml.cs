using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class AddContactModel : PageModel
    {
        AppDbContext db;
        public Contact contact { get; set; }
        public AddContactModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(Contact contact)
        {
            db.tbl_Contact.Add(contact);
            db.SaveChanges();
            return RedirectToPage("ShowContact");
        }
    }
}
