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
            _testBadge.DoorAccess = new List<string> { "C4", "D3" };
            _badgeDictionary.AddBadge(_testBadge);
        }

        [TestMethod]
        public void Test_AddBadge()
        {
            BadgeRepo repo = new BadgeRepo();
            Badge badge = new Badge();
            List<string> door = new List<string>() { "D3" };
            badge.BadgeID = 1111111;
            door.Add("C4");
            bool success = _badgeDictionary.AddBadge(_testBadge);
            Assert.IsTrue(success);


        }
    }
}
