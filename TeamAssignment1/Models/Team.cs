using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamAssignment1.Models
{
    public class Team
    {
        public string sName { get; set; }
        public int iPoints { get; set; }
        
        
        public Team()
        {

        }

        public Team(string inputName)
        {
            this.sName = inputName;
        }
    }
}