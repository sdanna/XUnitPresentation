using Xunit;
using Xunit.Extensions;

namespace XUnitPresentation._05_Data_Tests
{
    public class XUnitTest_ExcelData
    {
        // MUST COMPILE IN 32 bit mode!!!!
        [Theory]
        [ExcelData(@"_05_Data_Tests\ExcelSheets\old_excel_format.xls", "SELECT * FROM [Sheet1$]")]
        public void ExcelData_Test(bool expectedValue, bool actualValue)
        {
            Assert.True(expectedValue == actualValue);    
        }
    }
}