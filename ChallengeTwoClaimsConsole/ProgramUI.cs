using ChallengeTwoClaimsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwoClaimsConsole
{
    public class ProgramUI
    {
        private readonly ClaimRepo _claimRepo = new ClaimRepo();
        public void Run()
        {
            SeedQueueList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("************************* Komodo Claims Department *************************  \n\n\n Please choose a menu item by entering a number of the option you would like to select: \n\n" + "  1. See All Claims \n\n" + "  2. Take Care of Next Claim \n\n" + "  3. Enter a New Claim \n\n" + "  4. Exit \n\n");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ClaimList();
                        break;
                    case "2":
                        GetNextClaim();
                        break;
                    case "3":
                        AddNewClaim();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("  Please enter in a valid number between 1-4.  \n\n Press any key to continue. ");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void AddNewClaim()
        {

        }

        public void GetNextClaim()
        {

        }

        public void ClaimList()
        {
            Console.Clear();
            Queue<Claim> claimList = _claimRepo.ClaimList();

            foreach (Claim claim in claimList)
            {
                DisplayClaim(claim);
            }

            Console.ReadKey();
        }

        public void DisplayClaim(Claim claimItem)
        {
            Console.WriteLine($"ClaimID: {claimItem.ClaimID} | Type: {claimItem.TypeOfClaim} | Description: {claimItem.ClaimDescription} | Amount: {claimItem.ClaimAmount} | DateOfAccident: {claimItem.DateOfIncident.ToShortDateString()} | DateOfClaim: {claimItem.DateOfClaim.ToShortDateString()} IsValid: {claimItem.IsValid} \n\n");
        }

        public void SeedQueueList()
        {
        }
    }
}
