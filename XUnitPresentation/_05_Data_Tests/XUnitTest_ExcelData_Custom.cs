using XUnitPresentation._05_Data_Tests.Attributes;
using Xunit;
using Xunit.Extensions;

namespace XUnitPresentation._05_Data_Tests
{
    public class XUnitTest_ExcelData_Custom
    {
        [Theory]
        [ExcelDataCustom(@"_05_Data_Tests\ExcelSheets\old_excel_format.xls", "SELECT * FROM [Sheet1$]")]
        public void ExcelDataCustom_Test_Old_Excel_Format(bool expectedValue, bool actualValue)
        {
            Assert.True(expectedValue == actualValue);
        }

        [Theory]
        [ExcelDataCustom(@"_05_Data_Tests\ExcelSheets\new_excel_format.xlsx", "SELECT * FROM [Sheet1$]")]
        public void ExcelData_Test_New_Excel_Format(bool expectedValue, bool actualValue)
        {
            Assert.True(expectedValue == actualValue);
        }
    }
}