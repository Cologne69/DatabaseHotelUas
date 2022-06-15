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
            this.lb_hargaKamar = new System.Windows.Forms.ListBox();
            this.lbl_hargaHotel = new System.Windows.Forms.Label();
            this.lbl_waktu = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_jamWIB = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_crossmark = new System.Windows.Forms.PictureBox();
            this.pic_search = new System.Windows.Forms.PictureBox();
            this.btnRestoran = new System.Windows.Forms.Button();
            this.btnKamar = new System.Windows.Forms.Button();
            this.tb_cariMenu = new System.Windows.Forms.TextBox();
            this.btnRiwayatTransaksi = new System.Windows.Forms.Button();
            this.btnPelanggan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btn_cekidPelanggan = new System.Windows.Forms.Button();
            this.btn_tmbhPelanggan = new System.Windows.Forms.Button();
            this.gb_pelanggan = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDarkMode = new System.Windows.Forms.Panel();
            this.panelTombolDarkMode = new System.Windows.Forms.Panel();
            this.timermode6 = new System.Windows.Forms.Timer(this.components);
            this.timermode7 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_crossmark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).BeginInit();
            this.panel3.SuspendLayout();
            this.gb_pelanggan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_hargaKamar
            // 
            this.lb_hargaKamar.BackColor = System.Drawing.Color.Black;
            this.lb_hargaKamar.ForeColor = System.Drawing.Color.White;
            this.lb_hargaKamar.FormattingEnabled = true;
            this.lb_hargaKamar.ItemHeight = 16;
            this.lb_hargaKamar.Location = new System.Drawing.Point(760, 328);
            this.lb_hargaKamar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_hargaKamar.Name = "lb_hargaKamar";
            this.lb_hargaKamar.Size = new System.Drawing.Size(262, 84);
            this.lb_hargaKamar.TabIndex = 19;
            this.lb_hargaKamar.Click += new System.EventHandler(this.lb_hargaKamar_Click);
            // 
            // lbl_hargaHotel
            // 
            this.lbl_hargaHotel.AutoSize = true;
            this.lbl_hargaHotel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hargaHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hargaHotel.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_hargaHotel.Location = new System.Drawing.Point(756, 306);
            this.lbl_hargaHotel.Name = "lbl_hargaHotel";
            this.lbl_hargaHotel.Size = new System.Drawing.Size(111, 20);
            this.lbl_hargaHotel.TabIndex = 20;
            this.lbl_hargaHotel.Text = "Harga Hotel";
            // 
            // lbl_waktu
            // 
            this.lbl_waktu.AutoSize = true;
            this.lbl_waktu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_waktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_waktu.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_waktu.Location = new System.Drawing.Point(775, 239);
            this.lbl_waktu.Name = "lbl_waktu";
            this.lbl_waktu.Size = new System.Drawing.Size(53, 20);
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
            this.lbl_jamWIB.Location = new System.Drawing.Point(830, 255);
            this.lbl_jamWIB.Name = "lbl_jamWIB";
            this.lbl_jamWIB.Size = new System.Drawing.Size(144, 71);
            this.lbl_jamWIB.TabIndex = 22;
            this.lbl_jamWIB.Text = "label1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Black;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip2.Location = new System.Drawing.Point(0, 39);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(204, 4, 0, 8);
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip2.Size = new System.Drawing.Size(929, 89);
            this.menuStrip2.Stretch = false;
            this.menuStrip2.TabIndex = 27;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(194, 29);
            this.toolStripMenuItem1.Text = "Tambah Pelanggan";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(158, 29);
            this.toolStripMenuItem3.Text = "Cek Pelanggan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.panel1.Controls.Add(this.pic_crossmark);
            this.panel1.Controls.Add(this.pic_search);
            this.panel1.Controls.Add(this.btnRestoran);
            this.panel1.Controls.Add(this.btnKamar);
            this.panel1.Controls.Add(this.tb_cariMenu);
            this.panel1.Controls.Add(this.btnRiwayatTransaksi);
            this.panel1.Controls.Add(this.btnPelanggan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 415);
            this.panel1.TabIndex = 30;
            // 
            // pic_crossmark
            // 
            this.pic_crossmark.BackColor = System.Drawing.Color.Transparent;
            this.pic_crossmark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_crossmark.Image = global::DatabaseHotelUas.Properties.Resources.x_mark;
            this.pic_crossmark.Location = new System.Drawing.Point(21, 367);
            this.pic_crossmark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_crossmark.Name = "pic_crossmark";
            this.pic_crossmark.Size = new System.Drawing.Size(23, 21);
            this.pic_crossmark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_crossmark.TabIndex = 35;
            this.pic_crossmark.TabStop = false;
            this.pic_crossmark.Click += new System.EventHandler(this.pic_crossmark_Click);
            // 
            // pic_search
            // 
            this.pic_search.BackColor = System.Drawing.Color.Transparent;
            this.pic_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_search.Image = ((System.Drawing.Image)(resources.GetObject("pic_search.Image")));
            this.pic_search.Location = new System.Drawing.Point(19, 367);
            this.pic_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_search.Name = "pic_search";
            this.pic_search.Size = new System.Drawing.Size(25, 21);
            this.pic_search.TabIndex = 33;
            this.pic_search.TabStop = false;
            // 
            // btnRestoran
            // 
            this.btnRestoran.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.btnRestoran.FlatAppearance.BorderSize = 2;
            this.btnRestoran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoran.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoran.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRestoran.Image = global::DatabaseHotelUas.Properties.Resources.restaurant_jpg;
            this.btnRestoran.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestoran.Location = new System.Drawing.Point(12, 249);
            this.btnRestoran.Name = "btnRestoran";
            this.btnRestoran.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRestoran.Size = new System.Drawing.Size(252, 70);
            this.btnRestoran.TabIndex = 32;
            this.btnRestoran.Text = "     Restoran";
            this.btnRestoran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestoran.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestoran.UseVisualStyleBackColor = true;
            this.btnRestoran.Click += new System.EventHandler(this.btnRestoran_Click);
            // 
            // btnKamar
            // 
            this.btnKamar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.btnKamar.FlatAppearance.BorderSize = 2;
            this.btnKamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKamar.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKamar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKamar.Image = global::DatabaseHotelUas.Properties.Resources.hotel_jpg;
            this.btnKamar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKamar.Location = new System.Drawing.Point(12, 173);
            this.btnKamar.Name = "btnKamar";
            this.btnKamar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnKamar.Size = new System.Drawing.Size(252, 70);
            this.btnKamar.TabIndex = 31;
            this.btnKamar.Text = "     Kamar";
            this.btnKamar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKamar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKamar.UseVisualStyleBackColor = true;
            this.btnKamar.Click += new System.EventHandler(this.btnKamar_Click);
            // 
            // tb_cariMenu
            // 
            this.tb_cariMenu.BackColor = System.Drawing.SystemColors.Info;
            this.tb_cariMenu.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cariMenu.Location = new System.Drawing.Point(50, 366);
            this.tb_cariMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_cariMenu.Name = "tb_cariMenu";
            this.tb_cariMenu.Size = new System.Drawing.Size(203, 24);
            this.tb_cariMenu.TabIndex = 34;
            this.tb_cariMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_cariMenu.TextChanged += new System.EventHandler(this.tb_cariMenu_TextChanged);
            this.tb_cariMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_cariMenu_KeyDown);
            // 
            // btnRiwayatTransaksi
            // 
            this.btnRiwayatTransaksi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.btnRiwayatTransaksi.FlatAppearance.BorderSize = 2;
            this.btnRiwayatTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiwayatTransaksi.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiwayatTransaksi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRiwayatTransaksi.Image = global::DatabaseHotelUas.Properties.Resources.clipboard_jpg;
            this.btnRiwayatTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRiwayatTransaksi.Location = new System.Drawing.Point(12, 97);
            this.btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            this.btnRiwayatTransaksi.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRiwayatTransaksi.Size = new System.Drawing.Size(252, 70);
            this.btnRiwayatTransaksi.TabIndex = 1;
            this.btnRiwayatTransaksi.Text = "     Transaksi";
            this.btnRiwayatTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRiwayatTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRiwayatTransaksi.UseVisualStyleBackColor = true;
            this.btnRiwayatTransaksi.Click += new System.EventHandler(this.btnRiwayatTransaksi_Click);
            // 
            // btnPelanggan
            // 
            this.btnPelanggan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.btnPelanggan.FlatAppearance.BorderSize = 2;
            this.btnPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPelanggan.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPelanggan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPelanggan.Image = global::DatabaseHotelUas.Properties.Resources.user_removebg_000_preview_jpg__1_;
            this.btnPelanggan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPelanggan.Location = new System.Drawing.Point(12, 21);
            this.btnPelanggan.Name = "btnPelanggan";
            this.btnPelanggan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPelanggan.Size = new System.Drawing.Size(252, 70);
            this.btnPelanggan.TabIndex = 0;
            this.btnPelanggan.Text = "     Pelanggan";
            this.btnPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPelanggan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPelanggan.UseVisualStyleBackColor = true;
            this.btnPelanggan.Click += new System.EventHandler(this.btnPelanggan_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(141)))), ((int)(((byte)(64)))));
            this.button1.CausesValidation = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(1018, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 46);
            this.button1.TabIndex = 24;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1064, 121);
            this.panel3.TabIndex = 31;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(425, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "D\'Mario, All Rights Reserved";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BackgroundImage = global::DatabaseHotelUas.Properties.Resources.D_Mario_hotel;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(59, -9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 147);
            this.panel2.TabIndex = 0;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 3000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // btn_cekidPelanggan
            // 
            this.btn_cekidPelanggan.Location = new System.Drawing.Point(23, 32);
            this.btn_cekidPelanggan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cekidPelanggan.Name = "btn_cekidPelanggan";
            this.btn_cekidPelanggan.Size = new System.Drawing.Size(140, 43);
            this.btn_cekidPelanggan.TabIndex = 14;
            this.btn_cekidPelanggan.Text = "Cek ID Pelanggan";
            this.btn_cekidPelanggan.UseVisualStyleBackColor = true;
            // 
            // btn_tmbhPelanggan
            // 
            this.btn_tmbhPelanggan.Location = new System.Drawing.Point(244, 32);
            this.btn_tmbhPelanggan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tmbhPelanggan.Name = "btn_tmbhPelanggan";
            this.btn_tmbhPelanggan.Size = new System.Drawing.Size(140, 43);
            this.btn_tmbhPelanggan.TabIndex = 15;
            this.btn_tmbhPelanggan.Text = "Tambah Pelanggan";
            this.btn_tmbhPelanggan.UseVisualStyleBackColor = true;
            this.btn_tmbhPelanggan.Click += new System.EventHandler(this.btn_tmbhPelanggan_Click);
            // 
            // gb_pelanggan
            // 
            this.gb_pelanggan.BackColor = System.Drawing.Color.Transparent;
            this.gb_pelanggan.Controls.Add(this.btn_tmbhPelanggan);
            this.gb_pelanggan.Controls.Add(this.btn_cekidPelanggan);
            this.gb_pelanggan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gb_pelanggan.Location = new System.Drawing.Point(299, 381);
            this.gb_pelanggan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_pelanggan.Name = "gb_pelanggan";
            this.gb_pelanggan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_pelanggan.Size = new System.Drawing.Size(409, 86);
            this.gb_pelanggan.TabIndex = 15;
            this.gb_pelanggan.TabStop = false;
            this.gb_pelanggan.Text = "Pelanggan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(276, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 415);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelDarkMode
            // 
            this.panelDarkMode.BackColor = System.Drawing.Color.Black;
            this.panelDarkMode.Location = new System.Drawing.Point(981, 497);
            this.panelDarkMode.Name = "panelDarkMode";
            this.panelDarkMode.Size = new System.Drawing.Size(64, 27);
            this.panelDarkMode.TabIndex = 2;
            // 
            // panelTombolDarkMode
            // 
            this.panelTombolDarkMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTombolDarkMode.Location = new System.Drawing.Point(990, 502);
            this.panelTombolDarkMode.Name = "panelTombolDarkMode";
            this.panelTombolDarkMode.Size = new System.Drawing.Size(23, 17);
            this.panelTombolDarkMode.TabIndex = 32;
            this.panelTombolDarkMode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // timermode6
            // 
            this.timermode6.Interval = 25;
            this.timermode6.Tick += new System.EventHandler(this.timermode6_Tick);
            // 
            // timermode7
            // 
            this.timermode7.Interval = 10;
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 536);
            this.Controls.Add(this.panelTombolDarkMode);
            this.Controls.Add(this.panelDarkMode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_jamWIB);
            this.Controls.Add(this.lbl_waktu);
            this.Controls.Add(this.lbl_hargaHotel);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.lb_hargaKamar);
            this.Controls.Add(this.gb_pelanggan);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_main";
            this.Text = "D\'Mario Hotel ";
            this.Load += new System.EventHandler(this.form_main_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_crossmark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gb_pelanggan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lb_hargaKamar;
        private System.Windows.Forms.Label lbl_hargaHotel;
        private System.Windows.Forms.Label lbl_waktu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_jamWIB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPelanggan;
        private System.Windows.Forms.Button btnKamar;
        private System.Windows.Forms.Button btnRiwayatTransaksi;
        private System.Windows.Forms.Button btnRestoran;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pic_crossmark;
        private System.Windows.Forms.TextBox tb_cariMenu;
        private System.Windows.Forms.PictureBox pic_search;
        private System.Windows.Forms.Button btn_cekidPelanggan;
        private System.Windows.Forms.Button btn_tmbhPelanggan;
        private System.Windows.Forms.GroupBox gb_pelanggan;
        private System.Windows.Forms.Panel panelDarkMode;
        private System.Windows.Forms.Panel panelTombolDarkMode;
        private System.Windows.Forms.Timer timermode6;
        private System.Windows.Forms.Timer timermode7;
    }
}

