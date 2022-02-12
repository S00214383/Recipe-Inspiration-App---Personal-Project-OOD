using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Inspiration_App___Personal_Project_OOD
{
    public abstract class Country : IComparable
    {

        //Properties
        public string CountryName { get; set; }


        //list of dishes
        public List<Dishes> DishesList { get; set; }

        public string  TraditionalFood { get; set; }


        //Constructors
        public Country(string countryname, string tradFood)
        {
            CountryName = countryname;
            TraditionalFood = tradFood;

          DishesList = new List<Dishes>();
        }

        public Country():this("Unknown", "Unknown")
        {
            DishesList = new List<Dishes>();
        }


        //Methods
        public override string ToString()
        {
            return CountryName;
        }


        public int CompareTo(object obj)
        {

            Country otherCountry = obj as Country;

            return this.CountryName.CompareTo(otherCountry.CountryName);
        }
    }

    public class AmericaCountry : Country
    {
        //public override string ToString()
        //{
        //    return base.ToString() + "American";
        //}

    }
    public class EuropeCountry : Country
    {
        //public override string ToString()
        //{
        //    return base.ToString() + "European";
        //}

    }
    public class AfricaCountry : Country
    {
        //public override string ToString()
        //{
        //    return base.ToString() + "African";
        //}
    }
    public class AsiaCountry : Country
    {
        //public override string ToString()
        //{
        //    return base.ToString() + "Asian";
        //}
    }
    public class OceaniaCountry : Country
    {
        //public override string ToString()
        //{
        //    return base.ToString() + "Oceanic";
        //}
    }



}


