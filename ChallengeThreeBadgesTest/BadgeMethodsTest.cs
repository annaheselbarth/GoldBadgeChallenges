using ChallengThreeBadgesLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChallengeThreeBadgesTest
{
    [TestClass]
    public class BadgeMethodsTest
    {
        
        //private BadgeRepo _badgeRepo;
        //private Badge _testBadge;
       // private Badge _testBadge1;
       // private Badge _testBadge2;

        BadgeRepo _badgeRepo = new BadgeRepo();
        Badge _testBadge = new Badge();
        BadgeRepo _badgeDictionary = new BadgeRepo();


        [TestInitialize]

        public void Arrange()
        {
            //_testBadge = new Badge();
            //_testBadge1 = new Badge(1, "D3");
            //_badgeRepo = new BadgeRepo();
            //_testBadge = new Badge(2, "A3");

            //_testBadge = new Badge(3, new List<string> { "A1", "B2", "C3", "D4" });
            //_badgeRepo.AddBadge(_testBadge);

            

            //_badgeRepo.AddBadge(_testBadge);
            //_testBadge.DoorAccess = new Dictionary<string> { "C4", "D3" };
            //_badgeDictionary.AddBadge(_testBadge);

        }

        [TestMethod]
        public void Test_AddBadge()
        {
           BadgeRepo _badgeRepo = new BadgeRepo();
           Badge _testBadge = new Badge(new List<string> { "A1", "A2", "A3" });
            
           bool success = _badgeRepo.AddBadge(_testBadge);

            Assert.IsNotNull(success);
            Assert.IsTrue(success);



            //Assert.IsTrue(_badgeRepo.GetBadgeDictionary().ContainsKey(3));
        }

        [TestMethod]
        public void Test_AddDoor()
        {
            BadgeRepo _badgeRepo = new BadgeRepo();
            Badge _testBadge = new Badge(new List<string> { "A1", "A2", "A3" });

            _badgeRepo.AddBadge(_testBadge);
            var addDoor = "A4";
            bool doorAdded = _badgeRepo.AddDoor(_testBadge.BadgeID, addDoor);
            Assert.IsTrue(doorAdded);
            //string doorAccess = "A3";
            //Assert.IsTrue(_badgeRepo.GetBadgeDictionary().TryGetValue(3, "A3"));
            
            
            //string access = "A3";

            //bool success = _badgeRepo.AddDoor(12345, access);

            //Assert.IsTrue (success);
        }

        [TestMethod]
        public void Test_GetBadgeDictionary()
        {
            BadgeRepo _badgeRepo = new BadgeRepo();
            Badge getBadge = new Badge(2, new List<string> { "C1", "C2" } );
            _badgeRepo.AddBadge(getBadge);
            int intialCount = _badgeRepo.GetBadgeDictionary().Count;
            Assert.AreEqual(getBadge, intialCount);
            Assert.AreNotEqual(getBadge, intialCount);
        }

        [TestMethod]
        public void Test_BadgeID()
        {
            var badge = _badgeRepo.BadgeID(1);
            Assert.AreEqual(_testBadge.DoorAccess, badge);
        }

        [TestMethod]
        public void Test_DeleteBadge()
        {
           bool deleteBadge = _badgeRepo.DeleteBadge(_testBadge);

           Assert.IsTrue(deleteBadge);
        }

        [TestMethod]
        public void Test_DeleteDoor()
        {
            //bool deleteDoor = _badgeRepo.DeleteDoor(111111, "C4");
            //Assert.IsTrue(deleteDoor);

            BadgeRepo _badgeRepo = new BadgeRepo();
            //Badge _testBadge = new Badge(3, List<string> "A3" );
            //_badgeRepo.AddBadge(_testBadge);

            //int startingCount = _testBadge.DoorAccess.Count;
            //_badgeRepo.DeleteDoor(3, "A3");
            //int finalCount = _testBadge.DoorAccess.Count("A3");

            //Assert.IsFalse(_testBadge.DoorAccess.Contains("A3"));
            //Assert.AreEqual(startingCount - 1, finalCount);

           Badge _testBadge = new Badge();
            Badge removeBadge = new Badge(3, List<string> { "A3" });
            _badgeRepo.AddBadge(removeBadge);
            var removeDoor = "A3";
            bool itemRemoved = _badgeRepo.DeleteDoor(_testBadge.BadgeID, removeDoor);

            Assert.IsTrue(itemRemoved);


        }
    }
}
