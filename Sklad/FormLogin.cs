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
    public partial class FormLogin : Form
    {
        public int UserRoleID = 0;
        public int UserID = 0;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usersBindingSource.Filter = string.Format("UserLogin = '{0}' and UserPassword = '{1}'", textBoxLogin.Text, Crypt.Encrypt(textBoxPass.Text));
            //usersBindingSource.Filter = string.Format("UserLogin = '{0}'", textBoxLogin.Text);
            if (usersBindingSource.Count >0)
            {
                UserRoleID = Convert.ToInt32((usersBindingSource.Current as DataRowView).Row["RolesUser"]);
                UserID = Convert.ToInt32((usersBindingSource.Current as DataRowView).Row["UsersID"]);
                this.DialogResult = DialogResult.OK;
            }
            else { MessageBox.Show("Неверная комбинация логина и пароля!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.skladDataSet.Users);

        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (UserRoleID == 0)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
