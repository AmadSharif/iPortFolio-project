using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class AddSkillModel : PageModel
    {
        AppDbContext db;
        public Skill skill{ get; set; }
        public AddSkillModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(Skill skill)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Skill.Add(skill);
                db.SaveChanges();
                return RedirectToPage("ShowSkill");
            }
                return Page();
        }
    }
}
