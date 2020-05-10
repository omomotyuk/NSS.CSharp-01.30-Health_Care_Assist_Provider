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
    public class PatientsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public PatientsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Patients
        public async Task<IActionResult> Index()
        {
            var currentUser = await GetCurrentUserAsync();

            //var applicationDbContext = _context.Patient.Select(p => p.PersonId == currentUser.Id);
            var applicationDbContext = _context.Patient.Where(p => p.PersonId == currentUser.Id);

            switch (currentUser.UserType)
            {
                case 1:
                    {
                        applicationDbContext = _context.Patient
                            .Include(p => p.Person)
                            .Include(p => p.Diagnoses)
                            .Where(p => p.PersonId == currentUser.Id);
                    }
                    break;
                default:
                    {
                        applicationDbContext = _context.Patient
                           .Include(p => p.Person)
                           .Include(p => p.Diagnoses);
                    }
                    break;
            }

            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Patients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _context.Patient
                .Include(p => p.Person)
                .FirstOrDefaultAsync(m => m.PatientId == id);

            if (patient == null)
            {
                return NotFound();
            }

            return View(patient);
        }

        // GET: Patients/Create
        public IActionResult Create()
        {
            ViewData["PersonId"] = new SelectList(_context.ApplicationUsers, "Id", "Id");
            return View();
        }

        // POST: Patients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PatientId,PersonId,DateOfBirth")] Patient patient)
        {
            var currentUser = await GetCurrentUserAsync();

            patient.PersonId = currentUser.Id;

            if (ModelState.IsValid)
            {
                _context.Add(patient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["PersonId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", patient.PersonId);
            return View(patient);
        }

        // GET: Patients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var patient = await _context.Patient.FindAsync(id);
            var patient = await _context.Patient
                                        .Include(p => p.Person)
                                        .FirstOrDefaultAsync(m => m.PatientId == id);

            if (patient == null)
            {
                return NotFound();
            }

            var currentUser = await GetCurrentUserAsync();

            if (!patient.Person.Id.Equals(currentUser.Id))
            {
                TempData["ErrorMessage"] = $"Sorry {currentUser.FirstName}, you can't edit this patient info.";
                return RedirectToAction("Index");
            }

            ViewData["PersonId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", patient.PersonId);
            return View(patient);
        }

        // POST: Patients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PatientId,PersonId,DateOfBirth")] Patient patient)
        {
            if (id != patient.PatientId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patient);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatientExists(patient.PatientId))
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

            ViewData["PersonId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", patient.PersonId);
            return View(patient);
        }

        // GET: Patients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _context.Patient
                .Include(p => p.Person)
                .FirstOrDefaultAsync(m => m.PatientId == id);

            if (patient == null)
            {
                return NotFound();
            }

            var currentUser = await GetCurrentUserAsync();

            if (!patient.Person.Id.Equals(currentUser.Id))
            {
                TempData["ErrorMessage"] = $"Sorry {currentUser.FirstName}, you can't delete this patient info.";
                return RedirectToAction("Index");
            }

            return View(patient);
        }

        // POST: Patients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var patient = await _context.Patient.FindAsync(id);

            _context.Patient.Remove(patient);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool PatientExists(int id)
        {
            return _context.Patient.Any(e => e.PatientId == id);
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}
