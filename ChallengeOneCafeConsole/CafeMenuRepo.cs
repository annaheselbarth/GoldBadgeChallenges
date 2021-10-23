using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOneCafeConsole
{
    public class CafeMenuRepo
    {
        //Create - New Menu item & List of items. Each menu item needs a meal number, meal name, description, list of ingredients, and price. 

        CafeMenu menu = new CafeMenu();
        public List<CafeMenu> _cafeMenuRepo = new List<CafeMenu>();
        int counter;
        /*public void AddItem(CafeMenu menuItem)
        {
            counter = _cafeMenuRepo.Count + 1;
            menuItem.MealNumber = counter;
            _cafeMenuRepo.Add(menuItem);
        }*/

        public void CreateNewItem(CafeMenu menuItem)
        {
            counter = _cafeMenuRepo.Count +1;
            menuItem.MealNumber = counter;
            _cafeMenuRepo.Add(menuItem);
        }

        public CafeMenu GetItemByNumber(int mealNumber)
        {
            foreach(CafeMenu menu in _cafeMenuRepo)
            {
                if(menu.MealNumber == mealNumber)
                {
                    return menu;
                }
            }
            return null;
        }

        public bool AddItemToMenu(int mealNumber, CafeMenu menuItems)
        {
            CafeMenu cafeMenu = GetItemByNumber(mealNumber);
            if(cafeMenu != null)
            {
                _cafeMenuRepo.Add(menuItems);
                return true;
            }
            return false;
        }
        //Read

        public List<CafeMenu> GetCafeMenu()
        {
            return _cafeMenuRepo;
        }
        //Update
        //*Client currently does not wish to update at this time. 
        //Delete

        public bool RemoveItem(CafeMenu item)
        {
            bool result = _cafeMenuRepo.Remove(item);
            return result;
        }
    }
}
