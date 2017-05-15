using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTestAutomationFramework.Helpers
{
    public class ExcelHelpers
    {
        private static IList<Datacollection> _dataCol = new List<Datacollection>();

        public static void PopulateInCollection(string fileName)
        {
            DataTable table = ExcelToDataTable(fileName);

            // Loop throuh the rows and columns of the table
            for(int row = 1; row <= table.Rows.Count; row++)
            {
                for(int col = 0; col < table.Columns.Count; col++)
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };
                // All all the details for each row
                _dataCol.Add(dtTable);
                }
            }
        }

        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                // Retrieving Data using LINQ to reduce iterations
                string data = (from colData in _dataCol
                               where colData.colName == columnName && colData.rowNumber == rowNumber
                               select colData.colValue).SingleOrDefault();

                return data.ToString();
            }catch (Exception e)
            {
                return null;
            }
        }
        private static DataTable ExcelToDataTable(string fileName)
        {
            // Open file and returns it as Stream
            System.IO.FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            // Createopenxmlreader via ExcelReaderfactory
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            // Set the first row as column name
            excelReader.IsFirstRowAsColumnNames = true;
            // Return as DataSet
            DataSet result = excelReader.AsDataSet();
            // Get all the tables
            DataTableCollection table = result.Tables;
            // Store it in Datatable
            DataTable resultTable = table["Sheet1"];

            return resultTable;
        }

        public class Datacollection
        {
            public int rowNumber { get; set; }
            public string colName { get; set; }
            public string colValue { get; set; }
        }
    }
}
