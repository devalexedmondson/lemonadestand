using System;
using lemonadestand;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LemonadeStandUnitTesting
{
    [TestClass]
    public class LemonadeTestClass
    {
        [TestMethod]
        public void Multiply_PositiveNumbers_ReturnPositiveSum()
        {
            //Arrange
            Store multiply = new Store();
            Lemon lemon = new Lemon();
            int value1 = 3;
            double result;
            //Act
            result = multiply.GetLemonExpense(value1);
            //Assert
            Assert.AreEqual(value1 * lemon.price, result);
        }
        [TestMethod]
        public void DecreasePlayerMoney()
        {
            // Arrange
            Store store = new Store();
            Player player = new Player();
            double expense = 5;
            double result = player.inventory.money - expense;
            //Act
            store.WithdrawLemonMoney(player, expense);
            //Assert
            Assert.AreEqual(player.inventory.money, result);
        }
        [TestMethod]
        public void AddOneLemonToList()
        {
            //Arrange
            Inventory inventory = new Inventory();
            Lemon lemon = new Lemon();
            int lemonCount = 1;
            //Act
            inventory.AddLemon(lemon);
            //Assert
            Assert.AreEqual(lemonCount, inventory.supplies[0].Count);
        }
        [TestMethod]
        public void AddOneSugarToList()
        {
            //Arrange
            Inventory add = new Inventory();
            Sugar sugar = new Sugar();
            int sugarCount = 1;
            //Act
            add.AddSugar(sugar);
            //Assert
            Assert.AreEqual(sugarCount, add.supplies[1].Count);
        }
        [TestMethod]
        public void RemoveLemonFromList()
        {
            //Arrange
            Recipe remove = new Recipe();
            Player player = new Player();
            int suppliesList = player.inventory.supplies[0].Count;
            int lemon = 5;
            lemon = suppliesList;
            //Act
            remove.RemoveLemons(player, lemon);
            //Assert
            Assert.AreEqual(0, player.inventory.supplies[0].Count);
        }
        [TestMethod]
        public void RemoveSugarFromList()
        {
            //Arrange
            Recipe remove = new Recipe();
            Player player = new Player();
            int suppliesList = player.inventory.supplies[1].Count;
            int sugar = 5;
            sugar = suppliesList;
            //Act
            remove.RemoveSugar(player, sugar);
            //Assert
            Assert.AreEqual(0, player.inventory.supplies[1].Count);
        }
        [TestMethod]
        public void CheckLemonInventory()
        {
            //Arrange
            Recipe check = new Recipe();
            Player player = new Player();
            int lemon = 5;
            //Act
            bool result = check.CheckLemonInventory(player, lemon);
            //Assert
            Assert.IsFalse(result);
        }
       



    }
}
