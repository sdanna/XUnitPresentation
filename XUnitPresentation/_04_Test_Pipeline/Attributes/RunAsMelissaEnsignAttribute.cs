using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace XUnitPresentation._04_Test_Pipeline.Attributes
{
    public class RunAsMelissaEnsignAttribute : BeforeAfterTestAttribute
    {
        private IPrincipal _originalPrincipal;

        public override void Before(MethodInfo methodUnderTest)
        {
            _originalPrincipal = Thread.CurrentPrincipal;
            var identity = new GenericIdentity("Melissa Ensign");
            var principal = new GenericPrincipal(identity, new string[] {"Inspector", "Data Admin"});

            Thread.CurrentPrincipal = principal;
        }

        public override void After(MethodInfo methodUnderTest)
        {
            Thread.CurrentPrincipal = _originalPrincipal;
        }
    }
}
