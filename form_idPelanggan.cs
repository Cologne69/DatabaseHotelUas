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
            
        }

        private void btn_cariNama_Click(object sender, EventArgs e)
        {
            sqlQuery = $"SELECT * FROM `CUSTOMER` WHERE `CUST_NAMA` LIKE '%{txt_cariNamaPelanggan.Text.ToString()}%'";
            sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(pelanggan);
            dataGridView1.DataSource = pelanggan;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}
