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
    public partial class FormAdminPanel : Form
    {
        public FormAdminPanel()
        {
            InitializeComponent();
        }

        private void FormAdminPanel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.RoleUsers". При необходимости она может быть перемещена или удалена.
            this.roleUsersTableAdapter.Fill(this.skladDataSet.RoleUsers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.skladDataSet.Users);

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           

            if (e.ColumnIndex == 2)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Crypt.Encrypt(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
            try
            {
                Validate();
                usersBindingSource.EndEdit();
                usersTableAdapter.Update(skladDataSet.Users);
            }
            catch { }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (MessageBox.Show("Удалить выделенную строку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Validate();
                usersBindingSource.EndEdit();
                usersTableAdapter.Update(skladDataSet.Users);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usersTableAdapter.Insert(textBoxLogin.Text, Crypt.Encrypt(textBoxPass.Text), Convert.ToInt16(comboBoxRole.SelectedValue), "", "");
            usersTableAdapter.Update(skladDataSet.Users);
            this.usersTableAdapter.Fill(this.skladDataSet.Users);
            panel1.Visible = false;
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminPanel_Load(sender, e);
        }
    }
}
