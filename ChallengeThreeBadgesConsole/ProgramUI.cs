using ChallengThreeBadgesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThreeBadgesConsole
{
    class ProgramUI
    {
        private readonly BadgeRepo _badgeRepo = new BadgeRepo();

        public void Run()
        {
            SeedBadgeList();
            RunMenu(true);
        }

        public void RunMenu(bool continueToRun)
        {
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n ******************************* Komodo Insurance Badges **************************** \n\n\n" + "\n\n   Hello Security Admin, What would you like to do? \n\n\n" + "\n   1. Add a Badge  \n\n" + "\n   2. Edit a Badge  \n\n" + "\n   3. List all Badges  \n\n" + "\n   4. Exit  \n\n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddBadge();
                        break;
                    case "2":
                        EditBadge();
                        break;
                    case "3":
                        DisplayBadgeDictionary();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine(" Please enter a valid number between 1-4. Press any key to continue.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void AddBadge()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n What is the number on the badge:  \n\n");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine(" List a door that it needs access to: \n\n");
            List<string> doorAccess = new List<string>();
            string userInput = Console.ReadLine();
            doorAccess.Add(userInput);
            _badgeRepo.AddBadge(id, doorAccess);


            bool otherDoors = true;
            while (otherDoors)
            {
                Console.WriteLine(" Any other doors? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine(" List a door that it needs access to: \n\n");
                    string doorAnswer = Console.ReadLine();
                    doorAccess.Add(doorAnswer);
                    _badgeRepo.AddDoor(id, doorAnswer);

                }
                else if (answer == "n")
                {
                    Console.WriteLine(" Press any key to exit. \n\n");
                    otherDoors = false;
                   // _badgeRepo.AddBadge(id, doorAccess);
                    return;
                }
                else
                {
                    Console.WriteLine(" Please enter a valid response of y or n. ");
                    return;

                }
            }
            _badgeRepo.AddBadge(id, doorAccess);
        }

        public void EditBadge()
        {
            Console.Clear();
            bool editBadge = true;
            while (editBadge)
            {
                //GetBadgeList();
                Dictionary<int, List<string>> badgeList = _badgeRepo.GetBadgeDictionary();
                Console.WriteLine("\n\n What is the badge number to update? \n\n");
                int id = int.Parse(Console.ReadLine());
                Badge badge = _badgeRepo.BadgeID(id);
                Console.WriteLine($" Badge {badge.BadgeID} has access to doors ");
                foreach(string door in badge.DoorAccess)
                {
                    Console.WriteLine($" {door}");
                }
                Console.WriteLine("What would you like to do?" + "\n\n 1. Remove a Door \n\n" + "\n 2. Add a Door \n\n" + "\n 3. Exit \n\n");

                string answerDoor = Console.ReadLine();
                if (answerDoor == "1")
                {
                    Console.WriteLine(" Which door would you like to remove? ");
                    string doorID = Console.ReadLine();
                    _badgeRepo.DeleteDoor(badge.BadgeID, doorID);

                    Console.WriteLine(" Door Removed. \n\n");
                    Console.WriteLine($"{badge.BadgeID} has access to doors: ");

                    foreach (string door in badge.DoorAccess)
                    {
                        Console.WriteLine($" {door}");
                    }
                    editBadge = false;
                    //return;
                }
                else if (answerDoor == "2")
                {
                    Console.WriteLine("\n\n Which door would you like to add? \n\n");
                    string newDoorID = Console.ReadLine();
                    _badgeRepo.AddDoor(badge.BadgeID, newDoorID);
                    Console.WriteLine(" Door Added \n\n");
                    Console.WriteLine($"{badge.BadgeID} has access to doors:");
                    foreach (string door in badge.DoorAccess)
                    {
                        Console.WriteLine($" {door} \n\n");
                    }
                    editBadge = false;
                    //return;
                }
                else
                {
                    Console.WriteLine(" Enter a valid response. \n\n");
                    return;
                }
            }
            
        }

        public void DisplayBadgeDictionary()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n *************************** List of Badges **************************\n\n\n");

            //BadgeList();
            Dictionary<int, List<string>> badges = _badgeRepo.GetBadgeDictionary();
            //keyvaluepair[0] => key: 123 value: "A7","blah2","blah3"
            //keyvaluepair[1] => key: 354 value: "blah5","blah22","blah13"
            foreach (var idAndDoors in badges) //foreach item in my dictionary
            {
                foreach (string door in idAndDoors.Value) //foreach string in my keyvaluepair value(List<string>)
                {

                    Console.WriteLine($" {idAndDoors.Key} : {door} ");
                }
            }

           
            Console.ReadKey();
            return;
            
        }
        public void SeedBadgeList()
        {

            Badge badge1 = new Badge(12345, new List<string> { "A7" });
            Badge badge2 = new Badge(22345, new List<string> { "A1", "A4", "B1", "B2" });
            Badge badge3 = new Badge(32345, new List<string> { "A4", "A5" });

            _badgeRepo.AddBadge(badge1.BadgeID, badge1.DoorAccess);
            _badgeRepo.AddBadge(badge2.BadgeID, badge2.DoorAccess);
            _badgeRepo.AddBadge(badge3.BadgeID, badge3.DoorAccess);

           
        }
    }
}
