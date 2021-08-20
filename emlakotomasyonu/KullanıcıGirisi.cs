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
    public partial class girisekranı : Form
    {
        public girisekranı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Bilgilerinizi Kontrol Ediniz...");
                return;
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Bilgilerinizi Kontrol Ediniz...");
                return;
            }

            if (textBox1.Text != "admin" )
            {

                MessageBox.Show("Yanlış Kullanıcı!");
                return;
            }
            else if (textBox2.Text != "1234")
            {

                MessageBox.Show("Yanlış Kullanıcı!");
                return;
            }
            else
            {
                anaform emlakkayıt = new anaform();
                emlakkayıt.Show();
                this.Hide();

            }
        }
    }
}
