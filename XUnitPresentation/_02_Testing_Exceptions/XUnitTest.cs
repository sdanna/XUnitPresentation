using System;
using Xunit;

namespace XUnitPresentation._02_Testing_Exceptions
{
    public class XUnitTest
    {
        [Fact]
        public void Method_Under_Test()
        {
            //Arrange

            //Act
            //Assert
            Assert.Throws<ArgumentException>(() =>
                {
                    throw new ArgumentException();
                });
        }
    }
}
