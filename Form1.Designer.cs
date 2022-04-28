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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_parkir = new System.Windows.Forms.CheckBox();
            this.cb_restoran = new System.Windows.Forms.CheckBox();
            this.cb_fasilitaskamar = new System.Windows.Forms.CheckBox();
            this.tgl_checkin = new System.Windows.Forms.DateTimePicker();
            this.lbl_testTanggal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(606, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama Pelanggan: ";
            // 
            // cb_parkir
            // 
            this.cb_parkir.AutoSize = true;
            this.cb_parkir.Location = new System.Drawing.Point(46, 225);
            this.cb_parkir.Name = "cb_parkir";
            this.cb_parkir.Size = new System.Drawing.Size(75, 24);
            this.cb_parkir.TabIndex = 3;
            this.cb_parkir.Text = "Parkir";
            this.cb_parkir.UseVisualStyleBackColor = true;
            this.cb_parkir.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cb_restoran
            // 
            this.cb_restoran.AutoSize = true;
            this.cb_restoran.Location = new System.Drawing.Point(46, 365);
            this.cb_restoran.Name = "cb_restoran";
            this.cb_restoran.Size = new System.Drawing.Size(101, 24);
            this.cb_restoran.TabIndex = 4;
            this.cb_restoran.Text = "Restoran";
            this.cb_restoran.UseVisualStyleBackColor = true;
            // 
            // cb_fasilitaskamar
            // 
            this.cb_fasilitaskamar.AutoSize = true;
            this.cb_fasilitaskamar.Location = new System.Drawing.Point(46, 294);
            this.cb_fasilitaskamar.Name = "cb_fasilitaskamar";
            this.cb_fasilitaskamar.Size = new System.Drawing.Size(143, 24);
            this.cb_fasilitaskamar.TabIndex = 5;
            this.cb_fasilitaskamar.Text = "Fasilitas Kamar";
            this.cb_fasilitaskamar.UseVisualStyleBackColor = true;
            // 
            // tgl_checkin
            // 
            this.tgl_checkin.Location = new System.Drawing.Point(235, 159);
            this.tgl_checkin.Name = "tgl_checkin";
            this.tgl_checkin.Size = new System.Drawing.Size(304, 26);
            this.tgl_checkin.TabIndex = 7;
            this.tgl_checkin.ValueChanged += new System.EventHandler(this.tgl_checkin_ValueChanged);
            // 
            // lbl_testTanggal
            // 
            this.lbl_testTanggal.AutoSize = true;
            this.lbl_testTanggal.Location = new System.Drawing.Point(231, 188);
            this.lbl_testTanggal.Name = "lbl_testTanggal";
            this.lbl_testTanggal.Size = new System.Drawing.Size(21, 20);
            this.lbl_testTanggal.TabIndex = 8;
            this.lbl_testTanggal.Text = "...";
            this.lbl_testTanggal.Click += new System.EventHandler(this.lbl_testTanggal_Click);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 539);
            this.Controls.Add(this.lbl_testTanggal);
            this.Controls.Add(this.tgl_checkin);
            this.Controls.Add(this.cb_fasilitaskamar);
            this.Controls.Add(this.cb_restoran);
            this.Controls.Add(this.cb_parkir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_main";
            this.Text = "HOTEL CALIFORNIA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_parkir;
        private System.Windows.Forms.CheckBox cb_restoran;
        private System.Windows.Forms.CheckBox cb_fasilitaskamar;
        private System.Windows.Forms.DateTimePicker tgl_checkin;
        private System.Windows.Forms.Label lbl_testTanggal;
    }
}

