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
    public partial class Form4 : Form
    {
        //images input
        Bitmap red = new Bitmap("E:\\project\\Classic Bingo\\red.png");
        Bitmap yellow = new Bitmap("E:\\project\\Classic Bingo\\yellow.png");
        Bitmap emptyClassic = new Bitmap("E:\\project\\Classic Bingo\\empty classic.png");
        Bitmap frameClassic = new Bitmap("E:\\project\\Classic Bingo\\main frame3.jpg");
        Bitmap frameDark = new Bitmap("E:\\project\\Classic Bingo\\dark frame.png");
        Bitmap emptyDark = new Bitmap("E:\\project\\Classic Bingo\\empty dark.png");
        Bitmap moon = new Bitmap("E:\\project\\Classic Bingo\\moon.png");
        Bitmap sun = new Bitmap("E:\\project\\Classic Bingo\\sun.png");
        Bitmap restart = new Bitmap("E:\\project\\Classic Bingo\\restart.png");
        Bitmap home = new Bitmap("E:\\project\\Classic Bingo\\home.png");
        Bitmap soundon = new Bitmap("E:\\project\\Classic Bingo\\soundon.png");
        Bitmap soundoff = new Bitmap("E:\\project\\Classic Bingo\\soundoff.png");
        Bitmap bingo = new Bitmap("E:\\project\\Classic Bingo\\Bingo.png");
        Bitmap playagain = new Bitmap("E:\\project\\Classic Bingo\\playagain.png");

        //picturebox two dimensional array
        PictureBox[,] p = new PictureBox[7, 6];

        //button array
        Button[] b = new Button[7];

        //disc counter
        int counter0 = -1;
        int counter1 = -1;
        int counter2 = -1;
        int counter3 = -1;
        int counter4 = -1;
        int counter5 = -1;
        int counter6 = -1;

        //sounds
        SoundPlayer drum = new SoundPlayer(@"E:/project/drumroll.wav");
        SoundPlayer gamesound = new SoundPlayer(@"E:/project/Summertime-Fun.wav");

        //player strings
        string player1, player2;

        //default constructor
        public Form4()
        {
            InitializeComponent();
        }

        //overloaded constructor
        public Form4(string p1,string p2,Image pb1, Image pb2)
        {
            InitializeComponent();
            label2.Text = p1;
            label3.Text = p2;
            pictureBox1.BackgroundImage = pb1;
            pictureBox2.BackgroundImage = pb2;
            player1 = label2.Text;
            player2 = label3.Text;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //buttons allocation
            b[0] = circularButton1;
            b[1] = circularButton2;
            b[2] = circularButton3;
            b[3] = circularButton4;
            b[4] = circularButton5;
            b[5] = circularButton6;
            b[6] = circularButton7;

            //picturebox allocation
            p[0, 0] = circularPictureBox_1;
            p[0, 1] = circularPictureBox_2;
            p[0, 2] = circularPictureBox_3;
            p[0, 3] = circularPictureBox_4;
            p[0, 4] = circularPictureBox_5;
            p[0, 5] = circularPictureBox_6;

            p[1, 0] = circularPictureBox_7;
            p[1, 1] = circularPictureBox_8;
            p[1, 2] = circularPictureBox_9;
            p[1, 3] = circularPictureBox_10;
            p[1, 4] = circularPictureBox_11;
            p[1, 5] = circularPictureBox_12;

            p[2, 0] = circularPictureBox_13;
            p[2, 1] = circularPictureBox_14;
            p[2, 2] = circularPictureBox_15;
            p[2, 3] = circularPictureBox_16;
            p[2, 4] = circularPictureBox_17;
            p[2, 5] = circularPictureBox_18;

            p[3, 0] = circularPictureBox_19;
            p[3, 1] = circularPictureBox_20;
            p[3, 2] = circularPictureBox_21;
            p[3, 3] = circularPictureBox_22;
            p[3, 4] = circularPictureBox_23;
            p[3, 5] = circularPictureBox_24;

            p[4, 0] = circularPictureBox_25;
            p[4, 1] = circularPictureBox_26;
            p[4, 2] = circularPictureBox_27;
            p[4, 3] = circularPictureBox_28;
            p[4, 4] = circularPictureBox_29;
            p[4, 5] = circularPictureBox_30;

            p[5, 0] = circularPictureBox_31;
            p[5, 1] = circularPictureBox_32;
            p[5, 2] = circularPictureBox_33;
            p[5, 3] = circularPictureBox_34;
            p[5, 4] = circularPictureBox_35;
            p[5, 5] = circularPictureBox_36;

            p[6, 0] = circularPictureBox_37;
            p[6, 1] = circularPictureBox_38;
            p[6, 2] = circularPictureBox_39;
            p[6, 3] = circularPictureBox_40;
            p[6, 4] = circularPictureBox_41;
            p[6, 5] = circularPictureBox_42;

            // default game frame
            circularButton9.BackgroundImage = restart;
            circularButton9.BackgroundImageLayout = ImageLayout.Stretch;
            circularButton10.BackgroundImage = home;
            circularButton10.BackgroundImageLayout = ImageLayout.Stretch;
            circularButton11.BackgroundImage = soundon;
            circularButton11.BackgroundImageLayout = ImageLayout.Stretch;

            //label dispay
            VerticalDisplay(label2);
            VerticalDisplay(label3);

            //music on by default
            gamesound.PlayLooping();

            DefaultDisplay();
        }
        private void VerticalDisplay(Label l)
        {
            string temp;
            temp = l.Text;
            l.Text = "";
            for (int i = 0; i < temp.Length; i++)
            {
                l.Text += temp[i] + "\n";
            }
        }
        private void DefaultDisplay()
        {
            circularButton9.Enabled = true;
            circularButton8.BackgroundImage = moon;
            circularButton8.BackgroundImageLayout = ImageLayout.Stretch;
            for (int i = 0; i < 7; i++)
            {
                b[i].BackgroundImage = red;
                b[i].BackgroundImageLayout = ImageLayout.Stretch;
                b[i].Visible = true;
                b[i].Enabled = true;
            }

            this.BackgroundImage = frameClassic;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            circularPictureBox_43.BackgroundImage = bingo;
            circularPictureBox_43.BackgroundImageLayout = ImageLayout.Stretch;
            circularPictureBox_43.Visible = false;

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    p[i, j].BackgroundImage = emptyClassic;
                }
            }
            label1.Visible = false;
            counter0 = -1;
            counter1 = -1;
            counter2 = -1;
            counter3 = -1;
            counter4 = -1;
            counter5 = -1;
            counter6 = -1;

            button1.BackgroundImage = playagain;
            button1.Visible = false;
            
            label2.Location = new Point(label2.Location.X, (this.Size.Height - label2.Size.Height) / 2);
            label3.Location = new Point(label3.Location.X, (this.Size.Height - label3.Size.Height) / 2);
            timer1.Stop();
            progressBar1.Enabled = true;
            progressBar1.Visible = true;
            progressBar1.Value = 0;
        }
        private void ClassicDisplay()
        {
            this.BackgroundImage = frameClassic;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (p[i, j].BackgroundImage != red && p[i, j].BackgroundImage != yellow)
                    {
                        p[i, j].BackgroundImage = emptyClassic;
                    }
                }
            }
        }
        private void DarkDisplay()
        {
            this.BackgroundImage = frameDark;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (p[i, j].BackgroundImage != red && p[i, j].BackgroundImage != yellow)
                    {
                        p[i, j].BackgroundImage = emptyDark;
                    }
                }
            }
        }
        private async void Insert_Red_Disc(int row, int column)
        {
            for (int i = 5; i > row; i--)
            {
                p[column, i].BackgroundImage = red;  
                await Task.Delay(40);
                if (circularButton8.BackgroundImage == moon)
                {
                    p[column, i].BackgroundImage = emptyClassic;

                }
                else if (circularButton8.BackgroundImage == sun)
                {
                    p[column, i].BackgroundImage = emptyDark;
                }
            }
            p[column, row].BackgroundImage = red;
            Check_Winner();
        }
        private async void Insert_Yellow_Disc(int row, int column)
        {
            for (int i = 5; i > row; i--)
            {
                p[column, i].BackgroundImage = yellow;
                await Task.Delay(40);
                if (circularButton8.BackgroundImage == moon)
                {
                    p[column, i].BackgroundImage = emptyClassic;

                }
                else if (circularButton8.BackgroundImage == sun)
                {
                    p[column, i].BackgroundImage = emptyDark;
                }
            }
            p[column, row].BackgroundImage = yellow;
            Check_Winner();
        }
        private void Check_Winner()
        {
            //check horizontally
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    //check red
                    if (p[i, j].BackgroundImage == red && p[i + 1, j].BackgroundImage == red && p[i + 2, j].BackgroundImage == red && p[i + 3, j].BackgroundImage == red)
                    {
                        for (int k = 0; k < 7; k++)
                        {
                            b[k].Enabled = false;
                            b[k].Visible = false;

                        }
                        drum.Play();
                        label1.Text = player1 + " WINS!!!";
                        label1.Location = new Point((this.Size.Width - label1.Size.Width) / 2, label1.Location.Y);
                        label1.Visible = true;
                        label1.BackColor = Color.Red;
                        circularPictureBox_43.Visible = true;
                        button1.Visible = true;
                        progressBar1.Enabled = false;
                        progressBar1.Visible = false;
                        circularButton9.Enabled = false;
                        
                        
                    }
                    //check yellow
                    else if (p[i, j].BackgroundImage == yellow && p[i + 1, j].BackgroundImage == yellow && p[i + 2, j].BackgroundImage == yellow && p[i + 3, j].BackgroundImage == yellow)
                    {
                        for (int k = 0; k < 7; k++)
                        {
                            b[k].Enabled = false;
                            b[k].Visible = false;
                        }
                        drum.Play();
                        label1.Text = player2 + " WINS!!!";
                        label1.Location = new Point((this.Size.Width - label1.Size.Width) / 2, label1.Location.Y);
                        label1.Visible = true;
                        label1.BackColor = Color.Yellow;
                        circularPictureBox_43.Visible = true;
                        button1.Visible = true;
                        progressBar1.Enabled = false;
                        progressBar1.Visible = false;
                        circularButton9.Enabled = false;
                        
                    }
                }
            }

            //check vertically
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //check red
                    if (p[i, j].BackgroundImage == red && p[i, j + 1].BackgroundImage == red && p[i, j + 2].BackgroundImage == red && p[i, j + 3].BackgroundImage == red)
                    {
                        for (int k = 0; k < 7; k++)
                        {
                            b[k].Enabled = false;
                            b[k].Visible = false;

                        }
                        drum.Play();
                        label1.Text = player1 + " WINS!!!";
                        label1.Location = new Point((this.Size.Width - label1.Size.Width) / 2, label1.Location.Y);
                        label1.Visible = true;
                        label1.BackColor = Color.Red;
                        circularPictureBox_43.Visible = true;
                        button1.Visible = true;
                        progressBar1.Enabled = false;
                        progressBar1.Visible = false;
                        circularButton9.Enabled = false;
                    }
                    //check yellow
                    else if (p[i, j].BackgroundImage == yellow && p[i, j + 1].BackgroundImage == yellow && p[i, j + 2].BackgroundImage == yellow && p[i, j + 3].BackgroundImage == yellow)
                    {
                        for (int k = 0; k < 7; k++)
                        {
                            b[k].Enabled = false;
                            b[k].Visible = false;
                        }
                        drum.Play();
                        label1.Text = player2 + " WINS!!!";
                        label1.Location = new Point((this.Size.Width - label1.Size.Width) / 2, label1.Location.Y);
                        label1.Visible = true;
                        label1.BackColor = Color.Yellow;
                        circularPictureBox_43.Visible = true;
                        button1.Visible = true;
                        progressBar1.Enabled = false;
                        progressBar1.Visible = false;
                        circularButton9.Enabled = false;
                    }
                }
            }

            //check diagnol downwards
            for (int i = 0; i < 4; i++) //coulmns
            {
                for (int j = 3; j < 6; j++) 
                {
                    //check red
                    if (p[i, j].BackgroundImage == red && p[i + 1, j - 1].BackgroundImage == red && p[i + 2, j - 2].BackgroundImage == red && p[i + 3, j - 3].BackgroundImage == red)
                    {
                        for (int k = 0; k < 7; k++)
                        {
                            b[k].Enabled = false;
                            b[k].Visible = false;
                        }
                        drum.Play();
                        label1.Text = player1 + " WINS!!!";
                        label1.Location = new Point((this.Size.Width - label1.Size.Width) / 2, label1.Location.Y);
                        label1.Visible = true;
                        label1.BackColor = Color.Red;
                        button1.Visible = true;
                        circularPictureBox_43.Visible = true;
                        progressBar1.Enabled = false;
                        progressBar1.Visible = false;
                        circularButton9.Enabled = false;
                    }
                    //check yellow
                    else if (p[i, j].BackgroundImage == yellow && p[i + 1, j - 1].BackgroundImage == yellow && p[i + 2, j - 2].BackgroundImage == yellow && p[i + 3, j - 3].BackgroundImage == yellow)
                    {
                        for (int k = 0; k < 7; k++)
                        {
                            b[k].Enabled = false;
                            b[k].Visible = false;
                        }
                        drum.Play();
                        label1.Text = player2 + " WINS!!!";
                        label1.Location = new Point((this.Size.Width - label1.Size.Width) / 2, label1.Location.Y);
                        label1.Visible = true;
                        label1.BackColor = Color.Yellow;
                        circularPictureBox_43.Visible = true;
                        button1.Visible = true;
                        progressBar1.Enabled = false;
                        progressBar1.Visible = false;
                        circularButton9.Enabled = false;
                    }
                }
            }

            //check diagnol upwards
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //check red
                    if (p[i, j].BackgroundImage == red && p[i + 1, j + 1].BackgroundImage == red && p[i + 2, j + 2].BackgroundImage == red && p[i + 3, j + 3].BackgroundImage == red)
                    {
                        for (int k = 0; k < 7; k++)
                        {
                            b[k].Enabled = false;
                            b[k].Visible = false;
                        }
                        drum.Play();
                        label1.Text = player1 + " WINS!!!";
                        label1.Location = new Point((this.Size.Width - label1.Size.Width) / 2, label1.Location.Y);
                        label1.Visible = true;
                        label1.BackColor = Color.Red;
                        circularPictureBox_43.Visible = true;
                        button1.Visible = true;
                        progressBar1.Enabled = false;
                        progressBar1.Visible = false;
                        circularButton9.Enabled = false;
                    }
                    //check yellow
                    else if (p[i, j].BackgroundImage == yellow && p[i + 1, j + 1].BackgroundImage == yellow && p[i + 2, j + 2].BackgroundImage == yellow && p[i + 3, j + 3].BackgroundImage == yellow)
                    {
                        for (int k = 0; k < 7; k++)
                        {
                            b[k].Enabled = false;
                            b[k].Visible = false;
                        }
                        drum.Play();
                        label1.Text = player2 + " WINS!!!";
                        label1.Location = new Point((this.Size.Width - label1.Size.Width) / 2, label1.Location.Y);
                        label1.Visible = true;
                        label1.BackColor = Color.Yellow;
                        circularPictureBox_43.Visible = true;
                        button1.Visible = true;
                        progressBar1.Enabled = false;
                        progressBar1.Visible = false;
                        circularButton9.Enabled = false;
                    }
                }
            }
        }
        private void circularButton1_Click(object sender, EventArgs e)
        {
            counter0 += 1;
            if (b[0].BackgroundImage == red)
            {
                for (int i = 0; i < 7; i++)
                {
                    b[i].BackgroundImage = yellow;
                }
                Insert_Red_Disc(counter0, 0);
            }
            else if (b[0].BackgroundImage == yellow)
            {
                for (int i = 0; i < 7; i++)
                {
                    b[i].BackgroundImage = red;
                }
                Insert_Yellow_Disc(counter0, 0);
            }
            //Check_Winner();
            if (counter0 == 5)
            {
                b[0].Enabled = false;
                b[0].Visible = false;
            }
            progressBar1.Value = 0;
            timer1.Start();

        }
        private void circularButton2_Click(object sender, EventArgs e)
        {
            counter1 += 1;
            if (b[0].BackgroundImage == red)
            {
                for (int i = 0; i < 7; i++)
                {
                    b[i].BackgroundImage = yellow;
                }
                Insert_Red_Disc(counter1, 1);
            }
            else if (b[0].BackgroundImage == yellow)
            {
                for (int i = 0; i < 7; i++)
                {
                    b[i].BackgroundImage = red;
                }
                Insert_Yellow_Disc(counter1, 1);
            }
            //Check_Winner();
            if (counter1 == 5)
            {
                b[1].Enabled = false;
                b[1].Visible = false;
            }
            progressBar1.Value = 0;
            timer1.Start();
        }
        private void circularButton3_Click(object sender, EventArgs e)
        {
            counter2 += 1;
            if (b[0].BackgroundImage == red)
            {
                for (int i = 0; i < 7; i++)
                {
                    b[i].BackgroundImage = yellow;
                }
                Insert_Red_Disc(counter2, 2);
            }
            else if (b[0].BackgroundImage == yellow)
            {
                for (int i = 0; i < 7; i++)
                {
                    b[i].BackgroundImage = red;
                }
                Insert_Yellow_Disc(counter2, 2);
            }
            //Check_Winner();
            if (counter2 == 5)
            {
                b[2].Enabled = false;
                b[2].Visible = false;
            }
            progressBar1.Value = 0;
            timer1.Start();
        }
        private void circularButton4_Click(object sender, EventArgs e)
        {
            counter3 += 1;
            if (b[0].BackgroundImage == red)
            {
                for (int i = 0; i < 7; i++)
                {
                    b[i].BackgroundImage = yellow;
                }
                Insert_Red_Disc(counter3, 3);
            }
            else if (b[0].BackgroundImage == yellow)
            {
                for (int i = 0; i < 7; i++)
                {
                    b[i].BackgroundImage = red;
                }
                Insert_Yellow_Disc(counter3, 3);
            }
            //Check_Winner();
            if (counter3 == 5)
            {
                b[3].Visible = false;
                b[3].Enabled = false;
            }
            progressBar1.Value = 0;
            timer1.Start();
        }
        private void circularButton5_Click(object sender, EventArgs e)
        {
            counter4 += 1;
            if (b[0].BackgroundImage == red)
            {
                for (int i = 0; i < 7; i++)
                {
                    b[i].BackgroundImage = yellow;
                }
                Insert_Red_Disc(counter4, 4);
            }
            else if (b[0].BackgroundImage == yellow)
            {
                for (int i = 0; i < 7; i++)
                {
                    b[i].BackgroundImage = red;
                }
                Insert_Yellow_Disc(counter4, 4);
            }
            //Check_Winner();
            if (counter4 == 5)
            {
                b[4].Enabled = false;
                b[4].Visible = false;
            }
            progressBar1.Value = 0;
            timer1.Start();
        }
        private void circularButton6_Click(object sender, EventArgs e)
        {
            counter5 += 1;
            if (b[0].BackgroundImage == red)
            {
                for (int i = 0; i < 7; i++)
                {
                    b[i].BackgroundImage = yellow;
                }
                Insert_Red_Disc(counter5, 5);
            }
            else if (b[0].BackgroundImage == yellow)
            {
                for (int i = 0; i < 7; i++)
                {
                    b[i].BackgroundImage = red;
                }
                Insert_Yellow_Disc(counter5, 5);
            }
            //Check_Winner();
            if (counter5 == 5)
            {
                b[5].Enabled = false;
                b[5].Visible = false;
            }
            progressBar1.Value = 0;
            timer1.Start();
        }
        private void circularButton7_Click(object sender, EventArgs e)
        {
            counter6 += 1;
            if (b[0].BackgroundImage == red)
            {
                for (int i = 0; i < 7; i++)
                {
                    b[i].BackgroundImage = yellow;
                }
                Insert_Red_Disc(counter6, 6);
            }
            else if (b[0].BackgroundImage == yellow)
            {
                for (int i = 0; i < 7; i++)
                {
                    b[i].BackgroundImage = red;
                }
                Insert_Yellow_Disc(counter6, 6);
            }
            //Check_Winner();
            if (counter6 == 5)
            {
                b[6].Enabled = false;
                b[6].Visible = false;
            }
            progressBar1.Value = 0;
            timer1.Start();
        }
        private void circularButton8_Click(object sender, EventArgs e)
        {
            if (circularButton8.BackgroundImage == moon)
            {
                DarkDisplay();
                circularButton8.BackgroundImage = sun;
            }
            else if (circularButton8.BackgroundImage == sun)
            {
                ClassicDisplay();
                circularButton8.BackgroundImage = moon;
            }
        }
        private void circularButton9_Click(object sender, EventArgs e)
        {
            DefaultDisplay();
        }
        private void circularButton11_Click(object sender, EventArgs e)
        {
            if (circularButton11.BackgroundImage == soundon)
            {
                circularButton11.BackgroundImage = soundoff;
                gamesound.Stop();

            }
            else if (circularButton11.BackgroundImage == soundoff)
            {
                circularButton11.BackgroundImage = soundon;
                gamesound.Play();

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (progressBar1.Value == 201)
            {
                progressBar1.Value = 0;

                for (int i = 0; i < 7; i++)
                {
                    if (b[i].BackgroundImage == red)
                    {
                        b[i].BackgroundImage = yellow;
                    }
                    else if (b[i].BackgroundImage == yellow)
                    {
                        b[i].BackgroundImage = red;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DefaultDisplay();
            gamesound.PlayLooping();

        }
        private void circularPictureBox_24_Click(object sender, EventArgs e)
        {
           
        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);

        }
        private void circularButton10_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
