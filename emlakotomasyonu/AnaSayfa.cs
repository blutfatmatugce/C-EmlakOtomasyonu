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
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            skonut emlakkayıt = new skonut();
            emlakkayıt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sisyeri emlakkayıt = new sisyeri();
            emlakkayıt.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arsa emlakkayıt = new arsa();
            emlakkayıt.Show();
            this.Hide();
        }


        private void button4_Click(object sender, EventArgs e)
        {
                kisyeri emlakkayıt = new kisyeri();
                emlakkayıt.Show();
                this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
                kkonut emlakkayıt = new kkonut();
                emlakkayıt.Show();
                this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            s.Show();
            this.Hide();
        }
    }
}

