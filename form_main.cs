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
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }
        
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        new DataTable HargaKamar = new DataTable();
        public static int transID;
        MySqlDataReader myReader;
        


        //----------------------------------------------------- BMYSQL SERVER -----------------------------------------------------

        public static string sqlConnString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_03_HOTEL";
        public static MySqlConnection sqlConnect = new MySqlConnection(sqlConnString);

        public static void TestKoneksi()
        {
            try
            {
                sqlConnect.Close();
                sqlConnect.Open();
                //MessageBox.Show("Koneksi Berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal");
            }
        }
        //----------------------------------------------------- MYSQL SERVER -----------------------------------------------------


        //----------------------------------------------------- BAGIAN FORMS -----------------------------------------------------
        public static Form_Cek_Transaksi fct = new Form_Cek_Transaksi();
        public static form_kamar fk = new form_kamar();
        public static form_resto fr = new form_resto();
        public static form_main fm = new form_main();
        public static form_idPelanggan fcidp = new form_idPelanggan();
        public static form_tambahPelanggan ftp = new form_tambahPelanggan();
        public static form_historiRestoran fhr = new form_historiRestoran();
 
        //----------------------------------------------------- BAGIAN FORMS -----------------------------------------------------

        private void button2_Click(object sender, EventArgs e)
        {
            fct.ShowDialog();
        }
        
        private void btn_lihatkamar_Click(object sender, EventArgs e)
        {
            fk.ShowDialog();
            fk.cb_pelanggan.Enabled = true;
        }

        private void btn_fasilitasKamar_Click(object sender, EventArgs e)
        {
            fr.ShowDialog();
        }

        private void btn_cekidPelanggan_Click(object sender, EventArgs e)
        {
            fcidp.ShowDialog();
        }
        public int maxtransID()
        {
            try
            {
                sqlQuery = $"SELECT MAX(TRANS_ID) FROM TRANS_SETTLEMENT";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                return Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private void form_main_Load(object sender, EventArgs e)
        {
            TestKoneksi();
            try
            {
                
                transID = maxtransID();
                sqlQuery = $"SELECT CONCAT(TK.TIPE_KAMAR_ID,' - ',TK.TIPE_KAMAR_NAMA, ' ',' | ','Rp.', TK.TIPE_KAMAR_HARGA) as '1' FROM TIPE_KAMAR TK;";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(HargaKamar);
                lb_hargaKamar.DataSource = HargaKamar;
                lb_hargaKamar.DisplayMember = "1";
                lb_hargaKamar.ValueMember = "1";
                lb_hargaKamar.ClearSelected();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_tmbhPelanggan_Click(object sender, EventArgs e)
        {
            ftp.ShowDialog();
        }

        private void tambahPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ftp.ShowDialog();
        }

        private void daftarPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fcidp.ShowDialog();
        }

        private void pelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cekRiwayatTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime WIB = DateTime.Now;
            lbl_waktu.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lbl_jamWIB.Text = WIB.ToString("HH:mm:ss");
        }

        private void btn_historiRestoran_Click(object sender, EventArgs e)
        {
            fhr.ShowDialog();
        }

        private void lb_hargaKamar_Click(object sender, EventArgs e)
        {
            if (lb_hargaKamar.SelectedIndex == 0)
            {
                MessageBox.Show("Presidential Suite\n\n1. 3 Kamar king bed\n2. Ukuran kamar 92 -100 meter persegi (m2)\n3. Ruang olahraga pribadi dan kolam renang pribadi\n4. Fasilitas mewah");
            }
            else if (lb_hargaKamar.SelectedIndex == 1)
            {
                MessageBox.Show("Suite\n\n1. 2 kamar king bed\n2. Ukuran kamar 80 meter persegi (m2)");
            }
            else if (lb_hargaKamar.SelectedIndex == 2)
            {
                MessageBox.Show("Junior Suite\n\n1. 2 kamar (1 king bed, 1 single bed)\n2. Ukuran kamar 50 meter persegi (m2)");
            }
            else if (lb_hargaKamar.SelectedIndex == 3)
            {
                MessageBox.Show("Deluxe\n\n1. 1 kamar king bed\n2. Ukuran kamar 50 meter persegi (m2)");
            }
        }

        private void riwayatPemesananKamarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_riwayatKamar form2 = new form_riwayatKamar();
            form2.Show();
        }
    }
}
