using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memgamev1
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
            timer1.Start();
            
            foreach (PictureBox picture in holder.Controls)
            {
                picture.BackgroundImage = Properties.Resources.impossibly_cute_puppy_21;
            }

        }

        

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.BackgroundImage = Properties.Resources.impossibly_cute_puppy_21;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.impossibly_cute_puppy_21;

        }

        
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox picture in holder.Controls)
            {
                picture.BackgroundImage = Properties.Resources.unnamed;
            }

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.impossibly_cute_puppy_21;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.impossibly_cute_puppy_21;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = Properties.Resources.impossibly_cute_puppy_21;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.BackgroundImage = Properties.Resources.impossibly_cute_puppy_21;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.BackgroundImage = Properties.Resources.impossibly_cute_puppy_21;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.BackgroundImage = Properties.Resources.impossibly_cute_puppy_21;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.BackgroundImage = Properties.Resources.impossibly_cute_puppy_21;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.BackgroundImage = Properties.Resources.impossibly_cute_puppy_21;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.BackgroundImage = Properties.Resources.impossibly_cute_puppy_21;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.BackgroundImage = Properties.Resources.impossibly_cute_puppy_21;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = Properties.Resources.impossibly_cute_puppy_21;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.BackgroundImage = Properties.Resources.impossibly_cute_puppy_21;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.BackgroundImage = Properties.Resources.impossibly_cute_puppy_21;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.BackgroundImage = Properties.Resources.impossibly_cute_puppy_21;
        }
    }
}
