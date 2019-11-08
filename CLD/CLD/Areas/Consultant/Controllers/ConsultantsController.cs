using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CLD.Data;
using CLD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace CLD.Controllers
{
   // inlog is stuk  [Authorize(Roles= "Consultant")]
    public class ConsultantsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConsultantsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Consultants
        public async Task<IActionResult> Index()
        {
            return View(await _context.Consultant.ToListAsync());
        }

        // GET: Consultants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultant = await _context.Consultant
                .FirstOrDefaultAsync(m => m.ConsultantId == id);
            if (consultant == null)
            {
                return NotFound();
            }

            return View(consultant);
        }

        // GET: Consultants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Consultants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImageUrl,Biography")] Consultant consultant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consultant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(consultant);
        }

        // GET: Consultants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultant = await _context.Consultant.FindAsync(id);
            if (consultant == null)
            {
                return NotFound();
            }
            return View(consultant);
        }

        // POST: Consultants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImageUrl,Biography")] Consultant consultant, IFormFile ImageUrl)
        {
            if (id != consultant.ConsultantId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consultant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsultantExists(consultant.ConsultantId))
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
            return View(consultant);
        }

        // GET: Consultants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consultant = await _context.Consultant
                .FirstOrDefaultAsync(m => m.ConsultantId == id);
            if (consultant == null)
            {
                return NotFound();
            }

            return View(consultant);
        }

        // POST: Consultants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var consultant = await _context.Consultant.FindAsync(id);
            _context.Consultant.Remove(consultant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsultantExists(int id)
        {
            return _context.Consultant.Any(e => e.ConsultantId == id);
        }
        // POST: Consultant/Edit (counts the amount of images)
        //public async Task<IActionResult> OnPostUploadAsync(List<IFormFile> files)
        //{
        //    long size = files.Sum(f => f.Length);
        //    foreach (var formFile in files)
        //    {
        //        if (formFile.Length > 0)
        //            {
        //            var filePath = Path.GetTempFileName();
        //            using (var stream = System.IO.File.Create(filePath))
        //            {
        //                await formFile.CopyToAsync(stream);
        //            }
        //        }
        //    }
        //    // Process upload files
        //    return Ok(new { count = files.Count, size, filePath });
        //} 
    }

}
