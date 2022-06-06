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
    public partial class form_idPelanggan : Form
    {
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        new DataTable pelanggan = new DataTable();

        public form_idPelanggan()
        {
            InitializeComponent();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void form_idPelanggan_Load(object sender, EventArgs e)
        {
            pelanggan.Clear();
            try
            {
                sqlQuery = $"SELECT * FROM CUSTOMER";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(pelanggan);
                dataGridView1.DataSource = pelanggan;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void txt_cariNamaPelanggan_TextChanged(object sender, EventArgs e)
        {
            pelanggan.DefaultView.RowFilter = string.Format("CUST_NAMA LIKE '%{0}%'", txt_cariNamaPelanggan.Text);
        }
        private void btn_cariNama_Click(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
