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
    public partial class FormPropoise : Form
    {
        public FormPropoise()
        {
            InitializeComponent();
        }

        private void FormPropoise_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.purpose". При необходимости она может быть перемещена или удалена.
            this.purposeTableAdapter.Fill(this.skladDataSet.purpose);

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Validate();
            purposeBindingSource.EndEdit();
            purposeTableAdapter.Update(skladDataSet.purpose);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (MessageBox.Show("Удалить выделенную строку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Validate();
                purposeBindingSource.EndEdit();
                purposeTableAdapter.Update(skladDataSet.purpose);
            }
        }

        private void FormPropoise_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
