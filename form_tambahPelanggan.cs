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
    public partial class form_tambahPelanggan : Form
    {
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        string JenisKelamin = "";
        
        public form_tambahPelanggan()
        {
            InitializeComponent();
        }
        

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_idPelanggan_TextChanged(object sender, EventArgs e)
        {

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
                    
                    sqlQuery = $"INSERT INTO CUSTOMER VALUES ('{txt_idPelanggan.Text.ToString().ToUpper()}','{txt_namaPelanggan.Text.ToString().ToUpper()}','{txt_KotaPelanggan.Text.ToString().ToUpper()}','0','{JenisKelamin}')";
                    sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    //MessageBox.Show($"Pelanggan dengan NAMA: {txt_namaPelanggan.Text} dan ID: {txt_idPelanggan.Text} berhasil ditambahkan");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
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

        private void txt_namaPelanggan_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_tambahPelanggan_Load(object sender, EventArgs e)
        {

        }
    }
}
