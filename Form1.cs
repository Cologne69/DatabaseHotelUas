﻿using System;
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
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }
        
        //----------------------------------------------------- BMYSQL SERVER -----------------------------------------------------
        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public static MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public static MySqlCommand sqlCommand;
        public static MySqlDataAdapter mySqlAdapter;
        public string sqlQuery;
        //----------------------------------------------------- MYSQL SERVER -----------------------------------------------------

        
        //----------------------------------------------------- BAGIAN FORMS -----------------------------------------------------
        public static Form_Cek_Transaksi fct = new Form_Cek_Transaksi();
        public static form_kamar fk = new form_kamar();
        public static form_resto fr = new form_resto();
        public static form_main fm = new form_main();
        //----------------------------------------------------- BAGIAN FORMS -----------------------------------------------------

        private void lbl_testTanggal_Click(object sender, EventArgs e)
        {

        }

        private void tgl_checkin_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            fct.ShowDialog();
            
        }
        
        private void btn_lihatkamar_Click(object sender, EventArgs e)
        {
            
            fk.ShowDialog();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
