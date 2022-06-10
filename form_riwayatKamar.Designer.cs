
namespace DatabaseHotelUas
{
    partial class form_riwayatKamar
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
            this.lblCariTransID = new System.Windows.Forms.Label();
            this.dgv_riwayatKamar = new System.Windows.Forms.DataGridView();
            this.btnProses = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.cBoxTransID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_riwayatKamar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCariTransID
            // 
            this.lblCariTransID.AutoSize = true;
            this.lblCariTransID.Location = new System.Drawing.Point(37, 25);
            this.lblCariTransID.Name = "lblCariTransID";
            this.lblCariTransID.Size = new System.Drawing.Size(120, 17);
            this.lblCariTransID.TabIndex = 0;
            this.lblCariTransID.Text = "Cari ID Transaksi:";
            // 
            // dgv_riwayatKamar
            // 
            this.dgv_riwayatKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_riwayatKamar.Location = new System.Drawing.Point(40, 60);
            this.dgv_riwayatKamar.Name = "dgv_riwayatKamar";
            this.dgv_riwayatKamar.RowHeadersWidth = 51;
            this.dgv_riwayatKamar.RowTemplate.Height = 24;
            this.dgv_riwayatKamar.Size = new System.Drawing.Size(748, 369);
            this.dgv_riwayatKamar.TabIndex = 2;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(471, 17);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 33);
            this.btnProses.TabIndex = 3;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(703, 446);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(85, 28);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // cBoxTransID
            // 
            this.cBoxTransID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxTransID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxTransID.FormattingEnabled = true;
            this.cBoxTransID.Location = new System.Drawing.Point(172, 22);
            this.cBoxTransID.Name = "cBoxTransID";
            this.cBoxTransID.Size = new System.Drawing.Size(256, 24);
            this.cBoxTransID.TabIndex = 5;
            // 
            // form_riwayatKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 485);
            this.Controls.Add(this.cBoxTransID);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.dgv_riwayatKamar);
            this.Controls.Add(this.lblCariTransID);
            this.Name = "form_riwayatKamar";
            this.Text = "form_riwayatKamar";
            this.Load += new System.EventHandler(this.form_riwayatKamar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_riwayatKamar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCariTransID;
        private System.Windows.Forms.DataGridView dgv_riwayatKamar;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox cBoxTransID;
    }
}