using System;

namespace XUnitPresentation._01_Test_Fixtures
{
    public class XUnitTestDatabaseFixture : IDisposable
    {
        public XUnitTestDatabaseFixture()
        {
            // This will only happen once per "test" class
            Build_Fixture_Database();
        }

        public void Build_Fixture_Database()
        {
            
        }

        public void Destroy_Fixture_Database()
        {
            
        }

        public void Dispose()
        {
            Destroy_Fixture_Database();
        }
    }
}