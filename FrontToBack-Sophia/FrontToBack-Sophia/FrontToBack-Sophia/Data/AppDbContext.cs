using FrontToBack_Sophia.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack_Sophia.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<Slider> Sliders { get; set; }
    }
}
