
using Entity_Framework_Slider.Data;
using Entity_Framework_Slider.Models;
using Entity_Framework_Slider.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;

namespace Entity_Framework_Slider.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        //databazaynan isleyirkse async -etmeliyik
        //Task -async yazanda yaziriq methoda
        public async Task<IActionResult> Index()
        {
            //_context.Sliders =databazadan gedib getirmek ucun datalari
            //ToList()-Program run olanda datani getirir qoyur RAMa ordan viewa
            //FirstOrDefault()-UI-da birdene data gorsedeceyik deye.
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderInfo sliderInfo = await _context.SliderInfos.FirstOrDefaultAsync();

            HomeVM model = new()
            {
                Sliders = sliders,
                SliderInfo = sliderInfo
            };
            return View(model);
        }

     
    }
}