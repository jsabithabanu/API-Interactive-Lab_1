using API_Interactive_Lab_1.Controllers;
using API_Interactive_Lab_1.Models;
using NUnit.Framework;

namespace API_Interactive_Lab_1.Tests.Controllers
{
    public class CoffeeControllerTests
    {
        // this attribute tells NUnit to run this method as a test
        [Test]
        public void Test_Get_Coffee_Lover()
        {
            // ARRANGE - we set up everything needed for our test
            string expectedContent = "I like coffee!";
            var controller = new CoffeeController();

            // ACT - we perform the test
            var result = controller.GetCoffeeLover();

            // ASSERT - we compare the result to the expected result
            Assert.AreEqual(expectedContent, result);
        }

        [Test]
        public void Test_Get_Coffee_No_Parameters()
        {
            // ARRANGE - we set up everything needed for our test
            Coffee expected = new Coffee
            {
                Name = "latte",
                Id = -1
            };
            var controller = new CoffeeController();

            // ACT - we perform the test
            var result = controller.Get(null);

            // ASSERT - we compare the result to the expected result
            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }

        [Test]
        public void Test_Get_Coffee_By_Name()
        {
            // ARRANGE - we set up everything needed for our test
            string name = "cappuccino";
            Coffee expected = new Coffee
            {
                Name = name,
                Id = 1
            };
            var controller = new CoffeeController();

            // ACT - we perform the test
            var result = controller.Get(name);

            // ASSERT - we compare the result to the expected result
            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }
    }
}
