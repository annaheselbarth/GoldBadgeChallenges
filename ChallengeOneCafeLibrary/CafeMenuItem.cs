using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOneCafeLibrary
{
    public class CafeMenuItem
    {
        public CafeMenuItem() { }
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public int Price { get; set; }



        public string menuItems { get; set; }
        public CafeMenuItem(int mealNumber, string mealName, string description, int price, string ingredients)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            Price = price;
            Ingredients = ingredients;
        }
    }
}
