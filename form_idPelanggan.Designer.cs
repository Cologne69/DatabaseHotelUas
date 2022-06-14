namespace DatabaseHotelUas
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_cariNamaPelanggan = new System.Windows.Forms.TextBox();
            this.lbl_cariNama = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_deletePelanggan = new System.Windows.Forms.Button();
            this.btnTambahPelanggan = new System.Windows.Forms.Button();
            this.statusNamaPelanggan = new System.Windows.Forms.PictureBox();
            this.btnProses = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusNamaPelanggan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(675, 511);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(85, 28);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_cariNamaPelanggan
            // 
            this.txt_cariNamaPelanggan.Location = new System.Drawing.Point(97, 42);
            this.txt_cariNamaPelanggan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cariNamaPelanggan.Name = "txt_cariNamaPelanggan";
            this.txt_cariNamaPelanggan.Size = new System.Drawing.Size(474, 22);
            this.txt_cariNamaPelanggan.TabIndex = 2;
            // 
            // lbl_cariNama
            // 
            this.lbl_cariNama.AutoSize = true;
            this.lbl_cariNama.Location = new System.Drawing.Point(11, 42);
            this.lbl_cariNama.Name = "lbl_cariNama";
            this.lbl_cariNama.Size = new System.Drawing.Size(82, 17);
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
            this.dataGridView1.Location = new System.Drawing.Point(11, 108);
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
            this.dataGridView1.Size = new System.Drawing.Size(751, 369);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_deletePelanggan
            // 
            this.btn_deletePelanggan.Location = new System.Drawing.Point(613, 38);
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
            this.btnTambahPelanggan.Location = new System.Drawing.Point(611, 38);
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
            this.statusNamaPelanggan.Location = new System.Drawing.Point(577, 39);
            this.statusNamaPelanggan.Name = "statusNamaPelanggan";
            this.statusNamaPelanggan.Size = new System.Drawing.Size(25, 25);
            this.statusNamaPelanggan.TabIndex = 6;
            this.statusNamaPelanggan.TabStop = false;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(611, 37);
            this.btnProses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(149, 28);
            this.btnProses.TabIndex = 7;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // form_idPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 549);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.statusNamaPelanggan);
            this.Controls.Add(this.btnTambahPelanggan);
            this.Controls.Add(this.btn_deletePelanggan);
            this.Controls.Add(this.lbl_cariNama);
            this.Controls.Add(this.txt_cariNamaPelanggan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_idPelanggan";
            this.Text = "Cek ID Pelanggan";
            this.Load += new System.EventHandler(this.form_idPelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusNamaPelanggan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_cariNamaPelanggan;
        private System.Windows.Forms.Label lbl_cariNama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_deletePelanggan;
        private System.Windows.Forms.Button btnTambahPelanggan;
        private System.Windows.Forms.PictureBox statusNamaPelanggan;
        private System.Windows.Forms.Button btnProses;
    }
}