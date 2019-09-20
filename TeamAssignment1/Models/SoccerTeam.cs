using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamAssignment1.Models
{
    public class SoccerTeam : Team
    {
        public int iWins { get; set; }
        public int iLosses { get; set; }
        public int iDifferential { get; set; }
        public int iGoalsFor { get; set; }
        public int iGoalsAgainst { get; set; }

        public SoccerTeam()
        {

        }

        public SoccerTeam(string inputName, int iPoints)
        {
            base.sName = inputName;
            base.iPoints = iPoints;
        }
    }
}