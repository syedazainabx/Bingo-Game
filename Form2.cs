using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int f = 1;
        Bitmap stop = new Bitmap("E:\\project\\musicstop.jpg");
        Bitmap play = new Bitmap("E:\\project\\musicplay.jpg");
        Bitmap avatarbutton = new Bitmap("E:\\project\\Classic Bingo\\yellow2.png");

        SoundPlayer s1 = new SoundPlayer(@"E:/project/gamemusic.wav");

        public static object f2 { get; internal set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            s1.Play();
            int f = 1;
            musicb.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void musicb_Click(object sender, EventArgs e)
        {
            f *= -1;
            if (f==1) { 
                musicb.BackgroundImage = play;
              
                s1.Play();
            }
            else
            {
                s1.Stop();
                musicb.BackgroundImage = stop;
            }
        }

        private void exitclick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playgameclick(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
            s1.Stop();
        }

        private void rulesclick(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
