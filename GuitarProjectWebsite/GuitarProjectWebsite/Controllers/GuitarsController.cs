using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GuitarProjectWebsite.Data;
using GuitarProjectWebsite.Models;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace GuitarProjectWebsite.Controllers
{
    [Authorize(Policy = "RequireManegementRole")]
    public class GuitarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GuitarsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Guitars
        public async Task<IActionResult> Index()
        {
            var guitarDbContext = _context.Guitars.Include(g => g.Category).Include(g => g.Producer);
            return View(await guitarDbContext.ToListAsync());
        }

        // GET: Guitars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guitar = await _context.Guitars
                .Include(g => g.Category)
                .Include(g => g.Producer)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (guitar == null)
            {
                return NotFound();
            }

            return View(guitar);
        }

        // GET: Guitars/Create
        public IActionResult Create()
        {
            ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "Name");
            ViewData["ProducerID"] = new SelectList(_context.Producers, "ID", "Name");
            return View();
        }

        // POST: Guitars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Image,Description,ReleaseDate,ProducerID,CategoryID")] Guitar guitar, IFormFile fileImage)
        {
            if (ModelState.IsValid)
            {
                if (fileImage != null)
                {
                    byte[] p1 = null;
                    using (var fs1 = fileImage.OpenReadStream())
                    using (var ms1 = new MemoryStream())
                    {
                        fs1.CopyTo(ms1);
                        p1 = ms1.ToArray();
                    }
                    guitar.Image = p1;
                }

                _context.Add(guitar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "Name", guitar.CategoryID);
            ViewData["ProducerID"] = new SelectList(_context.Producers, "ID", "Name", guitar.ProducerID);
            return View(guitar);
        }

        // GET: Guitars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guitar = await _context.Guitars.FindAsync(id);
            if (guitar == null)
            {
                return NotFound();
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "Name", guitar.CategoryID);
            ViewData["ProducerID"] = new SelectList(_context.Producers, "ID", "Name", guitar.ProducerID);
            return View(guitar);
        }

        // POST: Guitars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description,ReleaseDate,ProducerID,CategoryID")] Guitar guitar)
        {
            if (id != guitar.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(guitar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GuitarExists(guitar.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "Name", guitar.CategoryID);
            ViewData["ProducerID"] = new SelectList(_context.Producers, "ID", "Name", guitar.ProducerID);
            return View(guitar);
        }

        // GET: Guitars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guitar = await _context.Guitars
                .Include(g => g.Category)
                .Include(g => g.Producer)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (guitar == null)
            {
                return NotFound();
            }

            return View(guitar);
        }

        // POST: Guitars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var guitar = await _context.Guitars.FindAsync(id);
            _context.Guitars.Remove(guitar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GuitarExists(int id)
        {
            return _context.Guitars.Any(e => e.ID == id);
        }
    }
}
