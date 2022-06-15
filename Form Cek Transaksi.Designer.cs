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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cek_Transaksi));
            this.dgv_cekTransBlmLunas = new System.Windows.Forms.DataGridView();
            this.btn_prosesCekTransaksi = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lblJenisTransaksi = new System.Windows.Forms.Label();
            this.cBoxBookKamar = new System.Windows.Forms.CheckBox();
            this.cBoxOrderResto = new System.Windows.Forms.CheckBox();
            this.dgv_SemuaTransaksi = new System.Windows.Forms.DataGridView();
            this.lblTransBelumLunas = new System.Windows.Forms.Label();
            this.lblSemuaTransaksi = new System.Windows.Forms.Label();
            this.dgv_SemuaTransaksi2 = new System.Windows.Forms.DataGridView();
            this.dgv_cekTransBlmLunas2 = new System.Windows.Forms.DataGridView();
            this.lblBookingKamar = new System.Windows.Forms.Label();
            this.lblOrderResto = new System.Windows.Forms.Label();
            this.lblBookingKamar2 = new System.Windows.Forms.Label();
            this.lblOrderResto2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cekTransBlmLunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SemuaTransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SemuaTransaksi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cekTransBlmLunas2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cekTransBlmLunas
            // 
            this.dgv_cekTransBlmLunas.AllowUserToAddRows = false;
            this.dgv_cekTransBlmLunas.AllowUserToDeleteRows = false;
            this.dgv_cekTransBlmLunas.AllowUserToResizeColumns = false;
            this.dgv_cekTransBlmLunas.AllowUserToResizeRows = false;
            this.dgv_cekTransBlmLunas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cekTransBlmLunas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_cekTransBlmLunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cekTransBlmLunas.Location = new System.Drawing.Point(10, 51);
            this.dgv_cekTransBlmLunas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_cekTransBlmLunas.Name = "dgv_cekTransBlmLunas";
            this.dgv_cekTransBlmLunas.RowHeadersWidth = 62;
            this.dgv_cekTransBlmLunas.RowTemplate.Height = 28;
            this.dgv_cekTransBlmLunas.Size = new System.Drawing.Size(1086, 108);
            this.dgv_cekTransBlmLunas.TabIndex = 0;
            // 
            // btn_prosesCekTransaksi
            // 
            this.btn_prosesCekTransaksi.Location = new System.Drawing.Point(66, 736);
            this.btn_prosesCekTransaksi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_prosesCekTransaksi.Name = "btn_prosesCekTransaksi";
            this.btn_prosesCekTransaksi.Size = new System.Drawing.Size(124, 36);
            this.btn_prosesCekTransaksi.TabIndex = 7;
            this.btn_prosesCekTransaksi.Text = "Proses";
            this.btn_prosesCekTransaksi.UseVisualStyleBackColor = true;
            this.btn_prosesCekTransaksi.Click += new System.EventHandler(this.btn_prosesCekTransaksi_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(965, 736);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(124, 36);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Keluar";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lblJenisTransaksi
            // 
            this.lblJenisTransaksi.AutoSize = true;
            this.lblJenisTransaksi.Location = new System.Drawing.Point(62, 711);
            this.lblJenisTransaksi.Name = "lblJenisTransaksi";
            this.lblJenisTransaksi.Size = new System.Drawing.Size(105, 16);
            this.lblJenisTransaksi.TabIndex = 9;
            this.lblJenisTransaksi.Text = "Jenis Transaksi:";
            // 
            // cBoxBookKamar
            // 
            this.cBoxBookKamar.AutoSize = true;
            this.cBoxBookKamar.Location = new System.Drawing.Point(190, 710);
            this.cBoxBookKamar.Name = "cBoxBookKamar";
            this.cBoxBookKamar.Size = new System.Drawing.Size(121, 20);
            this.cBoxBookKamar.TabIndex = 10;
            this.cBoxBookKamar.Text = "Booking Kamar";
            this.cBoxBookKamar.UseVisualStyleBackColor = true;
            // 
            // cBoxOrderResto
            // 
            this.cBoxOrderResto.AutoSize = true;
            this.cBoxOrderResto.Location = new System.Drawing.Point(322, 710);
            this.cBoxOrderResto.Name = "cBoxOrderResto";
            this.cBoxOrderResto.Size = new System.Drawing.Size(102, 20);
            this.cBoxOrderResto.TabIndex = 11;
            this.cBoxOrderResto.Text = "Order Resto";
            this.cBoxOrderResto.UseVisualStyleBackColor = true;
            // 
            // dgv_SemuaTransaksi
            // 
            this.dgv_SemuaTransaksi.AllowUserToAddRows = false;
            this.dgv_SemuaTransaksi.AllowUserToDeleteRows = false;
            this.dgv_SemuaTransaksi.AllowUserToResizeColumns = false;
            this.dgv_SemuaTransaksi.AllowUserToResizeRows = false;
            this.dgv_SemuaTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SemuaTransaksi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_SemuaTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SemuaTransaksi.Location = new System.Drawing.Point(10, 350);
            this.dgv_SemuaTransaksi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_SemuaTransaksi.Name = "dgv_SemuaTransaksi";
            this.dgv_SemuaTransaksi.RowHeadersWidth = 62;
            this.dgv_SemuaTransaksi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_SemuaTransaksi.RowTemplate.Height = 28;
            this.dgv_SemuaTransaksi.Size = new System.Drawing.Size(1086, 159);
            this.dgv_SemuaTransaksi.TabIndex = 12;
            // 
            // lblTransBelumLunas
            // 
            this.lblTransBelumLunas.AutoSize = true;
            this.lblTransBelumLunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransBelumLunas.Location = new System.Drawing.Point(12, 8);
            this.lblTransBelumLunas.Name = "lblTransBelumLunas";
            this.lblTransBelumLunas.Size = new System.Drawing.Size(108, 20);
            this.lblTransBelumLunas.TabIndex = 13;
            this.lblTransBelumLunas.Text = "Belum Lunas";
            // 
            // lblSemuaTransaksi
            // 
            this.lblSemuaTransaksi.AutoSize = true;
            this.lblSemuaTransaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemuaTransaksi.Location = new System.Drawing.Point(11, 307);
            this.lblSemuaTransaksi.Name = "lblSemuaTransaksi";
            this.lblSemuaTransaksi.Size = new System.Drawing.Size(139, 20);
            this.lblSemuaTransaksi.TabIndex = 14;
            this.lblSemuaTransaksi.Text = "Semua Transaksi";
            // 
            // dgv_SemuaTransaksi2
            // 
            this.dgv_SemuaTransaksi2.AllowUserToAddRows = false;
            this.dgv_SemuaTransaksi2.AllowUserToDeleteRows = false;
            this.dgv_SemuaTransaksi2.AllowUserToResizeColumns = false;
            this.dgv_SemuaTransaksi2.AllowUserToResizeRows = false;
            this.dgv_SemuaTransaksi2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SemuaTransaksi2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_SemuaTransaksi2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SemuaTransaksi2.Location = new System.Drawing.Point(10, 535);
            this.dgv_SemuaTransaksi2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_SemuaTransaksi2.Name = "dgv_SemuaTransaksi2";
            this.dgv_SemuaTransaksi2.RowHeadersWidth = 62;
            this.dgv_SemuaTransaksi2.RowTemplate.Height = 28;
            this.dgv_SemuaTransaksi2.Size = new System.Drawing.Size(1086, 165);
            this.dgv_SemuaTransaksi2.TabIndex = 15;
            // 
            // dgv_cekTransBlmLunas2
            // 
            this.dgv_cekTransBlmLunas2.AllowUserToAddRows = false;
            this.dgv_cekTransBlmLunas2.AllowUserToDeleteRows = false;
            this.dgv_cekTransBlmLunas2.AllowUserToResizeColumns = false;
            this.dgv_cekTransBlmLunas2.AllowUserToResizeRows = false;
            this.dgv_cekTransBlmLunas2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cekTransBlmLunas2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_cekTransBlmLunas2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cekTransBlmLunas2.Location = new System.Drawing.Point(10, 184);
            this.dgv_cekTransBlmLunas2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_cekTransBlmLunas2.Name = "dgv_cekTransBlmLunas2";
            this.dgv_cekTransBlmLunas2.RowHeadersWidth = 62;
            this.dgv_cekTransBlmLunas2.RowTemplate.Height = 28;
            this.dgv_cekTransBlmLunas2.Size = new System.Drawing.Size(1086, 108);
            this.dgv_cekTransBlmLunas2.TabIndex = 16;
            // 
            // lblBookingKamar
            // 
            this.lblBookingKamar.AutoSize = true;
            this.lblBookingKamar.Location = new System.Drawing.Point(15, 331);
            this.lblBookingKamar.Name = "lblBookingKamar";
            this.lblBookingKamar.Size = new System.Drawing.Size(99, 16);
            this.lblBookingKamar.TabIndex = 17;
            this.lblBookingKamar.Text = "Booking Kamar";
            // 
            // lblOrderResto
            // 
            this.lblOrderResto.AutoSize = true;
            this.lblOrderResto.Location = new System.Drawing.Point(15, 515);
            this.lblOrderResto.Name = "lblOrderResto";
            this.lblOrderResto.Size = new System.Drawing.Size(80, 16);
            this.lblOrderResto.TabIndex = 18;
            this.lblOrderResto.Text = "Order Resto";
            // 
            // lblBookingKamar2
            // 
            this.lblBookingKamar2.AutoSize = true;
            this.lblBookingKamar2.Location = new System.Drawing.Point(16, 32);
            this.lblBookingKamar2.Name = "lblBookingKamar2";
            this.lblBookingKamar2.Size = new System.Drawing.Size(99, 16);
            this.lblBookingKamar2.TabIndex = 19;
            this.lblBookingKamar2.Text = "Booking Kamar";
            // 
            // lblOrderResto2
            // 
            this.lblOrderResto2.AutoSize = true;
            this.lblOrderResto2.Location = new System.Drawing.Point(16, 164);
            this.lblOrderResto2.Name = "lblOrderResto2";
            this.lblOrderResto2.Size = new System.Drawing.Size(80, 16);
            this.lblOrderResto2.TabIndex = 20;
            this.lblOrderResto2.Text = "Order Resto";
            // 
            // Form_Cek_Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 779);
            this.Controls.Add(this.lblOrderResto2);
            this.Controls.Add(this.lblBookingKamar2);
            this.Controls.Add(this.lblOrderResto);
            this.Controls.Add(this.lblBookingKamar);
            this.Controls.Add(this.dgv_cekTransBlmLunas2);
            this.Controls.Add(this.dgv_SemuaTransaksi2);
            this.Controls.Add(this.lblSemuaTransaksi);
            this.Controls.Add(this.lblTransBelumLunas);
            this.Controls.Add(this.dgv_SemuaTransaksi);
            this.Controls.Add(this.cBoxOrderResto);
            this.Controls.Add(this.cBoxBookKamar);
            this.Controls.Add(this.lblJenisTransaksi);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_prosesCekTransaksi);
            this.Controls.Add(this.dgv_cekTransBlmLunas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Cek_Transaksi";
            this.Text = "Cek Transaksi";
            this.Load += new System.EventHandler(this.Form_Cek_Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cekTransBlmLunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SemuaTransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SemuaTransaksi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cekTransBlmLunas2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cekTransBlmLunas;
        private System.Windows.Forms.Button btn_prosesCekTransaksi;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lblJenisTransaksi;
        private System.Windows.Forms.CheckBox cBoxBookKamar;
        private System.Windows.Forms.CheckBox cBoxOrderResto;
        private System.Windows.Forms.DataGridView dgv_SemuaTransaksi;
        private System.Windows.Forms.Label lblTransBelumLunas;
        private System.Windows.Forms.Label lblSemuaTransaksi;
        private System.Windows.Forms.DataGridView dgv_SemuaTransaksi2;
        private System.Windows.Forms.DataGridView dgv_cekTransBlmLunas2;
        private System.Windows.Forms.Label lblBookingKamar;
        private System.Windows.Forms.Label lblOrderResto;
        private System.Windows.Forms.Label lblBookingKamar2;
        private System.Windows.Forms.Label lblOrderResto2;
    }
}