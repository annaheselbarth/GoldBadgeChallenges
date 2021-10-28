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
        Queue<Claim> claimList = new Queue<Claim>();

        
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
            Console.Clear();
            Claim newClaim = new Claim();
            
            Console.WriteLine("\n\n Claim ID:  \n\n");
            int id = int.Parse(Console.ReadLine());
            newClaim.ClaimID = id;
            //bool typeMenu = true;
            //while (typeMenu)
            //{

            Console.WriteLine(" \n\n Claim Type:  \n\n" + "Choose 1 for Car \n" + "Choose 2 for Home. \n" + "Choose 3 for Theft. \n\n");

            //string answer = Console.ReadLine();

            //switch (answer)
            //{
            //case "1":
            //Car()
            //}
            //}

            string answerType = Console.ReadLine();
            int type = int.Parse(answerType);
            newClaim.TypeOfClaim = (ClaimType)type;

            Console.WriteLine(" \n\n Description: \n\n");
            string decriptionOfClaim = Console.ReadLine();
            newClaim.ClaimDescription = decriptionOfClaim;

            Console.WriteLine(" \n\n Amount:  \n\n");
            decimal claimAmount = decimal.Parse(Console.ReadLine());
            newClaim.ClaimAmount = claimAmount;

            Console.WriteLine(" \n\n Date of Incident:  (yyyy/mm/dd)  \n\n");
            DateTime dateOfIncident = Convert.ToDateTime(Console.ReadLine());
            newClaim.DateOfIncident = dateOfIncident;

            Console.WriteLine("  \n\n Date of Claim: (yyyy/mm/dd) \n\n");
            DateTime dateOfClaim = Convert.ToDateTime(Console.ReadLine());
            newClaim.DateOfClaim = dateOfClaim;

            Console.WriteLine($" \n\n Claim is Valid: {newClaim.IsValid}");
            _claimRepo.AddNewClaim(newClaim);

            Console.WriteLine("  \n\n Press any key to go back to main menu. \n\n");
            Console.ReadKey();
            return;


        }

        public void GetNextClaim()
        {
            Console.Clear();
            bool nextClaim = true;
            while (nextClaim)
            {
                Console.WriteLine(" \n Here are the details for the next claim to be handled:  \n\n");
                Claim claimInQueue = _claimRepo.GetNextClaim();
                Console.WriteLine($" \n Claim ID:  {claimInQueue.ClaimID} | Type: {claimInQueue.TypeOfClaim} | Description: {claimInQueue.ClaimDescription} | Amount: {claimInQueue.ClaimAmount} | DateOfAccident: {claimInQueue.DateOfIncident.ToShortDateString()} | DateOfClaim: {claimInQueue.DateOfClaim.ToShortDateString()} | IsValid: {claimInQueue.IsValid} ");
                Console.WriteLine(" /n/n Do you want to deal with this claim now(y/n)? \n\n");
                string claimAnswer = Console.ReadLine();
                if (claimAnswer == "y")
                {
                    _claimRepo.DequeueClaim();
                    Console.Clear();
                }
                else if (claimAnswer == "n")
                {
                    nextClaim = false;
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n Please enter y or n. \n\n");
                    return;
                }
            }
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
            Claim claim1 = new Claim(1, ClaimType.Car, "Car accident on 465.", 400.00m, new DateTime(2018, 4, 25), new DateTime(2018, 4, 27));
            Claim claim2 = new Claim(2, ClaimType.Home, "House fire in kitchen.", 4000.00m, new DateTime(2018, 4, 11), new DateTime(2018, 4, 12));
            Claim claim3 = new Claim(3, ClaimType.Theft, "Stolen pancakes.", 4.00m, new DateTime(2018, 4, 27), new DateTime(2018, 6, 1));

            _claimRepo.AddNewClaim(claim1);
            _claimRepo.AddNewClaim(claim2);
            _claimRepo.AddNewClaim(claim3);
         
        }
    }
}
