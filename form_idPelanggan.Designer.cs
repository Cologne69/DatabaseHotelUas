﻿namespace DatabaseHotelUas
{
    partial class form_idPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_idPelanggan));
            this.txt_cariNamaPelanggan = new System.Windows.Forms.TextBox();
            this.lbl_cariNama = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_deletePelanggan = new System.Windows.Forms.Button();
            this.btnTambahPelanggan = new System.Windows.Forms.Button();
            this.statusNamaPelanggan = new System.Windows.Forms.PictureBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusNamaPelanggan)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_cariNamaPelanggan
            // 
            this.txt_cariNamaPelanggan.Location = new System.Drawing.Point(97, 127);
            this.txt_cariNamaPelanggan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cariNamaPelanggan.Name = "txt_cariNamaPelanggan";
            this.txt_cariNamaPelanggan.Size = new System.Drawing.Size(449, 22);
            this.txt_cariNamaPelanggan.TabIndex = 2;
            this.txt_cariNamaPelanggan.TextChanged += new System.EventHandler(this.txt_cariNamaPelanggan_TextChanged);
            // 
            // lbl_cariNama
            // 
            this.lbl_cariNama.AutoSize = true;
            this.lbl_cariNama.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cariNama.Location = new System.Drawing.Point(12, 128);
            this.lbl_cariNama.Name = "lbl_cariNama";
            this.lbl_cariNama.Size = new System.Drawing.Size(96, 22);
            this.lbl_cariNama.TabIndex = 3;
            this.lbl_cariNama.Text = "Cari Nama: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 171);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(751, 392);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_deletePelanggan
            // 
            this.btn_deletePelanggan.Location = new System.Drawing.Point(613, 124);
            this.btn_deletePelanggan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deletePelanggan.Name = "btn_deletePelanggan";
            this.btn_deletePelanggan.Size = new System.Drawing.Size(139, 28);
            this.btn_deletePelanggan.TabIndex = 4;
            this.btn_deletePelanggan.Text = "Hapus Pelanggan";
            this.btn_deletePelanggan.UseVisualStyleBackColor = true;
            this.btn_deletePelanggan.Click += new System.EventHandler(this.btn_deletePelanggan_Click);
            // 
            // btnTambahPelanggan
            // 
            this.btnTambahPelanggan.Location = new System.Drawing.Point(611, 124);
            this.btnTambahPelanggan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTambahPelanggan.Name = "btnTambahPelanggan";
            this.btnTambahPelanggan.Size = new System.Drawing.Size(149, 28);
            this.btnTambahPelanggan.TabIndex = 5;
            this.btnTambahPelanggan.Text = "Tambah Pelanggan";
            this.btnTambahPelanggan.UseVisualStyleBackColor = true;
            this.btnTambahPelanggan.Click += new System.EventHandler(this.btnTambahPelanggan_Click);
            // 
            // statusNamaPelanggan
            // 
            this.statusNamaPelanggan.BackColor = System.Drawing.Color.White;
            this.statusNamaPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusNamaPelanggan.Location = new System.Drawing.Point(552, 125);
            this.statusNamaPelanggan.Name = "statusNamaPelanggan";
            this.statusNamaPelanggan.Size = new System.Drawing.Size(25, 25);
            this.statusNamaPelanggan.TabIndex = 6;
            this.statusNamaPelanggan.TabStop = false;
            // 
            // btnProses
            // 
            this.btnProses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.btnProses.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProses.Location = new System.Drawing.Point(611, 120);
            this.btnProses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(149, 36);
            this.btnProses.TabIndex = 7;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = false;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 96);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(141)))), ((int)(((byte)(64)))));
            this.btnExit.CausesValidation = false;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(725, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 37);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DatabaseHotelUas.Properties.Resources.D_Mario_hotel;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(289, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "PELANGGAN";
            // 
            // form_idPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(771, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.statusNamaPelanggan);
            this.Controls.Add(this.btnTambahPelanggan);
            this.Controls.Add(this.btn_deletePelanggan);
            this.Controls.Add(this.lbl_cariNama);
            this.Controls.Add(this.txt_cariNamaPelanggan);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_idPelanggan";
            this.Text = "Cek ID Pelanggan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusNamaPelanggan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_cariNamaPelanggan;
        private System.Windows.Forms.Label lbl_cariNama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_deletePelanggan;
        private System.Windows.Forms.Button btnTambahPelanggan;
        private System.Windows.Forms.PictureBox statusNamaPelanggan;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}