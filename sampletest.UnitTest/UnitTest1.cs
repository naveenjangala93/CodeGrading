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
<<<<<<< HEAD

    
            Assert.Equal("naveen123", result);
=======
            Assert.Equal("naveen", result);
>>>>>>> 3ee7f2c11a9df26c5b1bf5168e53287d36117054
        }
    }
}
