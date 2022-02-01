using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Bitmap bg = new Bitmap("E:\\project\\Classic Bingo\\avatarbg.png");
        // red avatars for player 1
        Bitmap avatar1 = new Bitmap("E:\\project\\Classic Bingo\\red1.png");
        Bitmap avatar2 = new Bitmap("E:\\project\\Classic Bingo\\red2.png");
        Bitmap avatar3 = new Bitmap("E:\\project\\Classic Bingo\\red3.png");
        Bitmap avatar4 = new Bitmap("E:\\project\\Classic Bingo\\red4.png");

        // yellow avatars for player 2
        Bitmap avatar5 = new Bitmap("E:\\project\\Classic Bingo\\yellow1.png");
        Bitmap avatar6 = new Bitmap("E:\\project\\Classic Bingo\\yellow2.png");
        Bitmap avatar7 = new Bitmap("E:\\project\\Classic Bingo\\yellow3.png");
        Bitmap avatar8 = new Bitmap("E:\\project\\Classic Bingo\\yellow4.png");

        private void Form5_Load(object sender, EventArgs e)
        {
            BackgroundImage = bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BackgroundImageLayout = pictureBox2.BackgroundImageLayout = pictureBox3.BackgroundImageLayout = pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.BackgroundImageLayout = pictureBox6.BackgroundImageLayout = pictureBox7.BackgroundImageLayout = pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = avatar1;
            pictureBox2.Image = avatar2;
            pictureBox3.Image = avatar3;
            pictureBox4.Image = avatar4;
            pictureBox5.Image = avatar5;
            pictureBox6.Image = avatar6;
            pictureBox7.Image = avatar7;
            pictureBox8.Image = avatar8;
            player1.Image = avatar1;
            player2.Image = avatar5;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            player1.Image = pictureBox1.Image;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            player1.Image = pictureBox3.Image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            player1.Image = pictureBox2.Image;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            player1.Image = pictureBox4.Image;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            player2.Image = pictureBox5.Image;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            player2.Image = pictureBox7.Image;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            player2.Image = pictureBox8.Image;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            player2.Image = pictureBox6.Image;
        }

        private void Done_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4(firstplayer.Text, secondplayer.Text, player1.Image, player2.Image);
            this.Hide();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
