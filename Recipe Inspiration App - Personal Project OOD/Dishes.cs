using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Inspiration_App___Personal_Project_OOD
{


    public class Dishes 
    {
        //properties
        public string DishName { get; set; }

        public string DishIngredients { get; set; }

        public string DishInstructions { get; set; }

        public string DifficultyLevel { get; set; }



        //methods

        public Dishes(string dishName, string dishIngredients, string dishInstructions,  string difficultyLevel)
        {
            DishName = dishName;
            DishIngredients = dishIngredients;
            DishInstructions = dishInstructions;
            DifficultyLevel = difficultyLevel;
        }

        public override string ToString()
        {
            return string.Format($"Dish: {DishName } \n Igredients: {DishIngredients } \n Instructions: {DishInstructions } \n Difficulty Level: {DifficultyLevel}"); 
        }
        //default constructor
        public Dishes()
        {

        }
        

}
  


}
