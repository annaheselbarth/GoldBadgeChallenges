using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOneCafeLibrary
{
    public class CafeMenuRepo
    {
        //Create - New Menu item & List of items. Each menu item needs a meal number, meal name, description, list of ingredients, and price. 

        CafeMenuItem menu = new CafeMenuItem();
        public List<CafeMenuItem> _cafeMenuRepo = new List<CafeMenuItem>();

        /*public void AddItem(CafeMenu menuItem)
        {
            counter = _cafeMenuRepo.Count + 1;
            menuItem.MealNumber = counter;
            _cafeMenuRepo.Add(menuItem);
        }*/

        public bool CreateNewItem(CafeMenuItem menuItem)
        {
            int initCount = _cafeMenuRepo.Count;
            int counter;
            counter = _cafeMenuRepo.Count + 1;
            menuItem.MealNumber = counter;
            _cafeMenuRepo.Add(menuItem);
            int newCount = _cafeMenuRepo.Count;
            return newCount == initCount + 1;

        }

        public CafeMenuItem GetItemByNumber(int mealNumber)
        {
            foreach (CafeMenuItem menu in _cafeMenuRepo)
            {
                if (menu.MealNumber == mealNumber)
                {
                    return menu;
                }
            }
            return null;
        }

        public bool AddItemToMenu(int mealNumber, CafeMenuItem menuItems)
        {
            CafeMenuItem cafeMenu = GetItemByNumber(mealNumber);
            if (cafeMenu != null)
            {
                _cafeMenuRepo.Add(menuItems);
                return true;
            }
            return false;
        }
        //Read

        public List<CafeMenuItem> GetCafeMenu()
        {
            return _cafeMenuRepo;
        }
        //Update
        //*Client currently does not wish to update at this time. 
        //Delete

        public bool RemoveItem(CafeMenuItem item)
        {
            bool result = _cafeMenuRepo.Remove(item);
            return result;
        }
    }
}
