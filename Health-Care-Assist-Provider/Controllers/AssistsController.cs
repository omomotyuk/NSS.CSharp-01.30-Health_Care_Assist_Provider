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
    public class AssistsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public AssistsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Assists
        public async Task<IActionResult> Index()
        {
            //var applicationDbContext = _context.Assist.Include(a => a.Appointment).Include(a => a.Diagnosis).Include(a => a.Sponsor);

            var assist = _context.Assist
                .Include(a => a.Appointment)
                    .ThenInclude(ad => ad.Doctor)
                        .ThenInclude(adp => adp.Person)
                .Include(d => d.Diagnosis)
                    .ThenInclude(dp => dp.Patient)
                        .ThenInclude(dpp => dpp.Person)
                .Include(s => s.Sponsor)
                    .ThenInclude(sp => sp.Person);
            //.FirstOrDefaultAsync(m => m.Id == id);

            return View(await assist.ToListAsync());
            //return View(await applicationDbContext.ToListAsync());
        }

        // GET: Assists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assist = await _context.Assist
                .Include(a => a.Appointment)
                    .ThenInclude(ad => ad.Doctor)
                        .ThenInclude(adp => adp.Person)
                .Include(d => d.Diagnosis)
                    .ThenInclude(dp => dp.Patient)
                .Include(s => s.Sponsor)
                    .ThenInclude(sp => sp.Person)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (assist == null)
            {
                return NotFound();
            }

            return View(assist);
        }

        // GET: Assists/Create
        public async Task<IActionResult> Create()
        {
            var person = await GetCurrentUserAsync();

            var patient = await _context.Patient.FirstOrDefaultAsync(p => p.PersonId == person.Id);
            var doctor = await _context.Doctor.FirstOrDefaultAsync(p => p.PersonId == person.Id);
            var sponsor = await _context.Sponsor.FirstOrDefaultAsync(p => p.PersonId == person.Id);

            switch (person.UserType)
            {
                case 1:
                    {
                        var patientDiagnoses = _context.Diagnosis
                            .Where(d => d.PatientId == patient.PatientId && d.Active == true);
                        var selectedDiagnoses = await patientDiagnoses.ToListAsync();
                        if (selectedDiagnoses.Count != 0)
                        {
                            ViewData["DiagnosisId"] = new SelectList(selectedDiagnoses, "DiagnosisId", "Specialty");
                        }
                        else
                        {
                            TempData["ErrorMessage"] = $"Sorry {patient.Person.FirstName}, you can't add new assist at this moment. There is not your diagnosis.";
                            return RedirectToAction("Index");
                        }

                        // Get the list of the appropriate appointments
                        List<string> specialtyList = new List<string>();
                        string specialty = selectedDiagnoses[0].Specialty;
                        specialtyList.Add( specialty );

                        var doctorAppointments = _context.Appointment
                            .Include(d => d.Doctor)
                            .Where(a => a.Doctor.Specialty == specialty && a.Available == true);

                        var selectedAppointments = await doctorAppointments.ToListAsync();

                        foreach ( Diagnosis diagnosis in selectedDiagnoses )
                        {
                            specialty = diagnosis.Specialty;

                            if ( !specialtyList.Contains( specialty ) )
                            {
                                specialtyList.Add( specialty );

                                doctorAppointments = _context.Appointment
                                    .Include(d => d.Doctor)
                                    .Where(a => a.Doctor.Specialty == specialty && a.Available == true);

                                selectedAppointments.AddRange( await doctorAppointments.ToListAsync() );
                            }
                        }

                        if (selectedAppointments.Count != 0)
                        {
                            ViewData["AppointmentId"] = new SelectList(selectedAppointments, "AppointmentId", "Doctor.Specialty");
                        }
                        else
                        {
                            TempData["ErrorMessage"] = $"Sorry {patient.Person.FirstName}, you can't add new assist at this moment. There is not available appointment.";
                            return RedirectToAction("Index");
                        }

                        // Get the list of the sponsors
                        var sponsorFunds = _context.Sponsor
                            .Where(s => s.CurrentDonation > 0);

                        var selectedSponsors = await sponsorFunds.ToListAsync();
                        if (selectedSponsors.Count != 0)
                        {
                            ViewData["SponsorId"] = new SelectList(selectedSponsors, "SponsorId", "CurrentDonation");
                        }
                        else
                        {
                            TempData["ErrorMessage"] = $"Sorry {patient.Person.FirstName}, you can't add new assist at this moment. There is not available funds.";
                            return RedirectToAction("Index");
                        }
                    }
                    break;
                case 2:
                    {
                        var patientDiagnoses = _context.Diagnosis
                            .Where(d => d.Specialty == doctor.Specialty && d.Active == true );
                        var selectedDiagnoses = await patientDiagnoses.ToListAsync();
                        if( selectedDiagnoses.Count != 0 )
                        {
                            ViewData["DiagnosisId"] = new SelectList(selectedDiagnoses, "DiagnosisId", "Specialty");
                        }
                        else
                        {
                            TempData["ErrorMessage"] = $"Sorry {doctor.Person.FirstName}, you can't add new assist at this moment. There is not your speciality cases.";
                            return RedirectToAction("Index");
                        }

                        var doctorAppointments = _context.Appointment
                            .Include(d => d.Doctor)
                            .Where(a => a.DoctorId == doctor.DoctorId && a.Available == true);
                        var selectedAppointments = await doctorAppointments.ToListAsync();
                        if (selectedAppointments.Count != 0)
                        {
                            ViewData["AppointmentId"] = new SelectList(selectedAppointments, "AppointmentId", "Doctor.Specialty");
                        }
                        else
                        {
                            TempData["ErrorMessage"] = $"Sorry {doctor.Person.FirstName}, you can't add new assist at this moment. There is not available appointment.";
                            return RedirectToAction("Index");
                        }

                        //var sponsorFunds = _context.Sponsor
                        //    .Where(s => s.CurrentDonation > 0);
                        //ViewData["SponsorId"] = new SelectList(await sponsorFunds.ToListAsync(), "SponsorId", "CurrentDonation");
                    }
                    break;
                case 3:
                    {
                        var patientDiagnoses = _context.Diagnosis
                           .Where(d => d.Active == true);
                        ViewData["DiagnosisId"] = new SelectList(await patientDiagnoses.ToListAsync(), "DiagnosisId", "Specialty");
                    }
                    break;
                default: break;
            }

            //ViewData["AppointmentId"] = new SelectList(_context.Appointment, "AppointmentId", "AppointmentId");
            //ViewData["DiagnosisId"] = new SelectList(_context.Diagnosis, "DiagnosisId", "Specialty");
            //ViewData["SponsorId"] = new SelectList(_context.Sponsor, "SponsorId", "SponsorId");
            return View();
        }

        // POST: Assists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateCreated,DiagnosisId,SponsorId,AppointmentId,Rating,Comment,Active")] Assist assist)
        {
            //assist.DateCreated = DateTime.Now;

            if (ModelState.IsValid)
            {
                _context.Assist.Add(assist);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AppointmentId"] = new SelectList(_context.Appointment, "AppointmentId", "AppointmentId", assist.AppointmentId);
            ViewData["DiagnosisId"] = new SelectList(_context.Diagnosis, "DiagnosisId", "Specialty", assist.DiagnosisId);
            ViewData["SponsorId"] = new SelectList(_context.Sponsor, "SponsorId", "SponsorId", assist.SponsorId);
            return View(assist);
            //
            //var person = await GetCurrentUserAsync();

            //var patient = await _context.Patient.FirstOrDefaultAsync(p => p.PersonId == person.Id);
            //var doctor = await _context.Doctor.FirstOrDefaultAsync(p => p.PersonId == person.Id);
            //var sponsor = await _context.Sponsor.FirstOrDefaultAsync(p => p.PersonId == person.Id);

            //switch (person.UserType)
            //{
            //    case 1:
            //        {

            //        }
            //}
        }

        // GET: Assists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assist = await _context.Assist.FindAsync(id);
            if (assist == null)
            {
                return NotFound();
            }
            ViewData["AppointmentId"] = new SelectList(_context.Appointment, "AppointmentId", "AppointmentId", assist.AppointmentId);
            ViewData["DiagnosisId"] = new SelectList(_context.Diagnosis, "DiagnosisId", "Specialty", assist.DiagnosisId);
            ViewData["SponsorId"] = new SelectList(_context.Sponsor, "SponsorId", "SponsorId", assist.SponsorId);
            return View(assist);
        }

        // POST: Assists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateCreated,DiagnosisId,SponsorId,AppointmentId,Rating,Comment,Active")] Assist assist)
        {
            if (id != assist.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(assist);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssistExists(assist.Id))
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
            ViewData["AppointmentId"] = new SelectList(_context.Appointment, "AppointmentId", "AppointmentId", assist.AppointmentId);
            ViewData["DiagnosisId"] = new SelectList(_context.Diagnosis, "DiagnosisId", "Specialty", assist.DiagnosisId);
            ViewData["SponsorId"] = new SelectList(_context.Sponsor, "SponsorId", "SponsorId", assist.SponsorId);
            return View(assist);
        }

        // GET: Assists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assist = await _context.Assist
                .Include(a => a.Appointment)
                .Include(a => a.Diagnosis)
                .Include(a => a.Sponsor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (assist == null)
            {
                return NotFound();
            }

            return View(assist);
        }

        // POST: Assists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var assist = await _context.Assist.FindAsync(id);
            _context.Assist.Remove(assist);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssistExists(int id)
        {
            return _context.Assist.Any(e => e.Id == id);
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}
