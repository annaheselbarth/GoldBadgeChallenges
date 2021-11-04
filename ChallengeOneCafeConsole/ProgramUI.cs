using ChallengeOneCafeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOneCafeConsole
{
    class ProgramUI
    {
        private CafeMenuRepo _cafeMenuRepo = new CafeMenuRepo();

        public void Run()
        {
            RunMenu(true);
        }

        public void RunMenu(bool continueToRun)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n ********************** Komodo Cafe Menu **************************\n\n\n\n\n" + "   Please Enter a number below of the option you would like to work with.  \n\n" + "  1. Menu List  \n\n" + "  2. Add Item to Menu  \n\n" + "  3. Delete Item from Menu  \n\n" + "  4. Exit \n\n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        CafeMenuList();
                        break;
                    case "2":
                        AddItem();
                        break;
                    case "3":
                        RemoveItem();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("   Please enter a valid number from 1-4.  \n\n" + "   Press any key to continue.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void CafeMenuList()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n  *********************************  Komodo Cafe Menu List  **********************************\n\n\n");
            //Console.ReadLine();
            //CafeMenuList();
            List<CafeMenuItem> menuList = _cafeMenuRepo.GetCafeMenu();
            if (menuList.Count == 0)
            {
                Console.WriteLine("Currently we don't have any items listed.");
                
            }
            else
            {
                int index = 1;
                foreach (CafeMenuItem cafeMenuItem in menuList)
                {
                    //_cafeMenuRepo.AddItem(cafeMenuItem);
                    Console.WriteLine($"{index}. {cafeMenuItem.MealName} {cafeMenuItem.MealNumber} {cafeMenuItem.menuItems} {cafeMenuItem.Ingredients} {cafeMenuItem.Description} {cafeMenuItem.Price}");
                      index ++;
                    
                    
                    
                }
            }
           Console.ReadKey();
        }

        public void AddItem()
        {
            CafeMenuItem menuItem = new CafeMenuItem();
            Console.Clear();
            Console.WriteLine("  Create new menu item. \n\n" + "Please enter in the name of the new menu item:  \n\n");
            menuItem.MealName = Console.ReadLine();

            Console.WriteLine("\n\n Please enter in the description of the menu item:  \n\n");
            menuItem.Description = Console.ReadLine();

            Console.WriteLine("\n\n Please enter in the list of ingredients:  \n\n");
            menuItem.Ingredients = Console.ReadLine();

            Console.WriteLine("\n\n Please enter the price of the item:  \n\n");
            string input = Console.ReadLine();
            decimal itemPrice = decimal.Parse(input);
            menuItem.Price = itemPrice;

            _cafeMenuRepo.AddItem(menuItem);
            
            Console.WriteLine($" {menuItem.MealName} was added to the menu. The description is {menuItem.Description}. The price is $ {menuItem.Price} and ingredients are {menuItem.Ingredients}.");
              
            Console.ReadKey();
            return;
        }

        public void RemoveItem()
        {
            bool removeItem = true;
            while (removeItem)
            {
                Console.Clear();
                Console.WriteLine("\n Enter in the meal number that you would like to remove: \n\n");
                int removeNum = int.Parse(Console.ReadLine());
                
                CafeMenuItem cafeMenuItem = _cafeMenuRepo.GetItemByNumber(removeNum);
                if (cafeMenuItem == null)
                {
                    Console.WriteLine(" \n Meal Number was not found. \n\n");

                }
                else
                {
                    CafeMenuList();
                    Console.WriteLine($" Are you sure you want to delete {cafeMenuItem.MealNumber} Enter yes or no");

                    string userAnswer = Console.ReadLine();
                    if (userAnswer.ToLower() == "yes")
                    {
                        _cafeMenuRepo.RemoveItem(cafeMenuItem);
                        Console.WriteLine($"{cafeMenuItem.MealNumber} has been removed.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("This item was not removed. Press any key to exit.");
                        Console.ReadKey();
                        return;
                    }
                }
            
            }
        }

        private int Number()
        {
            bool checkId = true;
            while (checkId)
            {
                string stringInput = Console.ReadLine();
                if (!int.TryParse(stringInput, out int Id))
                {

                    Console.Write("Please enter a number: \n\n");
                    continue;
                }
                else
                {
                    return Int32.Parse(stringInput);
                }
            }
            return +1;
        }
    }
}
