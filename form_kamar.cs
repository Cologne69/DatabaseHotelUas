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
    public partial class form_kamar : Form
    {
        public form_kamar()
        {
            InitializeComponent();

        }
        private void form_kamar_Load(object sender, EventArgs e)
        {
            
            
            
            /*
             * query check for KAMAR_STATUS = 1
             * append(btn_A{KAMAR_NO})
             * change it to red
             */
            DataTable filled_kamar_dt = new DataTable();
            List<String> filled_kamar = new List<string>();

            string sqlQuery = "SELECT KAMAR_NO FROM KAMAR WHERE KAMAR_STATUS = 1";
            new MySqlDataAdapter(sqlQuery, form_main.sqlConnect).Fill(filled_kamar_dt);
            filled_kamar = filled_kamar_dt.AsEnumerable().Select(x => x.Field<String>("KAMAR_NO")).ToList();

            // append "btn_A" to every child in filled_kamar and change it as button backColor to red
            foreach (string kamar_no in filled_kamar)
            {
                Button btn = this.Controls.Find("btn_A" + kamar_no, true).FirstOrDefault() as Button;
                btn.BackColor = Color.Red;
            }

            LblKeterangan.Text = "1. Presidential Suite (PS)\n2. Suite(S)\n3. Junior Suite(JS)\n4. Deluxe(D)";

        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
                
        private void btn_lantai2_Click(object sender, EventArgs e)
        {
            btn_lantai2.BackColor = Color.Lime;
            btn_lantai1.BackColor = Color.Red;
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
            btn_lantai2.BackColor = Color.Red;
            btn_lantai1.BackColor = Color.Lime;
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

        /*
            @pressed_button = reference to the button that was pressed for form_popupKamar
            @btn_child_onClick = dynamic func that return value to pressed_button & do query whether the button is available or not (red / green)
        */

        public string pressed_button;
        private void btn_child_onClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;

            // cast system.windows.forms.button btn to string
            pressed_button = btn.Name;
        }

        private void cb_namaPelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
