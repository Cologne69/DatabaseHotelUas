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

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
            //{
            //    // Store Auto Sized Widths:
            //    int colw = dataGridView1.Columns[i].Width;

            //    // Remove AutoSizing:
            //    dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            //    // Set Width to calculated AutoSize value:
            //    dataGridView1.Columns[i].Width = colw;
            //}
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

        private void btn_deletePelanggan_Click(object sender, EventArgs e)
        {
            //form_main.fdp.ShowDialog(); 
            if(MessageBox.Show("Apakah anda yakin mau menghapus pelanggan tersebut?", "Hapus pelanggan", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    sqlQuery = $"DELETE FROM CUSTOMER WHERE CUST_ID = '{dataGridView1.CurrentRow.Cells[0].Value.ToString()}';";
                    sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    MessageBox.Show($"Pelanggan dengan ID: {dataGridView1.CurrentRow.Cells[0].Value.ToString()} berhasil dihapus");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
  
        }
    }
}
