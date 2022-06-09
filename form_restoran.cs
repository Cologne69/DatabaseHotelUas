using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DatabaseHotelUas
{
    public partial class form_resto : Form
    {

        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        int maxorderID = 0;
        DataTable Pelanggan = new DataTable();
        DataTable Pesanan = new DataTable();
        DataTable Menu = new DataTable();
        DataTable Invoice = new DataTable();
        public form_resto()
        {
            InitializeComponent();
        }
        



        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        
        private void btn_pesan_Click(object sender, EventArgs e)
        {
            try
            { 
                this.Height = 750;
 
                lbl_isiiteminCart.Text = jumlahDataMenu().ToString();
                sqlQuery = $"INSERT INTO DETAIL_ORDER_MENU VALUES('{maxorderID}', '{DGV_Menu.CurrentRow.Cells[0].Value.ToString()}','{num_jumlahMakanan.Value}' , (SELECT SUM({num_jumlahMakanan.Value} * MENU.MENU_HARGA) FROM MENU WHERE MENU.MENU_ID = '{DGV_Menu.CurrentRow.Cells[0].Value.ToString()}'))";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(Pesanan);

                sqlQuery = $"SELECT M.MENU_NAMA as`Nama Menu` , D.ORDER_QTY as `Jumlah Menu`, M.MENU_HARGA as `Harga Menu`, D.ORDER_PRICE AS `Sub-Total` FROM DETAIL_ORDER_MENU D, MENU M WHERE M.MENU_ID = D.MENU_ID;";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(Invoice);
                DGV_invoice.DataSource = Invoice;
                lbl_totalHarga.Text = totalHargaOrder().ToString();
                Invoice.Clear();

                if(totalHargaOrder() > 0)
                {
                    btn_checkout.Enabled = true;
                }
                else if (totalHargaOrder() == 0)
                {
                    btn_checkout.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
     
        
        private void cb_pilihMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public int jumlahOrderID()
        {
            try
            {
                sqlQuery = $"SELECT COUNT(ORDER_ID) FROM DETAIL_ORDER_MENU WHERE ORDER_ID = {maxorderID}";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
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
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                return Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        } 
        public int jumlahDataMenu()
        {
            try
            {
                sqlQuery = $"SELECT COUNT(ORDER_ID) FROM DETAIL_ORDER_MENU WHERE ORDER_ID = {maxorderID}";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
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

                sqlQuery = $"SELECT MAX(ORDER_ID) FROM DETAIL_ORDER_MENU";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
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
            
            maxorderID = maxORDER_ID() + 1;
            num_jumlahMakanan.Value = 1;
            lbl_isiiteminCart.Text = "0";
            lbl_totalHarga.Text = "0";
            Menu.Clear();
            lbl_isiOrderID.Text = maxorderID.ToString();
            this.Height = 500;
            Pesanan.Clear();
            Invoice.Clear();
            try
            {
                //label1.Text = DGV_Menu.CurrentRow.Cells[0].Value.ToString();
                sqlQuery = $"SELECT * FROM MENU";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(Menu);
                DGV_Menu.DataSource = Menu;
                
                sqlQuery = $"SELECT CONCAT(CUST_NAMA,' - ',CUST_ID) as 'id dan nama', CUST_ID as 'nama' FROM CUSTOMER ORDER BY 2 DESC";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(Pelanggan);
                cb_pelanggan.DataSource = Pelanggan;
                cb_pelanggan.DisplayMember = "id dan nama";
                cb_pelanggan.ValueMember = "nama";

                DGV_Menu.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGV_Menu.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGV_Menu.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void cb_jumlahMenu_TextChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
       
        }
        
        private void btn_checkout_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Apakah anda yakin untuk melakukan Checkout pesanan?", "Checkout Restoran", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    this.Height = 500;
                    Pesanan.Clear();
                    Invoice.Clear();
                    DGV_invoice.DataSource = Invoice;
                    sqlQuery = $"INSERT INTO ORDER_FOOD VALUES ('{maxorderID}','{form_main.transID.ToString()}','{cb_pelanggan.SelectedValue.ToString()}', date_format(now(), '%Y-%m-%d') , null , (SELECT COUNT(ORDER_ID) FROM DETAIL_ORDER_MENU WHERE ORDER_ID = {maxorderID}) , (select sum(ORDER_PRICE) FROM DETAIL_ORDER_MENU WHERE ORDER_ID = '{maxorderID}'),0);";
                    sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    maxorderID++;
                    MessageBox.Show($"Pesanan dengan ID: {maxorderID-1} berhasil di Checkout");
                    lbl_isiOrderID.Text = maxorderID.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void DGV_Menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_Menu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void form_resto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Apakah anda yakin untuk menutup sebelum Checkout pesanan?", "Tutup Pemesanan", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sqlQuery = $"DELETE FROM DETAIL_ORDER_MENU WHERE ORDER_ID = '{maxorderID}'";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(Pesanan);
            }
        }
    }
}
