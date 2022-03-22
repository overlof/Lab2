using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Team
    {
        String TeamID;
        String Name;
        String Abbr;
        String Logo;

        public void Set(String TeamID, String Name, String Abbr, String Logo)
        {
        this.TeamID = TeamID;
        this.Name = Name;
        this.Abbr = Abbr;
        this.Logo = Logo;

        }
    }
}
