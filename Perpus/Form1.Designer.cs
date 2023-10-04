namespace Perpus
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peminjamanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengembalianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPeminjamanBulanIniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPengembalianBulanIniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.peminjamanToolStripMenuItem,
            this.pengembalianToolStripMenuItem,
            this.laporanToolStripMenuItem,
            this.masukToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(566, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBukuToolStripMenuItem,
            this.dataMemberToolStripMenuItem,
            this.dataAdminToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // peminjamanToolStripMenuItem
            // 
            this.peminjamanToolStripMenuItem.Name = "peminjamanToolStripMenuItem";
            this.peminjamanToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.peminjamanToolStripMenuItem.Text = "Peminjaman";
            // 
            // pengembalianToolStripMenuItem
            // 
            this.pengembalianToolStripMenuItem.Name = "pengembalianToolStripMenuItem";
            this.pengembalianToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.pengembalianToolStripMenuItem.Text = "Pengembalian";
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laporanPeminjamanBulanIniToolStripMenuItem,
            this.laporanPengembalianBulanIniToolStripMenuItem});
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // dataBukuToolStripMenuItem
            // 
            this.dataBukuToolStripMenuItem.Name = "dataBukuToolStripMenuItem";
            this.dataBukuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dataBukuToolStripMenuItem.Text = "Data buku";
            // 
            // dataMemberToolStripMenuItem
            // 
            this.dataMemberToolStripMenuItem.Name = "dataMemberToolStripMenuItem";
            this.dataMemberToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dataMemberToolStripMenuItem.Text = "Data member";
            // 
            // dataAdminToolStripMenuItem
            // 
            this.dataAdminToolStripMenuItem.Name = "dataAdminToolStripMenuItem";
            this.dataAdminToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dataAdminToolStripMenuItem.Text = "Data admin";
            // 
            // laporanPeminjamanBulanIniToolStripMenuItem
            // 
            this.laporanPeminjamanBulanIniToolStripMenuItem.Name = "laporanPeminjamanBulanIniToolStripMenuItem";
            this.laporanPeminjamanBulanIniToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.laporanPeminjamanBulanIniToolStripMenuItem.Text = "Laporan peminjaman bulan ini";
            // 
            // laporanPengembalianBulanIniToolStripMenuItem
            // 
            this.laporanPengembalianBulanIniToolStripMenuItem.Name = "laporanPengembalianBulanIniToolStripMenuItem";
            this.laporanPengembalianBulanIniToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.laporanPengembalianBulanIniToolStripMenuItem.Text = "Laporan pengembalian bulan ini";
            // 
            // masukToolStripMenuItem
            // 
            this.masukToolStripMenuItem.Name = "masukToolStripMenuItem";
            this.masukToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.masukToolStripMenuItem.Text = "Masuk";
            this.masukToolStripMenuItem.Click += new System.EventHandler(this.masukToolStripMenuItem_Click);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.keluarToolStripMenuItem.Text = "Keluar";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peminjamanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengembalianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanPeminjamanBulanIniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanPengembalianBulanIniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;

    }
}

