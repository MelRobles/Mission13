using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySQLBowler.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLBowler.Controllers
{
    public class HomeController : Controller
    {
        private BowlerDbContext _context { get; set; }
        //Constructor
        public HomeController(BowlerDbContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            var blah = _context.Bowlers
                //.Include(x => _context.Teams)
                .FromSqlRaw("SELECT * FROM Bowlers")
                .ToList();

            return View(blah);
        }

        [HttpGet]
        public IActionResult Form() 
        {
            ViewBag.Teams = _context.Teams.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Form(Bowler bnew) 
        {
            if (ModelState.IsValid) 
            {
                _context.Add(bnew);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Teams = _context.Teams.ToList();
                return View("Form");
            }
            
        }
    }
}
