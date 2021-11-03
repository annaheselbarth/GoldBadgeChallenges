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
        private CafeMenuItem _menuItem;

        [TestInitialize]

        public void Arrange()
        {
            _cafeMenuRepo = new CafeMenuRepo();
            _menuItem = new CafeMenuItem(1, "Fries", "Hot fries with sea salt", 3.99m, "potatoes, olive oil, sea salt");
            _cafeMenuRepo.AddItem(_menuItem);
        }

        [TestMethod]
        public void Test_AddItem()
        {
            //Arrange

            //CafeMenuItem cafeMenu = new CafeMenuItem();

            //Act

            
           bool itemAdded = _cafeMenuRepo.AddItem(_menuItem);

            //Assert


            Assert.IsFalse(itemAdded);

        }

        [TestMethod]
        public void Test_GetItemByNumber()
        {
            /*List<string> item = new List<string>();
            item.Add("fries");

            CafeMenuItem fries = new CafeMenuItem();
            CafeMenuRepo _cafeMenuItem = new CafeMenuRepo*/


        }

        [TestMethod]
        public void Test_RemoveItem()
        {
            bool itemRemoved = _cafeMenuRepo.RemoveItem(_menuItem);

            Assert.IsTrue(itemRemoved);
        }
    }
}
