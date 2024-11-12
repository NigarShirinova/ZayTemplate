using Microsoft.EntityFrameworkCore;
using Zay_Template.Entities;

namespace Zay_Template.Areas.Admin.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        
    }
}
