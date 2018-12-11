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
    public partial class FormDepartament : Form
    {
        public FormDepartament()
        {
            InitializeComponent();
        }

        private void FormDepartament_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Departament". При необходимости она может быть перемещена или удалена.
            this.departamentTableAdapter.Fill(this.skladDataSet.Departament);

        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (MessageBox.Show("Удалить выделенную строку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Validate();
                departamentBindingSource.EndEdit();
                departamentTableAdapter.Update(skladDataSet.Departament);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Validate();
            departamentBindingSource.EndEdit();
            departamentTableAdapter.Update(skladDataSet.Departament);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void FormDepartament_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
