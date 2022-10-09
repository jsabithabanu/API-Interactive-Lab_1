using API_Interactive_Lab_1.Controllers;
using NUnit.Framework;
namespace API_Interactive_Lab_1.Tests
{
    public class HomeControllerTests
    {
        // this attribute tells NUnit to run this method as a test
        [Test]
        public void TestGetHome()
        {
            // ARRANGE - we set up everything needed for our test
            string expectedContent = "Welcome to the Drinks API!";
            var controller = new HomeController();

            // ACT - we perform the test
            var result = controller.Get();

            // ASSERT - we compare the result to the expected result
            Assert.AreEqual(expectedContent, result);
        }
    }
}
