﻿namespace DatabaseHotelUas
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
            this.btn_bookKamar = new System.Windows.Forms.Button();
            this.btn_checktrans = new System.Windows.Forms.Button();
            this.gb_kamar = new System.Windows.Forms.GroupBox();
            this.btn_lihatkamar = new System.Windows.Forms.Button();
            this.btn_restoran = new System.Windows.Forms.Button();
            this.gb_restoran = new System.Windows.Forms.GroupBox();
            this.gb_pelanggan = new System.Windows.Forms.GroupBox();
            this.btn_tmbhPelanggan = new System.Windows.Forms.Button();
            this.btn_cekidPelanggan = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pelangganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarPelangganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahPelangganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cekRiwayatTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riwayatPemesananKamarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riwayatTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_hargaKamar = new System.Windows.Forms.ListBox();
            this.lbl_hargaHotel = new System.Windows.Forms.Label();
            this.lbl_waktu = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_historiRestoran = new System.Windows.Forms.Button();
            this.gb_kamar.SuspendLayout();
            this.gb_restoran.SuspendLayout();
            this.gb_pelanggan.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_bookKamar
            // 
            this.btn_bookKamar.Location = new System.Drawing.Point(46, 442);
            this.btn_bookKamar.Name = "btn_bookKamar";
            this.btn_bookKamar.Size = new System.Drawing.Size(158, 54);
            this.btn_bookKamar.TabIndex = 0;
            this.btn_bookKamar.Text = "Book Kamar";
            this.btn_bookKamar.UseVisualStyleBackColor = true;
            this.btn_bookKamar.Click += new System.EventHandler(this.btn_bookKamar_Click);
            // 
            // btn_checktrans
            // 
            this.btn_checktrans.Location = new System.Drawing.Point(226, 442);
            this.btn_checktrans.Name = "btn_checktrans";
            this.btn_checktrans.Size = new System.Drawing.Size(158, 54);
            this.btn_checktrans.TabIndex = 11;
            this.btn_checktrans.Text = "Cek Transaksi";
            this.btn_checktrans.UseVisualStyleBackColor = true;
            this.btn_checktrans.Click += new System.EventHandler(this.button2_Click);
            // 
            // gb_kamar
            // 
            this.gb_kamar.Controls.Add(this.btn_lihatkamar);
            this.gb_kamar.Location = new System.Drawing.Point(437, 201);
            this.gb_kamar.Name = "gb_kamar";
            this.gb_kamar.Size = new System.Drawing.Size(460, 100);
            this.gb_kamar.TabIndex = 12;
            this.gb_kamar.TabStop = false;
            this.gb_kamar.Text = "Kamar";
            // 
            // btn_lihatkamar
            // 
            this.btn_lihatkamar.Location = new System.Drawing.Point(26, 31);
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
            this.btn_restoran.Name = "btn_restoran";
            this.btn_restoran.Size = new System.Drawing.Size(158, 54);
            this.btn_restoran.TabIndex = 14;
            this.btn_restoran.Text = "Restoran";
            this.btn_restoran.UseVisualStyleBackColor = true;
            this.btn_restoran.Click += new System.EventHandler(this.btn_fasilitasKamar_Click);
            // 
            // gb_restoran
            // 
            this.gb_restoran.Controls.Add(this.btn_historiRestoran);
            this.gb_restoran.Controls.Add(this.btn_restoran);
            this.gb_restoran.Location = new System.Drawing.Point(437, 307);
            this.gb_restoran.Name = "gb_restoran";
            this.gb_restoran.Size = new System.Drawing.Size(460, 107);
            this.gb_restoran.TabIndex = 14;
            this.gb_restoran.TabStop = false;
            this.gb_restoran.Text = "Restoran";
            this.gb_restoran.Enter += new System.EventHandler(this.gb_restoran_Enter);
            // 
            // gb_pelanggan
            // 
            this.gb_pelanggan.Controls.Add(this.btn_tmbhPelanggan);
            this.gb_pelanggan.Controls.Add(this.btn_cekidPelanggan);
            this.gb_pelanggan.Location = new System.Drawing.Point(437, 420);
            this.gb_pelanggan.Name = "gb_pelanggan";
            this.gb_pelanggan.Size = new System.Drawing.Size(460, 107);
            this.gb_pelanggan.TabIndex = 15;
            this.gb_pelanggan.TabStop = false;
            this.gb_pelanggan.Text = "Pelanggan";
            this.gb_pelanggan.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_tmbhPelanggan
            // 
            this.btn_tmbhPelanggan.Location = new System.Drawing.Point(275, 40);
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
            this.btn_cekidPelanggan.Name = "btn_cekidPelanggan";
            this.btn_cekidPelanggan.Size = new System.Drawing.Size(158, 54);
            this.btn_cekidPelanggan.TabIndex = 14;
            this.btn_cekidPelanggan.Text = "Cek ID Pelanggan";
            this.btn_cekidPelanggan.UseVisualStyleBackColor = true;
            this.btn_cekidPelanggan.Click += new System.EventHandler(this.btn_cekidPelanggan_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pelangganToolStripMenuItem,
            this.cekRiwayatTransaksiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 33);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pelangganToolStripMenuItem
            // 
            this.pelangganToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daftarPelangganToolStripMenuItem,
            this.tambahPelangganToolStripMenuItem});
            this.pelangganToolStripMenuItem.Name = "pelangganToolStripMenuItem";
            this.pelangganToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.pelangganToolStripMenuItem.Text = "Pelanggan";
            this.pelangganToolStripMenuItem.Click += new System.EventHandler(this.pelangganToolStripMenuItem_Click);
            // 
            // daftarPelangganToolStripMenuItem
            // 
            this.daftarPelangganToolStripMenuItem.Name = "daftarPelangganToolStripMenuItem";
            this.daftarPelangganToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.daftarPelangganToolStripMenuItem.Text = "Cek Pelanggan";
            this.daftarPelangganToolStripMenuItem.Click += new System.EventHandler(this.daftarPelangganToolStripMenuItem_Click);
            // 
            // tambahPelangganToolStripMenuItem
            // 
            this.tambahPelangganToolStripMenuItem.Name = "tambahPelangganToolStripMenuItem";
            this.tambahPelangganToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.tambahPelangganToolStripMenuItem.Text = "Tambah Pelanggan";
            this.tambahPelangganToolStripMenuItem.Click += new System.EventHandler(this.tambahPelangganToolStripMenuItem_Click);
            // 
            // cekRiwayatTransaksiToolStripMenuItem
            // 
            this.cekRiwayatTransaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.riwayatPemesananKamarToolStripMenuItem,
            this.riwayatTransaksiToolStripMenuItem});
            this.cekRiwayatTransaksiToolStripMenuItem.Name = "cekRiwayatTransaksiToolStripMenuItem";
            this.cekRiwayatTransaksiToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.cekRiwayatTransaksiToolStripMenuItem.Text = "Cek Riwayat ";
            this.cekRiwayatTransaksiToolStripMenuItem.Click += new System.EventHandler(this.cekRiwayatTransaksiToolStripMenuItem_Click);
            // 
            // riwayatPemesananKamarToolStripMenuItem
            // 
            this.riwayatPemesananKamarToolStripMenuItem.Name = "riwayatPemesananKamarToolStripMenuItem";
            this.riwayatPemesananKamarToolStripMenuItem.Size = new System.Drawing.Size(324, 34);
            this.riwayatPemesananKamarToolStripMenuItem.Text = "Riwayat Pemesanan Kamar";
            // 
            // riwayatTransaksiToolStripMenuItem
            // 
            this.riwayatTransaksiToolStripMenuItem.Name = "riwayatTransaksiToolStripMenuItem";
            this.riwayatTransaksiToolStripMenuItem.Size = new System.Drawing.Size(324, 34);
            this.riwayatTransaksiToolStripMenuItem.Text = "Riwayat Transaksi";
            // 
            // lb_hargaKamar
            // 
            this.lb_hargaKamar.FormattingEnabled = true;
            this.lb_hargaKamar.ItemHeight = 20;
            this.lb_hargaKamar.Location = new System.Drawing.Point(12, 201);
            this.lb_hargaKamar.Name = "lb_hargaKamar";
            this.lb_hargaKamar.Size = new System.Drawing.Size(409, 144);
            this.lb_hargaKamar.TabIndex = 19;
            this.lb_hargaKamar.SelectedIndexChanged += new System.EventHandler(this.lb_hargaKamar_SelectedIndexChanged);
            // 
            // lbl_hargaHotel
            // 
            this.lbl_hargaHotel.AutoSize = true;
            this.lbl_hargaHotel.Location = new System.Drawing.Point(12, 165);
            this.lbl_hargaHotel.Name = "lbl_hargaHotel";
            this.lbl_hargaHotel.Size = new System.Drawing.Size(95, 20);
            this.lbl_hargaHotel.TabIndex = 20;
            this.lbl_hargaHotel.Text = "Harga Hotel";
            // 
            // lbl_waktu
            // 
            this.lbl_waktu.AutoSize = true;
            this.lbl_waktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_waktu.Location = new System.Drawing.Point(12, 48);
            this.lbl_waktu.Name = "lbl_waktu";
            this.lbl_waktu.Size = new System.Drawing.Size(64, 25);
            this.lbl_waktu.TabIndex = 21;
            this.lbl_waktu.Text = "label1";
            this.lbl_waktu.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DatabaseHotelUas.Properties.Resources.D_Mario_hotel;
            this.pictureBox1.Location = new System.Drawing.Point(734, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btn_historiRestoran
            // 
            this.btn_historiRestoran.Location = new System.Drawing.Point(275, 40);
            this.btn_historiRestoran.Name = "btn_historiRestoran";
            this.btn_historiRestoran.Size = new System.Drawing.Size(158, 54);
            this.btn_historiRestoran.TabIndex = 15;
            this.btn_historiRestoran.Text = "Histori Restoran";
            this.btn_historiRestoran.UseVisualStyleBackColor = true;
            this.btn_historiRestoran.Click += new System.EventHandler(this.btn_historiRestoran_Click);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 539);
            this.Controls.Add(this.lbl_waktu);
            this.Controls.Add(this.lbl_hargaHotel);
            this.Controls.Add(this.lb_hargaKamar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gb_pelanggan);
            this.Controls.Add(this.gb_restoran);
            this.Controls.Add(this.gb_kamar);
            this.Controls.Add(this.btn_checktrans);
            this.Controls.Add(this.btn_bookKamar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_main";
            this.Text = "D\'Mario Hotel ";
            this.Load += new System.EventHandler(this.form_main_Load);
            this.gb_kamar.ResumeLayout(false);
            this.gb_restoran.ResumeLayout(false);
            this.gb_pelanggan.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bookKamar;
        private System.Windows.Forms.Button btn_checktrans;
        private System.Windows.Forms.GroupBox gb_kamar;
        private System.Windows.Forms.Button btn_lihatkamar;
        private System.Windows.Forms.Button btn_restoran;
        private System.Windows.Forms.GroupBox gb_restoran;
        private System.Windows.Forms.GroupBox gb_pelanggan;
        private System.Windows.Forms.Button btn_cekidPelanggan;
        private System.Windows.Forms.Button btn_tmbhPelanggan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pelangganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daftarPelangganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahPelangganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cekRiwayatTransaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riwayatPemesananKamarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riwayatTransaksiToolStripMenuItem;
        private System.Windows.Forms.ListBox lb_hargaKamar;
        private System.Windows.Forms.Label lbl_hargaHotel;
        private System.Windows.Forms.Label lbl_waktu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_historiRestoran;
    }
}

