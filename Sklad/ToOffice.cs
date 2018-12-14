using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Sklad
{
    static class ToOffice
    {
        public static void ExportToExcel(DataGridView dgwToExport)
        {
            try
            {

                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                ExcelApp.Columns.ColumnWidth = 15;
                int i = 1;
                int j = 0;
                foreach (DataGridViewColumn col in dgwToExport.Columns)
                {

                    if (col.Visible)
                        ExcelApp.Cells[1, ++j] = col.HeaderText;
                }


                foreach (DataGridViewRow row in dgwToExport.Rows)
                {
                    i++;
                    j = 0;

                    foreach (DataGridViewColumn col in dgwToExport.Columns)
                    {
                        if (col.Visible)
                        {
                            j++;
                            ExcelApp.Cells[i, j] = row.Cells[col.Index].FormattedValue.ToString().Replace("\r\n", " ");
                        }
                    }

                }
                ExcelApp.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
