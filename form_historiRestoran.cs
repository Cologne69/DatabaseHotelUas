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
    public partial class form_historiRestoran : Form
    {
        public form_historiRestoran()
        {
            InitializeComponent();
        }

        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        new DataTable historiPemesanan = new DataTable();

        private void form_historiRestoran_Load(object sender, EventArgs e)
        {
            historiPemesanan.Clear();
            try
            {
                sqlQuery = $"SELECT * FROM DETAIL_ORDER_MENU";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(historiPemesanan);
                DGV_historiRestoran.DataSource = historiPemesanan;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGV_historiRestoran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
