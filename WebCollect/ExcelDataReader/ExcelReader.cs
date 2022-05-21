using System;
using System.IO;
using System.Data;
using ExcelDataReader;
using System.Collections.Generic;

namespace WebCollect.ExcelDataReader
{
    public class ExcelReader
    {
        private static IDictionary<string, IExcelDataReader> _cache;
        private static FileStream stream;
        private static IExcelDataReader reader;

        static ExcelReader()
        {
            _cache = new Dictionary<string, IExcelDataReader>();
        }

        private static IExcelDataReader GetExcelReader(string xlPath, string sheetName)
        {
            if (_cache.ContainsKey(sheetName))
            {
                reader = _cache[sheetName];
            }
            else
            {
                stream = new FileStream(xlPath, FileMode.Open, FileAccess.Read);
                reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                _cache.Add(sheetName, reader);
            }
            return reader;
        }

        public static int GetTotalRows(string xlPath, string sheetName)
        {
            IExcelDataReader _readRows = GetExcelReader(xlPath, sheetName);
            return _readRows.AsDataSet().Tables[sheetName].Rows.Count;
        }
        public static int GetTotalColumns(string xlPath, string sheetName)
        {
            IExcelDataReader _readColumns = GetExcelReader(xlPath, sheetName);
            return _readColumns.AsDataSet().Tables[sheetName].Columns.Count;
        }

        public static object GetCellData(string xlPath, string sheetName, int row, int column)
        {
            IExcelDataReader _readCellData = GetExcelReader(xlPath, sheetName);
            DataTable table = _readCellData.AsDataSet().Tables[sheetName];
            return GetDataType(table.Rows[row][column].GetType(), table.Rows[row][column]);
        }

        #region Helper Method
        private static object GetDataType(Type type, Object data)
        {
            switch (type.Name)
            {
                case "string":
                    return data.ToString();
                case "boolean":
                    return Convert.ToBoolean(data);
                case "integer":
                    return Convert.ToInt32(data);
                case "DateTime":
                    return Convert.ToDateTime(data);
                default:
                    return data.ToString();
            }
        }

        #endregion

    }
}
