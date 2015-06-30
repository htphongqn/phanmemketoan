using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace ketoansoft.app.Class.Global
{
    public class ExcelUtlity
    {
        public bool WriteDataTableToExcel(System.Data.DataTable dataTable)
        {
            string saveAsLocation = "";
            string worksheetName ="";
            string path = Application.StartupPath + @"\ExcelTemplate\SOCTCN11.xls";
            string cell1 = "";
            string cell2 = "";
            Microsoft.Office.Interop.Excel.Application excelApplication = null;
            Microsoft.Office.Interop.Excel.Workbook workbook = null;
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;

            excelApplication = new Microsoft.Office.Interop.Excel.Application();
            excelApplication.Visible = false;
            excelApplication.DisplayAlerts = false;
            try
            {
                workbook = excelApplication.Workbooks.Open(path, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];

                string cellValue = "";
                object cellObject = null;
                Microsoft.Office.Interop.Excel.Range range = null;
                range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[22, 1];
                cellObject = range.get_Value(null);
                cellValue = (cellObject == null ? "" : cellObject.ToString().Trim());
                cell1 = cellValue;

                cellValue = "";
                cellObject = null;
                range = null;
                range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[22, 2];
                cellObject = range.get_Value(null);
                cellValue = (cellObject == null ? "" : cellObject.ToString().Trim());
                cell2 = cellValue;


                excelApplication.Quit();
                excelApplication = null;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook excelworkBook;
            Microsoft.Office.Interop.Excel.Worksheet excelSheet;
            Microsoft.Office.Interop.Excel.Range excelCellrange;

            try
            {
                // Start Excel and get Application object.
                excel = new Microsoft.Office.Interop.Excel.Application();

                // for making Excel visible
                excel.Visible = false;
                excel.DisplayAlerts = false;

                // Creation a new Workbook
                excelworkBook = excel.Workbooks.Add(Type.Missing);

                // Workk sheet
                excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;
                excelSheet.Name = worksheetName;

                //gắn header
                excelSheet.Cells[1, 1] = cell1;
                excelSheet.Cells[1, 2] = cell2;

                // loop through each row and add values to our sheet
                int rowcount = 2;

                foreach (DataRow datarow in dataTable.Rows)
                {
                    rowcount += 1;
                    for (int i = 1; i <= dataTable.Columns.Count; i++)
                    {
                        // on the first iteration we add the column headers
                        if (rowcount == 3)
                        {
                            excelSheet.Cells[2, i] = dataTable.Columns[i - 1].ColumnName;
                            excelSheet.Cells.Font.Color = System.Drawing.Color.Black;

                        }

                        excelSheet.Cells[rowcount, i] = datarow[i - 1].ToString();

                        //for alternate rows
                        if (rowcount > 3)
                        {
                            if (i == dataTable.Columns.Count)
                            {
                                if (rowcount % 2 == 0)
                                {
                                    excelCellrange = excelSheet.Range[excelSheet.Cells[rowcount, 1], excelSheet.Cells[rowcount, dataTable.Columns.Count]];
                                    FormattingExcelCells(excelCellrange, "#CCCCFF", System.Drawing.Color.Black, false);
                                }

                            }
                        }

                    }

                }
                //gắn footer
                excelSheet.Cells[rowcount + 1, 1] = cell1;
                excelSheet.Cells[rowcount + 1, 2] = cell2;

                // now we resize the columns
                excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[rowcount, dataTable.Columns.Count]];
                excelCellrange.EntireColumn.AutoFit();
                Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;


                excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[2, dataTable.Columns.Count]];
                FormattingExcelCells(excelCellrange, "#000099", System.Drawing.Color.White, true);


                //now save the workbook and exit Excel


                excelworkBook.SaveAs(saveAsLocation); ;
                excelworkBook.Close();
                excel.Quit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                excelSheet = null;
                excelCellrange = null;
                excelworkBook = null;
            }

        }
        public void FormattingExcelCells(Microsoft.Office.Interop.Excel.Range range, string HTMLcolorCode, System.Drawing.Color fontColor, bool IsFontbool)
        {
            range.Interior.Color = System.Drawing.ColorTranslator.FromHtml(HTMLcolorCode);
            range.Font.Color = System.Drawing.ColorTranslator.ToOle(fontColor);
            if (IsFontbool == true)
            {
                range.Font.Bold = IsFontbool;
            }
        }
        public bool WriteDataTableToExcel_SOCTCN11_Mauchuan(System.Data.DataTable dataTable)
        {
            string saveAsLocation = Application.StartupPath + @"\Excel\SOCTCN11.xls";  
            string worksheetName = "SHVND";

            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook excelworkBook;
            Microsoft.Office.Interop.Excel.Worksheet excelSheet;
            Microsoft.Office.Interop.Excel.Range excelCellrange;

            try
            {
                // Start Excel and get Application object.
                excel = new Microsoft.Office.Interop.Excel.Application();

                // for making Excel visible
                excel.Visible = false;
                excel.DisplayAlerts = false;

                // Creation a new Workbook
                excelworkBook = excel.Workbooks.Add(Type.Missing);

                // Workk sheet
                excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;
                excelSheet.Name = worksheetName;

                //gắn header
                excelSheet.Cells[1, 1] = "CÔNG TY ABCDab";
                excelSheet.Cells[2, 1] = "M17 LÊ HOÀNG PHÁI,GÒ VẤP,TP.HCM";
                excelSheet.Cells[3, 1] = "Mã số thuế : 0300688235";
                excelSheet.Cells[4, 1] = "SỔ CHI TIẾT TÀI KHOẢN THEO ĐỐI TƯỢNG";
                excelSheet.Cells[5, 1] = "Tài khoản :  - Tiền mặt";
                excelSheet.Cells[6, 1] = "Mã ĐTPN :  - ";
                excelSheet.Cells[7, 1] = "Từ ngày 01/01/08 đến ngày 31/01/08";
                excelSheet.Cells[9, 1] = "Chứng từ";
                excelSheet.Cells[9, 3] = "Diễn giải";
                excelSheet.Cells[9, 4] = "TK";
                excelSheet.Cells[9, 5] = "VND";
                excelSheet.Cells[10, 1] = "Loại";
                excelSheet.Cells[10, 2] = "Số";
                excelSheet.Cells[10, 3] = "Ngày";
                excelSheet.Cells[10, 5] = "DU";
                excelSheet.Cells[10, 6] = "Nợ";
                excelSheet.Cells[10, 7] = "Có";
                excelSheet.Cells[11, 4] = "SỐ DƯ ĐẦU KỲ";
                // loop through each row and add values to our sheet
                int rowcount = 11;

                foreach (DataRow datarow in dataTable.Rows)
                {
                    rowcount += 1;
                    excelSheet.Cells[rowcount, 1] = datarow["LOAI"].ToString();
                    excelSheet.Cells[rowcount, 2] = datarow["SO"].ToString();
                    excelSheet.Cells[rowcount, 3] = datarow["NGAY"].ToString();
                    excelSheet.Cells[rowcount, 4] = datarow["DIENGIAI"].ToString();
                    excelSheet.Cells[rowcount, 5] = datarow["TKDU"].ToString();
                    excelSheet.Cells[rowcount, 6] = datarow["NO"].ToString();
                    excelSheet.Cells[rowcount, 7] = datarow["CO"].ToString();
                }
                //gắn footer
                //excelSheet.Cells[rowcount + 1, 1] = cell1;
                //excelSheet.Cells[rowcount + 1, 2] = cell2;

                //now save the workbook and exit Excel
                excelworkBook.SaveAs(saveAsLocation);
                excelworkBook.Close();
                excel.Quit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                excelSheet = null;
                excelCellrange = null;
                excelworkBook = null;
            }
        }
    }
}
