using Entity_Framework_Slider.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework_Slider.Data
{
    public class AppDbContext:DbContext
    {

        //DbContext-konstruktoru data isteyir oraya AppDbContext gonderirik
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
       
        //DbSet<Slider> - menim Slider clasim bazada Sliders adinda table olacaq
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<SliderInfo> SliderInfos { get; set; }
    }
}
