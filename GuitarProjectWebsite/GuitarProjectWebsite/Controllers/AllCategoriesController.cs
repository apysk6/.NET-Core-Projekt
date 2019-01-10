using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuitarProjectWebsite.Data;
using GuitarProjectWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GuitarProjectWebsite.Controllers
{
    public class AllCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AllCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }

        public async Task<IActionResult> Show(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guitars = await _context.Guitars.Where(m => m.CategoryID == id).ToListAsync();

            if (guitars == null)
            {
                return NotFound();
            }

            List<GuitarViewModel> newGuitars = new List<GuitarViewModel>();
            var category = await _context.Categories.Where(m => m.ID == id).ToListAsync();
            foreach (var guitar in guitars)
            {
                var website = await _context.Producers.Where(x => x.Guitars.Contains(guitar)).FirstOrDefaultAsync();
                newGuitars.Add(new GuitarViewModel
                {
                    ID = guitar.ID,
                    Name = guitar.Name,
                    Image = guitar.Image,
                    Category = category.FirstOrDefault().Name,
                    Description = guitar.Description,
                    Producer = guitar.Producer,
                    Website = website.Website
                });
            }

            return View(newGuitars);
        }
    }
}