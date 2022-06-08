namespace DatabaseHotelUas
{
    partial class form_invoiceResto
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
            this.DGV_InvoiceResto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InvoiceResto)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_InvoiceResto
            // 
            this.DGV_InvoiceResto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_InvoiceResto.Location = new System.Drawing.Point(1, 141);
            this.DGV_InvoiceResto.Name = "DGV_InvoiceResto";
            this.DGV_InvoiceResto.RowHeadersWidth = 62;
            this.DGV_InvoiceResto.RowTemplate.Height = 28;
            this.DGV_InvoiceResto.Size = new System.Drawing.Size(816, 534);
            this.DGV_InvoiceResto.TabIndex = 0;
            this.DGV_InvoiceResto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_InvoiceResto_CellContentClick);
            // 
            // form_invoiceResto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 676);
            this.Controls.Add(this.DGV_InvoiceResto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "form_invoiceResto";
            this.Text = "Invoice Restoran";
            this.Load += new System.EventHandler(this.form_invoiceResto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InvoiceResto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_InvoiceResto;
    }
}