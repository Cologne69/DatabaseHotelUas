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
    public partial class form_riwayatKamar : Form
    {
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable riwayatKamar = new DataTable();
        DataTable transID = new DataTable();
        public form_riwayatKamar()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            try
            {
                riwayatKamar = new DataTable();
                sqlQuery = $"SELECT BOOK_ID, CUST_ID, BOOK_TGL_CIN, BOOK_TGL_COUT, BOOK_KAMAR_COUNT, BOOK_TOTAL FROM BOOKING_KAMAR WHERE TRANS_ID='"+cBoxTransID.Text+"'; ";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(riwayatKamar);
                dgv_riwayatKamar.RowHeadersVisible = false;
                dgv_riwayatKamar.DataSource = riwayatKamar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void form_riwayatKamar_Load(object sender, EventArgs e)
        {
            transID = new DataTable();
            string sqlQuery = $"SELECT TRANS_ID as 'trans' FROM BOOKING_KAMAR WHERE TRANS_ID is not null";
            sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(transID);
            cBoxTransID.DataSource = transID;
            cBoxTransID.DisplayMember = "trans";
        }
    }
}
