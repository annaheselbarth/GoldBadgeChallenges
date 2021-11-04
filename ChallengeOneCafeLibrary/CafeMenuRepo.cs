using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOneCafeLibrary
{
    public class CafeMenuRepo
    {
        CafeMenuItem menu = new CafeMenuItem();
        public List<CafeMenuItem> _cafeMenuRepo = new List<CafeMenuItem>();
        int counter = 1;

        public bool AddItem(CafeMenuItem menuItem)
        {
            int initCount = _cafeMenuRepo.Count;
            int counter;
            counter = _cafeMenuRepo.Count +1;
            menuItem.MealNumber = counter++;
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

       
        public List<CafeMenuItem> GetCafeMenu()
        {
            return _cafeMenuRepo;
        }
        

        public bool RemoveItem(CafeMenuItem menu)
        {
            bool result = _cafeMenuRepo.Remove(menu);
            return result;
        }
    }
}
