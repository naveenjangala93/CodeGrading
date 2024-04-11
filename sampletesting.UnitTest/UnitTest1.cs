using Xunit;
using WebApplication1.Controllers;

namespace WebApplication1.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void GiveStudent_ReturnsExpectedString()
        {
            // Arrange
            var controller = new StudentController();

            // Act
            var result = controller.getstring();

            // Assert
            Assert.Equal("naveen123", result);
        }
        [Fact]
        public void givemeresult()
        {
            // Arrange
            var controller = new StudentController();

            // Act
            var result = controller.getnumber();

            // Assert
            Assert.Equal(5, result);
        }


    }
}
