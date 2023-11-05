using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages
{
    public class IndexModel : PageModel
    {
        AppDbContext db;
        public Profile? profile { get; set; }
        public Facts facts { get; set; }
        public List<Skill> skill { get; set; }
        public List<Education> education { get; set; }
        public List<Experiance> experiance { get; set; }
        public List<Service> service { get; set; }
        public List<Testimonial> testimonial { get; set; }
        public Contact contact { get; set; }
        public IndexModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            profile = db.tbl_Profile.FirstOrDefault();
            facts = db.tbl_Facts.FirstOrDefault();
            skill = db.tbl_Skill.ToList();
            education = db.tbl_Education.ToList();
            experiance = db.tbl_Experiance.ToList();
            service = db.tbl_Service.ToList();
            testimonial = db.tbl_Testimonial.ToList();
        }

        public IActionResult OnPost(Contact contact)
        {
            db.tbl_Contact.Add(contact);
            db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
