using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklad
{
    public partial class FormMain : Form
    {
        private int UserRoleID = 0;
        private int UserID = 0;
        public FormMain()
        {
            FormLogin fl = new FormLogin();
            if( fl.ShowDialog() == DialogResult.OK)
            {
                UserRoleID = fl.UserRoleID;
                UserID = fl.UserID;
            }
            else
            {
                this.Close();
                Application.Exit();
            }
            InitializeComponent();
            if (UserRoleID != 1) панельАдминистратораToolStripMenuItem.Visible = false;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.View_1". При необходимости она может быть перемещена или удалена.
            this.view_1TableAdapter.Fill(this.skladDataSet.View_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.MaterialForShelf". При необходимости она может быть перемещена или удалена.
            this.materialForShelfTableAdapter.Fill(this.skladDataSet.MaterialForShelf);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.purpose". При необходимости она может быть перемещена или удалена.
            this.purposeTableAdapter.Fill(this.skladDataSet.purpose);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Shelf". При необходимости она может быть перемещена или удалена.
            this.shelfTableAdapter.Fill(this.skladDataSet.Shelf);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Stellazh". При необходимости она может быть перемещена или удалена.
            this.stellazhTableAdapter.Fill(this.skladDataSet.Stellazh);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Departament". При необходимости она может быть перемещена или удалена.
            this.departamentTableAdapter.Fill(this.skladDataSet.Departament);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.TypeMaterial". При необходимости она может быть перемещена или удалена.
            this.typeMaterialTableAdapter.Fill(this.skladDataSet.TypeMaterial);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Materials". При необходимости она может быть перемещена или удалена.
            this.materialsTableAdapter.Fill(this.skladDataSet.Materials);

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.Rows[e.RowIndex].Cells[1].Value != DBNull.Value &&
            //    dataGridView1.Rows[e.RowIndex].Cells[2].Value != DBNull.Value &&
            //    dataGridView1.Rows[e.RowIndex].Cells[3].Value != DBNull.Value &&
            //    dataGridView1.Rows[e.RowIndex].Cells[4].Value != DBNull.Value)
            //{
            //    if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != DBNull.Value)
            //        dataGridView1.Rows[e.RowIndex].Cells[0].Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex - 1].Cells[0].Value) + 1;
                Validate();
                materialForShelfBindingSource.EndEdit();
                materialForShelfTableAdapter.Update(skladDataSet.MaterialForShelf);
            //}
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
           // MessageBox.Show(e.Exception.Message);
        }

        private void dataGridView1_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {
            
          
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (MessageBox.Show("Удалить выделенную строку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Validate();
                materialForShelfBindingSource.EndEdit();
                materialForShelfTableAdapter.Update(skladDataSet.MaterialForShelf);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void типыМатериаловToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                try
                {
                    FormTypeMaterials f = new FormTypeMaterials();
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        this.typeMaterialTableAdapter.Fill(this.skladDataSet.TypeMaterial);
                    }
                }
                catch { }
           
        }

        private void отделыToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                try
                {
                    FormDepartament f = new FormDepartament();
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        this.departamentTableAdapter.Fill(this.skladDataSet.Departament);
                    }
                }
                catch { }
           
        }

        private void стеллажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                try
                {
                    FormStellazh f = new FormStellazh();
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        this.stellazhTableAdapter.Fill(this.skladDataSet.Stellazh);
                    }
                }
                catch { }
           
        }

        private void полкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                try
                {
                    FormPolka f = new FormPolka();
                    if(f.ShowDialog() == DialogResult.OK)
                    {
                        this.shelfTableAdapter.Fill(this.skladDataSet.Shelf);
                    }
                }
                catch { }
          
        }

        private void целиХраненияToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                try
                {
                    FormPropoise f = new FormPropoise();
                    if(f.ShowDialog() == DialogResult.OK)
                    {
                        this.purposeTableAdapter.Fill(this.skladDataSet.purpose);
                    }
                }
                catch { }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string Filtr = "";
           
            if(checkBoxTypeMaterials.Checked)
            {

                if(Filtr == "")
                { Filtr = string.Format(" [IdMaterial] = {0}", comboBoxTypeMaterials.SelectedValue); }
                else { Filtr += string.Format(" and [IdMaterial] = {0}", comboBoxTypeMaterials.SelectedValue); }
            }
          
            if(checkBoxStellaz.Checked)
            {
                if (Filtr == "")
                { Filtr = string.Format(" [ShelfID] = {0}", comboBoxStellaz.SelectedValue); }
                else { Filtr += string.Format(" and [ShelfID] = {0}", comboBoxStellaz.SelectedValue); }

            }
            view1BindingSource.Filter = Filtr;

        }

        private void панельАдминистратораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                    FormAdminPanel formAdminPanel = new FormAdminPanel();
                    formAdminPanel.Show();
               
        }

        private void ордераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrder formOrder = new FormOrder((short)UserID);
            formOrder.Show();
        }

        private void dsuhepbnmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToOffice.ExportToExcel(dataGridView1);
        }



        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Удалить выделенную строку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                Validate();
                materialsBindingSource.EndEdit();
                materialsTableAdapter.Update(skladDataSet.Materials);
            }            
           
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void редактироватьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.BeginEdit(true);
        }

        private void выгрузитьДанныеВWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToOffice.ExportToWord(dataGridView1);
        }

        private void материалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                try
                {
                    Materials fm = new Materials();
                    if (fm.ShowDialog() == DialogResult.OK)
                    {
                        this.materialsTableAdapter.Fill(this.skladDataSet.Materials);
                    }
                }
                catch { }
          
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void выгрузитьДанныеВPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToPDF.ExportToPDF(dataGridView1);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           
        }
    }
}
