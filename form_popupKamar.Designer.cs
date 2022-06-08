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
            this.SuspendLayout();
            // 
            // lbl_no_kamar
            // 
            this.lbl_no_kamar.AutoSize = true;
            this.lbl_no_kamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_no_kamar.Location = new System.Drawing.Point(23, 28);
            this.lbl_no_kamar.Name = "lbl_no_kamar";
            this.lbl_no_kamar.Size = new System.Drawing.Size(113, 46);
            this.lbl_no_kamar.TabIndex = 0;
            this.lbl_no_kamar.Text = "A101";
            // 
            // form_popupKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_no_kamar);
            this.Name = "form_popupKamar";
            this.Text = "form_popupKamar";
            this.Load += new System.EventHandler(this.form_popupKamar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_no_kamar;
    }
}