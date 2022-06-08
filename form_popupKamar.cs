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
    public partial class form_popupKamar : Form
    {
        public form_popupKamar()
        {
            InitializeComponent();
        }
        private void form_popupKamar_Load(object sender, EventArgs e)
        {
            sync();
            lbl_no_kamar.Text = "A"+form_kamar.pressed_button;
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
                    lbl_list_fasilitas.Text = "1. 1 kamar king bed\n2. Ukuran kamar 50 meter persegi (m2)";
                    break; 
                default:
                    lbl_tipe_kamar.Text = "Error occured";
                    break;
            }
        }

        private void sync()
        {
            // check if form_kamar.pressed_button is in form_kamar.filled_kamar list
            if (form_kamar.filled_kamar.Contains(form_kamar.pressed_button))
            {
                // if true, hide datetime_check_in and lbl_check_in
                lbl_check_in.Hide();
                datetime_check_in.Hide();
            }
            else
            {
                // vice versa
                lbl_check_out.Hide();
                datetime_check_out.Hide();
            }
        }
    }
}
