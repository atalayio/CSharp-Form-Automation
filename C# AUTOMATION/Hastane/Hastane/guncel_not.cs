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
    public partial class guncel_not : Form
    {
        public guncel_not()
        {
            InitializeComponent();
            
            
            



        }

        giris giris = new giris();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guncel_not_Load(object sender, EventArgs e)
        {
            int pos = giris.pos;
            pos += giris.Width * 2;

            this.Location = new Point(pos, this.Location.Y + (this.Location.Y / 2));

            v1panel.Size = new Size(v1panel.Width, 31);
            v2panel.Size = new Size(v2panel.Width, 31);
            v3panel.Size = new Size(v3panel.Width, 31);
            v4panel.Size = new Size(v3panel.Width, 31);
            v5panel.Size = new Size(v3panel.Width, 31);
            v6panel.Size = new Size(v3panel.Width, 31);
            v2panel.Location = new Point(v2panel.Location.X, v1panel.Height + v1panel.Location.Y);
            v3panel.Location = new Point(v3panel.Location.X, v2panel.Height + v2panel.Location.Y);
            v4panel.Location = new Point(v4panel.Location.X, v3panel.Height + v3panel.Location.Y);
            v5panel.Location = new Point(v5panel.Location.X, v4panel.Height + v4panel.Location.Y);
            v6panel.Location = new Point(v6panel.Location.X, v5panel.Height + v5panel.Location.Y);
        }

        int v1 = 1, v2 = 1, v3 = 1, v4 = 1, v5 = 1, v6 = 1;

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (v5 == 0)
            {
                v5panel.Size = new Size(v5panel.Width, 31);
                v5 = 1;
            }
            else if (v5 == 1)
            {
                v5panel.Size = new Size(v5panel.Width, 109);
                v5 = 0;
            }
            v2panel.Location = new Point(v2panel.Location.X, v1panel.Height + v1panel.Location.Y);
            v3panel.Location = new Point(v3panel.Location.X, v2panel.Height + v2panel.Location.Y);
            v4panel.Location = new Point(v4panel.Location.X, v3panel.Height + v3panel.Location.Y);
            v5panel.Location = new Point(v5panel.Location.X, v4panel.Height + v4panel.Location.Y);
            v6panel.Location = new Point(v6panel.Location.X, v5panel.Height + v5panel.Location.Y);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (v6 == 0)
            {
                v6panel.Size = new Size(v6panel.Width, 31);
                v6 = 1;
            }
            else if (v6 == 1)
            {
                v6panel.Size = new Size(v6panel.Width, 109);
                v6 = 0;
            }
            v2panel.Location = new Point(v2panel.Location.X, v1panel.Height + v1panel.Location.Y);
            v3panel.Location = new Point(v3panel.Location.X, v2panel.Height + v2panel.Location.Y);
            v4panel.Location = new Point(v4panel.Location.X, v3panel.Height + v3panel.Location.Y);
            v5panel.Location = new Point(v5panel.Location.X, v4panel.Height + v4panel.Location.Y);
            v6panel.Location = new Point(v6panel.Location.X, v5panel.Height + v5panel.Location.Y);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (v4 == 0)
            {
                v4panel.Size = new Size(v4panel.Width, 31);
                v4 = 1;
            }
            else if (v4 == 1)
            {
                v4panel.Size = new Size(v4panel.Width, 138);
                v4 = 0;
            }
            v2panel.Location = new Point(v2panel.Location.X, v1panel.Height + v1panel.Location.Y);
            v3panel.Location = new Point(v3panel.Location.X, v2panel.Height + v2panel.Location.Y);
            v4panel.Location = new Point(v4panel.Location.X, v3panel.Height + v3panel.Location.Y);
            v5panel.Location = new Point(v5panel.Location.X, v4panel.Height + v4panel.Location.Y);
            v6panel.Location = new Point(v6panel.Location.X, v5panel.Height + v5panel.Location.Y);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (v1 == 0)
            {
                v1panel.Size = new Size(v1panel.Width, 31);
                v1 = 1;
            }
            else if (v1 == 1)
            {
                v1panel.Size = new Size(v1panel.Width, 131);
                v1 = 0;
            }
            v2panel.Location = new Point(v2panel.Location.X, v1panel.Height + v1panel.Location.Y);
            v3panel.Location = new Point(v3panel.Location.X, v2panel.Height + v2panel.Location.Y);
            v4panel.Location = new Point(v4panel.Location.X, v3panel.Height + v3panel.Location.Y);
            v5panel.Location = new Point(v5panel.Location.X, v4panel.Height + v4panel.Location.Y);
            v6panel.Location = new Point(v6panel.Location.X, v5panel.Height + v5panel.Location.Y);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (v2 == 0)
            {
                v2panel.Size = new Size(v2panel.Width, 31);
                v2 = 1;
            }
            else if (v2 == 1)
            {
                v2panel.Size = new Size(v2panel.Width, 131);
                v2 = 0;
            }
            v2panel.Location = new Point(v2panel.Location.X, v1panel.Height + v1panel.Location.Y);
            v3panel.Location = new Point(v3panel.Location.X, v2panel.Height + v2panel.Location.Y);
            v4panel.Location = new Point(v4panel.Location.X, v3panel.Height + v3panel.Location.Y);
            v5panel.Location = new Point(v5panel.Location.X, v4panel.Height + v4panel.Location.Y);
            v6panel.Location = new Point(v6panel.Location.X, v5panel.Height + v5panel.Location.Y);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (v3 == 0)
            {
                v3panel.Size = new Size(v3panel.Width, 31);
                v3 = 1;
            }
            else if (v3 == 1)
            {
                v3panel.Size = new Size(v3panel.Width, 161);
                v3 = 0;
            }
            v2panel.Location = new Point(v2panel.Location.X, v1panel.Height + v1panel.Location.Y);
            v3panel.Location = new Point(v3panel.Location.X, v2panel.Height + v2panel.Location.Y);
            v4panel.Location = new Point(v4panel.Location.X, v3panel.Height + v3panel.Location.Y);
            v5panel.Location = new Point(v5panel.Location.X, v4panel.Height + v4panel.Location.Y);
            v6panel.Location = new Point(v6panel.Location.X, v5panel.Height + v5panel.Location.Y);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        

        
    }
}
