using ChallengThreeBadgesLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChallengeThreeBadgesTest
{
    [TestClass]
    public class BadgeMethodsTest
    {
        private BadgeRepo _badgeDictionary;
        private Badge testBadge;
        [TestInitialize]

        public void Arrange()
        {
            testBadge = new Badge(new Dictionary<int, string> { c4, A3 });
            BadgeRepo _badgeDictionary = new BadgeRepo(); }

        [TestMethod]
        public void Test_AddBadge()
        {

            bool success = _badgeDictionary.AddBadge(testBadge);
            Assert.IsTrue(success);


        }
    }
}
