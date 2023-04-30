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
    public partial class timer_kul : Form
    {
        public timer_kul()
        {
            InitializeComponent();
        }

        private void timer_kul_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (sayacc == 100)
            {
                timer1.Stop();
            }
            sayacc++;
            guna2ProgressBar1.Value = sayacc;
            if (sayacc == 100)
            {
                anasayfa git = new anasayfa();
                git.Show();
                this.Hide();
            }
        }
        int sayacc = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayacc == 100)
            {
                timer1.Stop();
            }
            sayacc++;
            guna2ProgressBar1.Value = sayacc;
            if (sayacc == 100)
            {
                anasayfa_kul git = new anasayfa_kul();
                giris_kul gel = new giris_kul();
                git.label2.Text = gel.guna2TextBox1.Text.ToUpper();
                git.Show();
                this.Hide();
            }
        }
    }
}
