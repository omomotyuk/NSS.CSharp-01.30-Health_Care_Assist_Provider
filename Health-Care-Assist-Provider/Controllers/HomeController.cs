using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Health_Care_Assist_Provider.Models;
using Microsoft.AspNetCore.Identity;
using Health_Care_Assist_Provider.Data;
using Microsoft.EntityFrameworkCore;

namespace Health_Care_Assist_Provider.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var person = await GetCurrentUserAsync();

            if (person != null)
            {
                switch( person.UserType )
                {
                    case 1:
                        {
                            var patient = await _context.Patient.FirstOrDefaultAsync(p => p.PersonId == person.Id);
                            if (patient == null)
                            {
                                return RedirectToAction("Create", "Patients");
                            }
                        } break;
                    case 2:
                        {
                            var doctor = await _context.Doctor.FirstOrDefaultAsync(p => p.PersonId == person.Id);
                            if (doctor == null)
                            {
                                return RedirectToAction("Create", "Doctors");
                            }
                        }
                        break;
                    case 3:
                        {
                            var sponsor = await _context.Sponsor.FirstOrDefaultAsync(p => p.PersonId == person.Id);
                            if (sponsor == null)
                            {
                                return RedirectToAction("Create", "Sponsors");
                            }
                        }
                        break;
                    default: break;
                }
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}
