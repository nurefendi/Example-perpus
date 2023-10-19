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
        FormDataBuku formDataBuku = null;
        FormLogin formLogin = null;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void masukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.showFormLogin();
        }

        private void dataBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.showFormDataBuku();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Word!");
        }


        private void showFormDataBuku()
        {
            if (formDataBuku == null || formDataBuku.IsDisposed)
            {
                formDataBuku = new FormDataBuku();
                formDataBuku.MdiParent = this;
                formDataBuku.Show();
            }
            else
            {
                formDataBuku.Activate();
            }
        }

        private void showFormLogin()
        {
            if (formLogin == null || formLogin.IsDisposed)
            {
                formLogin = new FormLogin();
                formLogin.MdiParent = this;
                formLogin.Show();
            }
            else
            {
                formLogin.Activate();
            }
        }

        private void btnOpenFormDataBuku_Click(object sender, EventArgs e)
        {
            this.showFormDataBuku();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            showFormLogin();
        }
    }
}
