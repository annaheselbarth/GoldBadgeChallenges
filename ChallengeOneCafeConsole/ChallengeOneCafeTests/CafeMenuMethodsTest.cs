using ChallengeOneCafeConsole;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChallengeOneCafeTests
{
    [TestClass]
    public class CafeMenuMethodsTest
    {
        private CafeMenuRepo _cafeMenuRepo;

        [TestInitialize]

        public void Arrange()
        {
            _cafeMenuRepo = new CafeMenuRepo();
        }

        [TestMethod]
        public void Test_CreateNewItem()
        {
            //Arrange

            CafeMenuRepo _cafeMenuRepo = new CafeMenuRepo();
            CafeMenu cafeMenu = new CafeMenu();

            //Act


        }
    }
}
