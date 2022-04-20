using Microsoft.AspNetCore.Mvc;
using MySQLBowler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLBowler.Components
{
    public class TeamIdViewComponent : ViewComponent
    {
        private IBowlerRepository repo2 { get; set; }

        public TeamIdViewComponent(IBowlerRepository temp)
        {
            repo2 = temp;
        }

        public IViewComponentResult Invoke()
        {
            //ViewBag.SelectedCategory = RouteData?.Values["TeamId"];
            var team = repo2.Bowlers
                .Select(x => x.TeamID)
                .Distinct()
                .OrderBy(x => x);

            return View(team);
        }
    }
}
