using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Country
    {
        String CountryCode;
        String CountryName;

        //todo Сделать через инициализацию
        public void Set(String CountryCode, String CountryName)
        {
            this.CountryCode = CountryCode;
            this.CountryName = CountryName;
        }
    }
}
