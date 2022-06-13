namespace DatabaseHotelUas
{
    partial class form_main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.btn_checktrans = new System.Windows.Forms.Button();
            this.gb_kamar = new System.Windows.Forms.GroupBox();
            this.btn_lihatkamar = new System.Windows.Forms.Button();
            this.btn_restoran = new System.Windows.Forms.Button();
            this.gb_restoran = new System.Windows.Forms.GroupBox();
            this.btn_historiRestoran = new System.Windows.Forms.Button();
            this.gb_pelanggan = new System.Windows.Forms.GroupBox();
            this.btn_tmbhPelanggan = new System.Windows.Forms.Button();
            this.btn_cekidPelanggan = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pelangganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cekRiwayatTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kamarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_hargaKamar = new System.Windows.Forms.ListBox();
            this.lbl_hargaHotel = new System.Windows.Forms.Label();
            this.lbl_waktu = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_jamWIB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_kamar.SuspendLayout();
            this.gb_restoran.SuspendLayout();
            this.gb_pelanggan.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_checktrans
            // 
            this.btn_checktrans.Location = new System.Drawing.Point(539, 550);
            this.btn_checktrans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_checktrans.Name = "btn_checktrans";
            this.btn_checktrans.Size = new System.Drawing.Size(158, 54);
            this.btn_checktrans.TabIndex = 11;
            this.btn_checktrans.Text = "Cek Transaksi";
            this.btn_checktrans.UseVisualStyleBackColor = true;
            this.btn_checktrans.Click += new System.EventHandler(this.button2_Click);
            // 
            // gb_kamar
            // 
            this.gb_kamar.BackColor = System.Drawing.Color.Transparent;
            this.gb_kamar.Controls.Add(this.btn_lihatkamar);
            this.gb_kamar.ForeColor = System.Drawing.Color.Black;
            this.gb_kamar.Location = new System.Drawing.Point(82, 275);
            this.gb_kamar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_kamar.Name = "gb_kamar";
            this.gb_kamar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_kamar.Size = new System.Drawing.Size(460, 100);
            this.gb_kamar.TabIndex = 12;
            this.gb_kamar.TabStop = false;
            this.gb_kamar.Text = "Kamar";
            // 
            // btn_lihatkamar
            // 
            this.btn_lihatkamar.Location = new System.Drawing.Point(26, 31);
            this.btn_lihatkamar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_lihatkamar.Name = "btn_lihatkamar";
            this.btn_lihatkamar.Size = new System.Drawing.Size(158, 54);
            this.btn_lihatkamar.TabIndex = 13;
            this.btn_lihatkamar.Text = "Lihat Kamar";
            this.btn_lihatkamar.UseVisualStyleBackColor = true;
            this.btn_lihatkamar.Click += new System.EventHandler(this.btn_lihatkamar_Click);
            // 
            // btn_restoran
            // 
            this.btn_restoran.Location = new System.Drawing.Point(26, 40);
            this.btn_restoran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_restoran.Name = "btn_restoran";
            this.btn_restoran.Size = new System.Drawing.Size(158, 54);
            this.btn_restoran.TabIndex = 14;
            this.btn_restoran.Text = "Restoran";
            this.btn_restoran.UseVisualStyleBackColor = true;
            this.btn_restoran.Click += new System.EventHandler(this.btn_fasilitasKamar_Click);
            // 
            // gb_restoran
            // 
            this.gb_restoran.BackColor = System.Drawing.Color.Transparent;
            this.gb_restoran.Controls.Add(this.btn_historiRestoran);
            this.gb_restoran.Controls.Add(this.btn_restoran);
            this.gb_restoran.Location = new System.Drawing.Point(82, 379);
            this.gb_restoran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_restoran.Name = "gb_restoran";
            this.gb_restoran.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_restoran.Size = new System.Drawing.Size(460, 108);
            this.gb_restoran.TabIndex = 14;
            this.gb_restoran.TabStop = false;
            this.gb_restoran.Text = "Restoran";
            // 
            // btn_historiRestoran
            // 
            this.btn_historiRestoran.Location = new System.Drawing.Point(274, 40);
            this.btn_historiRestoran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_historiRestoran.Name = "btn_historiRestoran";
            this.btn_historiRestoran.Size = new System.Drawing.Size(158, 54);
            this.btn_historiRestoran.TabIndex = 15;
            this.btn_historiRestoran.Text = "Histori Restoran";
            this.btn_historiRestoran.UseVisualStyleBackColor = true;
            this.btn_historiRestoran.Click += new System.EventHandler(this.btn_historiRestoran_Click);
            // 
            // gb_pelanggan
            // 
            this.gb_pelanggan.BackColor = System.Drawing.Color.Transparent;
            this.gb_pelanggan.Controls.Add(this.btn_tmbhPelanggan);
            this.gb_pelanggan.Controls.Add(this.btn_cekidPelanggan);
            this.gb_pelanggan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gb_pelanggan.Location = new System.Drawing.Point(82, 500);
            this.gb_pelanggan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_pelanggan.Name = "gb_pelanggan";
            this.gb_pelanggan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_pelanggan.Size = new System.Drawing.Size(460, 108);
            this.gb_pelanggan.TabIndex = 15;
            this.gb_pelanggan.TabStop = false;
            this.gb_pelanggan.Text = "Pelanggan";
            // 
            // btn_tmbhPelanggan
            // 
            this.btn_tmbhPelanggan.Location = new System.Drawing.Point(274, 40);
            this.btn_tmbhPelanggan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tmbhPelanggan.Name = "btn_tmbhPelanggan";
            this.btn_tmbhPelanggan.Size = new System.Drawing.Size(158, 54);
            this.btn_tmbhPelanggan.TabIndex = 15;
            this.btn_tmbhPelanggan.Text = "Tambah Pelanggan";
            this.btn_tmbhPelanggan.UseVisualStyleBackColor = true;
            this.btn_tmbhPelanggan.Click += new System.EventHandler(this.btn_tmbhPelanggan_Click);
            // 
            // btn_cekidPelanggan
            // 
            this.btn_cekidPelanggan.Location = new System.Drawing.Point(26, 40);
            this.btn_cekidPelanggan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cekidPelanggan.Name = "btn_cekidPelanggan";
            this.btn_cekidPelanggan.Size = new System.Drawing.Size(158, 54);
            this.btn_cekidPelanggan.TabIndex = 14;
            this.btn_cekidPelanggan.Text = "Cek ID Pelanggan";
            this.btn_cekidPelanggan.UseVisualStyleBackColor = true;
            this.btn_cekidPelanggan.Click += new System.EventHandler(this.btn_cekidPelanggan_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pelangganToolStripMenuItem,
            this.cekRiwayatTransaksiToolStripMenuItem,
            this.kamarToolStripMenuItem,
            this.restoranToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(230, 5, 0, 10);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1045, 49);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // pelangganToolStripMenuItem
            // 
            this.pelangganToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pelangganToolStripMenuItem.Name = "pelangganToolStripMenuItem";
            this.pelangganToolStripMenuItem.Size = new System.Drawing.Size(138, 34);
            this.pelangganToolStripMenuItem.Text = "Pelanggan";
            this.pelangganToolStripMenuItem.Click += new System.EventHandler(this.pelangganToolStripMenuItem_Click);
            // 
            // cekRiwayatTransaksiToolStripMenuItem
            // 
            this.cekRiwayatTransaksiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cekRiwayatTransaksiToolStripMenuItem.Name = "cekRiwayatTransaksiToolStripMenuItem";
            this.cekRiwayatTransaksiToolStripMenuItem.Size = new System.Drawing.Size(213, 34);
            this.cekRiwayatTransaksiToolStripMenuItem.Text = "Riwayat Transaksi";
            this.cekRiwayatTransaksiToolStripMenuItem.Click += new System.EventHandler(this.cekRiwayatTransaksiToolStripMenuItem_Click);
            // 
            // kamarToolStripMenuItem
            // 
            this.kamarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.kamarToolStripMenuItem.Name = "kamarToolStripMenuItem";
            this.kamarToolStripMenuItem.Size = new System.Drawing.Size(96, 34);
            this.kamarToolStripMenuItem.Text = "Kamar";
            this.kamarToolStripMenuItem.Click += new System.EventHandler(this.kamarToolStripMenuItem_Click);
            // 
            // restoranToolStripMenuItem
            // 
            this.restoranToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.restoranToolStripMenuItem.Name = "restoranToolStripMenuItem";
            this.restoranToolStripMenuItem.Size = new System.Drawing.Size(120, 34);
            this.restoranToolStripMenuItem.Text = "Restoran";
            this.restoranToolStripMenuItem.Click += new System.EventHandler(this.restoranToolStripMenuItem_Click);
            // 
            // lb_hargaKamar
            // 
            this.lb_hargaKamar.BackColor = System.Drawing.Color.Black;
            this.lb_hargaKamar.ForeColor = System.Drawing.Color.White;
            this.lb_hargaKamar.FormattingEnabled = true;
            this.lb_hargaKamar.ItemHeight = 20;
            this.lb_hargaKamar.Location = new System.Drawing.Point(703, 437);
            this.lb_hargaKamar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_hargaKamar.Name = "lb_hargaKamar";
            this.lb_hargaKamar.Size = new System.Drawing.Size(298, 184);
            this.lb_hargaKamar.TabIndex = 19;
            this.lb_hargaKamar.Click += new System.EventHandler(this.lb_hargaKamar_Click);
            // 
            // lbl_hargaHotel
            // 
            this.lbl_hargaHotel.AutoSize = true;
            this.lbl_hargaHotel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hargaHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hargaHotel.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_hargaHotel.Location = new System.Drawing.Point(790, 400);
            this.lbl_hargaHotel.Name = "lbl_hargaHotel";
            this.lbl_hargaHotel.Size = new System.Drawing.Size(126, 25);
            this.lbl_hargaHotel.TabIndex = 20;
            this.lbl_hargaHotel.Text = "Harga Hotel";
            // 
            // lbl_waktu
            // 
            this.lbl_waktu.AutoSize = true;
            this.lbl_waktu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_waktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_waktu.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_waktu.Location = new System.Drawing.Point(740, 215);
            this.lbl_waktu.Name = "lbl_waktu";
            this.lbl_waktu.Size = new System.Drawing.Size(64, 25);
            this.lbl_waktu.TabIndex = 21;
            this.lbl_waktu.Text = "label1";
            this.lbl_waktu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_jamWIB
            // 
            this.lbl_jamWIB.AutoSize = true;
            this.lbl_jamWIB.BackColor = System.Drawing.Color.Transparent;
            this.lbl_jamWIB.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jamWIB.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_jamWIB.Location = new System.Drawing.Point(741, 255);
            this.lbl_jamWIB.Name = "lbl_jamWIB";
            this.lbl_jamWIB.Size = new System.Drawing.Size(175, 85);
            this.lbl_jamWIB.TabIndex = 22;
            this.lbl_jamWIB.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(994, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 49);
            this.button1.TabIndex = 24;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Black;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip2.Location = new System.Drawing.Point(0, 49);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(230, 5, 0, 10);
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip2.Size = new System.Drawing.Size(1045, 111);
            this.menuStrip2.Stretch = false;
            this.menuStrip2.TabIndex = 27;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(226, 34);
            this.toolStripMenuItem1.Text = "Tambah Pelanggan";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(182, 34);
            this.toolStripMenuItem3.Text = "Cek Pelanggan";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(604, 100);
            this.dataGridView1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "INI NANTI BUAT NAMPILIN KAMAR YANG SEDANG KOSONG";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DatabaseHotelUas.Properties.Resources.UI;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 691);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_jamWIB);
            this.Controls.Add(this.lbl_waktu);
            this.Controls.Add(this.lbl_hargaHotel);
            this.Controls.Add(this.lb_hargaKamar);
            this.Controls.Add(this.gb_pelanggan);
            this.Controls.Add(this.gb_restoran);
            this.Controls.Add(this.gb_kamar);
            this.Controls.Add(this.btn_checktrans);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_main";
            this.Text = "D\'Mario Hotel ";
            this.Load += new System.EventHandler(this.form_main_Load);
            this.gb_kamar.ResumeLayout(false);
            this.gb_restoran.ResumeLayout(false);
            this.gb_pelanggan.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_checktrans;
        private System.Windows.Forms.GroupBox gb_kamar;
        private System.Windows.Forms.Button btn_lihatkamar;
        private System.Windows.Forms.Button btn_restoran;
        private System.Windows.Forms.GroupBox gb_restoran;
        private System.Windows.Forms.GroupBox gb_pelanggan;
        private System.Windows.Forms.Button btn_cekidPelanggan;
        private System.Windows.Forms.Button btn_tmbhPelanggan;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cekRiwayatTransaksiToolStripMenuItem;
        private System.Windows.Forms.ListBox lb_hargaKamar;
        private System.Windows.Forms.Label lbl_hargaHotel;
        private System.Windows.Forms.Label lbl_waktu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_historiRestoran;
        private System.Windows.Forms.Label lbl_jamWIB;
        private System.Windows.Forms.ToolStripMenuItem kamarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoranToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem pelangganToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}

