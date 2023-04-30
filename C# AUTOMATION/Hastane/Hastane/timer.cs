using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane
{
    public partial class timer : Form
    {
        public timer()
        {
            InitializeComponent();
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac == 100)
            {
                timer1.Stop();
            }
            sayac++;
            guna2ProgressBar1.Value = sayac;
            if (sayac == 100)
            {
                anasayfa git = new anasayfa();
                giris gel = new giris();
                git.label4.Text = gel.guna2TextBox1.Text.ToUpper();
                git.Show();
                this.Hide();
            }

        }

        private void timer_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (sayac == 100)
            {
                timer1.Stop();
            }
            sayac++;
            guna2ProgressBar1.Value = sayac;
            if (sayac == 100)
            {
                anasayfa git = new anasayfa();
                git.Show();
                this.Hide();
            }
        }
    }
}
