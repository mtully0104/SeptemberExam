using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeptemberExam;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Bike_AddVat()
        {
            //arrange
            Bike b1 = new Bike() {ID = 2, price =10m };
            decimal expectedPrice = 12.3m;
            //act
            b1.AddVat(1.23m);
            //assert
            Assert.AreEqual(expectedPrice, b1.price);
        }
    }
}
