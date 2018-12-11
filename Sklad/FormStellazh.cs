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
    public partial class FormStellazh : Form
    {
        public FormStellazh()
        {
            InitializeComponent();
        }

        private void FormStellazh_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Stellazh". При необходимости она может быть перемещена или удалена.
            this.stellazhTableAdapter.Fill(this.skladDataSet.Stellazh);

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Validate();
            stellazhBindingSource.EndEdit();
            stellazhTableAdapter.Update(skladDataSet.Stellazh);
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (MessageBox.Show("Удалить выделенную строку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Validate();
                stellazhBindingSource.EndEdit();
                stellazhTableAdapter.Update(skladDataSet.Stellazh);
            }
        }

        private void FormStellazh_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
