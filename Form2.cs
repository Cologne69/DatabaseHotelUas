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
    public partial class form_parkir : Form
    {
        public form_parkir()
        {
            InitializeComponent();
        }
       

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
