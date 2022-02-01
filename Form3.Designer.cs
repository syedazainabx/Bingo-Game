
namespace project
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.forwardbut = new bingo_game_1.CircularButton();
            this.backwardbut = new bingo_game_1.CircularButton();
            this.Backb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(55, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // forwardbut
            // 
            this.forwardbut.Location = new System.Drawing.Point(730, 233);
            this.forwardbut.Name = "forwardbut";
            this.forwardbut.Size = new System.Drawing.Size(42, 42);
            this.forwardbut.TabIndex = 3;
            this.forwardbut.UseVisualStyleBackColor = true;
            this.forwardbut.Click += new System.EventHandler(this.forwclick);
            // 
            // backwardbut
            // 
            this.backwardbut.Location = new System.Drawing.Point(7, 233);
            this.backwardbut.Name = "backwardbut";
            this.backwardbut.Size = new System.Drawing.Size(42, 42);
            this.backwardbut.TabIndex = 4;
            this.backwardbut.UseVisualStyleBackColor = true;
            this.backwardbut.Click += new System.EventHandler(this.backwclick);
            // 
            // Backb
            // 
            this.Backb.BackColor = System.Drawing.Color.Transparent;
            this.Backb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Backb.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backb.ForeColor = System.Drawing.Color.Gold;
            this.Backb.Location = new System.Drawing.Point(612, 42);
            this.Backb.Name = "Backb";
            this.Backb.Size = new System.Drawing.Size(112, 41);
            this.Backb.TabIndex = 5;
            this.Backb.Text = "Back";
            this.Backb.UseVisualStyleBackColor = false;
            this.Backb.Click += new System.EventHandler(this.Back);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project.Properties.Resources.bgf3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Backb);
            this.Controls.Add(this.backwardbut);
            this.Controls.Add(this.forwardbut);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private bingo_game_1.CircularButton forwardbut;
        private bingo_game_1.CircularButton backwardbut;
        private System.Windows.Forms.Button Backb;
    }
}