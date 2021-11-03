using ChallengThreeBadgesLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChallengeThreeBadgesTest
{
    [TestClass]
    public class BadgeMethodsTest
    {
        private BadgeRepo _badgeDictionary;
        private Badge _testBadge;
        
        [TestInitialize]

        public void Arrange()
        {
            _testBadge = new Badge(111111);
            _badgeDictionary = new BadgeRepo();
            //_testBadge.DoorAccess = new List<string> { "C4", "D3" };
            //_badgeDictionary.AddBadge(_testBadge);
        }

        [TestMethod]
        public void Test_AddBadge()
        {
            /*BadgeRepo repo = new BadgeRepo();
            Badge badge = new Badge();
            List<string> door = new List<string>() { "D3" };
            badge.BadgeID = 1111111;
            door.Add("C4");
            bool success = _badgeDictionary.AddBadge(_testBadge);
            Assert.IsTrue(success);*/


        }

        [TestMethod]
        public void Test_AddDoor()
        {
            string access = "A3";

            bool success = _badgeDictionary.AddDoor(12345, access);

            Assert.IsTrue (success);
        }

        [TestMethod]
        public void Test_GetBadgeDictionary()
        {
           /* BadgeRepo repo = new BadgeRepo();
            Badge badge = new Badge(12345, new List<string> { "C5", "D4" });
            repo.AddBadge(badge);
            _badgeDictionary<int, List<string>> badge = repo.GetBadgeDictionary();
            Assert.IsNotNull(badge);*/
        }

        [TestMethod]
        public void Test_DeleteDoor()
        {
            bool deleteDoor = _badgeDictionary.DeleteDoor(111111, "C4");

            Assert.IsTrue(deleteDoor);
        }
    }
}
