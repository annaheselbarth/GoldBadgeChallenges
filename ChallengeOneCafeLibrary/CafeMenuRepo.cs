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
        int counter = 1;
        /*public void AddItem(CafeMenuItem menuItem)
        {
            menuItem.MealNumber = counter++;

            _cafeMenuRepo.Add(menuItem);
        }*/

        
        public bool AddItem(CafeMenuItem menuItem)
        {
            int initCount = _cafeMenuRepo.Count;
            //int counter;
            //counter = _cafeMenuRepo.Count +1;
            //menuItem.MealNumber = counter++;
            _cafeMenuRepo.Add(menuItem);
            int newCount = _cafeMenuRepo.Count;
            return newCount > initCount;

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

        /*public bool AddItemToMenu(CafeMenuItem menuItem)
        {
            int counter = 1;
            menuItem.MealNumber = counter++;
            int counter1 = _cafeMenuRepo.Count;
                _cafeMenuRepo.Add(menuItem);
            return (_cafeMenuRepo.Count > counter +1);
            
        }*/
        //Read

        //public List<CafeMenuItem> GetCafeMenu()
        //{
           // return _cafeMenuRepo;
        //}

        public List<CafeMenuItem> GetCafeMenu()
        {
            return _cafeMenuRepo;
        }
        //Update
        //*Client currently does not wish to update at this time. 
        //Delete

        public bool RemoveItem(CafeMenuItem menu)
        {
            bool result = _cafeMenuRepo.Remove(menu);
            return result;
        }
    }
}
