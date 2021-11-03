using ChallengeTwoClaimsLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChallengeTwoClaimsTest
{

    

    [TestClass]
    public class ClaimTest
    {

        ClaimRepo _claimRepo = new ClaimRepo();
        Claim _testClaim = new Claim();

        [TestInitialize]
        
        public void Arrange()
        {
            _testClaim = new Claim(3, ClaimType.Car, "wreck", 4000m, DateTime.Today, DateTime.Now);
            _claimRepo.AddNewClaim(_testClaim);
        }

        [TestMethod]
        public void Test_AddClaim()
        {
            Claim claim = new Claim();
            ClaimRepo claimRepo = new ClaimRepo();

            bool success = claimRepo.AddNewClaim(claim);

            Assert.IsTrue(success);


        }

        [TestMethod]
        public void Test_GetNextClaim()
        {
            /* ClaimRepo _claimRepo = new ClaimRepo();
             Claim claimID = new Claim();
             claimID.ClaimID = 2;

             _claimRepo.AddNewClaim(claimID);

             List<Claim> peekClaim = _claimRepo.ClaimList();
             bool newClaimID = peekClaim.Contains(claimID);
             Assert.IsTrue(newClaimID);*/
            Claim claim = _claimRepo.GetNextClaim();
            Assert.AreEqual(_testClaim, claim);
        }

        [TestMethod]
        public void Test_ClaimList()
        {
            /*DateTime dateOfClaim = new DateTime(2019, 11, 04);
            DateTime dateOfIncident = new DateTime(2019, 10, 30);
            Claim newClaim = new Claim(1, ClaimType.Home, "tornado", 10000, dateOfIncident, dateOfClaim);
            _claimRepo.AddNewClaim(newClaim);

            Queue<Claim> claimList = _claimRepo.ClaimList();

            bool success = claimList.Contains(newClaim);

            Assert.IsTrue(success);*/

            int intialCount = _claimRepo.ClaimList().Count;
            Assert.AreEqual(intialCount, 1);
            Assert.AreNotEqual(intialCount, 2);
        }

        [TestMethod]
        public void Test_DequeueClaim()
        {
            bool deleteClaim = _claimRepo.DequeueClaim(_testClaim);
            Assert.IsTrue(deleteClaim);
        }
    }
}
