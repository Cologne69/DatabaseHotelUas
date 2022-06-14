using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DatabaseHotelUas
{
    public partial class form_kamar : Form
    {
        public form_kamar()
        {
            InitializeComponent();
        }

        private static MySqlCommand sqlCommand;
        private static MySqlDataAdapter sqlAdapter;

        /* 
         * @filled_kamar is list of kamar WHERE kamar_status is 1
         * @cart_dt = temporary cart UI source for popup_kamar.dgv_cart & dgv_cart in the current file
         * @pelanggan = feed some suggestion to list_box_suggestion
         * @temp_pelanggan = for pic_status
         * @temp_used_kamar_by_pelanggan = for blue color in kamar status where id_pelanggan is cb_pelanggan.ValueMember
         */

        public static List<String> filled_kamar = new List<string>();
        public static DataTable cart_dt = new DataTable();

        /*
         * PLEASE BE ADVISED!
         * for checkin List<string> cart act as a temporary cart helper
         * but for checkout List<string> temp_used_kamar_by_pelangganact as temp source for cart_dt that will fill dgv_cart
         * we can do this, because cart.Add / cart.Remove only come from form_popupkamar which we will be disable those popup if 
         * pelanggan has already rent a kamar 
         */

        public static List<String> cart = new List<string>();

        private static DataTable pelanggan = new DataTable();
        private static List<string> temp_pelanggan = new List<string>();
        private List<string> temp_used_kamar_by_pelanggan = new List<string>(); // temp source for cart_dt that will fill dgv_cart

        private void form_kamar_Load(object sender, EventArgs e)
        {
            lbl_output_book_id.Text = getCurrentBookId().ToString();
            btn_check_out.Enabled = false;

            hideCheckAndDatetime();
            syncKamarStatus();
            syncPelanggan();
        }

        private void hideCheckAndDatetime() // @hideCheckAndDatetime = hide check in and check out datetime (for view only mode)
        {
            lbl_check_in.Hide();
            lbl_check_out.Hide();
            datetime_check_in.Hide();
            datetime_check_out.Hide();
        }

        private int getCurrentBookId() // @maxBookId = get max book_id from BOOKING_KAMAR
        {
            try
            {
                string sqlQuery = "select MAX(CAST(BOOK_ID as SIGNED)) as 'max_book_id' from BOOKING_KAMAR";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable temp_dt = new DataTable();
                sqlAdapter.Fill(temp_dt);
                return Convert.ToInt32(temp_dt.Rows[0]["max_book_id"].ToString()) + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occurred: " + ex.Message);
                return 0;
            }
        }

        private int countCart() // @countCart = count how many kamar in cart and update that value to lbl_output_total_item
        {
            lbl_output_total_item.Text = cart.Count.ToString();
            return cart.Count();
        }

        private int countTotalPrice() // @countTotalPrice = count total price of cart and update that value to lbl_output_total_price
        {
            int total_price = 0;
            // sum third column of cart_dt (price)
            foreach (DataRow row in cart_dt.Rows)
            {
                total_price += Convert.ToInt32(row[2].ToString());
            }
            // add thousand separator
            lbl_output_total_price.Text = total_price.ToString("#,##0");
            return total_price;
        }

        private void syncKamarStatus() // @syncKamarStatus = sync color of occupied kamar
        {
            /*
             * query check for KAMAR_STATUS = 1
             * append(btn_A{KAMAR_NO})
             * change it to red
             */
            try
            {
                DataTable filled_kamar_dt = new DataTable();
                string sqlQuery = "SELECT KAMAR_NO FROM KAMAR WHERE KAMAR_STATUS = 1";
                new MySqlDataAdapter(sqlQuery, form_main.sqlConnect).Fill(filled_kamar_dt);
                filled_kamar = filled_kamar_dt.AsEnumerable().Select(x => x.Field<String>("KAMAR_NO")).ToList();

                // hard reset color to green
                for (int i = 101; i <= 140; i++)
                {
                    Button btn = this.Controls.Find("btn_A" + i, true).FirstOrDefault() as Button;
                    btn.BackColor = Color.LimeGreen;
                }
                for (int i = 201; i <= 240; i++)
                {
                    Button btn = this.Controls.Find("btn_A" + i, true).FirstOrDefault() as Button;
                    btn.BackColor = Color.LimeGreen;
                }

                // append "btn_A" to every child in filled_kamar and change it as button backColor to red
                foreach (string kamar_no in filled_kamar)
                {
                    Button btn = this.Controls.Find("btn_A" + kamar_no, true).FirstOrDefault() as Button;
                    btn.BackColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occurred: " + ex.Message);
            }
        }

        private void syncPelanggan() // @syncPelanggan fill cb_pelanggan with data
        {
            try
            {
                pelanggan = new DataTable();
                string sqlQuery = $"SELECT CONCAT(CUST_NAMA,' - ',CUST_ID) as 'id dan nama', CUST_ID as 'nama' FROM CUSTOMER ORDER BY 2 DESC";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(pelanggan);
                cb_pelanggan.DataSource = pelanggan;
                cb_pelanggan.ValueMember = "nama";
                cb_pelanggan.DisplayMember = "id dan nama";

                // fill first column of pelanggan to temp_pelanggan
                temp_pelanggan = pelanggan.AsEnumerable().Select(x => x.Field<String>("id dan nama")).ToList();
                btn_tambah_pelanggan.Hide();
                btn_cancel.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occurred: " + ex.Message);
            }
        }

        /*
         * @syncPelangganKamar = change button to blue if kamar is filled with selected pelanggan
         * don't forget to clean up after btn_cancel is pressed!
         * perhaps show lbl_check_out & datetime_check_out if datatable filled with row ?
         */

        private void syncPelangganKamar()
        {
            try
            {
                DataTable pelanggan_kamar = new DataTable();
                string sqlQuery = $"select c.CUST_NAMA as 'nama', bk.BOOK_TGL_CIN 'check_in', d.kamar_no 'kamar_no' " +
                    $"from CUSTOMER c, BOOKING_KAMAR bk, KAMAR k, DETAIL_BOOK_KAMAR d " +
                    $"where c.CUST_ID = bk.CUST_ID and d.BOOK_ID = bk.BOOK_ID and d.KAMAR_NO = k.KAMAR_NO  " +
                    $"and bk.BOOK_TGL_COUT IS NULL and c.CUST_ID = '{cb_pelanggan.SelectedValue.ToString()}'";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(pelanggan_kamar);

                temp_used_kamar_by_pelanggan = pelanggan_kamar.AsEnumerable().Select(x => x.Field<String>("kamar_no")).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occurred: " + ex.Message);
            }
        }

        /*
         * @convertKamarToDgv = query no_kamar, tipe_kamar_nama, tipe_kamar_harga
         * based on List<String> cart and push it to DataTable cart_dt 
         * perhaps create new function that will change selected kamar to blue as an indicator?
         * 
         * @syncDgv = sync dgv_cart with cart_dt
         */

        private void convertKamarToDgv() // fill cart_dt with selected kamar in List<string> cart
        {
            string sqlQuery = $"SELECT k.KAMAR_NO as 'No Kamar', tk.TIPE_KAMAR_NAMA as 'Tipe', tk.TIPE_KAMAR_HARGA as 'Harga' FROM KAMAR k, TIPE_KAMAR tk " +
                $"WHERE tk.TIPE_KAMAR_ID = k.TIPE_KAMAR_ID AND k.KAMAR_NO IN ('{String.Join("','", cart)}')";
            sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(cart_dt);
        }

        private void syncDgv() // always refresh dt and sync dgv_cart with cart_dt
        {
            cart_dt = new DataTable();
            convertKamarToDgv();
            dgv_cart.DataSource = cart_dt;
        }

        /*
         * @syncKamarCart = change btn_Axx to blue if that number is in List<String> cart
         * probably, do it after check whether temp_used_kamar_by_pelanggan has any value in it
         */

        private void syncKamarCart()
        {
            syncKamarStatus(); // we need to sync kamar status first so red color still persist
            countCart();
            countTotalPrice();
            foreach (string kamar_no in cart)
            {
                Button btn = this.Controls.Find("btn_A" + kamar_no, true).FirstOrDefault() as Button;
                btn.BackColor = Color.LightSkyBlue;
            }
        }

        private void btn_lantai2_Click(object sender, EventArgs e)
        {
            btn_lantai2.BackColor = Color.LightSkyBlue;
            btn_lantai1.BackColor = Color.White;
            for (int i = 101; i <= 140; i++)
            {
                Button btn = this.Controls.Find("btn_A" + i, true).FirstOrDefault() as Button;
                btn.Hide();
            }
            for (int i = 201; i <= 240; i++)
            {
                Button btn = this.Controls.Find("btn_A" + i, true).FirstOrDefault() as Button;
                btn.Show();
            }
        }

        private void btn_lantai1_Click(object sender, EventArgs e)
        {
            btn_lantai2.BackColor = Color.White;
            btn_lantai1.BackColor = Color.LightSkyBlue;
            for (int i = 101; i <= 140; i++)
            {
                Button btn = this.Controls.Find("btn_A" + i, true).FirstOrDefault() as Button;
                btn.Show();
            }
            for (int i = 201; i <= 240; i++)
            {
                Button btn = this.Controls.Find("btn_A" + i, true).FirstOrDefault() as Button;
                btn.Hide();
            }
        }

        private void allKamarButtonEnabled(bool state) // @allKamarButtonEnabled Enable or disable all kamar button
        {
            for (int i = 101; i <= 140; i++)
            {
                Button btn = this.Controls.Find("btn_A" + i, true).FirstOrDefault() as Button;
                btn.Enabled = state;
            }
            for (int i = 201; i <= 240; i++)
            {
                Button btn = this.Controls.Find("btn_A" + i, true).FirstOrDefault() as Button;
                btn.Enabled = state;
            }
        }

        /*
            @pressed_button = reference to the button that was pressed for form_popupKamar
            @btn_child_onClick = dynamic func that return value to pressed_button & do query whether the button is available or not (red / green)
            @tipe_kamar = tipe_kamar of the button that was pressed PS, S, JS, D
        */

        public static string pressed_button;
        public static string tipe_kamar;

        private void btn_child_onClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            pressed_button = btn.Name.Substring(5); // cast system.windows.forms.button btn to string and remove "btn_a"

            // remove "A" and whitespace and 0-9 from btn.Text
            tipe_kamar = new string(btn.Text.Where(c => !char.IsDigit(c) && !char.IsWhiteSpace(c) && c != 'A').ToArray());

            form_popupKamar popup = new form_popupKamar();
            popup.StartPosition = FormStartPosition.CenterParent;

            if (temp_used_kamar_by_pelanggan.Count > 0) // if user has already use kamar then disable btn_add button
            {
                popup.btn_add.Enabled = false;
            }

            popup.ShowDialog();
            popup.btn_add.Enabled = true;
            syncKamarCart();
            syncDgv();
            countTotalPrice();
        }

        private void cb_pelanggan_KeyDown(object sender, KeyEventArgs e) // change status to red if user pressed any key in cb_pelanggan
        {
            pic_status.BackColor = Color.Red;
            btn_proses.Hide();
            btn_tambah_pelanggan.Show();
            if (temp_pelanggan.Contains(cb_pelanggan.Text))
            {
                pic_status.BackColor = Color.Green;
                btn_proses.Show();
                btn_tambah_pelanggan.Hide();
            }
        }

        private void cb_pelanggan_SelectedValueChanged(object sender, EventArgs e) // if user select from cb then it must be correct
        {
            pic_status.BackColor = Color.Green;
            btn_proses.Show();
            btn_tambah_pelanggan.Hide();
        }

        private void btn_proses_Click(object sender, EventArgs e)
        {
            cb_pelanggan.Enabled = false;
            btn_proses.Hide();
            btn_cancel.Show();
            syncPelangganKamar();

            if (temp_used_kamar_by_pelanggan.Count == 0) // pelanggan hasn't order kamar
            {
                lbl_check_in.Show();
                datetime_check_in.Show();
                // disable btn_A101 - btn_A140 and btn_A201 - btn_A240 if backcolor is red
                for (int i = 101; i <= 140; i++)
                {
                    Button btn = this.Controls.Find("btn_A" + i, true).FirstOrDefault() as Button;
                    if (btn.BackColor == Color.Red)
                    {
                        btn.Enabled = false;
                    }
                }
                for (int i = 201; i <= 240; i++)
                {
                    Button btn = this.Controls.Find("btn_A" + i, true).FirstOrDefault() as Button;
                    if (btn.BackColor == Color.Red)
                    {
                        btn.Enabled = false;
                    }
                }
            }
            else // pelanggan already order kamar, show where they live
            {
                lbl_check_out.Show();
                datetime_check_out.Show();
                btn_remove_all.Enabled = false;
                btn_check_in.Enabled = false;
                btn_check_out.Enabled = true;

                // delete all value in cart dan cart_dt
                cart.Clear();
                cart_dt.Clear();
                countCart();
                countTotalPrice();

                syncKamarStatus();
                allKamarButtonEnabled(false);

                // so if pelanggan has order kamar, kamar that has been ordered change to blue
                foreach (string kamar_no in temp_used_kamar_by_pelanggan)
                {
                    Button btn = this.Controls.Find("btn_A" + kamar_no, true).FirstOrDefault() as Button;
                    btn.BackColor = Color.LightSkyBlue;
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cb_pelanggan.Enabled = true;
            btn_remove_all.Enabled = true;
            btn_check_in.Enabled = true;
            btn_check_out.Enabled = false;
            btn_proses.Show();
            btn_cancel.Hide();
            hideCheckAndDatetime();
            // delete all value in cart dan cart_dt
            cart.Clear();
            cart_dt.Clear();
            countCart();
            countTotalPrice();

            // enable all button
            allKamarButtonEnabled(true);
            syncKamarStatus();
        }

        private void btn_tambah_pelanggan_Click(object sender, EventArgs e)
        {
            /*
             * cb_pelanggan.Text linked to form_tambahPelanggan.txt_namaPelanggan.Text
             * to make it works, form_tambahPelanggan.txt_nama_Pelanggan modifiers is set to public
             */
            form_main.ftp.StartPosition = FormStartPosition.CenterParent;
            form_main.ftp.txt_namaPelanggan.Text = cb_pelanggan.Text;
            form_main.ftp.ShowDialog();
            form_main.ftp.txt_KotaPelanggan.Clear();
            form_main.ftp.txt_idPelanggan.Clear();
            form_main.ftp.rdb_Laki.Checked = false;
            form_main.ftp.rdb_Perempuan.Checked = false;
            syncPelanggan();
        }

        private void btn_remove_all_Click(object sender, EventArgs e)
        {
            cart.Clear();
            cart_dt.Clear();
            countCart();
            countTotalPrice();
            syncKamarStatus();
        }

        private bool validateCheckIn(string total_cart) // @validateCheckIn validate whether user has selected pelanggan and user has selected kamar
        {
            if (total_cart == "0" || cb_pelanggan.Enabled == true)
            {
                if (total_cart == "0")
                {
                    MessageBox.Show("Cart is empty, please add some room first");
                }
                if (cb_pelanggan.Enabled == true)
                {
                    MessageBox.Show("Please select a customer");
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        private void queryWithoutReturningValue(string sqlQuery, string errorMsg)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(errorMsg + ": " + ex.Message);
            }
        }

        private void checkIn() // @checkIn = query from current state of book_id, total_item
        {
            string book_id = getCurrentBookId().ToString();
            string pelanggan_id = cb_pelanggan.SelectedValue.ToString();
            string total_cart = countCart().ToString();

            if (validateCheckIn(total_cart))
            {
                if (MessageBox.Show("Are you sure want to proceed?", "Order Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string sqlQuery;
                    // step 1 booking_kamar
                    sqlQuery = $"INSERT into BOOKING_KAMAR (BOOK_ID, CUST_ID, BOOK_TGL_CIN, BOOK_KAMAR_COUNT, DELETE_BOOKING_KAMAR) " +
                        $"values({book_id}, {pelanggan_id}, curdate(), {total_cart}, false)";
                    queryWithoutReturningValue(sqlQuery, "step 1");

                    // step 2 foreach kamar in cart insert into detail_book_kamar
                    foreach (string kamar_no in cart)
                    {
                        sqlQuery = $"INSERT into DETAIL_BOOK_KAMAR (BOOK_ID, KAMAR_NO) " +
                            $"values({book_id}, {kamar_no})";
                        queryWithoutReturningValue(sqlQuery, "step 2");
                    }

                    // step 3 update kamar status to 1
                    sqlQuery = "update KAMAR AS k " +
                            "left join DETAIL_BOOK_KAMAR dbk on k.KAMAR_NO = dbk.KAMAR_NO " +
                            "left join BOOKING_KAMAR bk on dbk.BOOK_ID = bk.BOOK_ID " +
                            "set k.KAMAR_STATUS = 1 " +
                            $"where dbk.BOOK_ID = {book_id}";
                    queryWithoutReturningValue(sqlQuery, "step 3");

                    cb_pelanggan.Enabled = true;
                    btn_cancel.Hide();
                    btn_proses.Show();
                    lbl_check_in.Hide();
                    datetime_check_in.Hide();
                }
            }
        }

        private void checkOut()
        {

        }

        private void btn_check_in_Click(object sender, EventArgs e)
        {
            checkIn();
            cart.Clear();
            cart_dt.Clear();
            syncKamarStatus();
            countCart();
            countTotalPrice();
            lbl_output_book_id.Text = getCurrentBookId().ToString();
        }

        private void form_kamar_FormClosing(object sender, FormClosingEventArgs e)
        {
            cart.Clear();
            cart_dt.Clear();
            cb_pelanggan.Enabled = true;
            btn_remove_all.Enabled = true;
            btn_check_in.Enabled = true;
            btn_check_out.Enabled = false;
            temp_used_kamar_by_pelanggan.Clear();

            allKamarButtonEnabled(true);
        }
    }
}
