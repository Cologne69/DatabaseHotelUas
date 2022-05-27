namespace DatabaseHotelUas
{
    partial class Form_Cek_Transaksi
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
            this.dgv_cekTrans = new System.Windows.Forms.DataGridView();
            this.lbl_transCariID = new System.Windows.Forms.Label();
            this.txt_transCariID = new System.Windows.Forms.TextBox();
            this.btn_prosesCekTransaksi = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_statusTrans = new System.Windows.Forms.Label();
            this.txt_statusPembayaran = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cekTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cekTrans
            // 
            this.dgv_cekTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cekTrans.Location = new System.Drawing.Point(12, 12);
            this.dgv_cekTrans.Name = "dgv_cekTrans";
            this.dgv_cekTrans.RowHeadersWidth = 62;
            this.dgv_cekTrans.RowTemplate.Height = 28;
            this.dgv_cekTrans.Size = new System.Drawing.Size(1222, 426);
            this.dgv_cekTrans.TabIndex = 0;
            // 
            // lbl_transCariID
            // 
            this.lbl_transCariID.AutoSize = true;
            this.lbl_transCariID.Location = new System.Drawing.Point(81, 495);
            this.lbl_transCariID.Name = "lbl_transCariID";
            this.lbl_transCariID.Size = new System.Drawing.Size(138, 20);
            this.lbl_transCariID.TabIndex = 4;
            this.lbl_transCariID.Text = "Cari ID Transaksi: ";
            // 
            // txt_transCariID
            // 
            this.txt_transCariID.Location = new System.Drawing.Point(234, 492);
            this.txt_transCariID.Name = "txt_transCariID";
            this.txt_transCariID.Size = new System.Drawing.Size(500, 26);
            this.txt_transCariID.TabIndex = 5;
            // 
            // btn_prosesCekTransaksi
            // 
            this.btn_prosesCekTransaksi.Location = new System.Drawing.Point(12, 611);
            this.btn_prosesCekTransaksi.Name = "btn_prosesCekTransaksi";
            this.btn_prosesCekTransaksi.Size = new System.Drawing.Size(139, 45);
            this.btn_prosesCekTransaksi.TabIndex = 7;
            this.btn_prosesCekTransaksi.Text = "Proses";
            this.btn_prosesCekTransaksi.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1095, 611);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(139, 45);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Keluar";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_statusTrans
            // 
            this.lbl_statusTrans.AutoSize = true;
            this.lbl_statusTrans.Location = new System.Drawing.Point(895, 492);
            this.lbl_statusTrans.Name = "lbl_statusTrans";
            this.lbl_statusTrans.Size = new System.Drawing.Size(157, 20);
            this.lbl_statusTrans.TabIndex = 3;
            this.lbl_statusTrans.Text = "Status Pembayaran: ";
            this.lbl_statusTrans.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_statusPembayaran
            // 
            this.txt_statusPembayaran.Location = new System.Drawing.Point(823, 538);
            this.txt_statusPembayaran.Name = "txt_statusPembayaran";
            this.txt_statusPembayaran.ReadOnly = true;
            this.txt_statusPembayaran.Size = new System.Drawing.Size(303, 26);
            this.txt_statusPembayaran.TabIndex = 6;
            // 
            // Form_Cek_Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 663);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_prosesCekTransaksi);
            this.Controls.Add(this.txt_statusPembayaran);
            this.Controls.Add(this.txt_transCariID);
            this.Controls.Add(this.lbl_transCariID);
            this.Controls.Add(this.lbl_statusTrans);
            this.Controls.Add(this.dgv_cekTrans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Cek_Transaksi";
            this.Text = "Cek Transaksi";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cekTrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cekTrans;
        private System.Windows.Forms.Label lbl_transCariID;
        private System.Windows.Forms.TextBox txt_transCariID;
        private System.Windows.Forms.Button btn_prosesCekTransaksi;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_statusTrans;
        private System.Windows.Forms.TextBox txt_statusPembayaran;
    }
}