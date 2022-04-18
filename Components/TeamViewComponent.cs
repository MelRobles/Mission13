using Microsoft.AspNetCore.Mvc;
using MySQLBowler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLBowler.Components
{
    public class TeamViewComponent : ViewComponent
    {
        private IBowlerRepository blah { get; set; }

        public TeamViewComponent (IBowlerRepository temp)
        {
            blah = temp;
        }

        public IViewComponentResult Invoke()
        {
            //ViewBag.SelectedCategory = RouteData?.Values["TeamId"];
            var team = blah.Bowlers
                .Select(x => x.TeamID)
                .Distinct()
                .OrderBy(x => x);

            return View(team);
        }
    }
}
