using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Inspiration_App___Personal_Project_OOD
{
    public class Country : IComparable
    {

        //Properties
        public string CountryName { get; set; }


        public string  TraditionalFood { get; set; }


        //Constructors
        public Country(string countryname, string tradFood)
        {
            CountryName = countryname;
            TraditionalFood = tradFood;
        }

        //default constructor
        public Country()
        {

        }

        //Methods
        public override string ToString()
        {
            return CountryName;
        }

        public int CompareTo(object obj)
        {

            return CountryName.CompareTo(obj);
        }
    }
}
