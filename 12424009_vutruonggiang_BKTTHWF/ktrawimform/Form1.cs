using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Quic;



namespace ktrawimform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(conn);
        }
        string conn = @"Data Source=my_pc_giang\SQLEXPRESS;Initial Catalog=QLSP;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataTable ta;

        public DataTable loadata(string qr)
        {
            adap = new SqlDataAdapter(qr, connection);
            ta = new DataTable();
            adap.Fill(ta);
            return ta;
        }

        public void thuchien(string qr)
        {
            adap = new SqlDataAdapter(qr, connection);
            ta = new DataTable();
            adap.Fill(ta);
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = loadata("select * from Productt ");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            loadata($"insert into Productt(ProducttID, ProducttName , Price , Quantity ) values ('" + txtmasp.Text + "' ,'" + txtten.Text + "','" + txtgia.Text + "','" + txtsoluong.Text + "')");
            dataGridView1.DataSource = loadata("select * from Productt");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql=($"update Productt set ProducttName = '{txtten.Text}',Price = '{txtgia.Text}',Quantity = '{txtsoluong.Text}' where ProducttID = '{txtmasp.Text}' ");
            loadata(sql);
            dataGridView1.DataSource = loadata("select * from Productt");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtmasp.Clear();
            txtten.Clear();
            txtgia.Clear();
            txtsoluong.Clear();
        }

        private void cbbloaisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtmasp.Text = dataGridView1.Rows[hang].Cells[0].Value.ToString();
            txtten.Text = dataGridView1.Rows[hang].Cells[1].Value.ToString();
            txtgia.Text = dataGridView1.Rows[hang].Cells[2].Value.ToString();
            txtsoluong.Text = dataGridView1.Rows[hang].Cells[3].Value.ToString();
        }
    }
}
