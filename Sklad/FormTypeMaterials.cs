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
    public partial class FormTypeMaterials : Form
    {
        public FormTypeMaterials()
        {
            InitializeComponent();
        }

        private void FormTypeMaterials_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.TypeMaterial". При необходимости она может быть перемещена или удалена.
            this.typeMaterialTableAdapter.Fill(this.skladDataSet.TypeMaterial);
          

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Validate();
            typeMaterialBindingSource.EndEdit();
            typeMaterialTableAdapter.Update(skladDataSet.TypeMaterial);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (MessageBox.Show("Удалить выделенную строку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Validate();
                typeMaterialBindingSource.EndEdit();
                typeMaterialTableAdapter.Update(skladDataSet.TypeMaterial);
            }
        }

        private void FormTypeMaterials_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
