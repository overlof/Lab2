using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Player
    {
        String PlayerID;
        String LastName;
        String FirstName;
        String Height;
        String Weight;
        String CountryCode;

        public void Set(String PlayerId, String LastName, String FirstName,String Height, String Weight,String CountryCode)
        {
            this.PlayerID = PlayerId;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.Height = Height;
            this.Weight = Weight;
            this.CountryCode = CountryCode;
        }
    }
}
