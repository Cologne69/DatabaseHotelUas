namespace DatabaseHotelUas
{
    partial class form_popupKamar
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
            this.lbl_no_kamar = new System.Windows.Forms.Label();
            this.lbl_tipe_kamar = new System.Windows.Forms.Label();
            this.lbl_fasilitas = new System.Windows.Forms.Label();
            this.lbl_list_fasilitas = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.lbl_check_in = new System.Windows.Forms.Label();
            this.txt_check_in = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_no_kamar
            // 
            this.lbl_no_kamar.AutoSize = true;
            this.lbl_no_kamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_no_kamar.Location = new System.Drawing.Point(21, 23);
            this.lbl_no_kamar.Name = "lbl_no_kamar";
            this.lbl_no_kamar.Size = new System.Drawing.Size(127, 51);
            this.lbl_no_kamar.TabIndex = 0;
            this.lbl_no_kamar.Text = "A101";
            // 
            // lbl_tipe_kamar
            // 
            this.lbl_tipe_kamar.AutoSize = true;
            this.lbl_tipe_kamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipe_kamar.Location = new System.Drawing.Point(25, 75);
            this.lbl_tipe_kamar.Name = "lbl_tipe_kamar";
            this.lbl_tipe_kamar.Size = new System.Drawing.Size(144, 25);
            this.lbl_tipe_kamar.TabIndex = 1;
            this.lbl_tipe_kamar.Text = "President Suite";
            // 
            // lbl_fasilitas
            // 
            this.lbl_fasilitas.AutoSize = true;
            this.lbl_fasilitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fasilitas.Location = new System.Drawing.Point(25, 131);
            this.lbl_fasilitas.Name = "lbl_fasilitas";
            this.lbl_fasilitas.Size = new System.Drawing.Size(118, 29);
            this.lbl_fasilitas.TabIndex = 2;
            this.lbl_fasilitas.Text = "Fasilitas:";
            // 
            // lbl_list_fasilitas
            // 
            this.lbl_list_fasilitas.AutoSize = true;
            this.lbl_list_fasilitas.Location = new System.Drawing.Point(27, 160);
            this.lbl_list_fasilitas.Name = "lbl_list_fasilitas";
            this.lbl_list_fasilitas.Size = new System.Drawing.Size(94, 48);
            this.lbl_list_fasilitas.TabIndex = 3;
            this.lbl_list_fasilitas.Text = "1. Makan enak\r\n2. Minum air\r\n3. Hirup udara";
            // 
            // txt_nama
            // 
            this.txt_nama.Enabled = false;
            this.txt_nama.Location = new System.Drawing.Point(454, 20);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(271, 22);
            this.txt_nama.TabIndex = 4;
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Location = new System.Drawing.Point(373, 23);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(62, 16);
            this.lbl_nama.TabIndex = 5;
            this.lbl_nama.Text = "Nama/id:";
            // 
            // lbl_check_in
            // 
            this.lbl_check_in.AutoSize = true;
            this.lbl_check_in.Location = new System.Drawing.Point(372, 107);
            this.lbl_check_in.Name = "lbl_check_in";
            this.lbl_check_in.Size = new System.Drawing.Size(61, 16);
            this.lbl_check_in.TabIndex = 6;
            this.lbl_check_in.Text = "Check in:";
            // 
            // txt_check_in
            // 
            this.txt_check_in.Enabled = false;
            this.txt_check_in.Location = new System.Drawing.Point(454, 104);
            this.txt_check_in.Name = "txt_check_in";
            this.txt_check_in.Size = new System.Drawing.Size(271, 22);
            this.txt_check_in.TabIndex = 9;
            // 
            // form_popupKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_check_in);
            this.Controls.Add(this.lbl_check_in);
            this.Controls.Add(this.lbl_nama);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.lbl_list_fasilitas);
            this.Controls.Add(this.lbl_fasilitas);
            this.Controls.Add(this.lbl_tipe_kamar);
            this.Controls.Add(this.lbl_no_kamar);
            this.Name = "form_popupKamar";
            this.Text = "j";
            this.Load += new System.EventHandler(this.form_popupKamar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_no_kamar;
        private System.Windows.Forms.Label lbl_tipe_kamar;
        private System.Windows.Forms.Label lbl_fasilitas;
        private System.Windows.Forms.Label lbl_list_fasilitas;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label lbl_check_in;
        private System.Windows.Forms.TextBox txt_check_in;
    }
}