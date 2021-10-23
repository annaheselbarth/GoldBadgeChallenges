using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOneCafeConsole
{
    //Needs:
    //1. Meal number
    //2. Meal name
    //3. Description
    //4. List of ingredients
    //5. Price
    public class CafeMenu
    {
        public CafeMenu() { }
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public List<CafeMenu> MenuList { get; set; }

        public string menuItems { get; set; }
        public CafeMenu(int mealNumber, string mealName, string description, int price)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            Price = price;
        }

    }

}



