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
            lbl_no_kamar.Text = form_kamar.pressed_button;
        }

        private void sync()
        {
            
        }
    }
}
