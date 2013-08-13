using XUnitPresentation._03_Test_Categories.Attributes;
using Xunit;

namespace XUnitPresentation._03_Test_Categories
{
    public class XUnitTest_Using_Trait_Advanced
    {
        [Fact]
        [Bug("1043")]
        public void Method_Under_Test_1()
        {
            Assert.True(true);
        }

        [Fact, FastTest]
        public void Method_Under_Test_2()
        {
            Assert.False(false);
        }
    }
}