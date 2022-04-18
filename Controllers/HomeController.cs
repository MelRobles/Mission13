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
        //private BowlerDbContext _context { get; set; }
        private IBowlerRepository _repo;
        //Constructor
        /*public HomeController(BowlerDbContext temp)
        {
            _context = temp;
        }*/
        public HomeController(IBowlerRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int teamType)
        {
            var blah = _repo.Bowlers
                .Where(T => T.TeamID == teamType || teamType == 0)
                //.Include(x => _context.Teams)
                //.FromSqlRaw("SELECT * FROM Bowlers")
                .ToList();

            return View(blah);
        }

        [HttpGet]
        public IActionResult Form() 
        {
            //ViewBag.Teams = _context.Teams.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Form(Bowler bnew) 
        {
            if (ModelState.IsValid) 
            {
                //FIX 
                //_repo.CreateBowler(bnew);
                //_context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                //ViewBag.Teams = _context.Teams.ToList();
                return View("Form");
            }
            
        }
    }
}
