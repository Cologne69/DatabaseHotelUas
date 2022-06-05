namespace DatabaseHotelUas
{
    partial class form_resto
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_addtoCart = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.DGV_Menu = new System.Windows.Forms.DataGridView();
            this.lbl_daftar = new System.Windows.Forms.Label();
            this.cb_pilihMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_jumlahMakanan = new System.Windows.Forms.NumericUpDown();
            this.lbl_iteminCart = new System.Windows.Forms.Label();
            this.lbl_isiiteminCart = new System.Windows.Forms.Label();
            this.lbl_orderID = new System.Windows.Forms.Label();
            this.lbl_isiOrderID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_jumlahMakanan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(697, 586);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 33);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_addtoCart
            // 
            this.btn_addtoCart.Location = new System.Drawing.Point(12, 586);
            this.btn_addtoCart.Name = "btn_addtoCart";
            this.btn_addtoCart.Size = new System.Drawing.Size(165, 33);
            this.btn_addtoCart.TabIndex = 2;
            this.btn_addtoCart.Text = "Masukkan Ke Cart";
            this.btn_addtoCart.UseVisualStyleBackColor = true;
            this.btn_addtoCart.Click += new System.EventHandler(this.btn_pesan_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // DGV_Menu
            // 
            this.DGV_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Menu.Location = new System.Drawing.Point(113, 60);
            this.DGV_Menu.Name = "DGV_Menu";
            this.DGV_Menu.RowHeadersWidth = 62;
            this.DGV_Menu.RowTemplate.Height = 28;
            this.DGV_Menu.Size = new System.Drawing.Size(576, 319);
            this.DGV_Menu.TabIndex = 3;
            // 
            // lbl_daftar
            // 
            this.lbl_daftar.AutoSize = true;
            this.lbl_daftar.Location = new System.Drawing.Point(345, 19);
            this.lbl_daftar.Name = "lbl_daftar";
            this.lbl_daftar.Size = new System.Drawing.Size(98, 20);
            this.lbl_daftar.TabIndex = 4;
            this.lbl_daftar.Text = "Daftar Menu";
            this.lbl_daftar.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_pilihMenu
            // 
            this.cb_pilihMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pilihMenu.FormattingEnabled = true;
            this.cb_pilihMenu.Location = new System.Drawing.Point(57, 438);
            this.cb_pilihMenu.Name = "cb_pilihMenu";
            this.cb_pilihMenu.Size = new System.Drawing.Size(687, 28);
            this.cb_pilihMenu.TabIndex = 5;
            this.cb_pilihMenu.SelectedIndexChanged += new System.EventHandler(this.cb_pilihMenu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pilih Menu: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jumlah Menu: ";
            // 
            // num_jumlahMakanan
            // 
            this.num_jumlahMakanan.Location = new System.Drawing.Point(57, 531);
            this.num_jumlahMakanan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_jumlahMakanan.Name = "num_jumlahMakanan";
            this.num_jumlahMakanan.Size = new System.Drawing.Size(120, 26);
            this.num_jumlahMakanan.TabIndex = 8;
            this.num_jumlahMakanan.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_jumlahMakanan.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lbl_iteminCart
            // 
            this.lbl_iteminCart.AutoSize = true;
            this.lbl_iteminCart.Location = new System.Drawing.Point(195, 592);
            this.lbl_iteminCart.Name = "lbl_iteminCart";
            this.lbl_iteminCart.Size = new System.Drawing.Size(103, 20);
            this.lbl_iteminCart.TabIndex = 9;
            this.lbl_iteminCart.Text = "Menu di Cart:";
            // 
            // lbl_isiiteminCart
            // 
            this.lbl_isiiteminCart.AutoSize = true;
            this.lbl_isiiteminCart.Location = new System.Drawing.Point(304, 592);
            this.lbl_isiiteminCart.Name = "lbl_isiiteminCart";
            this.lbl_isiiteminCart.Size = new System.Drawing.Size(18, 20);
            this.lbl_isiiteminCart.TabIndex = 10;
            this.lbl_isiiteminCart.Text = "0";
            // 
            // lbl_orderID
            // 
            this.lbl_orderID.AutoSize = true;
            this.lbl_orderID.Location = new System.Drawing.Point(220, 572);
            this.lbl_orderID.Name = "lbl_orderID";
            this.lbl_orderID.Size = new System.Drawing.Size(78, 20);
            this.lbl_orderID.TabIndex = 11;
            this.lbl_orderID.Text = "Order ID: ";
            // 
            // lbl_isiOrderID
            // 
            this.lbl_isiOrderID.AutoSize = true;
            this.lbl_isiOrderID.Location = new System.Drawing.Point(304, 572);
            this.lbl_isiOrderID.Name = "lbl_isiOrderID";
            this.lbl_isiOrderID.Size = new System.Drawing.Size(18, 20);
            this.lbl_isiOrderID.TabIndex = 12;
            this.lbl_isiOrderID.Text = "0";
            // 
            // form_resto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.lbl_isiOrderID);
            this.Controls.Add(this.lbl_orderID);
            this.Controls.Add(this.lbl_isiiteminCart);
            this.Controls.Add(this.lbl_iteminCart);
            this.Controls.Add(this.num_jumlahMakanan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_pilihMenu);
            this.Controls.Add(this.lbl_daftar);
            this.Controls.Add(this.DGV_Menu);
            this.Controls.Add(this.btn_addtoCart);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_resto";
            this.Text = "Form Restoran";
            this.Load += new System.EventHandler(this.form_resto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_jumlahMakanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_addtoCart;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.DataGridView DGV_Menu;
        private System.Windows.Forms.Label lbl_daftar;
        private System.Windows.Forms.ComboBox cb_pilihMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_jumlahMakanan;
        private System.Windows.Forms.Label lbl_iteminCart;
        private System.Windows.Forms.Label lbl_isiiteminCart;
        private System.Windows.Forms.Label lbl_orderID;
        private System.Windows.Forms.Label lbl_isiOrderID;
    }
}