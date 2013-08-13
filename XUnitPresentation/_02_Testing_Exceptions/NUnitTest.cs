using System;
using NUnit.Framework;

namespace XUnitPresentation._02_Testing_Exceptions
{
    [TestFixture]
    public class NUnitTest
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Method_Under_Test()
        {
            throw new ArgumentException();
        }
    }
}