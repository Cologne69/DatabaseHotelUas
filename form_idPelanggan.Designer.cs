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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(759, 639);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(96, 35);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txt_cariNamaPelanggan
            // 
            this.txt_cariNamaPelanggan.Location = new System.Drawing.Point(109, 52);
            this.txt_cariNamaPelanggan.Name = "txt_cariNamaPelanggan";
            this.txt_cariNamaPelanggan.Size = new System.Drawing.Size(574, 26);
            this.txt_cariNamaPelanggan.TabIndex = 2;
            this.txt_cariNamaPelanggan.TextChanged += new System.EventHandler(this.txt_cariNamaPelanggan_TextChanged);
            // 
            // lbl_cariNama
            // 
            this.lbl_cariNama.AutoSize = true;
            this.lbl_cariNama.Location = new System.Drawing.Point(12, 52);
            this.lbl_cariNama.Name = "lbl_cariNama";
            this.lbl_cariNama.Size = new System.Drawing.Size(91, 20);
            this.lbl_cariNama.TabIndex = 3;
            this.lbl_cariNama.Text = "Cari Nama: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(845, 512);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_deletePelanggan
            // 
            this.btn_deletePelanggan.Location = new System.Drawing.Point(699, 48);
            this.btn_deletePelanggan.Name = "btn_deletePelanggan";
            this.btn_deletePelanggan.Size = new System.Drawing.Size(156, 35);
            this.btn_deletePelanggan.TabIndex = 4;
            this.btn_deletePelanggan.Text = "Hapus Pelanggan";
            this.btn_deletePelanggan.UseVisualStyleBackColor = true;
            this.btn_deletePelanggan.Click += new System.EventHandler(this.btn_deletePelanggan_Click);
            // 
            // form_idPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 686);
            this.Controls.Add(this.btn_deletePelanggan);
            this.Controls.Add(this.lbl_cariNama);
            this.Controls.Add(this.txt_cariNamaPelanggan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_idPelanggan";
            this.Text = "Cek ID Pelanggan";
            this.Load += new System.EventHandler(this.form_idPelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_cariNamaPelanggan;
        private System.Windows.Forms.Label lbl_cariNama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_deletePelanggan;
    }
}