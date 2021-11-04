using ChallengThreeBadgesLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChallengeThreeBadgesTest
{
    [TestClass]
    public class BadgeMethodsTest
    {
        private List<string> _list1;
        private List<string> _list2;
        private List<string> _list3;
        private Badge _badge1;
        private Badge _badge2;
        private Badge _badge3;
        private BadgeRepo _badgeRepo;


        [TestInitialize]

        public void Arrange()
        {
            _list1 = new List<string>() { "A1", "A2" };
            _list2 = new List<string>() { "B1", "B2", "B3" };
            _list3 = new List<string>() { "C1", "C2", "C3" };
            _badge1 = new Badge(1, _list1);
            _badge2 = new Badge(2, _list2);
            _badge3 = new Badge(3, _list3);
            _badgeRepo = new BadgeRepo();
            _badgeRepo.AddBadge(1, _list1);
            _badgeRepo.AddBadge(2, _list2);
            _badgeRepo.AddBadge(3, _list3);
           
        }

        [TestMethod]
        public void Test_AddBadge()
        {
           
            Assert.IsTrue(_badgeRepo.GetBadgeDictionary().ContainsKey(1));
        }

        [TestMethod]
        public void Test_AddDoor()
        {

            int startingCount = _badge2.DoorAccess.Count;
            _badgeRepo.AddDoor(2, "A3");
            int secondCount = _badge2.DoorAccess.Count;

            Assert.IsTrue(_badge2.DoorAccess.Contains("A3"));
           
        }

        [TestMethod]
        public void Test_GetBadgeDictionary()
        {
            
            Dictionary<int, List<string>> testDictionary = new Dictionary<int, List<string>>(_badgeRepo.GetBadgeDictionary());

            Assert.IsNotNull(testDictionary);
            Assert.AreEqual(_badge1, testDictionary[1]);
        }

        [TestMethod]
        public void Test_BadgeID()
        {
            var getBadgeID = _badgeRepo.BadgeID(3);
            Assert.IsNotNull(getBadgeID);
        }

        [TestMethod]
        public void Test_DeleteBadge()
        {
           bool deleteBadge = _badgeRepo.DeleteBadge(_badge1);

           Assert.IsTrue(deleteBadge);
        }

        [TestMethod]
        public void Test_DeleteDoor()
        {
           List<string> addList = new List<string>() { "B1", "B2", "B3" };
            Badge removeDoor = new Badge(3, addList);
            
            bool itemRemoved = _badgeRepo.DeleteDoor(3, "B1");
          
            Assert.IsNotNull(itemRemoved);
        }
    }
}
