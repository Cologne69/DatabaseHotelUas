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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_historiRestoran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_historiRestoran
            // 
            this.DGV_historiRestoran.AllowUserToAddRows = false;
            this.DGV_historiRestoran.AllowUserToDeleteRows = false;
            this.DGV_historiRestoran.AllowUserToResizeColumns = false;
            this.DGV_historiRestoran.AllowUserToResizeRows = false;
            this.DGV_historiRestoran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_historiRestoran.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_historiRestoran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_historiRestoran.Location = new System.Drawing.Point(12, 136);
            this.DGV_historiRestoran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV_historiRestoran.MultiSelect = false;
            this.DGV_historiRestoran.Name = "DGV_historiRestoran";
            this.DGV_historiRestoran.RowHeadersVisible = false;
            this.DGV_historiRestoran.RowHeadersWidth = 62;
            this.DGV_historiRestoran.RowTemplate.Height = 28;
            this.DGV_historiRestoran.ShowCellErrors = false;
            this.DGV_historiRestoran.ShowCellToolTips = false;
            this.DGV_historiRestoran.ShowEditingIcon = false;
            this.DGV_historiRestoran.ShowRowErrors = false;
            this.DGV_historiRestoran.Size = new System.Drawing.Size(837, 428);
            this.DGV_historiRestoran.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(298, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "HISTORI RESTORAN";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(141)))), ((int)(((byte)(64)))));
            this.label1.CausesValidation = false;
            this.label1.FlatAppearance.BorderSize = 0;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(819, -5);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 46);
            this.label1.TabIndex = 26;
            this.label1.Text = "x";
            this.label1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DatabaseHotelUas.Properties.Resources.D_Mario_hotel;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 129);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // form_historiRestoran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(862, 574);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_historiRestoran);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_historiRestoran";
            this.Text = "Histori Pemesanan Restoran";
            this.Load += new System.EventHandler(this.form_historiRestoran_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_historiRestoran_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_historiRestoran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_historiRestoran;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}