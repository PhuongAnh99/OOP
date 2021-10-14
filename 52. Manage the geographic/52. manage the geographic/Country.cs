using System;
using System.Collections.Generic;
using System.Text;

namespace _52._manage_the_geographic
{
    class Country : EastAsiaCountries//, IComparable<Country>
    {
        private string countryTerrain;

        public Country()
        {

        }
        public Country(string countryTerrain, string countryCode, string countryName, double countryArea)
            : base(countryCode, countryName, countryArea)
        {
            this.countryTerrain = countryTerrain;
        }
        public override void display()
        {
            Console.WriteLine(String.Format("{0,-20}{1,-20}{2,-20}{3,-20}", this.countryCode,
                this.countryName, this.countryArea, this.countryTerrain));
        }
        public string CountryTerrain
        {
            get
            {
                return countryTerrain;
            }
            set
            {
                countryTerrain = value;
            }
        }
        //public int CompareTo(Country c)
        //{
        //    return this.countryName.CompareTo(c.countryName);
        //}
    }
}
