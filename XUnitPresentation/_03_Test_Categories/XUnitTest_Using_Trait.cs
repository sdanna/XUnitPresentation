using Xunit;

namespace XUnitPresentation._03_Test_Categories
{
    public class XUnitTest_Using_Trait
    {
        [Fact]
        [Trait("Bug", "1043")]
        public void Method_Under_Test()
        {
            Assert.True(true);
        }
    }
}
