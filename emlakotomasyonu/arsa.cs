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
    public partial class arsa : Form
    {
        public arsa()
        {
            InitializeComponent();
        }
        bag baglanti = new bag();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = refresh();
        }


        DataTable refresh()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select İlanBaşlığı,Fiyat,MetreKare,KatKarşılığı,KrediUygunluk,İl,İlçe,Adres,EklemeTarihi,Durum,Açıklama,AdSoyad,Telefon,Notlar from Sarsa ", baglanti.pcbaglanti());
            DataTable dt = new DataTable();
            adp.Fill(dt);
            baglanti.pcbaglanti().Close();
            return dt;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ilantxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMetrekare.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtkat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtkredi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtil.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtilce.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtadress.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            dtpEklenmeTarihi.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtdrm.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtnot.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txttel.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            textnotlar.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();


        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti.pcbaglanti();
            komut.CommandText = "Insert into Sarsa (İlanBaşlığı,Fiyat,MetreKare,KatKarşılığı,KrediUygunluk,İl,İlçe,Adres,EklemeTarihi,Durum,Açıklama,AdSoyad,Telefon,Notlar) values(@k2,@k3,@k4,@k5,@k6,@k7,@k8,@k9,@k10,@k11,@k12,@k13,@k14,@k15)";
           
            komut.Parameters.AddWithValue("@k2", ilantxt.Text);
            komut.Parameters.AddWithValue("@k3", txtFiyat.Text);
            komut.Parameters.AddWithValue("@k4", txtMetrekare.Text);
            komut.Parameters.AddWithValue("@k5", txtkat.Text);
            komut.Parameters.AddWithValue("@k6", txtkredi.Text);
            komut.Parameters.AddWithValue("@k7", txtil.Text);
            komut.Parameters.AddWithValue("@k8", txtilce.Text);
            komut.Parameters.AddWithValue("@k9", txtadress.Text);
            komut.Parameters.AddWithValue("@k10", dtpEklenmeTarihi.Value);
            komut.Parameters.AddWithValue("@k11", txtdrm.Text);
            komut.Parameters.AddWithValue("@k12", txtnot.Text);
            komut.Parameters.AddWithValue("@k13", txtad.Text);
            komut.Parameters.AddWithValue("@k14", txttel.Text);
            komut.Parameters.AddWithValue("@k15", textnotlar.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("EKLENDİ");
            baglanti.pcbaglanti().Close();
            dataGridView1.DataSource = refresh();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti.pcbaglanti();
            komut.CommandText = "Update Sarsa Set İlanBaşlığı=@k2,Fiyat=@k3,MetreKare=@k4,KatKarşılığı=@k5,KrediUygunluk=@k6,İl=@k7,İlçe=@k8,Adres=@k9,EklemeTarihi=@k10,Durum=@k11,Açıklama=@k12,AdSoyad=@k13,Telefon=@k14,Notlar=@k15 ";
           
            komut.Parameters.AddWithValue("@k2", ilantxt.Text);
            komut.Parameters.AddWithValue("@k3", txtFiyat.Text);
            komut.Parameters.AddWithValue("@k4", txtMetrekare.Text);
            komut.Parameters.AddWithValue("@k5", txtkat.Text);
            komut.Parameters.AddWithValue("@k6", txtkredi.Text);
            komut.Parameters.AddWithValue("@k7", txtil.Text);
            komut.Parameters.AddWithValue("@k8", txtilce.Text);
            komut.Parameters.AddWithValue("@k9", txtadress.Text);
            komut.Parameters.AddWithValue("@k10", dtpEklenmeTarihi.Value);
            komut.Parameters.AddWithValue("@k11", txtdrm.Text);
            komut.Parameters.AddWithValue("@k12", txtnot.Text);
            komut.Parameters.AddWithValue("@k13", txtad.Text);
            komut.Parameters.AddWithValue("@k14", txttel.Text);
            komut.Parameters.AddWithValue("@k15", textnotlar.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("GUNCELLENDİ");
            baglanti.pcbaglanti().Close();
            dataGridView1.DataSource = refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti.pcbaglanti();
            komut.CommandText = "DELETE from Sarsa where ID=@ID";
            komut.Parameters.AddWithValue("@ID", txtid.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("SİLİNDİ");
            baglanti.pcbaglanti().Close();
            dataGridView1.DataSource = refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            anaform ekran = new anaform();
            ekran.Show();
            this.Hide();
        }
    }
}
