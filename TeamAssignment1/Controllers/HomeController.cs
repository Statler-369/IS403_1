using System;
using TeamAssignment1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamAssignment1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<SoccerTeam> lstTeamNames = new List<SoccerTeam>();
            //List<SoccerTeam> lstSorted = new List<SoccerTeam>();
            int iTeamRank = 0;

            lstTeamNames.Add(new SoccerTeam("RSL", 35));
            lstTeamNames.Add(new SoccerTeam("Colorado", 24));
            lstTeamNames.Add(new SoccerTeam("FC Dallas", 42));
            lstTeamNames.Add(new SoccerTeam("Sporting KC", 39));
            lstTeamNames.Add(new SoccerTeam("San Jose", 16));
            lstTeamNames.Add(new SoccerTeam("Houston", 27));
            lstTeamNames.Add(new SoccerTeam("Seattle", 32));
            lstTeamNames.Add(new SoccerTeam("Vancouver", 33));
            lstTeamNames.Add(new SoccerTeam("Minnesota", 29));
            lstTeamNames.Add(new SoccerTeam("Portland", 37));
            lstTeamNames.Add(new SoccerTeam("LA Galaxy", 37));
            lstTeamNames.Add(new SoccerTeam("LAFC", 39));

            //lstSorted = lstTeamNames.OrderByDescending(sTeam => sTeam.iPoints).ToList();
            List<SoccerTeam> lstSorted = lstTeamNames.OrderByDescending(sTeam => sTeam.iPoints).ToList();

            ViewBag.Teams += "<table>";
            ViewBag.Teams += "<tr>";
            ViewBag.Teams += "<th>Ranking</th>";
            ViewBag.Teams += "<th>Team Name</th>";
            ViewBag.Teams += "<th>Points</th>";
            ViewBag.Teams += "</tr>";

            foreach (SoccerTeam sTeam in lstSorted) 
            {

                ViewBag.Teams += "<tr>";
                ViewBag.Teams += "<td>" + ++iTeamRank + "</td>";
                ViewBag.Teams += "<td>" + sTeam.sName + "</td>";
                ViewBag.Teams += "<td>" + sTeam.iPoints + "</td>";
                ViewBag.Teams += "</tr>";
            }

            ViewBag.Teams += "</table>";
                        

            return View();
        }
    }
}
