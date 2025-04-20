using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;

namespace Sklad
{
    static class ToPDF
    {

        public static void ExportToPDF(DataGridView dgwToExport)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pdf Files|*.pdf";
            saveFileDialog.FileName = "PDF_File.pdf";

            saveFileDialog.ShowDialog();
            iTextSharp.text.Document doc = new iTextSharp.text.Document();

            PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
            doc.Open();

            
            BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.NORMAL);


            PdfPTable table = new PdfPTable(dgwToExport.Columns.Count);
            PdfPCell cell;

            for (int j = 0; j < dgwToExport.Columns.Count; j++)
            {
                cell = new PdfPCell(new Phrase(new Phrase(dgwToExport.Columns[j].HeaderText, font)));
                //Фоновый цвет (необязательно, просто сделаем по красивее)
                cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;                
                table.AddCell(cell);
            }

            for (int j = 0; j < dgwToExport.Rows.Count; j++)
            {
                for (int k = 0; k < dgwToExport.Columns.Count; k++)
                {
                    table.AddCell(new Phrase(dgwToExport.Rows[j].Cells[k].FormattedValue.ToString().Replace("\r\n", " "), font));
                }
            }
            //Добавляем таблицу в документ
            doc.Add(table);

            doc.Close();

            MessageBox.Show("Pdf-документ сохранен");


        }
    }
}
