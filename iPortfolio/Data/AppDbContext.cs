using iPortfolio.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace iPortfolio.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Contact> tbl_Contact { get; set; }
        public DbSet<Education> tbl_Education { get; set; }
        public DbSet<Experiance> tbl_Experiance { get; set; }
        public DbSet<Facts> tbl_Facts { get; set; }
        public DbSet<Profile> tbl_Profile { get; set; }
        public DbSet<Service> tbl_Service { get; set; }
        public DbSet<Skill> tbl_Skill { get; set; }
        public DbSet<SocialNetworks> tbl_SocialNetworks { get; set; }
        public DbSet<Testimonial> tbl_Testimonial { get; set; }








    }
}
