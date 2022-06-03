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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cariNama = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.txt_cariNamaPelanggan.Size = new System.Drawing.Size(549, 26);
            this.txt_cariNamaPelanggan.TabIndex = 2;
            this.txt_cariNamaPelanggan.TextChanged += new System.EventHandler(this.txt_cariNamaPelanggan_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cari Nama: ";
            // 
            // btn_cariNama
            // 
            this.btn_cariNama.Location = new System.Drawing.Point(712, 52);
            this.btn_cariNama.Name = "btn_cariNama";
            this.btn_cariNama.Size = new System.Drawing.Size(125, 26);
            this.btn_cariNama.TabIndex = 4;
            this.btn_cariNama.Text = "Cari ";
            this.btn_cariNama.UseVisualStyleBackColor = true;
            this.btn_cariNama.Click += new System.EventHandler(this.btn_cariNama_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(845, 512);
            this.dataGridView1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 188);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(845, 444);
            this.listBox1.TabIndex = 5;
            // 
            // form_idPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 686);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_cariNama);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cariNama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
    }
}