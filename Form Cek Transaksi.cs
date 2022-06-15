using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DatabaseHotelUas
{
    public partial class Form_Cek_Transaksi : Form
    {
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        new DataTable kamarBelumLunas = new DataTable();
        new DataTable restoBelumLunas = new DataTable();
        new DataTable semuaTransaksiKamar = new DataTable();
        new DataTable semuaTransaksiResto = new DataTable();
        public Form_Cek_Transaksi()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

            this.Hide();
            dgv_cekTransBlmLunas.DataSource = null;
            dgv_cekTransBlmLunas2.DataSource = null;
            dgv_SemuaTransaksi.DataSource = null;
            dgv_SemuaTransaksi2.DataSource = null;


        }

        private void btn_prosesCekTransaksi_Click(object sender, EventArgs e)
        {
            if (cBoxBookKamar.Checked == false && cBoxOrderResto.Checked == false)
            {
                MessageBox.Show("Tolong pilih jenis transaksi yang ingin ditampilkan");
            }
            else
            {
                if (cBoxBookKamar.Checked == true && cBoxOrderResto.Checked == false)
                {
                    dgv_cekTransBlmLunas2.Hide();
                    dgv_SemuaTransaksi2.Hide();
                    lblBookingKamar.Hide();
                    lblOrderResto.Hide();
                    lblBookingKamar2.Hide();
                    lblOrderResto2.Hide();
                    TransaksiBookingKamarBelumLunas();
                    TransaksiBookingKamar();
                }
                else if (cBoxOrderResto.Checked == true && cBoxBookKamar.Checked == false)
                {
                    dgv_cekTransBlmLunas2.Hide();
                    dgv_SemuaTransaksi2.Hide();
                    lblBookingKamar.Hide();
                    lblOrderResto.Hide();
                    lblBookingKamar2.Hide();
                    lblOrderResto2.Hide();
                    TransaksiOrderFoodBelumLunas();
                    TransaksiOrderFood();
                }
                else if (cBoxOrderResto.Checked == true && cBoxBookKamar.Checked == true)
                {
                    dgv_cekTransBlmLunas2.Show();
                    dgv_SemuaTransaksi2.Show();
                    lblBookingKamar.Show();
                    lblOrderResto.Show();
                    lblBookingKamar2.Show();
                    lblOrderResto2.Show();
                    TransaksiBookingKamarBelumLunas();
                    TransaksiOrderFoodBelumLunas2();
                    TransaksiBookingKamar();
                    TransaksiOrderFood2();
                }
            }
        }
        public void TransaksiBookingKamarBelumLunas()
        {
            try
            {
                kamarBelumLunas = new DataTable();
                sqlQuery = $"SELECT BOOK_ID AS 'BOOKING ID', CUST_ID AS 'CUSTOMER ID', BOOK_TGL_CIN AS 'TANGGAL CHECK IN', BOOK_TGL_COUT AS 'TANGGAL CHECK OUT', BOOK_KAMAR_COUNT AS 'JUMLAH KAMAR', BOOK_TOTAL AS 'TOTAL BIAYA' FROM BOOKING_KAMAR WHERE TRANS_ID is null order by cast(BOOK_ID as unsigned); ";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(kamarBelumLunas);
                dgv_cekTransBlmLunas.RowHeadersVisible = false;
                dgv_cekTransBlmLunas.DataSource = kamarBelumLunas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void TransaksiOrderFoodBelumLunas()
        {
            try
            {
                restoBelumLunas = new DataTable();
                sqlQuery = $"SELECT ORDER_ID AS 'ORDER ID', CUST_ID AS 'CUSTOMER ID', ORDER_TGL AS 'TANGGAL ORDER', ORDER_MENU_COUNT AS 'JUMLAH JENIS MENU', ORDER_TOTAL 'TOTAL HARGA' FROM ORDER_FOOD WHERE TRANS_ID is null AND NOT ORDER_ID = '0' order by cast(ORDER_ID as unsigned); ";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(restoBelumLunas);
                dgv_cekTransBlmLunas.RowHeadersVisible = false;
                dgv_cekTransBlmLunas.DataSource = restoBelumLunas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void TransaksiBookingKamar()
        {
            try
            {
                semuaTransaksiKamar = new DataTable();
                sqlQuery = $"SELECT BOOK_ID AS 'BOOKING ID', CUST_ID AS 'CUSTOMER ID', BOOK_TGL_CIN AS 'TANGGAL CHECK IN', BOOK_TGL_COUT AS 'TANGGAL CHECK OUT', BOOK_KAMAR_COUNT AS 'JUMLAH KAMAR', BOOK_TOTAL AS 'TOTAL BIAYA' FROM BOOKING_KAMAR order by cast(BOOK_ID as unsigned);";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(semuaTransaksiKamar);
                dgv_SemuaTransaksi.RowHeadersVisible = false;
                dgv_SemuaTransaksi.DataSource = semuaTransaksiKamar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void TransaksiOrderFood()
        {
            try
            {
                semuaTransaksiResto = new DataTable();
                sqlQuery = $"SELECT ORDER_ID AS 'ORDER ID', CUST_ID AS 'CUSTOMER ID', ORDER_TGL AS 'TANGGAL ORDER', ORDER_MENU_COUNT AS 'JUMLAH JENIS MENU', ORDER_TOTAL 'TOTAL HARGA' FROM ORDER_FOOD WHERE NOT ORDER_ID = '0' order by cast(ORDER_ID as unsigned);";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(semuaTransaksiResto);
                dgv_SemuaTransaksi.RowHeadersVisible = false;
                dgv_SemuaTransaksi.DataSource = semuaTransaksiResto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void TransaksiOrderFoodBelumLunas2()
        {
            try
            {
                restoBelumLunas = new DataTable();
                sqlQuery = $"SELECT ORDER_ID AS 'ORDER ID', CUST_ID AS 'CUSTOMER ID', ORDER_TGL AS 'TANGGAL ORDER', ORDER_MENU_COUNT AS 'JUMLAH JENIS MENU', ORDER_TOTAL 'TOTAL HARGA' FROM ORDER_FOOD WHERE TRANS_ID is null AND NOT ORDER_ID = '0' order by cast(ORDER_ID as unsigned); ";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(restoBelumLunas);
                dgv_cekTransBlmLunas2.RowHeadersVisible = false;
                dgv_cekTransBlmLunas2.DataSource = restoBelumLunas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void TransaksiOrderFood2()
        {
            try
            {
                semuaTransaksiResto = new DataTable();
                sqlQuery = $"SELECT ORDER_ID AS 'ORDER ID', CUST_ID AS 'CUSTOMER ID', ORDER_TGL AS 'TANGGAL ORDER', ORDER_MENU_COUNT AS 'JUMLAH JENIS MENU', ORDER_TOTAL 'TOTAL HARGA' FROM ORDER_FOOD WHERE NOT ORDER_ID = '0' order by cast(ORDER_ID as unsigned); ";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(semuaTransaksiResto);
                dgv_SemuaTransaksi2.RowHeadersVisible = false;
                dgv_SemuaTransaksi2.DataSource = semuaTransaksiResto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form_Cek_Transaksi_Load(object sender, EventArgs e)
        {
            dgv_cekTransBlmLunas2.Hide();
            dgv_SemuaTransaksi2.Hide();
            lblBookingKamar.Hide();
            lblOrderResto.Hide();
            lblBookingKamar2.Hide();
            lblOrderResto2.Hide();
            dgv_cekTransBlmLunas.DataSource = null;
            dgv_cekTransBlmLunas2.DataSource = null;
            dgv_SemuaTransaksi.DataSource = null;
            dgv_SemuaTransaksi2.DataSource = null;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            cBoxBookKamar.Checked = false;
            cBoxOrderResto.Checked = false;
            this.Hide();
            dgv_cekTransBlmLunas.DataSource = null;
            dgv_cekTransBlmLunas2.DataSource = null;
            dgv_SemuaTransaksi.DataSource = null;
            dgv_SemuaTransaksi2.DataSource = null;
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
