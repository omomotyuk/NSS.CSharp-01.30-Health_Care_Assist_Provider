using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Health_Care_Assist_Provider.Data;
using Health_Care_Assist_Provider.Models;
using Microsoft.AspNetCore.Identity;

namespace Health_Care_Assist_Provider.Controllers
{
    public class SponsorsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public SponsorsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Sponsors
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Sponsor
                .Include(s => s.Person)
                .Include(s => s.Assists);

            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Sponsors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sponsor = await _context.Sponsor
                .Include(s => s.Person)
                .FirstOrDefaultAsync(m => m.SponsorId == id);
            if (sponsor == null)
            {
                return NotFound();
            }

            return View(sponsor);
        }

        // GET: Sponsors/Create
        public IActionResult Create()
        {
            ViewData["PersonId"] = new SelectList(_context.ApplicationUsers, "Id", "Id");
            return View();
        }

        // POST: Sponsors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SponsorId,PersonId,CurrentDonation,TotalDonation,TotalAssists")] Sponsor sponsor)
        {
            var currentUser = await GetCurrentUserAsync();

            sponsor.PersonId = currentUser.Id;
            sponsor.TotalDonation = 0;
            sponsor.TotalAssists = 0;

            if (ModelState.IsValid)
            {
                _context.Add(sponsor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", sponsor.PersonId);
            return View(sponsor);
        }

        // GET: Sponsors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var sponsor = await _context.Sponsor.FindAsync(id);
            var sponsor = await _context.Sponsor
                            .Include(p => p.Person)
                            .FirstOrDefaultAsync(m => m.SponsorId == id);

            if (sponsor == null)
            {
                return NotFound();
            }

            var currentUser = await GetCurrentUserAsync();

            if (!sponsor.Person.Id.Equals(currentUser.Id))
            {
                TempData["ErrorMessage"] = $"Sorry {currentUser.FirstName}, you can't edit this sponsor info.";
                return RedirectToAction("Index");
            }

            ViewData["PersonId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", sponsor.PersonId);
            return View(sponsor);
        }

        // POST: Sponsors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SponsorId,PersonId,CurrentDonation,TotalDonation,TotalAssists")] Sponsor sponsor)
        {
            if (id != sponsor.SponsorId)
            {
                return NotFound();
            }

            var currentUser = await GetCurrentUserAsync();

            sponsor.PersonId = currentUser.Id;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sponsor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SponsorExists(sponsor.SponsorId))
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
            ViewData["PersonId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", sponsor.PersonId);
            return View(sponsor);
        }

        // GET: Sponsors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sponsor = await _context.Sponsor
                .Include(s => s.Person)
                .FirstOrDefaultAsync(m => m.SponsorId == id);

            if (sponsor == null)
            {
                return NotFound();
            }

            var currentUser = await GetCurrentUserAsync();

            if (!sponsor.Person.Id.Equals(currentUser.Id))
            {
                TempData["ErrorMessage"] = $"Sorry {currentUser.FirstName}, you can't delete this sponsor info.";
                return RedirectToAction("Index");
            }

            return View(sponsor);
        }

        // POST: Sponsors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sponsor = await _context.Sponsor.FindAsync(id);
            _context.Sponsor.Remove(sponsor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SponsorExists(int id)
        {
            return _context.Sponsor.Any(e => e.SponsorId == id);
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}
