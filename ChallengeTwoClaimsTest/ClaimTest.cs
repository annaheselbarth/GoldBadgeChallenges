using ChallengeTwoClaimsLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChallengeTwoClaimsTest
{
    [TestClass]
    public class ClaimTest
    {

        ClaimRepo _claimRepo = new ClaimRepo();
        Claim claim = new Claim();
        
        [TestMethod]
        public void Test_AddClaim()
        {
            


        }

        [TestMethod]
        public void Test_GetNextClaim()
        {
            /*ClaimRepo claim = new ClaimRepo();
            Claim claimID = new Claim();
            claimID.ClaimID = 2;

            claim.AddNewClaim(claimID);

            ClaimRepo<Claim> peekClaim = claim.ClaimList();
            bool newClaimID = peekClaim.Contains(claimID);
            Assert.IsTrue(newClaimID);*/
        }

        [TestMethod]
        public void Test_DequeueClaim()
        {
            bool deleteClaim = _claimRepo.DequeueClaim();
            Assert.IsTrue(deleteClaim);
        }
    }
}
