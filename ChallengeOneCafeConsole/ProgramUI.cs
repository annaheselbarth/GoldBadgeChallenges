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
            Console.WriteLine("\n\n\n  *********************************  Komodo Cafe Menu List  **********************************");
            _cafeMenuRepo.GetCafeMenu();
            Console.ReadKey();
            return;

        }

        public void AddItem()
        {
            CafeMenu menuItem = new CafeMenu();
            Console.Clear();
            Console.WriteLine("  Create new menu item. \n\n" + "Please enter in the name of the new menu item:  \n\n");
            menuItem.MealName = Console.ReadLine();

            Console.WriteLine("\n\n Please enter in the number for the item:  \n\n");
            string answer = Console.ReadLine();
            var itemNumber = int.Parse(answer);
            menuItem.MealNumber = itemNumber;
            
            Console.WriteLine("\n\n Please enter in the description of the menu item:  \n\n");
            menuItem.Description = Console.ReadLine();

            Console.WriteLine("\n\n Please enter in the list of ingredients:  \n\n");
            menuItem.Ingredients = Console.ReadLine();

            Console.WriteLine("\n\n Please enter the price of the item:  \n\n");
            string input = Console.ReadLine();
            var itemPrice = int.Parse(input);
            menuItem.Price = itemPrice;

            _cafeMenuRepo.CreateNewItem(menuItem);
            Console.WriteLine($"{menuItem.MealName} was added to the menu with the item number {menuItem.MealNumber}. The description is {menuItem.Description}. The price is {menuItem.Price} and ingredients are {menuItem.Ingredients}.");
            Console.ReadKey();
            return;
        }

        public void RemoveItem()
        {
            bool removeItem = true;
            while (removeItem)
            {
                Console.Clear();
                CafeMenuList();
                List<CafeMenu> listOfItems = _cafeMenuRepo.GetCafeMenu();
                if (listOfItems.Count == 0)
                {
                    removeItem = false;
                    return;
                }
                else
                {
                    Console.WriteLine("\n Please enter the menu number of the item you would like to remove:  \n\n");
                    string removeNum = Console.ReadLine();
                    var number = int.Parse(removeNum);
                    RemoveItem();
                    Console.WriteLine("\n    Your item has been removed. \n\n" + "    Press any key to continue.   ");
                    Console.ReadKey();
                    return;
                }
            }

        }
    }
}
