using ChallengeOneCafeConsole;
using ChallengeOneCafeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChallengeOneCafeTests
{
    [TestClass]
    public class CafeMenuMethodsTest
    {
        CafeMenuRepo _cafeMenuRepo = new CafeMenuRepo();
        CafeMenuItem _menuItem = new CafeMenuItem();

        [TestInitialize]

        public void Arrange()
        {
            
        }

        [TestMethod]
        public void Test_AddItem()
        {
            bool success = _cafeMenuRepo.AddItem(_menuItem); 

            Assert.IsNotNull(success);
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void Test_GetItemByNumber()
        {
            CafeMenuRepo _cafeMenuItem = new CafeMenuRepo();


            CafeMenuItem meal = new CafeMenuItem(1, "Fries", "Hot fries with sea salt", 3.99m, "potatoes, olive oil, sea salt");

            _cafeMenuRepo.AddItem(meal);
            
            CafeMenuItem returnedMeal = _cafeMenuRepo.GetItemByNumber(1);

            Assert.IsNotNull(returnedMeal);
            Assert.AreEqual(meal, returnedMeal);

        }

        [TestMethod]
        public void Test_GetCafeMenu()
        {
            CafeMenuRepo _cafeMenuItem = new CafeMenuRepo();
            CafeMenuItem getMeal = new CafeMenuItem(1, "Fries", "Hot fries with sea salt", 3.99m, "potatoes, olive oil, sea salt");
            _cafeMenuRepo.AddItem(getMeal);
            int intialCount = _cafeMenuRepo.GetCafeMenu().Count;
            Assert.AreEqual(intialCount, 1);
            Assert.AreNotEqual(intialCount, 2);
        }

        [TestMethod]
        public void Test_RemoveItem()
        {
            CafeMenuRepo _cafeMenuItem = new CafeMenuRepo();
            CafeMenuItem removeMeal = new CafeMenuItem(1, "Fries", "Hot fries with sea salt", 3.99m, "potatoes, olive oil, sea salt");
            _cafeMenuRepo.AddItem(removeMeal);
            bool itemRemoved = _cafeMenuRepo.RemoveItem(removeMeal);

            Assert.IsTrue(itemRemoved);
        }
    }
}
