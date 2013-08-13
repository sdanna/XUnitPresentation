using System.Linq;
using System.Threading;
using Xunit;
using Xunit.Extensions;
//using XUnitPresentation._04_Test_Pipeline.Context;
using __NAME__.Models;

namespace XUnitPresentation._04_Test_Pipeline
{
    public class XUnitTest_Extensions
    {
        [Fact]
        [AutoRollback]
        public void Method_Under_Test_With_AutoRollback()
        {
            using (var context = new XUnitPresentationContext())
            {
                var user = new User
                    {
                        Email = "steven.danna@praeses.com",
                        FirstName = "Steven",
                        LastName = "D'Anna"
                    };
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        [Fact, AssumeIdentity("Inspector")]
        public void Method_Under_Test_AutoRollback()
        {
            bool isInspector = Thread.CurrentPrincipal.IsInRole("Inspector");
            Assert.True(isInspector);
        }
    }
}
