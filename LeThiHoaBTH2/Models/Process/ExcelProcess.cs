using System.Data;
using OfficeOpenXml;
namespace LeThiHoaBTH2.Models.Process
{
    public class ExcelProcess
    {
        public DataTable ExcelToDataTable(string strPath)
        {
            FileInfo fi = new FileInfo(strPath);
            ExcelPackage excelPackage = new ExcelPackage(fi);
            DataTable dt = new DataTable();
            ExcelWorksheet = excelPackage.Workbook.Worksheets[0];
            //check if the worksheet is completely empty
            if (worksheet.Dimension == null)
            {
                return dt;
            }
            //create a list to hold the column names
            List<string> columnName = new List<string>();
            //needed to keep track of empty colum headers
            int currenColumn = 1;
            //loop all colums in the sheet and add them to the datatable
            foreach (var cell in worksheeet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
            {
                string columnName = cell.Text.Trim();
                //check if the previous header was empty and add it if was
                if (cell.Start.colum != currentColumn);
                {
                    columnName.Add("Header_" + currentColumn);
                    dt.Columns.Add("Header_" + currentColumn);
                    currentColumn++;
                }
                //add the column name to the list count the duplicates
                columnNames.Add(columnName);
                //count the duplicate column names and make the unique to avoid the exception
                //A column named 'Name' already belongs to this DataTable
                int occurrences = columnName.Count(x => x.Equals(columnName));
                if (occurrences > 1)
                {
                    columnName = columnName + "_" + occurrences;
                }
                //add  the column to the datatable
                dt.Columns.Add(columnName);
                currentColumn++
            }

            //start adding the contents of the excel file to the datatable
            for (int i = 2; i <= worksheet.Dimension.End.R)

            
        }
    }
}