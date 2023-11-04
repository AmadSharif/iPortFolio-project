using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class ShowSocialNetworksModel : PageModel
    {
        AppDbContext db;
        public List<SocialNetworks> socialNetworks { get; set; }
        public ShowSocialNetworksModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet(int Id)
        {
            socialNetworks=db.tbl_SocialNetworks.ToList();
        }
        public IActionResult OnGetDelete(int Id)
        {
            var itemToDel = db.tbl_SocialNetworks.Find(Id);
            db.tbl_SocialNetworks.Remove(itemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowSocialNetworks");
        }
    }
}
