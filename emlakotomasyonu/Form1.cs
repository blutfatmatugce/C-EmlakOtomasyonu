using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emlakotomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bag baglanti = new bag();
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;


        private void güncelle()
        {
            da = new SqlDataAdapter("Select * from Sarsa", baglanti.pcbaglanti());
            ds = new DataSet();
            da.Fill(ds, "Sarsa");
            baglanti.pcbaglanti().Close();
            dataGridView1.DataSource = ds.Tables["Sarsa"];
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            bag baglanti = new bag();
            güncelle();
           
        }



        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            anaform geri = new anaform();
            geri.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            { 
                if (textBox1.Text != "")
                {
                    da = new SqlDataAdapter("select * from Skonut where il  Like'" + textBox1.Text + "%'", baglanti.pcbaglanti());
                    ds = new DataSet();
                    da.Fill(ds, "Skonut");
                    baglanti.pcbaglanti().Close();
                    dataGridView1.DataSource = ds.Tables["Skonut"];
                    da = new SqlDataAdapter();
                    dt = new DataTable();
                }
                else if (textBox2.Text != "")
                {
                    da = new SqlDataAdapter("select * from Skonut  where  İlçe  Like'" + textBox2.Text + "%'", baglanti.pcbaglanti());
                    ds = new DataSet();
                    da.Fill(ds, "Skonut");
                    baglanti.pcbaglanti().Close();
                    dataGridView1.DataSource = ds.Tables["Skonut"];
                    da = new SqlDataAdapter();
                    dt = new DataTable();
                }

            }



            if (radioButton2.Checked == true)
            {
                if (textBox1.Text != "")
                {
                    da = new SqlDataAdapter("select * from Sisyeri where İl  Like'" + textBox1.Text + "%'", baglanti.pcbaglanti());
                    ds = new DataSet();
                    da.Fill(ds, "Sisyeri");
                    baglanti.pcbaglanti().Close();
                    dataGridView1.DataSource = ds.Tables["Sisyeri"];
                    da = new SqlDataAdapter();
                    dt = new DataTable();
                }
                else if (textBox2.Text != "")
                {
                    da = new SqlDataAdapter("select * from Sisyeri  where  İlçe  Like'" + textBox2.Text + "%'", baglanti.pcbaglanti());
                    ds = new DataSet();
                    da.Fill(ds, "Sisyeri");
                    baglanti.pcbaglanti().Close();
                    dataGridView1.DataSource = ds.Tables["Sisyeri"];
                    da = new SqlDataAdapter();
                    dt = new DataTable();
                }
            }



            if (radioButton3.Checked == true)
            {
                if(textBox1.Text != "")
                {
                    da = new SqlDataAdapter("select * from Sarsa where İl  Like'" + textBox1.Text + "%'", baglanti.pcbaglanti());
                    ds = new DataSet();
                    da.Fill(ds, "Sarsa");
                    baglanti.pcbaglanti().Close();
                    dataGridView1.DataSource = ds.Tables["Sarsa"];
                    da = new SqlDataAdapter();
                    dt = new DataTable();
                }
               else if(textBox2.Text != "")
                {
                    da = new SqlDataAdapter("select * from Sarsa  where  İlçe  Like'" + textBox2.Text + "%'", baglanti.pcbaglanti());
                    ds = new DataSet();
                    da.Fill(ds, "Sarsa");
                    baglanti.pcbaglanti().Close();
                    dataGridView1.DataSource = ds.Tables["Sarsa"];
                    da = new SqlDataAdapter();
                    dt = new DataTable();
                }



            }


            if (radioButton4.Checked == true)
            {
                if (textBox1.Text != "")
                {
                    da = new SqlDataAdapter("select * from Kkonut where Il  Like'" + textBox1.Text + "%'", baglanti.pcbaglanti());
                    ds = new DataSet();
                    da.Fill(ds, "Kkonut");
                    baglanti.pcbaglanti().Close();
                    dataGridView1.DataSource = ds.Tables["Kkonut"];
                    da = new SqlDataAdapter();
                    dt = new DataTable();
                }
                else if (textBox2.Text != "")
                {
                    da = new SqlDataAdapter("select * from Kkonut  where  Ilçe  Like'" + textBox2.Text + "%'", baglanti.pcbaglanti());
                    ds = new DataSet();
                    da.Fill(ds, "Kkonut");
                    baglanti.pcbaglanti().Close();
                    dataGridView1.DataSource = ds.Tables["Kkonut"];
                    da = new SqlDataAdapter();
                    dt = new DataTable();
                }
            }


            if (radioButton5.Checked == true)
            {
                if (textBox1.Text != "")
                {
                    da = new SqlDataAdapter("select * from Kisyeri where il  Like'" + textBox1.Text + "%'", baglanti.pcbaglanti());
                    ds = new DataSet();
                    da.Fill(ds, "Kisyeri");
                    baglanti.pcbaglanti().Close();
                    dataGridView1.DataSource = ds.Tables["Kisyeri"];
                    da = new SqlDataAdapter();
                    dt = new DataTable();
                }
                else if (textBox2.Text != "")
                {
                    da = new SqlDataAdapter("select * from Sarsa  where  Ilçe  Like'" + textBox2.Text + "%'", baglanti.pcbaglanti());
                    ds = new DataSet();
                    da.Fill(ds, "Kisyeri");
                    baglanti.pcbaglanti().Close();
                    dataGridView1.DataSource = ds.Tables["Kisyeri"];
                    da = new SqlDataAdapter();
                    dt = new DataTable();
                }
            }






        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
