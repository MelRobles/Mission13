using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        //Gets list of teamid but not used in project, used viewcomponent instead
        private IEnumerable<System.Collections.IList> GetTeamIdList()
        {
            var team = _repo.Bowlers
                .Select(x => x.TeamID)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            var teamList = new List<System.Collections.IList>();

            teamList.Add(team);

            return (teamList);
        }

        [HttpGet]
        public IActionResult Form() 
        {
            //var Tid = _repo.Bowlers
            //    .Select(x => x.TeamID)
            //    .Distinct()
            //    .OrderBy(x => x)
            //    .ToList();

            //List<int> teamList = new List<int> {1, 2, 3, 4 };

            //ViewBag.TeamID = GetTeamIdList();
            ViewBag.Page = "New";
            Bowler b = new Bowler();

            return View(b);
        }

        [HttpPost]
        public IActionResult Form(Bowler b) 
        {
            if (ModelState.IsValid) 
            {
                if (b.BowlerID == 0)
                {
                    _repo.CreateBowler(b);
                    _repo.SaveBowler(b);
                }
                else
                {
                    _repo.UpdateBowler(b);
                    _repo.SaveBowler(b);
                }
                return RedirectToAction("Index");
            }
            else
            {
                //ViewBag.Teams = _context.Teams.ToList();
                return View("Form");
            }
            
        }

        [HttpGet]
        public IActionResult Edit(int bId)
        {
            ViewBag.Page = "Edit";

            var bowler = _repo.Bowlers.SingleOrDefault(x => x.BowlerID == bId);

            return View("Form", bowler);
        }

        [HttpPost]
        public IActionResult Edit(Bowler b)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateBowler(b);
                _repo.SaveBowler(b);

                return View("Index");
            }
            else
            {
                return View("Form", b);
            }
        }

        [HttpGet]
        public IActionResult Delete(int bId)
        {
            var bowler = _repo.Bowlers.Single(x => x.BowlerID == bId);
            return View(bowler);
        }
        [HttpPost]
        public IActionResult Delete(Bowler b)
        {
            _repo.DeleteBowler(b);
            _repo.SaveBowler(b);

            return View("Index");

        }
    }
}
