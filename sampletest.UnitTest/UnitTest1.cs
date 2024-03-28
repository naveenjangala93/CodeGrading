using Xunit;
using WebApplication1.Controllers;

namespace StudentManagement.UnitTests
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
            Assert.Equal("naveen", result); 
        }
    }
}