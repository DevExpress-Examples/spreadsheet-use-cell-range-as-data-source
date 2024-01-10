using DevExpress.Spreadsheet;
using System;
using System.Linq;

namespace RangeDataSource
{
    #region #MyColumnDetector
    class MyColumnDetector : IDataSourceColumnTypeDetector
    {
        public string GetColumnName(int index, int offset, CellRange range)
        {
            if (offset > 3) return String.Format("Column{0}", index);
            string[] names = { "City", "Year", "Month", "Temperature" };
            return names[index];
        }

        public Type GetColumnType(int index, int offset, CellRange range)
        {
            Type defaultType = typeof(string);
            CellValue value = range[0, offset].Value;
            if (value.IsText) return typeof(string);
            if (value.IsBoolean) return typeof(bool);
            if (value.IsDateTime) return typeof(DateTime);
            if (value.IsNumeric) return typeof(double);
            return defaultType;
        }
    }
    #endregion #MyColumnDetector
}
