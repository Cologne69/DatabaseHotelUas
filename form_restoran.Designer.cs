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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_resto));
            this.btn_addtoCart = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.DGV_Menu = new System.Windows.Forms.DataGridView();
            this.lbl_daftar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_jumlahMakanan = new System.Windows.Forms.NumericUpDown();
            this.lbl_iteminCart = new System.Windows.Forms.Label();
            this.lbl_isiiteminCart = new System.Windows.Forms.Label();
            this.lbl_orderID = new System.Windows.Forms.Label();
            this.lbl_isiOrderID = new System.Windows.Forms.Label();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.cb_pelanggan = new System.Windows.Forms.ComboBox();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.lbl_totalHarga = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.DGV_invoice = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_jumlahMakanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addtoCart
            // 
            this.btn_addtoCart.Location = new System.Drawing.Point(349, 524);
            this.btn_addtoCart.Name = "btn_addtoCart";
            this.btn_addtoCart.Size = new System.Drawing.Size(165, 45);
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
            this.DGV_Menu.Location = new System.Drawing.Point(12, 59);
            this.DGV_Menu.Name = "DGV_Menu";
            this.DGV_Menu.RowHeadersWidth = 62;
            this.DGV_Menu.RowTemplate.Height = 28;
            this.DGV_Menu.Size = new System.Drawing.Size(776, 319);
            this.DGV_Menu.TabIndex = 3;
            this.DGV_Menu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Menu_CellContentClick);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jumlah Menu: ";
            // 
            // num_jumlahMakanan
            // 
            this.num_jumlahMakanan.Location = new System.Drawing.Point(57, 534);
            this.num_jumlahMakanan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_jumlahMakanan.Name = "num_jumlahMakanan";
            this.num_jumlahMakanan.Size = new System.Drawing.Size(120, 26);
            this.num_jumlahMakanan.TabIndex = 8;
            this.num_jumlahMakanan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_jumlahMakanan.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lbl_iteminCart
            // 
            this.lbl_iteminCart.AutoSize = true;
            this.lbl_iteminCart.Location = new System.Drawing.Point(195, 673);
            this.lbl_iteminCart.Name = "lbl_iteminCart";
            this.lbl_iteminCart.Size = new System.Drawing.Size(103, 20);
            this.lbl_iteminCart.TabIndex = 9;
            this.lbl_iteminCart.Text = "Menu di Cart:";
            // 
            // lbl_isiiteminCart
            // 
            this.lbl_isiiteminCart.AutoSize = true;
            this.lbl_isiiteminCart.Location = new System.Drawing.Point(304, 673);
            this.lbl_isiiteminCart.Name = "lbl_isiiteminCart";
            this.lbl_isiiteminCart.Size = new System.Drawing.Size(18, 20);
            this.lbl_isiiteminCart.TabIndex = 10;
            this.lbl_isiiteminCart.Text = "0";
            // 
            // lbl_orderID
            // 
            this.lbl_orderID.AutoSize = true;
            this.lbl_orderID.Location = new System.Drawing.Point(220, 653);
            this.lbl_orderID.Name = "lbl_orderID";
            this.lbl_orderID.Size = new System.Drawing.Size(78, 20);
            this.lbl_orderID.TabIndex = 11;
            this.lbl_orderID.Text = "Order ID: ";
            // 
            // lbl_isiOrderID
            // 
            this.lbl_isiOrderID.AutoSize = true;
            this.lbl_isiOrderID.Location = new System.Drawing.Point(304, 653);
            this.lbl_isiOrderID.Name = "lbl_isiOrderID";
            this.lbl_isiOrderID.Size = new System.Drawing.Size(18, 20);
            this.lbl_isiOrderID.TabIndex = 12;
            this.lbl_isiOrderID.Text = "0";
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(574, 525);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(170, 44);
            this.btn_checkout.TabIndex = 13;
            this.btn_checkout.Text = "Checkout";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // cb_pelanggan
            // 
            this.cb_pelanggan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_pelanggan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_pelanggan.FormattingEnabled = true;
            this.cb_pelanggan.Location = new System.Drawing.Point(57, 437);
            this.cb_pelanggan.Name = "cb_pelanggan";
            this.cb_pelanggan.Size = new System.Drawing.Size(687, 28);
            this.cb_pelanggan.TabIndex = 14;
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Location = new System.Drawing.Point(53, 414);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(139, 20);
            this.lbl_nama.TabIndex = 15;
            this.lbl_nama.Text = "Nama Pelanggan: ";
            // 
            // lbl_totalHarga
            // 
            this.lbl_totalHarga.AutoSize = true;
            this.lbl_totalHarga.Location = new System.Drawing.Point(539, 653);
            this.lbl_totalHarga.Name = "lbl_totalHarga";
            this.lbl_totalHarga.Size = new System.Drawing.Size(18, 20);
            this.lbl_totalHarga.TabIndex = 17;
            this.lbl_totalHarga.Text = "0";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(433, 653);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(100, 20);
            this.lbl_total.TabIndex = 16;
            this.lbl_total.Text = "Total Harga: ";
            // 
            // DGV_invoice
            // 
            this.DGV_invoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_invoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_invoice.Location = new System.Drawing.Point(12, 731);
            this.DGV_invoice.Name = "DGV_invoice";
            this.DGV_invoice.RowHeadersWidth = 62;
            this.DGV_invoice.RowTemplate.Height = 28;
            this.DGV_invoice.Size = new System.Drawing.Size(776, 579);
            this.DGV_invoice.TabIndex = 18;
            // 
            // form_resto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 731);
            this.Controls.Add(this.DGV_invoice);
            this.Controls.Add(this.lbl_totalHarga);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_nama);
            this.Controls.Add(this.cb_pelanggan);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.lbl_isiOrderID);
            this.Controls.Add(this.lbl_orderID);
            this.Controls.Add(this.lbl_isiiteminCart);
            this.Controls.Add(this.lbl_iteminCart);
            this.Controls.Add(this.num_jumlahMakanan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_daftar);
            this.Controls.Add(this.DGV_Menu);
            this.Controls.Add(this.btn_addtoCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_resto";
            this.Text = "Form Restoran";
            this.Load += new System.EventHandler(this.form_resto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_jumlahMakanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_invoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_addtoCart;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.DataGridView DGV_Menu;
        private System.Windows.Forms.Label lbl_daftar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_jumlahMakanan;
        private System.Windows.Forms.Label lbl_iteminCart;
        private System.Windows.Forms.Label lbl_isiiteminCart;
        private System.Windows.Forms.Label lbl_orderID;
        private System.Windows.Forms.Label lbl_isiOrderID;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.ComboBox cb_pelanggan;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label lbl_totalHarga;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.DataGridView DGV_invoice;
    }
}