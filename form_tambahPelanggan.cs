using MySql.Data.MySqlClient;
using System;

using System.Data;
using System.Windows.Forms;

namespace DatabaseHotelUas
{
    public partial class form_tambahPelanggan : Form
    {
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        string JenisKelamin = "";
        new DataTable pelangganBaru = new DataTable();
        public form_tambahPelanggan()
        {
            InitializeComponent();
        }
        private void clearAll()
        {
            txt_idPelanggan.Text = "";
            txt_KotaPelanggan.Text = "";
            txt_namaPelanggan.Text = "";
            rdb_Laki.Checked = false;
            rdb_Perempuan.Checked = false;
        }


        private void btn_tambahPelanggan_Click(object sender, EventArgs e)
        {
            if (rdb_Laki.Checked == false && rdb_Perempuan.Checked == false || txt_namaPelanggan.Text.Length == 0 || txt_KotaPelanggan.Text.Length == 0 || txt_idPelanggan.Text.Length == 0)
            {
                MessageBox.Show("Isilah data diatas terlebih dahulu");
            }
            else
            {
                if (rdb_Laki.Checked == true)
                {
                    JenisKelamin = "L";
                }
                else if (rdb_Perempuan.Checked == true)
                {
                    JenisKelamin = "P";
                }

                try
                {
                    sqlQuery = $"INSERT INTO DBD_03_HOTEL.CUSTOMER (`CUST_ID`, `CUST_NAMA`, `CUST_KOTA`, `DELETE_CUST`, `CUST_KELAMIN`) VALUES ('{txt_idPelanggan.Text}','{txt_namaPelanggan.Text.ToUpper()}','{txt_KotaPelanggan.Text.ToUpper()}',0,'{JenisKelamin}');";
                    sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(pelangganBaru);
                    MessageBox.Show($"Data dengan ID: {txt_idPelanggan.Text} dan Nama: {txt_namaPelanggan.Text} sudah tersimpan");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                clearAll();
            }
        }

        private void txt_idPelanggan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void form_tambahPelanggan_FormClosing(object sender, FormClosingEventArgs e)
        {
            clearAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            clearAll();
        }
    }
}
