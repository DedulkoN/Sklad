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
    public partial class FormTypeOrder : Form
    {
        public FormTypeOrder()
        {
            InitializeComponent();
        }

        private void FormTypeOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.TypeOrders". При необходимости она может быть перемещена или удалена.
            this.typeOrdersTableAdapter.Fill(this.skladDataSet.TypeOrders);

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Validate();
            typeOrdersBindingSource.EndEdit();
            typeOrdersTableAdapter.Update(skladDataSet.TypeOrders);
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (MessageBox.Show("Удалить выделенную строку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Validate();
                typeOrdersBindingSource.EndEdit();
                typeOrdersTableAdapter.Update(skladDataSet.TypeOrders);
            }
        }
    }
}
