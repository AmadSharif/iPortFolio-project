using iPortfolio.Data;
using iPortfolio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iPortfolio.Pages.myadmin
{
    public class ShowSkillModel : PageModel
    {
        AppDbContext db;
        public List<Skill> skill { get; set; }
        public ShowSkillModel(AppDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
            skill = db.tbl_Skill.ToList();
        }
        public IActionResult OnGetDelete(int Id)
        {
          var itemToDel = db.tbl_Skill.Find(Id);
            db.tbl_Skill.Remove(itemToDel);
            db.SaveChanges();
            return RedirectToPage("ShowSkill");
        }
    }
}
