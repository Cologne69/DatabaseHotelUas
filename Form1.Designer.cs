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
            this.tgl_checkin = new System.Windows.Forms.DateTimePicker();
            this.lbl_chkin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tgl_checkout = new System.Windows.Forms.DateTimePicker();
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
            this.textBox1.Location = new System.Drawing.Point(46, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(606, 26);
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
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 539);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tgl_checkout);
            this.Controls.Add(this.lbl_chkin);
            this.Controls.Add(this.tgl_checkin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_main";
            this.Text = "Form Hotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tgl_checkin;
        private System.Windows.Forms.Label lbl_chkin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tgl_checkout;
    }
}

