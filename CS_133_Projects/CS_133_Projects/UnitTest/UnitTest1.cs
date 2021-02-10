using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddDishesInTheDirtyStack_IfItsADirtyDish_ReturnsString()
        {
            //Arrange
            Restaurant restaurant = new Restaurant();
            string sendVariable = "Dish 1";


            //Act

            string result = restaurant.AddDishesInTheDirtyStack(sendVariable);

            //Assert
            Assert.IsTrue(sendVariable == result);
        }

        [TestMethod]
        public void AddDishesInTheCleanStack_IfItsACleanDish_ReturnsString()
        {

            Restaurant restaurant = new Restaurant();
            string sendVariable = "Dish 1";

            restaurant.AddPeopleIntoTheQueue("Diner 1");
            string result = restaurant.AddDishesInTheCleanStack(sendVariable);


            Assert.IsTrue(sendVariable == result);
        }

        [TestMethod]
        public void DinerHasBeenSeated_IfDinerHasBeenSeated_ReturnsString()
        {

            Restaurant restaurant = new Restaurant();
            string sendVariable = "Diner 1";

            restaurant.AddPeopleIntoTheQueue("Diner 1");
            string result = restaurant.DinerHasBeenSeated(sendVariable);


            Assert.IsTrue(sendVariable == result);
        }

        [TestMethod]
        public void DinerHasEatenPaidAndLeft_IfDinerHasEatenPaidAndLeft_ReturnsString()
        {

            Restaurant restaurant = new Restaurant();
            string sendVariable = "Diner 1";

            restaurant.AddPeopleIntoTheQueue("Diner 1");
            string result = restaurant.DinerHasEatenPaidAndLeft(sendVariable);


            Assert.IsTrue(sendVariable == result);
        }

        [TestMethod]
        public void WaiterHasCleanedTheTable_IfTableIsCleaned_ReturnsString()
        {

            Restaurant restaurant = new Restaurant();
            string sendVariable = "Table 1";

            restaurant.AddPeopleIntoTheQueue("Table 1");
            string result = restaurant.WaiterHasCleanedTheTable(sendVariable);


            Assert.IsTrue(sendVariable == result);
        }
    }
}
