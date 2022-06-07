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
    public partial class form_invoiceResto : Form
    {
        public form_invoiceResto()
        {
            InitializeComponent();
        }
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        DataTable invoice = new DataTable();

        private void DGV_InvoiceResto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void form_invoiceResto_Load(object sender, EventArgs e)
        {
            this.DGV_InvoiceResto.Rows.Add();
        }
    }
}
