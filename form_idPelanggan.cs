using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

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
            txt_cariNamaPelanggan.Text = "";
        }
        private void form_idPelanggan_Load(object sender, EventArgs e)
        {
            pelanggan.Clear();
            try
            {
                sqlQuery = $"SELECT CUST_ID as 'CUSTOMER ID', CUST_NAMA as 'CUSTOMER NAMA', CUST_KOTA as 'CUSTOMER KOTA', DELETE_CUST as 'DELETE CUSTOMER', CUST_KELAMIN as 'CUSTOMER KELAMIN' FROM CUSTOMER";
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
            txt_cariNamaPelanggan.Text = "";
        }
        private void txt_cariNamaPelanggan_TextChanged(object sender, EventArgs e)
        {
            pelanggan.DefaultView.RowFilter = string.Format("`CUSTOMER NAMA` LIKE '%{0}%'", txt_cariNamaPelanggan.Text);
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
            if (MessageBox.Show("Apakah anda yakin mau menghapus pelanggan tersebut?", "Hapus pelanggan", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    sqlQuery = $"DELETE FROM CUSTOMER WHERE CUST_ID = '{dataGridView1.CurrentRow.Cells[0].Value.ToString()}';";
                    sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(pelanggan);
                    MessageBox.Show($"Pelanggan dengan ID: {dataGridView1.CurrentRow.Cells[0].Value.ToString()} berhasil dihapus");
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
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
