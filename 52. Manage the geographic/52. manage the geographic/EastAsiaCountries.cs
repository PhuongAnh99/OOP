using System;
using System.Collections.Generic;
using System.Text;

namespace _52._manage_the_geographic
{
    public class EastAsiaCountries
    {
        protected string countryCode;
        protected string countryName;
        protected double countryArea;

        public EastAsiaCountries()
        {

        }
        public EastAsiaCountries(string countryCode, string countryName, double countryArea)
        {
            this.countryCode = countryCode;
            this.countryName = countryName;
            this.countryArea = countryArea;
        }
        public string CountryCode
        {
            get
            {
                return countryCode;
            }
            set
            {
                countryCode = value;
            }
        }

        public string CountryName
        {
            get
            {
                return countryName;
            }
            set
            {
                countryName = value;
            }
        }
        public double CountryArea
        {
            get
            {
                return countryArea;
            }
            set
            {
                countryArea = value;
            }
        }

        public virtual void display()
        {

        }
    }
}
