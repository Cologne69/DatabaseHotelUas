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

            DGV_historiRestoran.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_historiRestoran.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_historiRestoran.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            for (int i = 0; i <= DGV_historiRestoran.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = DGV_historiRestoran.Columns[i].Width;

                // Remove AutoSizing:
                DGV_historiRestoran.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                DGV_historiRestoran.Columns[i].Width = colw;
            }
        }

        private void DGV_historiRestoran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void form_historiRestoran_Resize(object sender, EventArgs e)
        {
            
        }

        private void form_historiRestoran_StyleChanged(object sender, EventArgs e)
        {
            
        }
    }
}
