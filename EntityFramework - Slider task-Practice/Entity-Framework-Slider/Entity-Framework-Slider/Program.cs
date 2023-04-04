using Entity_Framework_Slider.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//1)AppDbContext-clasini istifade edeceymizi bildirik
builder.Services.AddDbContext<AppDbContext>(option =>
{
    //2)SQL- istifade edeceymizi bildirik,Configuration-vasitesi ile apsetting.json veya apsetingdevelopment.json datalarini oxuya bilersen-Conection-string-adin bildiririk
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
