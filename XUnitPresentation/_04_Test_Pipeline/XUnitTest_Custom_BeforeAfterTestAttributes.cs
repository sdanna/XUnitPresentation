using System.Threading;
using XUnitPresentation._04_Test_Pipeline.Attributes;
using Xunit;

namespace XUnitPresentation._04_Test_Pipeline
{
    public class XUnitTest_Custom_BeforeAfterTestAttributes
    {
        [Fact]
        [RunAsMelissaEnsign]
        public void I_Am_Running_As_Melissa_Ensign()
        {
            var principal = Thread.CurrentPrincipal;
            Assert.True(principal.Identity.Name == "Melissa Ensign");
            Assert.True(principal.IsInRole("Data Admin"));
        }
    }
}