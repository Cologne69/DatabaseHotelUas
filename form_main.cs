using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
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
        DataTable HargaKamar = new DataTable();
        public static int transID;
        MySqlDataReader myReader;
        //---------------------------------------------------------- UI -----------------------------------------------------------
        private Button currentButton;
        int imageNo = 1;
        private void imageSlideShow()
        {
            if (imageNo == 5)
            {
                imageNo = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"C:\Users\kyrel\Pictures\Gambat\Image{0}.png", imageNo);
            imageNo++;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            imageSlideShow();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null && slide == true)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(214, 173, 96);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(244, 235, 208);
                }
            }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal: " + ex.Message);
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
        public int maxtransID()
        {
            try
            {
                sqlQuery = $"SELECT MAX(CAST(TRANS_ID AS SIGNED)) FROM TRANS_SETTLEMENT";
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
                sqlQuery = $"SELECT CONCAT(TK.TIPE_KAMAR_NAMA, ' ',' | ','Rp.', TK.TIPE_KAMAR_HARGA) as '1', TK.TIPE_KAMAR_ID as '2' FROM TIPE_KAMAR TK;";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(HargaKamar);
                lb_hargaKamar.DataSource = HargaKamar;
                lb_hargaKamar.DisplayMember = "1";
                lb_hargaKamar.ValueMember = "2";
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime WIB = DateTime.Now;
            lbl_waktu.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lbl_jamWIB.Text = WIB.ToString("HH:mm:ss");
        }
        private void lb_hargaKamar_Click(object sender, EventArgs e)
        {
            if (lb_hargaKamar.SelectedIndex == 0)
            {
                MessageBox.Show("Presidential Suite\n\n1. 3 Kamar King Bed\n2. Ukuran kamar 92-100 meter persegi (M2)\n3. Ruang olahraga pribadi dan kolam renang pribadi\n4. Fasilitas mewah");
            }
            else if (lb_hargaKamar.SelectedIndex == 1)
            {
                MessageBox.Show("Suite\n\n1. 2 Kamar King Bed\n2. Ukuran kamar 80 meter persegi (M2)");
            }
            else if (lb_hargaKamar.SelectedIndex == 2)
            {
                MessageBox.Show("Junior Suite\n\n1. 2 Kamar (1 King Bed, 1 Single Bed)\n2. Ukuran kamar 50 meter persegi (M2)");
            }
            else if (lb_hargaKamar.SelectedIndex == 3)
            {
                MessageBox.Show("Deluxe\n\n1. 1 Kamar King Bed\n2. Ukuran kamar 40 meter persegi (M2)");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPelanggan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            fcidp.ShowDialog();
        }
        private void btnRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            fct.ShowDialog();
        }
        private void btnKamar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            fk.ShowDialog();
        }
        private void btnRestoran_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            fr.ShowDialog();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void tb_cariMenu_KeyDown(object sender, KeyEventArgs e)
        {
            string SAPbeLike;
            if (e.KeyCode == Keys.Enter)
            {
                SAPbeLike = tb_cariMenu.Text.ToUpper().ToString();
                switch (SAPbeLike)
                {
                    case "/R":
                        fr.ShowDialog();
                        break;
                    case "/K":
                        fk.ShowDialog();
                        break;
                    case "/P":
                        fcidp.ShowDialog();
                        break;
                    case "/T":
                        ftp.ShowDialog();
                        break;
                    case "/CT":
                        fct.ShowDialog();
                        break;
                    case "/HR":
                        fhr.ShowDialog();
                        break;
                    default:
                        MessageBox.Show("Tidak ada perintah!");
                        break;
                }
                tb_cariMenu.Text = "";
            }
        }
        private void tb_cariMenu_TextChanged(object sender, EventArgs e)
        {
            if(tb_cariMenu.Text.Length > 0)
            {
                pic_crossmark.Show();
                pic_search.Hide();
            }
            else if (tb_cariMenu.Text.Length == 0)
            {
                pic_crossmark.Hide();
                pic_search.Show();
            }
        }
        private void pic_crossmark_Click(object sender, EventArgs e)
        {
            tb_cariMenu.Text = "";
        }
        int r1 = 140 , g1 = 140, b1 = 140;
        int r2 = 244, g2 = 235, b2 = 208;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        int r3 = 214, g3 = 173, b3 = 96;
        bool slide = true;

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            timermode6.Start();
        }
        private void timermode6_Tick(object sender, EventArgs e)
        {
            if (slide == true)
            {
                panelTombolDarkMode.Left += 5;
                if (panelTombolDarkMode.Left >= 761)
                {
                    timermode6.Stop();
                    slide = false;
                    panelDarkMode.BackColor = Color.White;
                    panelTombolDarkMode.BackColor = Color.Black;
                    panel1.BackColor = Color.FromArgb(r1, g1, b1);
                    btnPelanggan.BackColor = Color.FromArgb(r1, g1, b1);
                    btnPelanggan.FlatAppearance.BorderColor= Color.Silver;
                    btnPelanggan.ForeColor = Color.White;
                    btnRiwayatTransaksi.BackColor = Color.FromArgb(r1, g1, b1);
                    btnRiwayatTransaksi.FlatAppearance.BorderColor = Color.Silver;
                    btnRiwayatTransaksi.ForeColor = Color.White;
                    btnKamar.BackColor = Color.FromArgb(r1, g1, b1);
                    btnKamar.FlatAppearance.BorderColor = Color.Silver;
                    btnKamar.ForeColor = Color.White;
                    btnRestoran.BackColor = Color.FromArgb(r1, g1, b1);
                    btnRestoran.FlatAppearance.BorderColor = Color.Silver;
                    btnRestoran.ForeColor = Color.White;
                    tb_cariMenu.BackColor = Color.Silver;
                    form_main.fct.BackColor = Color.FromArgb(r1, g1, b1);
                    form_main.fk.BackColor = Color.FromArgb(r1, g1, b1);
                    form_main.fr.BackColor = Color.FromArgb(r1, g1, b1);
                    form_main.fm.BackColor = Color.FromArgb(r1, g1, b1);
                    form_main.fcidp.BackColor = Color.FromArgb(r1, g1, b1);
                    form_main.ftp.BackColor = Color.FromArgb(r1, g1, b1);
                    form_main.fhr.BackColor = Color.FromArgb(r1, g1, b1);

                    // form restoran
                    form_main.fr.btn_checkout.BackColor = Color.Silver;
                    form_main.fr.btn_addtoCart.BackColor = Color.Silver;
                    form_main.fr.DGV_Menu.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver;
                    form_main.fr.DGV_Menu.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(251, 227, 163);
                    form_main.fr.DGV_Menu.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;
                    form_main.fr.DGV_Menu.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(251, 227, 163);
                    form_main.fr.DGV_Menu.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
                    form_main.fr.DGV_invoice.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver;
                    form_main.fr.DGV_invoice.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(251, 227, 163);
                    form_main.fr.DGV_invoice.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;
                    form_main.fr.DGV_invoice.RowsDefaultCellStyle.BackColor = Color.Silver;
                    form_main.fr.DGV_invoice.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(251, 227, 163);
                    form_main.fr.DGV_invoice.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                    // form id pelanggan
                    form_main.fcidp.btnProses.BackColor = Color.Silver;
                    form_main.fcidp.btnTambahPelanggan.BackColor = Color.Silver;
                    form_main.fcidp.btn_deletePelanggan.BackColor = Color.Silver;
                    form_main.fcidp.dgv_Pelanggan.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver;
                    form_main.fcidp.dgv_Pelanggan.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(251, 227, 163);
                    form_main.fcidp.dgv_Pelanggan.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;
                    form_main.fcidp.dgv_Pelanggan.RowsDefaultCellStyle.BackColor = Color.Silver;
                    form_main.fcidp.dgv_Pelanggan.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(251, 227, 163);
                    form_main.fcidp.dgv_Pelanggan.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                    // form tambah pelanggan
                    form_main.ftp.btn_tambahPelanggan.BackColor = Color.Silver;

                    // form kamar
                    form_main.fk.btn_cancel.BackColor = Color.Silver;
                    form_main.fk.btn_tambah_pelanggan.BackColor = Color.Silver;
                    form_main.fk.btn_proses.BackColor = Color.Silver;
                    form_main.fk.btn_remove_all.BackColor = Color.Silver;
                    form_main.fk.btn_check_in.BackColor = Color.Silver;
                    form_main.fk.btn_check_out.BackColor = Color.Silver;

                    // form cek transaksi
                    form_main.fct.btn_prosesCekTransaksi.BackColor = Color.Silver;
                }
            }
            else
            {
                panelTombolDarkMode.Left -= 5;
                if (panelTombolDarkMode.Left <= 746)
                {
                    timermode6.Stop();
                    panel1.BackColor = Color.FromArgb(r2, g2, b2);
                    btnPelanggan.BackColor = Color.FromArgb(r2, g2, b2);
                    btnPelanggan.FlatAppearance.BorderColor = Color.FromArgb(r3, g3, b3);
                    btnPelanggan.ForeColor = Color.Black;
                    btnRiwayatTransaksi.BackColor = Color.FromArgb(r2, g2, b2);
                    btnRiwayatTransaksi.FlatAppearance.BorderColor = Color.FromArgb(r3, g3, b3);
                    btnRiwayatTransaksi.ForeColor = Color.Black;
                    btnKamar.BackColor = Color.FromArgb(r2, g2, b2);
                    btnKamar.FlatAppearance.BorderColor = Color.FromArgb(r3, g3, b3);
                    btnKamar.ForeColor = Color.Black;
                    btnRestoran.BackColor = Color.FromArgb(r2, g2, b2);
                    btnRestoran.FlatAppearance.BorderColor = Color.FromArgb(r3, g3, b3);
                    btnRestoran.ForeColor = Color.Black;
                    tb_cariMenu.BackColor = Color.Linen;
                    form_main.fct.BackColor = Color.FromArgb(r2, g2, b2);
                    form_main.fk.BackColor = Color.FromArgb(r2, g2, b2);
                    form_main.fr.BackColor = Color.FromArgb(r2, g2, b2);
                    form_main.fm.BackColor = Color.FromArgb(r2, g2, b2);
                    form_main.fcidp.BackColor = Color.FromArgb(r2, g2, b2);
                    form_main.ftp.BackColor = Color.FromArgb(r2, g2, b2);
                    form_main.fhr.BackColor = Color.FromArgb(r2, g2, b2);
                    form_main.fr.btn_checkout.BackColor = Color.FromArgb(r3, g3, b3);
                    form_main.fr.btn_addtoCart.BackColor = Color.FromArgb(r3, g3, b3);
                    slide = true;
                    panelDarkMode.BackColor = Color.Black;
                    panelTombolDarkMode.BackColor = Color.White;
                }
            }
        }

    }
}
