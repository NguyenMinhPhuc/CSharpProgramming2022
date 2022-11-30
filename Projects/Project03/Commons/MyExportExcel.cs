using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Data;

using System.Windows.Forms;
using System.Drawing;

namespace Commons
{
    public class MyExportExcel
    {
        public static void ExportExcel(string path,DataGridView dgv,string title,int rowBegin=1,string fontName="Arial",int titleSize=14,int contentSize = 11)
        {
            //Khởi tạo ứng dụng Excel 
            Excel.Application xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Not Init Application", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Khởi tạo Workbooks
            xlApp.Visible = false;
            object misValue = System.Reflection.Missing.Value;

            Workbook wb = xlApp.Workbooks.Add(misValue);
            //Khởi tạo Woksheet 
            Worksheet ws =(Worksheet) wb.Worksheets[1];
            if (ws == null)
            {
                MessageBox.Show("Not Init worksheet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //xac dinh vung de ghi
            int row = rowBegin;
            string[] columName = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA" };

            int colBegin = 0;
            int colEnd = SoCotTrenLuoi(dgv);
            //Vung Caption
            Range row1_title = ws.get_Range(string.Format("{0}{1}:{2}{3}",columName[colBegin],row,columName[colEnd],row));
            row1_title.Merge();
            row1_title.Font.Bold = true;
            row1_title.Font.Name = fontName;
            row1_title.Font.Size = titleSize;
            row1_title.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
           // row1_title.Font.Background= Color.LightBlue;
            row1_title.Value2 = title;

            //Vung title cua du lieu
            row = rowBegin + 3;
            Range row3_Header = ws.get_Range(string.Format("{0}{1}:{2}{3}", columName[colBegin], row, columName[colEnd], row));

            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (dgv.Columns[i].Visible == true)
                {
                    Range header = ws.get_Range(string.Format("{0}{1}:{2}{3}", columName[i], row, columName[i], row));
                    header.Value2 = dgv.Columns[i].HeaderText;
                }
            }
            row3_Header.Font.Bold = true;
            row3_Header.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            row3_Header.Font.Size = 13;
            //row3_Header.Font.Background = Color.DarkBlue;
            row3_Header.Font.Color = Color.White;
            //Vung du lieu
            row = rowBegin+ 4;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                DataGridViewRow dr = dgv.Rows[i];
                dynamic[] arr = new dynamic[100];
                int colvalue = 0;
                for (int column = 0; column < dgv.ColumnCount; column++)
                {
                    if (dgv.Columns[column].Visible == true)
                    {
                        arr[colvalue++] = dr.Cells[dgv.Columns[column].Name].Value.ToString();
                    }
                }
                Range rowData= ws.get_Range(string.Format("{0}{1}:{2}{3}", columName[colBegin], row, columName[colEnd], row));
                rowData.Font.Size = contentSize;
                rowData.Font.Name = fontName;
                rowData.Value2 = arr;
                row++;
            }
            //Dong khung
            BorderAround(ws.get_Range(string.Format("{0}{1}:{2}{3}", columName[colBegin], rowBegin + 3, columName[colEnd], row - 1)));
            //Luu file
            wb.SaveAs(path);
            wb.Close();
            xlApp.Quit();
            //giai phong vung nho
            ReleaseObject(ws);
            ReleaseObject(wb);
            ReleaseObject(xlApp);
        }
        private static void BorderAround(Range range)
        {
            Borders border = range.Borders;
            border[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            border[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            border[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            border[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;

            border.Color = Color.Black;

            border[XlBordersIndex.xlInsideVertical].LineStyle= XlLineStyle.xlContinuous;
            border[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;

            border[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            border[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }

        private static void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GC.Collect();
            }
        }

        private static int SoCotTrenLuoi(DataGridView dgv)
        {
            int result = 0;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (dgv.Columns[i].Visible == true)
                {
                    result++;
                }
            }
            return result-1;
        }
    }
}
