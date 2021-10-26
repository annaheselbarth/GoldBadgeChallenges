using ChallengeOneCafeConsole;
using ChallengeOneCafeLibrary;
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

            CafeMenuItem cafeMenu = new CafeMenuItem();

            //Act


           var itemAdded = _cafeMenuRepo.CreateNewItem(cafeMenu);

            //Assert


            Assert.IsTrue(itemAdded);

        }

        [TestMethod]
        public void MyTestMethod()
        {

        }
    }
}
