namespace DatabaseHotelUas
{
    partial class form_resto
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_pesan = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_daftar = new System.Windows.Forms.Label();
            this.cb_pilihMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_jumlahMenu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(697, 586);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 33);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_pesan
            // 
            this.btn_pesan.Location = new System.Drawing.Point(12, 586);
            this.btn_pesan.Name = "btn_pesan";
            this.btn_pesan.Size = new System.Drawing.Size(91, 33);
            this.btn_pesan.TabIndex = 2;
            this.btn_pesan.Text = "Pesan";
            this.btn_pesan.UseVisualStyleBackColor = true;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 259);
            this.dataGridView1.TabIndex = 3;
            // 
            // lbl_daftar
            // 
            this.lbl_daftar.AutoSize = true;
            this.lbl_daftar.Location = new System.Drawing.Point(345, 19);
            this.lbl_daftar.Name = "lbl_daftar";
            this.lbl_daftar.Size = new System.Drawing.Size(98, 20);
            this.lbl_daftar.TabIndex = 4;
            this.lbl_daftar.Text = "Daftar Menu";
            this.lbl_daftar.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_pilihMenu
            // 
            this.cb_pilihMenu.FormattingEnabled = true;
            this.cb_pilihMenu.Location = new System.Drawing.Point(56, 385);
            this.cb_pilihMenu.Name = "cb_pilihMenu";
            this.cb_pilihMenu.Size = new System.Drawing.Size(687, 28);
            this.cb_pilihMenu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pilih Menu: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jumlah Menu: ";
            // 
            // cb_jumlahMenu
            // 
            this.cb_jumlahMenu.Location = new System.Drawing.Point(56, 470);
            this.cb_jumlahMenu.Name = "cb_jumlahMenu";
            this.cb_jumlahMenu.Size = new System.Drawing.Size(124, 26);
            this.cb_jumlahMenu.TabIndex = 8;
            this.cb_jumlahMenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_jumlahMenu_KeyPress);
            // 
            // form_resto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.cb_jumlahMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_pilihMenu);
            this.Controls.Add(this.lbl_daftar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_pesan);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_resto";
            this.Text = "Form Restoran";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_pesan;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_daftar;
        private System.Windows.Forms.ComboBox cb_pilihMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cb_jumlahMenu;
    }
}