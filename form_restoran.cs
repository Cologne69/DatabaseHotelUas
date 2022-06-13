using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DatabaseHotelUas
{
    public partial class form_resto : Form
    {
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        int maxorderID = 0;
        DataTable Pelanggan = new DataTable();
        DataTable Menu = new DataTable();
        DataTable Invoice = new DataTable();
        DataTable Checkout = new DataTable();
        public form_resto()
        {
            InitializeComponent();
        }
        private void btn_pesan_Click(object sender, EventArgs e)
        {
            try
            {
                cb_pelanggan.Enabled = false;
                lbl_isiiteminCart.Text = (jumlahOrderID() + 1).ToString();

                sqlQuery = $"INSERT INTO DETAIL_ORDER_MENU VALUES('{maxorderID}', '{DGV_Menu.CurrentRow.Cells[0].Value.ToString()}','{num_jumlahMakanan.Value}' , (SELECT SUM({num_jumlahMakanan.Value} * MENU.MENU_HARGA) FROM MENU WHERE MENU.MENU_ID = '{DGV_Menu.CurrentRow.Cells[0].Value.ToString()}'))";
                commandAndadapter();
                sqlCommand.ExecuteNonQuery();

                lbl_totalHarga.Text = "Rp. " + totalHargaOrder().ToString();

                Invoice = new DataTable();
                sqlQuery = $"SELECT M.MENU_NAMA as`Nama Menu` , D.ORDER_QTY as `Jumlah Menu`, M.MENU_HARGA as `Harga Menu`, D.ORDER_PRICE AS `Sub-Total` FROM DETAIL_ORDER_MENU D, MENU M WHERE M.MENU_ID = D.MENU_ID AND ORDER_ID= '{maxORDER_ID()}';";
                commandAndadapter();
                sqlAdapter.Fill(Invoice);
                DGV_invoice.DataSource = Invoice;
               
                if (jumlahOrderID() > 0)
                {
                    btn_checkout.Enabled = true;
                }
                else if (jumlahOrderID() == 0)
                {
                    btn_checkout.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void commandAndadapter()
        {
            sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
        }
        public int jumlahOrderID()
        {
            try
            {
                sqlQuery = $"SELECT COUNT(ORDER_ID) FROM DETAIL_ORDER_MENU WHERE ORDER_ID = {maxorderID}";
                commandAndadapter();
                return Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public int totalHargaOrder()
        {
            try
            {
                sqlQuery = $"SELECT SUM(ORDER_PRICE) FROM DETAIL_ORDER_MENU WHERE ORDER_ID = {maxorderID}";
                commandAndadapter();
                return Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

        }

        public int maxORDER_ID()
        {
            try
            {
                sqlQuery = $"select MAX(CAST(ORDER_ID as SIGNED)) from ORDER_FOOD";
                commandAndadapter();
                return Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private void form_resto_Load(object sender, EventArgs e)
        {
            DGV_Menu.RowTemplate.MinimumHeight = 35;
            cb_pelanggan.Enabled = true;
            DGV_invoice.DataSource = Invoice;
            maxorderID = maxORDER_ID() + 1;
            num_jumlahMakanan.Value = 1;
            lbl_isiiteminCart.Text = "0";
            lbl_totalHarga.Text = "0";
            Menu.Clear();
            lbl_isiOrderID.Text = maxorderID.ToString();

            Invoice.Clear();
            Pelanggan.Clear();
            try
            {
                sqlQuery = $"SELECT `MENU_ID` AS 'ID MENU', `MENU_NAMA` AS 'NAMA MENU', CONCAT('Rp. ',`MENU_HARGA`) AS 'HARGA MENU' FROM MENU";
                commandAndadapter();
                sqlAdapter.Fill(Menu);
                DGV_Menu.DataSource = Menu;
                
                sqlQuery = $"SELECT CONCAT(CUST_NAMA,' - ',CUST_ID) as 'id dan nama', CUST_ID as 'nama' FROM CUSTOMER ORDER BY 2 DESC";
                commandAndadapter();
                sqlAdapter.Fill(Pelanggan);
                
                cb_pelanggan.DataSource = Pelanggan;
                cb_pelanggan.DisplayMember = "id dan nama";
                cb_pelanggan.ValueMember = "nama";
                DGV_Menu.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGV_Menu.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGV_Menu.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
                for (int i = 0; i <= DGV_Menu.Columns.Count - 1; i++)
                {
                    // Store Auto Sized Widths:
                    int colw = DGV_Menu.Columns[i].Width;

                    // Remove AutoSizing:
                    DGV_Menu.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                    // Set Width to calculated AutoSize value:
                    DGV_Menu.Columns[i].Width = colw;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void btn_checkout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin untuk melakukan Checkout pesanan?", "Checkout Restoran", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Invoice.Clear();

                    sqlQuery = $"INSERT INTO ORDER_FOOD VALUES ('{maxORDER_ID() + 1}','{form_main.transID + 1}','{cb_pelanggan.SelectedValue.ToString()}', date_format(now(),'%Y-%m-%d') , null , (SELECT COUNT(ORDER_ID) FROM DETAIL_ORDER_MENU WHERE ORDER_ID = '{maxORDER_ID()}') , (select sum(ORDER_PRICE) FROM DETAIL_ORDER_MENU WHERE ORDER_ID = '{maxORDER_ID()}'),0);";
                    commandAndadapter();
                    sqlCommand.ExecuteNonQuery();
                    
                    maxorderID++;

                    MessageBox.Show($"Pesanan dengan ID: {maxorderID - 1} berhasil di Checkout");
                    lbl_isiOrderID.Text = maxorderID.ToString();
                    lbl_isiiteminCart.Text = "0";
                    lbl_totalHarga.Text = "0";

                    sqlQuery = $"INSERT INTO TRANS_SETTLEMENT VALUES ('{form_main.transID + 1}', date_format(now(),'%Y-%m-%d') , (select sum(ORDER_PRICE) FROM DETAIL_ORDER_MENU WHERE ORDER_ID = '{maxORDER_ID()}') , 'Transaksi Restoran', 0);";
                    commandAndadapter();
                    sqlAdapter.Fill(Checkout);
                    form_main.transID++;
                    btn_cancelPelanggan.Enabled = false;
                    cb_pelanggan.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void form_resto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin untuk menutup sebelum Checkout pesanan?", "Tutup Pemesanan", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                sqlQuery = $"DELETE FROM DETAIL_ORDER_MENU WHERE ORDER_ID = '{maxorderID}'";
                commandAndadapter();
                sqlCommand.ExecuteNonQuery();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin mengganti Pelanggan?", "Ganti", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cb_pelanggan.Enabled = true;
                Invoice.Clear();
                Invoice = new DataTable();
                sqlQuery = $"DELETE FROM DETAIL_ORDER_MENU WHERE ORDER_ID = '{maxorderID}'";
                commandAndadapter();
                sqlCommand.ExecuteNonQuery();
                lbl_isiiteminCart.Text = "0";
                lbl_totalHarga.Text = "0";
            }
            else
            {

            }
        }
    }
}
