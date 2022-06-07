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
        DataTable tempData = new DataTable();
        int orderID = 1;
        int totalCart = 0;
        DataTable Pelanggan = new DataTable();
        public form_resto()
        {
            InitializeComponent();
        }
        

        private void btn_exit_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void btn_pesan_Click(object sender, EventArgs e)
        {
            try
            {
                sqlAdapter.Fill(OrderID);
                totalCart++;
                lbl_isiiteminCart.Text = totalCart.ToString();

                sqlQuery = $"SELECT SUM(ORDER_PRICE) FROM DETAIL_ORDER_MENU WHERE ORDER_ID = '{orderID}'";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                lbl_totalHarga.Text = sqlQuery;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        new DataTable Menu = new DataTable();
        new DataTable OrderID = new DataTable();


        private void cb_pilihMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void form_resto_Load(object sender, EventArgs e)
        {
            num_jumlahMakanan.Value = 1;
            Menu.Clear();
            OrderID.Clear();
            lbl_isiOrderID.Text = orderID.ToString();

            try
            {
                sqlQuery = $"SELECT * FROM MENU";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(Menu);
                DGV_Menu.DataSource = Menu;
                
                sqlQuery = $"SELECT CONCAT(CUST_ID,' - ', CUST_NAMA) as 'id dan nama', CUST_ID as 'nama' FROM CUSTOMER";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(Pelanggan);
                cb_pelanggan.DataSource = Pelanggan;
                cb_pelanggan.DisplayMember = "id dan nama";
                cb_pelanggan.ValueMember = "nama";
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());   
            }

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
                    sqlQuery = $"INSERT INTO DETAIL_ORDER_MENU VALUES ('{orderID}','{DGV_Menu.CurrentRow.Cells[0].Value.ToString()}','{num_jumlahMakanan.Value}',(SELECT SUM({num_jumlahMakanan.Value} * MENU.MENU_HARGA) FROM MENU WHERE MENU.MENU_ID = '{DGV_Menu.CurrentRow.Cells[0].Value.ToString()}'))";
                    sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    
                    sqlQuery = $"INSERT INTO ORDER_FOOD VALUES ('O{orderID.ToString()}','{form_main.transID.ToString()}','{cb_pelanggan.SelectedValue}','{DateTime.Now.ToString("yyyy-MM-dd")}',null,'{totalCart}',(select sum(ORDER_PRICE) FROM DETAIL_ORDER_MENU WHERE ORDER_ID = '{orderID}'),'0');";
                    sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(OrderID);
                    orderID++;
                    MessageBox.Show($"Pesanan dengan ID: {orderID.ToString()} berhasil di Checkout");
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
    }
}
