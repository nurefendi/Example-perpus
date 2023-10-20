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
        private FormDataBuku formDataBuku = null;
        private FormLogin formLogin = null;
        private DbConnection dbConnection;

        public Dashboard()
        {
            dbConnection = new DbConnection();
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            enableReconnectDB();
        }

        private void enableReconnectDB() {

            if (dbConnection.GetConnection().State != System.Data.ConnectionState.Open)
            {
                this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = false);

                DialogResult result = MessageBox.Show("Can't connect to database! \n Do you want to reconnect?", "Reconnect?", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    dbConnection = new DbConnection();
                    this.enableReconnectDB();
                }
                else
                {
                    Application.Exit();
                }

            }
            else
            {
                this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = true);
            }
        }
    }
}
