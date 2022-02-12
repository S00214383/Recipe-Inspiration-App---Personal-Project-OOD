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

        private void cbboxCountries_Loaded(object sender, RoutedEventArgs e)
        {
            //declaring objects
            Country c1 = new Country() { CountryName = "Mexico", TraditionalFood = "Chilaquiles" };
            Country c2 = new Country() { CountryName = "Brazil", TraditionalFood = "Feijoada" };
            Country c3 = new Country() { CountryName = "France", TraditionalFood = "Ratatouille" };
            Country c4 = new Country() { CountryName = "China", TraditionalFood = "Kung Pao Chicken" };
            Country c5 = new Country() { CountryName = "South Africa", TraditionalFood = "Bobotie" };
            Country c6 = new Country() { CountryName = "Japan", TraditionalFood = "Okonomiyyaki" };

            //adding them to th collection
            allCountries.Add(c1);
            allCountries.Add(c2);
            allCountries.Add(c3);
            allCountries.Add(c4);
            allCountries.Add(c5);
            allCountries.Add(c6);

            //Displaying countries
            cbboxCountries.ItemsSource = allCountries;



        }
    }
}
