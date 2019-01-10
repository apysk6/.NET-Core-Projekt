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
    public class AllProducersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AllProducersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Producers.ToListAsync());
        }

        public async Task<IActionResult> Show(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guitars = await _context.Guitars.Where(m => m.ProducerID == id).ToListAsync();

            if (guitars == null)
            {
                return NotFound();
            }

            List<GuitarViewModel> newGuitars = new List<GuitarViewModel>();
            var producer = await _context.Producers.Where(m => m.ID == id).ToListAsync();
            foreach (var guitar in guitars)
            {
                var website = await _context.Producers.Where(x => x.Guitars.Contains(guitar)).FirstOrDefaultAsync();
                newGuitars.Add(new GuitarViewModel
                {
                    ID = guitar.ID,
                    Name = guitar.Name,
                    Image = guitar.Image,
                    Category = producer.FirstOrDefault().Name,
                    Description = guitar.Description,
                    Producer = guitar.Producer,
                    Website = website.Website
                });
            }

            return View(newGuitars);
        }
    }
}