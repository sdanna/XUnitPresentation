using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit.Extensions;

namespace XUnitPresentation._05_Data_Tests.Attributes
{
    public class ExcelDataCustomAttribute : OleDbDataAttribute
    {
        protected const string connectionTemplateOldExcel =
            "Provider=Microsoft.Jet.OleDb.4.0; Data Source={0}; Extended Properties=Excel 8.0";
        protected const string connectionTemplateNewExcel =
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 12.0";

        /// <summary>
        /// Creates a new instance of <see cref="Xunit.Extensions2.ExcelDataAttribute"/>.
        /// </summary>
        /// <param name="fileName">The filename of the XLS spreadsheet file; if the filename provided
        /// is relative, then it is relative to the location of xunit.extensions.dll.</param>
        /// <param name="selectStatement">The SELECT statement that returns the data for the theory</param>
        public ExcelDataCustomAttribute(string fileName, string selectStatement)
            : base(String.Format(CultureInfo.InvariantCulture, fileName.EndsWith(".xlsx") ? connectionTemplateNewExcel : connectionTemplateOldExcel, GetFullFilename(fileName)), selectStatement) { }

        static string GetFullFilename(string filename)
        {
            string executable = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            return Path.GetFullPath(Path.Combine(Path.GetDirectoryName(executable), filename));
        }

        /// <inheritdoc/>
        protected override object ConvertParameter(object parameter, Type parameterType)
        {
            if ((parameter is double || parameter is float) &&
                (parameterType == typeof(int) || parameterType == typeof(int?)))
            {
                int intValue;
                string floatValueAsString = parameter.ToString();

                if (Int32.TryParse(floatValueAsString, out intValue))
                    return intValue;
            }

            return base.ConvertParameter(parameter, parameterType);
        }
    }
}
