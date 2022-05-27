using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseHotelUas
{
    public partial class form_tambahPelanggan : Form
    {
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
            txt_KotaPelanggan.Text.ToUpper();
            txt_namaPelanggan.Text.ToUpper();
            if (rdb_Laki.Checked == false && rdb_Perempuan.Checked == false || txt_namaPelanggan.Text.Length == 0 || txt_KotaPelanggan.Text.Length == 0)
            {
                MessageBox.Show("Isilah data diatas terlebih dahulu");
            }
            else
            {
                MessageBox.Show($"Pelanggan dengan NAMA: {txt_namaPelanggan.Text} dan ID: {txt_idPelanggan.Text} berhasil ditambahkan");
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
    }
}
