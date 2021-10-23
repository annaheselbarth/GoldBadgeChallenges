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
    }
}
