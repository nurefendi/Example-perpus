using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpus
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {

                MessageBox.Show("Please login first.");
                e.Cancel = true; // Cancel the form closing event

        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;

            if (checkbox.Checked)
            {
                inputPassword.PasswordChar = '\0'; 
            }
            else
            {
                inputPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Dashboard dasboard = new Dashboard();
            dasboard.Show();

            this.Close();
        }
    }
}
