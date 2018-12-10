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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            Validate();
            materialsBindingSource.EndEdit();
            materialsTableAdapter.Update(skladDataSet.Materials);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView1_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {
            
          
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (MessageBox.Show("Удалить выделенную строку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Validate();
                materialsBindingSource.EndEdit();
                materialsTableAdapter.Update(skladDataSet.Materials);
            }
        }
    }
}
