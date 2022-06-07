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
        int orderID = 5;
        int totalCart = 0;
        
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
                sqlQuery = $"INSERT INTO DETAIL_ORDER_MENU VALUES ('{orderID}','{cb_pilihMenu.SelectedValue}','{num_jumlahMakanan.Value}',(SELECT SUM({num_jumlahMakanan.Value} * MENU.MENU_HARGA) FROM MENU WHERE MENU.MENU_ID = '{cb_pilihMenu.SelectedValue.ToString()}'))";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(OrderID);
                totalCart++;
                lbl_isiiteminCart.Text = totalCart.ToString(); 
            }
            catch(Exception ex)
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
                sqlQuery = $"SELECT MENU_ID as `ID MENU`, MENU_NAMA as `NAMA MENU`, MENU_HARGA as `HARGA MENU` FROM MENU ORDER BY MENU_NAMA";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(Menu);
                DGV_Menu.DataSource = Menu;
                cb_pilihMenu.DataSource = Menu;
                cb_pilihMenu.DisplayMember = "NAMA MENU";
                cb_pilihMenu.ValueMember = "ID MENU";
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
            
        }

        private void DGV_Menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
