using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Data;

namespace Pro03_20CT111_QuaySo.Commons
{
    public class ExportExcel
    {
        public static string MyExportExcel(DataGridView dgv,string header,string footer)
        {
            string result = string.Format("{0}\n\r", header);
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                if (dgv.Columns[i].Visible == true)
                {
                    result += string.Format("{0}\t", dgv.Columns[i].HeaderText);
                }
            }
            result += "\n";
            for (int row = 0; row < dgv.RowCount; row++)
            {
                for (int column = 0; column < dgv.ColumnCount; column++)
                {
                    if (dgv.Columns[column].Visible == true)
                    {
                        result += string.Format("{0}\t",dgv.Rows[row].Cells[column].Value.ToString());
                    }
                }
                result += "\n";
            }
            result += "\n" + footer;

            return result;
        }

        public static void ExportExcelByInterop(string filePath, DataGridView dgv, int rowBegin = 1,
            string fontName = "Arial", int fontsizeTieude = 14, int fonsizeNoiDung = 12)
        {
            Excel.Application xlApp = new Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("khong tao file Application Excel");
                return;
            }

            xlApp.Visible = false;
            object misValue = System.Reflection.Missing.Value;
            Workbook wb = xlApp.Workbooks.Add(misValue);
            Worksheet ws = (Worksheet)wb.Worksheets[1];

            if (ws == null)
            {
                MessageBox.Show("khong tao worksheet");
                return;
            }

            //khoi bao mot so thuoc tinhs
            int row = rowBegin;
            //Them Tieu de
            Range row1_TieuDe = ws.get_Range("A" + rowBegin.ToString(), "J" + rowBegin.ToString());
            row1_TieuDe.Merge();
            row1_TieuDe.Font.Bold = true;
            row1_TieuDe.Font.Name = fontName;
            row1_TieuDe.Font.Size = fontsizeTieude;
            row1_TieuDe.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            row1_TieuDe.Value2 = "Danh Sach ...";

            //Phan tieu de cua noi dung
            Range row3;
            row = 3;
            string[] tencot = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int col = 0;
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                if (dgv.Columns[i].Visible == true)
                {
                    row3 = ws.get_Range(tencot[col] + row.ToString(), tencot[col] + row.ToString());
                    row3.Font.Bold = true;
                    row3.Font.Name = fontName;
                    row3.Font.Size = fontsizeTieude;
                    row3.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    row3.Value2 = dgv.Columns[i].HeaderText;
                    col++;
                }
            }
            row = 4;
            //noi dung
            for (int i = 0; i < dgv.RowCount; i++)
            {
                DataGridViewRow dr = dgv.Rows[i];
                dynamic[] arr = new dynamic[100];
                int colvalue = 0;
                for (int column = 0; column < dgv.Columns.Count; column++)
                {
                    if (dgv.Columns[column].Visible == true)
                    {
                        arr[colvalue++] = dr.Cells[dgv.Columns[column].Name].Value.ToString();
                    }
                }
                Range rowData = ws.get_Range("A" + row.ToString(), "J" + row.ToString());
                rowData.Font.Size = fonsizeNoiDung;
                rowData.Font.Name = fontName;
                rowData.Value2 = arr;
                row++;
            }

            //Dong khung table
            BorderAround(ws.get_Range("A3", "J" + (row - 1).ToString()));
            //Save
            wb.SaveAs(filePath);
            wb.Close();
            xlApp.Quit();
            releaseObject(ws);
            releaseObject(wb);
            releaseObject(xlApp);
        }
        private static void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = ConsoleColor.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
        //Hàm thu hồi bộ nhớ cho COM Excel
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = null;
            }
            finally
            { GC.Collect(); }
        }

    }
}
