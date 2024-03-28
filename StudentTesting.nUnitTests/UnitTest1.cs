using NUnit.Framework;
using WebApplication1.Controllers;
namespace StudentTesting.nUnitTests

{
    /* public class Tests
     {
         [SetUp]
         public void Setup()
         {
         }

         [Test]
         public void Test1()
         {
             Assert.Pass();
         }
     }*/
    public class ControllerTests
    {
        [Test]
        public void TestGetStringMethodExists()
        {
            // Arrange
            var mockService = new Mock<Iservice()>

            var controller = new StudentController();
            // Replace YourController with your actual controller name
            var methodInfo = controller.GetType().GetMethod("getstring");

            // Assert
            Assert.NotNull(methodInfo, "getstring method should be present in the controller");
        }
    }
}