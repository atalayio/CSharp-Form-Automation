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
    public partial class sunucu_isim : Form
    {
        public sunucu_isim()
        {
            InitializeComponent();
        }

        abone abone = new abone();
        public static string isim;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            

            if (bunifuTextBox1.Text != "" || bunifuTextBox1.Text != null)
            {
                isim=bunifuTextBox1.Text.ToString();
                MessageBox.Show("Server başarıyla eklendi!","Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bu alan boş bırakılamaz!.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bunifuTextBox1.Text = "";
;            }
            label3.Visible = true;
            label4.Visible = true;
        }

        private void sunucu_isim_Load(object sender, EventArgs e)
        {
            giris giris = new giris();
            int posY = giris.Location.Y;
            int posX = giris.Location.X;

            this.Location = new Point(this.Location.X+this.Width,this.Location.Y+this.Height);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
