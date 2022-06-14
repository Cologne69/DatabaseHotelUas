﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace DatabaseHotelUas
{
    public partial class form_idPelanggan : Form
    {
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        new DataTable pelanggan = new DataTable();
        private static List<string> list_pelanggan = new List<string>();

        public form_idPelanggan()
        {
            InitializeComponent();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            txt_cariNamaPelanggan.Text = "";
        }
        private void form_idPelanggan_Load(object sender, EventArgs e)
        {
            pelanggan.Clear();
            syncPelanggan();
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txt_cariNamaPelanggan.Text = "";
        }
        private void syncPelanggan()
        {
            try
            {
                sqlQuery = $"SELECT CUST_ID as 'CUSTOMER ID', CUST_NAMA as 'CUSTOMER NAMA', CUST_KOTA as 'CUSTOMER KOTA', DELETE_CUST as 'DELETE CUSTOMER', CUST_KELAMIN as 'CUSTOMER KELAMIN' FROM CUSTOMER";
                sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(pelanggan);
                dataGridView1.DataSource = pelanggan;

                list_pelanggan = pelanggan.AsEnumerable().Select(x => x.Field<String>("CUSTOMER NAMA")).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_cariNama_Click(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_deletePelanggan_Click(object sender, EventArgs e)
        {
            //form_main.fdp.ShowDialog(); 
            if (MessageBox.Show("Apakah anda yakin mau menghapus pelanggan tersebut?", "Hapus pelanggan", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    sqlQuery = $"DELETE FROM CUSTOMER WHERE CUST_ID = '{dataGridView1.CurrentRow.Cells[0].Value.ToString()}';";
                    sqlCommand = new MySqlCommand(sqlQuery, form_main.sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(pelanggan);
                    MessageBox.Show($"Pelanggan dengan ID: {dataGridView1.CurrentRow.Cells[0].Value.ToString()} berhasil dihapus");
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            btnProses.Hide();
            btnTambahPelanggan.Hide(); 
            btn_deletePelanggan.Hide();
            pelanggan.DefaultView.RowFilter = string.Format("`CUSTOMER NAMA` LIKE '%{0}%'", txt_cariNamaPelanggan.Text);
            for (int i = 0; i < pelanggan.DefaultView.Count; i++)
            {
                if (pelanggan.DefaultView.RowFilter.Contains(txt_cariNamaPelanggan.Text))
                {
                    statusNamaPelanggan.BackColor = Color.Red;
                    btn_deletePelanggan.Show();
                    i = pelanggan.DefaultView.Count;
                }
            }
            if (statusNamaPelanggan.BackColor == Color.White)
            {
                statusNamaPelanggan.BackColor = Color.Green;
                btnTambahPelanggan.Show();
            }
        }

        private void txt_cariNamaPelanggan_TextChanged(object sender, EventArgs e)
        {
            statusNamaPelanggan.BackColor = Color.White;
            btnProses.Show();

        }

        private void btnTambahPelanggan_Click(object sender, EventArgs e)
        {
            form_main.ftp.StartPosition = FormStartPosition.CenterParent;
            form_main.ftp.txt_namaPelanggan.Text = txt_cariNamaPelanggan.Text;
            form_main.ftp.ShowDialog();
            form_main.ftp.txt_KotaPelanggan.Clear();
            form_main.ftp.txt_idPelanggan.Clear();
            form_main.ftp.rdb_Laki.Checked = false;
            form_main.ftp.rdb_Perempuan.Checked = false;
        }
    }
}
