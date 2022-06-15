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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.DGV_Menu = new System.Windows.Forms.DataGridView();
            this.lbl_daftar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_jumlahMakanan = new System.Windows.Forms.NumericUpDown();
            this.lbl_isiiteminCart = new System.Windows.Forms.Label();
            this.lbl_orderID = new System.Windows.Forms.Label();
            this.lbl_isiOrderID = new System.Windows.Forms.Label();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.cb_pelanggan = new System.Windows.Forms.ComboBox();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_totalHarga = new System.Windows.Forms.TextBox();
            this.DGV_invoice = new System.Windows.Forms.DataGridView();
            this.btn_cancelPelanggan = new System.Windows.Forms.Button();
            this.tb_cariMenu = new System.Windows.Forms.TextBox();
            this.btn_addtoCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pic_crossmark = new System.Windows.Forms.PictureBox();
            this.pic_search = new System.Windows.Forms.PictureBox();
            this.pBoxCart = new System.Windows.Forms.PictureBox();
            this.pBoxCart2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_jumlahMakanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_invoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_crossmark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCart2)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // DGV_Menu
            // 
            this.DGV_Menu.AllowUserToAddRows = false;
            this.DGV_Menu.AllowUserToDeleteRows = false;
            this.DGV_Menu.AllowUserToResizeColumns = false;
            this.DGV_Menu.AllowUserToResizeRows = false;
            this.DGV_Menu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Menu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Menu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Menu.Location = new System.Drawing.Point(12, 250);
            this.DGV_Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV_Menu.MultiSelect = false;
            this.DGV_Menu.Name = "DGV_Menu";
            this.DGV_Menu.ReadOnly = true;
            this.DGV_Menu.RowHeadersVisible = false;
            this.DGV_Menu.RowHeadersWidth = 62;
            this.DGV_Menu.RowTemplate.Height = 50;
            this.DGV_Menu.RowTemplate.ReadOnly = true;
            this.DGV_Menu.ShowCellErrors = false;
            this.DGV_Menu.ShowCellToolTips = false;
            this.DGV_Menu.ShowEditingIcon = false;
            this.DGV_Menu.ShowRowErrors = false;
            this.DGV_Menu.Size = new System.Drawing.Size(690, 429);
            this.DGV_Menu.TabIndex = 3;
            // 
            // lbl_daftar
            // 
            this.lbl_daftar.AutoSize = true;
            this.lbl_daftar.Font = new System.Drawing.Font("Bodoni MT Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_daftar.Location = new System.Drawing.Point(27, 205);
            this.lbl_daftar.Name = "lbl_daftar";
            this.lbl_daftar.Size = new System.Drawing.Size(168, 40);
            this.lbl_daftar.TabIndex = 4;
            this.lbl_daftar.Text = "DAFTAR MENU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jumlah Menu: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // num_jumlahMakanan
            // 
            this.num_jumlahMakanan.Location = new System.Drawing.Point(39, 168);
            this.num_jumlahMakanan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_jumlahMakanan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_jumlahMakanan.Name = "num_jumlahMakanan";
            this.num_jumlahMakanan.Size = new System.Drawing.Size(107, 22);
            this.num_jumlahMakanan.TabIndex = 8;
            this.num_jumlahMakanan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_jumlahMakanan.ValueChanged += new System.EventHandler(this.num_jumlahMakanan_ValueChanged);
            // 
            // lbl_isiiteminCart
            // 
            this.lbl_isiiteminCart.AutoSize = true;
            this.lbl_isiiteminCart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_isiiteminCart.Font = new System.Drawing.Font("Bodoni MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_isiiteminCart.Location = new System.Drawing.Point(58, 707);
            this.lbl_isiiteminCart.Name = "lbl_isiiteminCart";
            this.lbl_isiiteminCart.Size = new System.Drawing.Size(19, 22);
            this.lbl_isiiteminCart.TabIndex = 10;
            this.lbl_isiiteminCart.Text = "0";
            this.lbl_isiiteminCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_isiiteminCart.Click += new System.EventHandler(this.lbl_isiiteminCart_Click);
            // 
            // lbl_orderID
            // 
            this.lbl_orderID.AutoSize = true;
            this.lbl_orderID.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderID.Location = new System.Drawing.Point(542, 143);
            this.lbl_orderID.Name = "lbl_orderID";
            this.lbl_orderID.Size = new System.Drawing.Size(75, 22);
            this.lbl_orderID.TabIndex = 11;
            this.lbl_orderID.Text = "Order ID";
            this.lbl_orderID.Click += new System.EventHandler(this.lbl_orderID_Click);
            // 
            // lbl_isiOrderID
            // 
            this.lbl_isiOrderID.AutoSize = true;
            this.lbl_isiOrderID.Font = new System.Drawing.Font("Bodoni MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_isiOrderID.Location = new System.Drawing.Point(568, 165);
            this.lbl_isiOrderID.Name = "lbl_isiOrderID";
            this.lbl_isiOrderID.Size = new System.Drawing.Size(24, 28);
            this.lbl_isiOrderID.TabIndex = 12;
            this.lbl_isiOrderID.Text = "0";
            this.lbl_isiOrderID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_isiOrderID.Click += new System.EventHandler(this.lbl_isiOrderID_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.btn_checkout.Enabled = false;
            this.btn_checkout.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkout.Location = new System.Drawing.Point(1222, 348);
            this.btn_checkout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(166, 43);
            this.btn_checkout.TabIndex = 13;
            this.btn_checkout.Text = "Checkout";
            this.btn_checkout.UseVisualStyleBackColor = false;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // cb_pelanggan
            // 
            this.cb_pelanggan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_pelanggan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_pelanggan.FormattingEnabled = true;
            this.cb_pelanggan.Location = new System.Drawing.Point(34, 97);
            this.cb_pelanggan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_pelanggan.Name = "cb_pelanggan";
            this.cb_pelanggan.Size = new System.Drawing.Size(583, 24);
            this.cb_pelanggan.TabIndex = 14;
            this.cb_pelanggan.SelectedIndexChanged += new System.EventHandler(this.cb_pelanggan_SelectedIndexChanged);
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.Location = new System.Drawing.Point(35, 73);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(140, 22);
            this.lbl_nama.TabIndex = 15;
            this.lbl_nama.Text = "Nama Pelanggan: ";
            this.lbl_nama.Click += new System.EventHandler(this.lbl_nama_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.White;
            this.lbl_total.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(1090, 294);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(126, 26);
            this.lbl_total.TabIndex = 16;
            this.lbl_total.Text = "Total Harga: ";
            // 
            // lbl_totalHarga
            // 
            this.lbl_totalHarga.BackColor = System.Drawing.Color.White;
            this.lbl_totalHarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_totalHarga.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalHarga.Location = new System.Drawing.Point(1222, 294);
            this.lbl_totalHarga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_totalHarga.Name = "lbl_totalHarga";
            this.lbl_totalHarga.Size = new System.Drawing.Size(166, 27);
            this.lbl_totalHarga.TabIndex = 19;
            this.lbl_totalHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DGV_invoice
            // 
            this.DGV_invoice.AllowUserToAddRows = false;
            this.DGV_invoice.AllowUserToDeleteRows = false;
            this.DGV_invoice.AllowUserToResizeColumns = false;
            this.DGV_invoice.AllowUserToResizeRows = false;
            this.DGV_invoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_invoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_invoice.BackgroundColor = System.Drawing.Color.White;
            this.DGV_invoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_invoice.Location = new System.Drawing.Point(712, 63);
            this.DGV_invoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV_invoice.MultiSelect = false;
            this.DGV_invoice.Name = "DGV_invoice";
            this.DGV_invoice.ReadOnly = true;
            this.DGV_invoice.RowHeadersVisible = false;
            this.DGV_invoice.RowHeadersWidth = 62;
            this.DGV_invoice.RowTemplate.Height = 28;
            this.DGV_invoice.ShowCellErrors = false;
            this.DGV_invoice.ShowCellToolTips = false;
            this.DGV_invoice.ShowEditingIcon = false;
            this.DGV_invoice.ShowRowErrors = false;
            this.DGV_invoice.Size = new System.Drawing.Size(690, 270);
            this.DGV_invoice.TabIndex = 18;
            // 
            // btn_cancelPelanggan
            // 
            this.btn_cancelPelanggan.BackColor = System.Drawing.Color.Green;
            this.btn_cancelPelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelPelanggan.ForeColor = System.Drawing.Color.White;
            this.btn_cancelPelanggan.Location = new System.Drawing.Point(621, 94);
            this.btn_cancelPelanggan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelPelanggan.Name = "btn_cancelPelanggan";
            this.btn_cancelPelanggan.Size = new System.Drawing.Size(30, 30);
            this.btn_cancelPelanggan.TabIndex = 20;
            this.btn_cancelPelanggan.Text = "X";
            this.btn_cancelPelanggan.UseVisualStyleBackColor = false;
            this.btn_cancelPelanggan.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_cariMenu
            // 
            this.tb_cariMenu.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cariMenu.Location = new System.Drawing.Point(428, 214);
            this.tb_cariMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_cariMenu.Name = "tb_cariMenu";
            this.tb_cariMenu.Size = new System.Drawing.Size(243, 27);
            this.tb_cariMenu.TabIndex = 23;
            this.tb_cariMenu.Text = "Cari Disini";
            this.tb_cariMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_cariMenu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_addtoCart
            // 
            this.btn_addtoCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.btn_addtoCart.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addtoCart.Location = new System.Drawing.Point(536, 691);
            this.btn_addtoCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addtoCart.Name = "btn_addtoCart";
            this.btn_addtoCart.Size = new System.Drawing.Size(166, 43);
            this.btn_addtoCart.TabIndex = 2;
            this.btn_addtoCart.Text = "Masukkan Ke Cart";
            this.btn_addtoCart.UseVisualStyleBackColor = false;
            this.btn_addtoCart.Click += new System.EventHandler(this.btn_pesan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 40);
            this.label1.TabIndex = 25;
            this.label1.Text = "ORDER RESTORAN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni MT Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(757, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 40);
            this.label3.TabIndex = 26;
            this.label3.Text = "CART";
            // 
            // pic_crossmark
            // 
            this.pic_crossmark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_crossmark.Image = global::DatabaseHotelUas.Properties.Resources.pic_crossmark;
            this.pic_crossmark.Location = new System.Drawing.Point(666, 11);
            this.pic_crossmark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_crossmark.Name = "pic_crossmark";
            this.pic_crossmark.Size = new System.Drawing.Size(36, 32);
            this.pic_crossmark.TabIndex = 24;
            this.pic_crossmark.TabStop = false;
            this.pic_crossmark.Click += new System.EventHandler(this.pic_crossmark_Click);
            // 
            // pic_search
            // 
            this.pic_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_search.Image = ((System.Drawing.Image)(resources.GetObject("pic_search.Image")));
            this.pic_search.Location = new System.Drawing.Point(676, 213);
            this.pic_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_search.Name = "pic_search";
            this.pic_search.Size = new System.Drawing.Size(26, 32);
            this.pic_search.TabIndex = 22;
            this.pic_search.TabStop = false;
            // 
            // pBoxCart
            // 
            this.pBoxCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.pBoxCart.Image = global::DatabaseHotelUas.Properties.Resources.shopping_cart;
            this.pBoxCart.Location = new System.Drawing.Point(21, 690);
            this.pBoxCart.Name = "pBoxCart";
            this.pBoxCart.Size = new System.Drawing.Size(42, 37);
            this.pBoxCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxCart.TabIndex = 27;
            this.pBoxCart.TabStop = false;
            // 
            // pBoxCart2
            // 
            this.pBoxCart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.pBoxCart2.Image = global::DatabaseHotelUas.Properties.Resources.shopping_cart;
            this.pBoxCart2.Location = new System.Drawing.Point(712, 21);
            this.pBoxCart2.Name = "pBoxCart2";
            this.pBoxCart2.Size = new System.Drawing.Size(42, 37);
            this.pBoxCart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxCart2.TabIndex = 28;
            this.pBoxCart2.TabStop = false;
            // 
            // form_resto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1420, 790);
            this.Controls.Add(this.pBoxCart2);
            this.Controls.Add(this.lbl_totalHarga);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.pBoxCart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_crossmark);
            this.Controls.Add(this.tb_cariMenu);
            this.Controls.Add(this.pic_search);
            this.Controls.Add(this.btn_cancelPelanggan);
            this.Controls.Add(this.DGV_invoice);
            this.Controls.Add(this.lbl_nama);
            this.Controls.Add(this.cb_pelanggan);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.lbl_isiOrderID);
            this.Controls.Add(this.lbl_orderID);
            this.Controls.Add(this.num_jumlahMakanan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_daftar);
            this.Controls.Add(this.DGV_Menu);
            this.Controls.Add(this.btn_addtoCart);
            this.Controls.Add(this.lbl_isiiteminCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_resto";
            this.Text = "Form Restoran";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_resto_FormClosing);
            this.Load += new System.EventHandler(this.form_resto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_jumlahMakanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_invoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_crossmark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.DataGridView DGV_Menu;
        private System.Windows.Forms.Label lbl_daftar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_jumlahMakanan;
        private System.Windows.Forms.Label lbl_isiiteminCart;
        private System.Windows.Forms.Label lbl_orderID;
        private System.Windows.Forms.Label lbl_isiOrderID;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.ComboBox cb_pelanggan;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox lbl_totalHarga;
        private System.Windows.Forms.DataGridView DGV_invoice;
        private System.Windows.Forms.Button btn_cancelPelanggan;
        private System.Windows.Forms.PictureBox pic_search;
        private System.Windows.Forms.TextBox tb_cariMenu;
        private System.Windows.Forms.PictureBox pic_crossmark;
        private System.Windows.Forms.Button btn_addtoCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pBoxCart;
        private System.Windows.Forms.PictureBox pBoxCart2;
    }
}