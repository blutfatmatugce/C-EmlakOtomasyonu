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
    public partial class kkonut : Form
    {
        public kkonut()
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
            SqlDataAdapter adp = new SqlDataAdapter("select * from Kkonut ", baglanti.pcbaglanti());
            DataTable dt = new DataTable();
            adp.Fill(dt);
            baglanti.pcbaglanti().Close();
            return dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            anaform emlakkayıt = new anaform();
            emlakkayıt.Show();
            this.Hide();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti.pcbaglanti();
            komut.CommandText = "Insert into Kkonut (IlanBaşlığı,Fiyat,KrediUygunluk,EmlakTipi,Metrekare,OdaSalon,Il,Ilçe,Adres,EklemeTarihi,KullanımDurumu,Açıklama,AdSoyad,Telefon,Notlar,BinaYaşı,BinadakiKatSayısı) values(@k2,@k3,@k4,@k5,@k6,@k7,@k8,@k9,@k10,@k11,@k12,@k13,@k14,@k15,@k16,@k18,@k19)";
            
            komut.Parameters.AddWithValue("@k2", ilantxt.Text);
            komut.Parameters.AddWithValue("@k3", txtFiyat.Text);
            komut.Parameters.AddWithValue("@k4", txtMetrekare.Text);
            komut.Parameters.AddWithValue("@k5", cbEmlakTipi.Text);
            komut.Parameters.AddWithValue("@k6", txtkredi.Text);
            komut.Parameters.AddWithValue("@k7", textoda.Text);
            komut.Parameters.AddWithValue("@k8", txtil.Text);
            komut.Parameters.AddWithValue("@k9", txtilce.Text);
            komut.Parameters.AddWithValue("@k10", txtadress.Text);
            komut.Parameters.AddWithValue("@k11", dtpEklenmeTarihi.Value);
            komut.Parameters.AddWithValue("@k12", txtdrm.Text);
            komut.Parameters.AddWithValue("@k13", txtnot.Text);
            komut.Parameters.AddWithValue("@k14", txtad.Text);
            komut.Parameters.AddWithValue("@k15", txttel.Text);
            komut.Parameters.AddWithValue("@k16", textBox10.Text);
            komut.Parameters.AddWithValue("@k18", textyas.Text);
            komut.Parameters.AddWithValue("@k19", txtkat.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("EKLENDİ");
            baglanti.pcbaglanti().Close();
            dataGridView1.DataSource = refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti.pcbaglanti();
            komut.CommandText = "Delete Kkonut Where ID=@ID";
            komut.Parameters.AddWithValue("@ID", txtid.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("SILINDI");
            baglanti.pcbaglanti().Close();
            dataGridView1.DataSource = refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti.pcbaglanti();
            komut.CommandText = "Update Kkonut Set IlanBaşlığı=@k2,Fiyat=@k3,KrediUygunluk=@k4,EmlakTipi=@k5,Metrekare=@k6,OdaSalon=@k7,Il=@k8,Ilçe=@k9,Adres=@k10,EklemeTarihi=@k11,KullanımDurumu=@k12,Açıklama=@k13,AdSoyad=@k14,Telefon=@k15,Notlar=@k16,BinaYaşı=@k18,BinadakiKatSayısı=@k19 ";
           
            komut.Parameters.AddWithValue("@k2", ilantxt.Text);
            komut.Parameters.AddWithValue("@k3", txtFiyat.Text);
            komut.Parameters.AddWithValue("@k4", txtMetrekare.Text);
            komut.Parameters.AddWithValue("@k5", cbEmlakTipi.Text);
            komut.Parameters.AddWithValue("@k6", txtkredi.Text);
            komut.Parameters.AddWithValue("@k7", textoda.Text);
            komut.Parameters.AddWithValue("@k8", txtil.Text);
            komut.Parameters.AddWithValue("@k9", txtilce.Text);
            komut.Parameters.AddWithValue("@k10", txtadress.Text);
            komut.Parameters.AddWithValue("@k11", dtpEklenmeTarihi.Value);
            komut.Parameters.AddWithValue("@k12", txtdrm.Text);
            komut.Parameters.AddWithValue("@k13", txtnot.Text);
            komut.Parameters.AddWithValue("@k14", txtad.Text);
            komut.Parameters.AddWithValue("@k15", txttel.Text);
            komut.Parameters.AddWithValue("@k16", textBox10.Text);
            komut.Parameters.AddWithValue("@k18", textyas.Text);
            komut.Parameters.AddWithValue("@k19", txtkat.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("GUNCELLENDİ");
            baglanti.pcbaglanti().Close();
            dataGridView1.DataSource = refresh();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ilantxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMetrekare.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbEmlakTipi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtkredi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textoda.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtil.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtilce.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtadress.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            dtpEklenmeTarihi.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtdrm.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtnot.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txttel.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
           
            textyas.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            txtkat.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
