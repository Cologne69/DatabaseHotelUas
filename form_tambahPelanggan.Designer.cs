namespace DatabaseHotelUas
{
    partial class form_tambahPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_tambahPelanggan));
            this.btn_exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_namaPelanggan = new System.Windows.Forms.TextBox();
            this.rdb_Laki = new System.Windows.Forms.RadioButton();
            this.rdb_Perempuan = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_KotaPelanggan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_idPelanggan = new System.Windows.Forms.TextBox();
            this.btn_tambahPelanggan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(781, 352);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(114, 36);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Lengkap: ";
            // 
            // txt_namaPelanggan
            // 
            this.txt_namaPelanggan.Location = new System.Drawing.Point(197, 93);
            this.txt_namaPelanggan.Name = "txt_namaPelanggan";
            this.txt_namaPelanggan.Size = new System.Drawing.Size(634, 26);
            this.txt_namaPelanggan.TabIndex = 3;
            this.txt_namaPelanggan.TextChanged += new System.EventHandler(this.txt_namaPelanggan_TextChanged);
            // 
            // rdb_Laki
            // 
            this.rdb_Laki.AutoSize = true;
            this.rdb_Laki.Location = new System.Drawing.Point(197, 155);
            this.rdb_Laki.Name = "rdb_Laki";
            this.rdb_Laki.Size = new System.Drawing.Size(91, 24);
            this.rdb_Laki.TabIndex = 4;
            this.rdb_Laki.TabStop = true;
            this.rdb_Laki.Text = "Laki-laki";
            this.rdb_Laki.UseVisualStyleBackColor = true;
            // 
            // rdb_Perempuan
            // 
            this.rdb_Perempuan.AutoSize = true;
            this.rdb_Perempuan.Location = new System.Drawing.Point(367, 155);
            this.rdb_Perempuan.Name = "rdb_Perempuan";
            this.rdb_Perempuan.Size = new System.Drawing.Size(116, 24);
            this.rdb_Perempuan.TabIndex = 5;
            this.rdb_Perempuan.TabStop = true;
            this.rdb_Perempuan.Text = "Perempuan";
            this.rdb_Perempuan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jenis Kelamin: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kota: ";
            // 
            // txt_KotaPelanggan
            // 
            this.txt_KotaPelanggan.Location = new System.Drawing.Point(197, 208);
            this.txt_KotaPelanggan.Name = "txt_KotaPelanggan";
            this.txt_KotaPelanggan.Size = new System.Drawing.Size(634, 26);
            this.txt_KotaPelanggan.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID / NIK Pelanggan: ";
            // 
            // txt_idPelanggan
            // 
            this.txt_idPelanggan.Location = new System.Drawing.Point(197, 264);
            this.txt_idPelanggan.Name = "txt_idPelanggan";
            this.txt_idPelanggan.Size = new System.Drawing.Size(341, 26);
            this.txt_idPelanggan.TabIndex = 10;
            this.txt_idPelanggan.TextChanged += new System.EventHandler(this.txt_idPelanggan_TextChanged);
            this.txt_idPelanggan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idPelanggan_KeyPress);
            // 
            // btn_tambahPelanggan
            // 
            this.btn_tambahPelanggan.Location = new System.Drawing.Point(383, 323);
            this.btn_tambahPelanggan.Name = "btn_tambahPelanggan";
            this.btn_tambahPelanggan.Size = new System.Drawing.Size(169, 46);
            this.btn_tambahPelanggan.TabIndex = 11;
            this.btn_tambahPelanggan.Text = "Tambah Pelanggan";
            this.btn_tambahPelanggan.UseVisualStyleBackColor = true;
            this.btn_tambahPelanggan.Click += new System.EventHandler(this.btn_tambahPelanggan_Click);
            // 
            // form_tambahPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 400);
            this.Controls.Add(this.btn_tambahPelanggan);
            this.Controls.Add(this.txt_idPelanggan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_KotaPelanggan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdb_Perempuan);
            this.Controls.Add(this.rdb_Laki);
            this.Controls.Add(this.txt_namaPelanggan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_tambahPelanggan";
            this.Text = "Tambah Pelanggan";
            this.Load += new System.EventHandler(this.form_tambahPelanggan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_namaPelanggan;
        private System.Windows.Forms.RadioButton rdb_Laki;
        private System.Windows.Forms.RadioButton rdb_Perempuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_KotaPelanggan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_idPelanggan;
        private System.Windows.Forms.Button btn_tambahPelanggan;
    }
}