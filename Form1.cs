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

        //----------------------------------------------------- BAGIAN FORMS -----------------------------------------------------

        private void lbl_testTanggal_Click(object sender, EventArgs e)
        {

        }

        private void tgl_checkin_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            fct.ShowDialog();
            
        }
        
        private void btn_lihatkamar_Click(object sender, EventArgs e)
        {
            
            fk.ShowDialog();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_fasilitasKamar_Click(object sender, EventArgs e)
        {
            fr.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_cekidPelanggan_Click(object sender, EventArgs e)
        {
            fcidp.ShowDialog();
        }

        private void cb_namaPelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void form_main_Load(object sender, EventArgs e)
        {
            TestKoneksi();
            cb_namaPelanggan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_namaPelanggan.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void btn_tmbhPelanggan_Click(object sender, EventArgs e)
        {
            ftp.ShowDialog();
        }

        private void btn_bookKamar_Click(object sender, EventArgs e)
        {
            //Convert.ToDateTime(tgl_checkin);
            //Convert.ToDateTime(tgl_checkout);
            

        }
    }
}
