using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DatabaseHotelUas
{
    public partial class form_idPelanggan : Form
    {
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable pelanggan = new DataTable();
        private static List<string> list_pelanggan = new List<string>();
        public form_idPelanggan()
        {
            InitializeComponent();
        }
        private void form_idPelanggan_Load(object sender, EventArgs e)
        {
            pelanggan.Clear();
            syncPelanggan();
            dgv_Pelanggan.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_Pelanggan.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_Pelanggan.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txt_cariNamaPelanggan.Text = "";
        }
        private void syncPelanggan()
        {
            try
            {
                sqlQuery = $"SELECT CUST_ID as 'CUSTOMER ID', CUST_NAMA as 'CUSTOMER NAMA', CUST_KOTA as 'CUSTOMER KOTA', if(CUST_KELAMIN ='L', 'Laki-laki', 'Perempuan') as 'CUSTOMER KELAMIN' FROM CUSTOMER ORDER BY 2";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(pelanggan);
                dgv_Pelanggan.DataSource = pelanggan;

                list_pelanggan = pelanggan.AsEnumerable().Select(x => x.Field<String>("CUSTOMER NAMA")).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_deletePelanggan_Click(object sender, EventArgs e)
        {
            //form_main.fdp.ShowDialog(); 
            if (MessageBox.Show("Apakah anda yakin mau menghapus pelanggan tersebut?", "Hapus pelanggan", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    sqlQuery = $"DELETE FROM CUSTOMER WHERE CUST_ID = '{dgv_Pelanggan.CurrentRow.Cells[0].Value.ToString()}';";
                    sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(pelanggan);
                    MessageBox.Show($"Pelanggan dengan ID: {dgv_Pelanggan.CurrentRow.Cells[0].Value.ToString()} berhasil dihapus");
                    dgv_Pelanggan.Rows.RemoveAt(dgv_Pelanggan.CurrentRow.Index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnProses_Click(object sender, EventArgs e)
        {
            btnProses.Hide();
            btnTambahPelanggan.Hide();
            btn_deletePelanggan.Hide();
            pelanggan.DefaultView.RowFilter = string.Format("'CUSTOMER NAMA' LIKE '%{0}%'", txt_cariNamaPelanggan.Text);
            for (int i = 0; i < pelanggan.DefaultView.Count; i++)
            {
                if (pelanggan.DefaultView.RowFilter.Contains(txt_cariNamaPelanggan.Text))
                {
                    statusNamaPelanggan.BackColor = Color.Red;
                    btn_deletePelanggan.Show();
                    i = pelanggan.DefaultView.Count;
                }
            }
            if (statusNamaPelanggan.BackColor == Color.White)
            {
                statusNamaPelanggan.BackColor = Color.Green;
                btnTambahPelanggan.Show();
            }
        }

        private void txt_cariNamaPelanggan_TextChanged(object sender, EventArgs e)
        {
            statusNamaPelanggan.BackColor = Color.White;
            btnProses.Show();
        }

        private void btnTambahPelanggan_Click(object sender, EventArgs e)
        {
            form_main.ftp.StartPosition = FormStartPosition.CenterParent;
            form_main.ftp.txt_namaPelanggan.Text = txt_cariNamaPelanggan.Text;
            form_main.ftp.ShowDialog();
            form_main.ftp.txt_KotaPelanggan.Clear();
            form_main.ftp.txt_idPelanggan.Clear();
            form_main.ftp.rdb_Laki.Checked = false;
            form_main.ftp.rdb_Perempuan.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            txt_cariNamaPelanggan.Text = "";
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
