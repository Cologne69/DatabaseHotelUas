namespace DatabaseHotelUas
{
    partial class form_historiRestoran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_historiRestoran));
            this.DGV_historiRestoran = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_historiRestoran)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_historiRestoran
            // 
            this.DGV_historiRestoran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_historiRestoran.Location = new System.Drawing.Point(-1, -1);
            this.DGV_historiRestoran.Name = "DGV_historiRestoran";
            this.DGV_historiRestoran.RowHeadersWidth = 62;
            this.DGV_historiRestoran.RowTemplate.Height = 28;
            this.DGV_historiRestoran.Size = new System.Drawing.Size(1227, 526);
            this.DGV_historiRestoran.TabIndex = 0;
            this.DGV_historiRestoran.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_historiRestoran_CellContentClick);
            // 
            // form_historiRestoran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 519);
            this.Controls.Add(this.DGV_historiRestoran);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_historiRestoran";
            this.Text = "Histori Pemesanan Restoran";
            this.Load += new System.EventHandler(this.form_historiRestoran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_historiRestoran)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_historiRestoran;
    }
}