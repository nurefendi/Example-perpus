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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void masukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            DisableControls(false);
        }

        public void DisableControls(bool isDisabled)
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = isDisabled;
            }
        }

        private void dataBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataBuku dataBuku = new FormDataBuku();
            dataBuku.Show();
        }
    }
}
