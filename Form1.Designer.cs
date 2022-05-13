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
            this.btn_bookKamar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tgl_checkin = new System.Windows.Forms.DateTimePicker();
            this.lbl_chkin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tgl_checkout = new System.Windows.Forms.DateTimePicker();
            this.btn_checktrans = new System.Windows.Forms.Button();
            this.gb_kamar = new System.Windows.Forms.GroupBox();
            this.btn_lihatkamar = new System.Windows.Forms.Button();
            this.gb_kamar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_bookKamar
            // 
            this.btn_bookKamar.Location = new System.Drawing.Point(46, 442);
            this.btn_bookKamar.Name = "btn_bookKamar";
            this.btn_bookKamar.Size = new System.Drawing.Size(158, 54);
            this.btn_bookKamar.TabIndex = 0;
            this.btn_bookKamar.Text = "Book Kamar";
            this.btn_bookKamar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(822, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama Pelanggan: ";
            // 
            // tgl_checkin
            // 
            this.tgl_checkin.Location = new System.Drawing.Point(46, 201);
            this.tgl_checkin.Name = "tgl_checkin";
            this.tgl_checkin.Size = new System.Drawing.Size(277, 26);
            this.tgl_checkin.TabIndex = 7;
            this.tgl_checkin.ValueChanged += new System.EventHandler(this.tgl_checkin_ValueChanged);
            // 
            // lbl_chkin
            // 
            this.lbl_chkin.AutoSize = true;
            this.lbl_chkin.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chkin.Location = new System.Drawing.Point(41, 159);
            this.lbl_chkin.Name = "lbl_chkin";
            this.lbl_chkin.Size = new System.Drawing.Size(200, 25);
            this.lbl_chkin.TabIndex = 8;
            this.lbl_chkin.Text = "Tanggal Check-In: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tanggal Check-Out: ";
            // 
            // tgl_checkout
            // 
            this.tgl_checkout.Location = new System.Drawing.Point(46, 287);
            this.tgl_checkout.Name = "tgl_checkout";
            this.tgl_checkout.Size = new System.Drawing.Size(277, 26);
            this.tgl_checkout.TabIndex = 9;
            // 
            // btn_checktrans
            // 
            this.btn_checktrans.Location = new System.Drawing.Point(226, 442);
            this.btn_checktrans.Name = "btn_checktrans";
            this.btn_checktrans.Size = new System.Drawing.Size(158, 54);
            this.btn_checktrans.TabIndex = 11;
            this.btn_checktrans.Text = "Cek Transaksi";
            this.btn_checktrans.UseVisualStyleBackColor = true;
            this.btn_checktrans.Click += new System.EventHandler(this.button2_Click);
            // 
            // gb_kamar
            // 
            this.gb_kamar.Controls.Add(this.btn_lihatkamar);
            this.gb_kamar.Location = new System.Drawing.Point(437, 201);
            this.gb_kamar.Name = "gb_kamar";
            this.gb_kamar.Size = new System.Drawing.Size(460, 315);
            this.gb_kamar.TabIndex = 12;
            this.gb_kamar.TabStop = false;
            this.gb_kamar.Text = "Kamar";
            // 
            // btn_lihatkamar
            // 
            this.btn_lihatkamar.Location = new System.Drawing.Point(26, 31);
            this.btn_lihatkamar.Name = "btn_lihatkamar";
            this.btn_lihatkamar.Size = new System.Drawing.Size(158, 54);
            this.btn_lihatkamar.TabIndex = 13;
            this.btn_lihatkamar.Text = "Lihat Kamar";
            this.btn_lihatkamar.UseVisualStyleBackColor = true;
            this.btn_lihatkamar.Click += new System.EventHandler(this.btn_lihatkamar_Click);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 539);
            this.Controls.Add(this.gb_kamar);
            this.Controls.Add(this.btn_checktrans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tgl_checkout);
            this.Controls.Add(this.lbl_chkin);
            this.Controls.Add(this.tgl_checkin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_bookKamar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_main";
            this.Text = "Form Hotel";
            this.gb_kamar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bookKamar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tgl_checkin;
        private System.Windows.Forms.Label lbl_chkin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tgl_checkout;
        private System.Windows.Forms.Button btn_checktrans;
        private System.Windows.Forms.GroupBox gb_kamar;
        private System.Windows.Forms.Button btn_lihatkamar;
    }
}

