using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Recipe_Inspiration_App___Personal_Project_OOD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List os countries
        List<Country> allCountries = new List<Country>();

    

        public MainWindow()
        {
            InitializeComponent();
        }

        private void lbxCountries_Loaded(object sender, RoutedEventArgs e)
        {

            //comboBox
            string[] continents = { "All", "American", "European", "Asian", "African", "Oceania" };
            cbxContinent.ItemsSource = continents;


            //declaring objects
            AmericaCountry c1 = new AmericaCountry() { CountryName = "Mexico", TraditionalFood = "Chilaquiles" };
            AmericaCountry c2 = new AmericaCountry() { CountryName = "Brazil", TraditionalFood = "Feijoada" };

            EuropeCountry c3 = new EuropeCountry() { CountryName = "France", TraditionalFood = "Ratatouille" };
            EuropeCountry c4 = new EuropeCountry() { CountryName = "Germany", TraditionalFood = "Spatzle" };

            AsiaCountry c5 = new AsiaCountry() { CountryName = "China", TraditionalFood = "Kung Pao Chicken" };
            AsiaCountry c6 = new AsiaCountry() { CountryName = "India", TraditionalFood = "Iasooni Tikka Chicken" };
         //   AsiaCountry c7 = new AsiaCountry() { CountryName = "Japan", TraditionalFood = "Okonomiyyaki" };

            AfricaCountry c7 = new AfricaCountry() { CountryName = "South Africa", TraditionalFood = "Bobotie" };
            AfricaCountry c8 = new AfricaCountry() { CountryName = "Marocoo", TraditionalFood = "Tagine" };

            OceaniaCountry c9 = new OceaniaCountry() { CountryName = "Australia", TraditionalFood = "Lamb Leg Roast" };
            OceaniaCountry c10 = new OceaniaCountry() { CountryName = "Fiji", TraditionalFood = "Kokoda" };


            //declaring dishes from each country
            Dishes d1 = new Dishes { DishName = "Chilaquiles", DishIngredients = "Pepper", DifficultyLevel = "hard", DishInstructions = "instruc" };
            Dishes d2 = new Dishes { DishName = "Feijoada", DishIngredients = "Beans", DifficultyLevel = "Medium", DishInstructions = "instruc" };

            Dishes d3 = new Dishes { DishName = "Ratatouille", DishIngredients = "Vegetables", DifficultyLevel = "Medium", DishInstructions = "instruc" };
            Dishes d4 = new Dishes { DishName = "Spatzle", DishIngredients = "Beans", DifficultyLevel = "Medium", DishInstructions = "instruc" };

            Dishes d5 = new Dishes { DishName = "Kung Pao Chicken", DishIngredients = "Beans", DifficultyLevel = "Medium", DishInstructions = "instruc" };
            Dishes d6 = new Dishes { DishName = "Iasooni Tikka Chicken", DishIngredients = "Beans", DifficultyLevel = "Medium", DishInstructions = "instruc" };

            Dishes d7 = new Dishes { DishName = "Bobotie", DishIngredients = "Beans", DifficultyLevel = "Medium", DishInstructions = "instruc" };
            Dishes d8 = new Dishes { DishName = "Tagine", DishIngredients = "Beans", DifficultyLevel = "Medium", DishInstructions = "instruc" };

            Dishes d9 = new Dishes { DishName = "Lamb Leg Roast", DishIngredients = "Beans", DifficultyLevel = "Medium", DishInstructions = "instruc" };
            Dishes d10 = new Dishes { DishName = "Kokoda", DishIngredients = "Beans", DifficultyLevel = "Medium", DishInstructions = "instruc" };

            //adding them to th collection
            allCountries.Add(c1);
            allCountries.Add(c2);
            allCountries.Add(c3);
            allCountries.Add(c4);
            allCountries.Add(c5);
            allCountries.Add(c6);
            allCountries.Add(c7);
            allCountries.Add(c8);
            allCountries.Add(c9);
            allCountries.Add(c10);

            allCountries.Sort();

            //Displaying countries
            lbxCountries.ItemsSource = allCountries;

            //add dishes to countries
            c1.DishesList.Add(d1);
            c2.DishesList.Add(d2);
            c3.DishesList.Add(d3);
            c4.DishesList.Add(d4);
            c5.DishesList.Add(d5);
            c6.DishesList.Add(d6);
            c7.DishesList.Add(d7);
            c8.DishesList.Add(d8);
            c9.DishesList.Add(d9);
            c10.DishesList.Add(d10);


            //displaying dishes
            //tbxRecipeInfo.Items
            
           

            
        }

        //filtering by continent
        private void cbxContinent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //specify what is selected
            string selectedContinent = cbxContinent.SelectedItem as string;

            //add filter list
            List<Country> filteredList = new List<Country>();


            //if/else - switch
            switch (selectedContinent)
            {
                case "All":
                    lbxCountries.ItemsSource = allCountries;
                    break;
                case "American":
                    foreach (Country country in allCountries)
                    {
                        if (country is AmericaCountry)
                        {
                            filteredList.Add(country);
                        }                        
                    }
                    lbxCountries.ItemsSource = filteredList;
                    break;

                case "European":
                    foreach (Country country in allCountries)
                    {
                        if (country is EuropeCountry)
                        {
                            filteredList.Add(country);
                        }
                    }
                    lbxCountries.ItemsSource = filteredList;
                    break;
                case "Asian":
                    foreach (Country country in allCountries)
                    {
                        if (country is AsiaCountry)
                        {
                            filteredList.Add(country);
                        }
                    }
                    lbxCountries.ItemsSource = filteredList;
                    break;

                case "African":
                    foreach (Country country in allCountries)
                    {
                        if (country is AfricaCountry)
                        {
                            filteredList.Add(country);
                        }
                    }
                    lbxCountries.ItemsSource = filteredList;
                    break;
                case "Oceania":
                    foreach (Country country in allCountries)
                    {
                        if (country is OceaniaCountry)
                        {
                            filteredList.Add(country);
                        }
                    }
                    lbxCountries.ItemsSource = filteredList;
                    break;

                default:
                    break;
            }

           
        }

        private void lbxCountries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            
                Country selectedCountry = lbxCountries.SelectedItem as Country;

                if (selectedCountry != null)
                {
                    lbxDishInfo.ItemsSource = selectedCountry.DishesList;
                }
            
        }

     
    }
}
