using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace emlakotomasyonu
{
    public partial class kisyeri : Form
    {
        public kisyeri()
        {
            InitializeComponent();
        }
        bag baglanti = new bag();

        private void kisyeri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = refresh();
        }

        DataTable refresh()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Kisyeri ", baglanti.pcbaglanti());
            DataTable dt = new DataTable();
            adp.Fill(dt);
            baglanti.pcbaglanti().Close();
            return dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            anaform geri = new anaform();
            geri.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ilantxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMetrekare.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbEmlakTipi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtkredi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textdevren.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtil.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtilce.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtadress.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            dtpEklenmeTarihi.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtdrm.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtnot.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti.pcbaglanti();
            komut.CommandText = "Insert into Kisyeri (ilanbaşlığı,fiyat,metrekare,emlaktipi,krediyeuygunluk,devren,il,ilçe,adres,eklemetarihi,emlağındurumu,notlar,adsoyad,telefon,açıklama) values(@k2,@k3,@k4,@k5,@k6,@k7,@k8,@k9,@k10,@k11,@k12,@k13,@k14,@k15,@k16)";
          
            komut.Parameters.AddWithValue("@k2", ilantxt.Text);
            komut.Parameters.AddWithValue("@k3", txtFiyat.Text);
            komut.Parameters.AddWithValue("@k4", txtMetrekare.Text);
            komut.Parameters.AddWithValue("@k5", cbEmlakTipi.Text);
            komut.Parameters.AddWithValue("@k6", txtkredi.Text);
            komut.Parameters.AddWithValue("@k7", textdevren.Text);
            komut.Parameters.AddWithValue("@k8", txtil.Text);
            komut.Parameters.AddWithValue("@k9", txtilce.Text);
            komut.Parameters.AddWithValue("@k10", txtadress.Text);
            komut.Parameters.AddWithValue("@k11", dtpEklenmeTarihi.Value);
            komut.Parameters.AddWithValue("@k12", txtdrm.Text);
            komut.Parameters.AddWithValue("@k13", txtnot.Text);
            komut.Parameters.AddWithValue("@k14", textBox8.Text);
            komut.Parameters.AddWithValue("@k15", textBox9.Text);
            komut.Parameters.AddWithValue("@k16", textBox10.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("EKLENDİ");
            baglanti.pcbaglanti().Close();
            dataGridView1.DataSource = refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti.pcbaglanti();
            komut.CommandText = "Delete Kisyeri Where ID=@ID";
            komut.Parameters.AddWithValue("@ID", textBox1.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("SILINDI");
            baglanti.pcbaglanti().Close();
            dataGridView1.DataSource = refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti.pcbaglanti();
            komut.CommandText = "Update Kisyeri Set ilanbaşlığı=@k2,fiyat=@k3,metrekare=@k4,emlaktipi=@k5,krediyeuygunluk=@k6,devren=@k7,il=@k8,ilçe=@k9,adres=@k10,eklemetarihi=@k11,emlağındurumu=@k12,notlar=@k13,adsoyad=@k14,telefon=@k15,açıklama=@k16 ";
           
            komut.Parameters.AddWithValue("@k2", ilantxt.Text);
            komut.Parameters.AddWithValue("@k3", txtFiyat.Text);
            komut.Parameters.AddWithValue("@k4", txtMetrekare.Text);
            komut.Parameters.AddWithValue("@k5", cbEmlakTipi.Text);
            komut.Parameters.AddWithValue("@k6", txtkredi.Text);
            komut.Parameters.AddWithValue("@k7", textdevren.Text);
            komut.Parameters.AddWithValue("@k8", txtil.Text);
            komut.Parameters.AddWithValue("@k9", txtilce.Text);
            komut.Parameters.AddWithValue("@k10", txtadress.Text);
            komut.Parameters.AddWithValue("@k11", dtpEklenmeTarihi.Value);
            komut.Parameters.AddWithValue("@k12", txtdrm.Text);
            komut.Parameters.AddWithValue("@k13", txtnot.Text);
            komut.Parameters.AddWithValue("@k14", textBox8.Text);
            komut.Parameters.AddWithValue("@k15", textBox9.Text);
            komut.Parameters.AddWithValue("@k16", textBox10.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("GUNCELLENDİ");
            baglanti.pcbaglanti().Close();
            dataGridView1.DataSource = refresh();
        }
    }
    
}
