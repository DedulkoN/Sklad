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
    public partial class FormOrder : Form
    {
        private short UserID;
        public FormOrder(short userID)
        {
            UserID = userID;
            InitializeComponent();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.skladDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Materials". При необходимости она может быть перемещена или удалена.
            this.materialsTableAdapter.Fill(this.skladDataSet.Materials);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.TypeOrders". При необходимости она может быть перемещена или удалена.
            this.typeOrdersTableAdapter.Fill(this.skladDataSet.TypeOrders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.skladDataSet.Orders);

        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void отобразитьскрытьПанельФильтровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void buttonNoAdd_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ordersTableAdapter.Insert(Convert.ToInt16(comboBoxAddType.SelectedValue), dateTimePickerAdd.Value, Convert.ToInt16(comboBoxAddMaterial.SelectedValue), UserID, textBoxAddInfo.Text);
            ordersTableAdapter.Update(skladDataSet.Orders);
            ordersTableAdapter.Fill(skladDataSet.Orders);
            panel1.Visible = true;
        }

        private void buttonFiltr_Click(object sender, EventArgs e)
        {
            string Filtr = "";
            if (checkBoxType.Checked)
            {
                Filtr = string.Format( " TypeOrdersID = {0} ", comboBoxFiltrType.SelectedValue);
            }
            if(checkBoxmaterial.Checked)
            {
                if(Filtr=="")
                {
                    Filtr = string.Format(" MaterialId = {0} ", comboBoxFiltrMaterial.SelectedValue);
                }
                else
                {
                    Filtr += string.Format(" and MaterialId = {0} ", comboBoxFiltrMaterial.SelectedValue);
                }
            }

            if(checkBoxDate.Checked)
            {
                if (Filtr == "")
                {
                    Filtr = string.Format(" DateOrder = '{0}' ", dateTimePickerFiltr.Value.ToShortDateString());
                }
                else
                {
                    Filtr += string.Format(" and DateOrder = '{0}' ", dateTimePickerFiltr.Value.ToShortDateString());
                }
            }

            if(checkBoxWho.Checked)
            {
                if (Filtr == "")
                {
                    Filtr = string.Format(" WhoCreateOrder = {0} ", comboBoxFiltrWho.SelectedValue);
                }
                else
                {
                    Filtr += string.Format(" and WhoCreateOrder = {0} ", comboBoxFiltrWho.SelectedValue);
                }

            }
            ordersBindingSource.Filter = Filtr;

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Validate();
            ordersBindingSource.EndEdit();
            ordersTableAdapter.Update(skladDataSet.Orders);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (MessageBox.Show("Удалить выделенную строку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Validate();
                ordersBindingSource.EndEdit();
               ordersTableAdapter.Update(skladDataSet.Orders);
            }
        }

        private void выгрузитьДанныеВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToOffice.ExportToExcel(dataGridView1);
        }
    }
}
