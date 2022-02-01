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
    public partial class Form3 : Form
    {
        Bitmap first = new Bitmap("E:\\project\\1.jpg");
        Bitmap second = new Bitmap("E:\\project\\2.jpg");
        Bitmap third = new Bitmap("E:\\project\\3.jpg");
        Bitmap fourth = new Bitmap("E:\\project\\4.jpg");
        Bitmap forward = new Bitmap("E:\\project\\forward.png");
        Bitmap backward = new Bitmap("E:\\project\\backward.png");

        Bitmap[] pictures = new Bitmap[4];
        public Form3()
        {
            InitializeComponent();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            backwardbut.Visible = false;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BackgroundImage = first;
            forwardbut.BackgroundImage = forward;
            backwardbut.BackgroundImage = backward;
            forwardbut.BackgroundImageLayout = ImageLayout.Stretch;
            backwardbut.BackgroundImageLayout = ImageLayout.Stretch;
            pictures[0] = first;
            pictures[1] = second;
            pictures[2] = third;
            pictures[3] = fourth;

        }
        int count = 1;
        private void forwclick(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
            {
                pictureBox1.Image = pictures[0];
                backwardbut.Visible = false;
                forwardbut.Visible = true;
            }
            if (count == 2)
            {
                pictureBox1.Image = pictures[1];
                backwardbut.Visible = true;
                forwardbut.Visible = true;
            }
            if (count == 3)
            {
                pictureBox1.Image = pictures[2];
                backwardbut.Visible = true;
                forwardbut.Visible = true;
            }
            if (count == 4)
            {
                pictureBox1.Image = pictures[3];
                forwardbut.Visible = false;
                backwardbut.Visible = true;
            }
        }

        private void backwclick(object sender, EventArgs e)
        {
            count--;
            if (count == 1)
            {
                pictureBox1.Image = pictures[0];
                backwardbut.Visible = false;
                forwardbut.Visible = true;
            }
            if (count == 2)
            {
                pictureBox1.Image = pictures[1];
                backwardbut.Visible = true;
                forwardbut.Visible = true;
            }
            if (count == 3)
            {
                pictureBox1.Image = pictures[2];
                backwardbut.Visible = true;
                forwardbut.Visible = true;
            }
            if (count == 4)
            {
                pictureBox1.Image = pictures[3];
                forwardbut.Visible = false;
                backwardbut.Visible = true;
            }
        }

        private void Back(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
