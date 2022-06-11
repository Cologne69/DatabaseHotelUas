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
    public partial class form_popupKamar : Form
    {
        public form_popupKamar()
        {
            InitializeComponent();
        }
        private MySqlCommand sqlCommand;
        private MySqlDataAdapter sqlAdapter;

        /*
         *  @kamar = current kamar 
         */

        private string kamar = form_kamar.pressed_button;

        private void form_popupKamar_Load(object sender, EventArgs e)
        {
            sync();
            ui_sync();
        }
        
        // @sync = delivering status to form boilerplate especially txt_nama and txt_check_in with sqlquery
        private void sync()
        {
            // check if form_kamar.pressed_button is in form_kamar.filled_kamar list
            if (!form_kamar.filled_kamar.Contains(form_kamar.pressed_button))
            {
                txt_nama.Text = "Belum ada pengunjung";
                txt_check_in.Text = "Belum ada pengunjung";
            }
            else
            {
                DataTable temp_txt_dt = new DataTable();
                string sqlQuery = $"select c.CUST_NAMA as 'nama', date_format(bk.BOOK_TGL_CIN, '%d-%m-%Y') as 'tanggal' from BOOKING_KAMAR bk, CUSTOMER c, DETAIL_BOOK_KAMAR dbk " +
                    $"where c.CUST_ID = bk.CUST_ID and dbk.BOOK_ID = bk.BOOK_ID and dbk.KAMAR_NO = {form_kamar.pressed_button}";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(temp_txt_dt);

                txt_nama.Text = temp_txt_dt.Rows[0]["nama"].ToString();
                txt_check_in.Text = temp_txt_dt.Rows[0]["tanggal"].ToString();
                btn_add.Enabled = false;
            }

            // disable btn_add if current kamar is already on cart
            if (form_kamar.cart.Contains(form_kamar.pressed_button))
            {
                btn_add.Enabled = false;
            }
        }
        // @ui_sync = sync ui from form_kamar 
        private void ui_sync()
        {
            // set form name to form_kamar.pressed_button
            this.Text = "Kamar A" + form_kamar.pressed_button;

            // to keep integrity of form_kamar.pressed_button
            lbl_no_kamar.Text = "A"+form_kamar.pressed_button;
            
            // @switch show list of fasilitas based on form_main messagebox
            switch (form_kamar.tipe_kamar)
            {
                case "PS":
                    lbl_tipe_kamar.Text = "President Suite";
                    lbl_list_fasilitas.Text = "1. 3 Kamar king bed\n2. Ukuran kamar 92 -100 meter persegi (m2)\n3. Ruang olahraga pribadi dan kolam renang pribadi\n4. Fasilitas mewah";
                    break;
                case "S":
                    lbl_tipe_kamar.Text = "Suite";
                    lbl_list_fasilitas.Text = "1. 2 kamar king bed\n2. Ukuran kamar 80 meter persegi (m2)";
                    break;
                case "JS":
                    lbl_tipe_kamar.Text = "Junior suite";
                    lbl_list_fasilitas.Text = "1. 2 kamar (1 king bed, 1 single bed)\n2. Ukuran kamar 50 meter persegi (m2)";
                    break;
                case "D":
                    lbl_tipe_kamar.Text = "Deluxe";
                    lbl_list_fasilitas.Text = "1. 1 kamar king bed\n2. Ukuran kamar 40 meter persegi (m2)";
                    break; 
                default:
                    lbl_tipe_kamar.Text = "Error occured";
                    break;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // add kamar to form_kamar.cart
            form_kamar.cart.Add(kamar);
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            // remove kamar from form_kamar.cart
            form_kamar.cart.Remove(kamar);
            this.Close();
        }
    }
}
