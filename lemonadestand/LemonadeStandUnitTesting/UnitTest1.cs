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
            Store multiply = new Store();
            Lemon lemon = new Lemon();
            //Arrange
            int value1 = 1;
            double result;
            //Act
            result = multiply.GetLemonExpense(value1);
            //Assert
            Assert.AreEqual(value1 * lemon.price, result);
        }
    }
}
