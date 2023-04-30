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
    public partial class hasta : Form
    {
        public hasta()
        {
            InitializeComponent();
            
        }

        private void hasta_menu_Load(object sender, EventArgs e)
        {
            
        }

        

       

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel123.Controls.Clear();
            hasta_ekle ekle = new hasta_ekle();
            ekle.Dock = DockStyle.Fill;
            ekle.TopLevel = false;
            panel123.Controls.Add(ekle);
            ekle.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel123.Controls.Clear();
            hasta_sil ekle = new hasta_sil();
            ekle.Dock = DockStyle.Fill;
            ekle.TopLevel = false;
            panel123.Controls.Add(ekle);
            ekle.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panel123.Controls.Clear();
            kullanici ekle = new kullanici();
            ekle.Dock = DockStyle.Fill;
            ekle.TopLevel = false;
            panel123.Controls.Add(ekle);
            ekle.Show();
        }
    }
}
