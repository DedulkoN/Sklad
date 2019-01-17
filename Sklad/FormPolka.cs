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
    public partial class FormPolka : Form
    {
        public FormPolka()
        {
            InitializeComponent();
        }

        private void FormPolka_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Stellazh". При необходимости она может быть перемещена или удалена.
            this.stellazhTableAdapter.Fill(this.skladDataSet.Stellazh);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Shelf". При необходимости она может быть перемещена или удалена.
            this.shelfTableAdapter.Fill(this.skladDataSet.Shelf);

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Validate();
            shelfBindingSource.EndEdit();
            shelfTableAdapter.Update(skladDataSet.Shelf);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (MessageBox.Show("Удалить выделенную строку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Validate();
                shelfBindingSource.EndEdit();
                shelfTableAdapter.Update(skladDataSet.Shelf);
            }
        }

        private void FormPolka_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
