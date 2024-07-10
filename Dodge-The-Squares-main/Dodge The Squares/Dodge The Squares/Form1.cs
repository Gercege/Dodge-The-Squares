using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dodge_The_Squares
{
    public partial class Form1 : Form
    {
        public int s = 0;
        public int blacktopspeed = 7;
        public int blackleftspeed = 7;
        public int picturebox1topspeed = 7;
        public int picturebox1leftspeed = 7;
        public int picturebox2topspeed = 7;
        public int picturebox2leftspeed = 7;
        public int picturebox3topspeed = 7;
        public int picturebox3leftspeed = 7;
        public int picturebox4topspeed = 7;
        public int picturebox4leftspeed = 7;
        public int picturebox5topspeed = 7;
        public int picturebox5leftspeed = 7;
        public int picturebox6topspeed = 7;
        public int picturebox6leftspeed = 7;
        public int picturebox7topspeed = 7;
        public int picturebox7leftspeed = 7;
        public int picturebox8topspeed = 7;
        public int picturebox8leftspeed = 7;
        public int picturebox9topspeed = 7;
        public int picturebox9leftspeed = 7;
        public int picturebox10topspeed = 14;
        public int picturebox10leftspeed = 14;
        public int picturebox11topspeed = 14;
        public int picturebox11leftspeed = 14;
        public int yellowtopspeed = 14;
        public int yellowleftspeed = 14;
        public int browntopspeed = 3;
        public int brownleftspeed = 3;
        public int picturebox14topspeed = 3;
        public int picturebox14leftspeed = 3;
        public int picturebox13topspeed = 3;
        public int picturebox13leftspeed = 3;
        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RedSquare.Left = Cursor.Position.X - (RedSquare.Width / 2);
            RedSquare.Top = Cursor.Position.Y - (RedSquare.Height / 2);
            BlackSquare.Left += blackleftspeed;
            BlackSquare.Top += blacktopspeed;
            pictureBox1.Left += picturebox1leftspeed;
            pictureBox1.Top += picturebox1topspeed;
            pictureBox2.Left += picturebox2leftspeed;
            pictureBox2.Top += picturebox2topspeed;
            pictureBox3.Left += picturebox3leftspeed;
            pictureBox3.Top += picturebox3topspeed;
            pictureBox4.Left += picturebox4leftspeed;
            pictureBox4.Top += picturebox4topspeed;
            pictureBox5.Left += picturebox5leftspeed;
            pictureBox5.Top += picturebox5topspeed;
            pictureBox6.Left += picturebox6leftspeed;
            pictureBox6.Top += picturebox6topspeed;
            pictureBox7.Left += picturebox7leftspeed;
            pictureBox7.Top += picturebox7topspeed;
            pictureBox8.Left += picturebox8leftspeed;
            pictureBox8.Top += picturebox8topspeed;
            pictureBox9.Left += picturebox9leftspeed;
            pictureBox9.Top += picturebox9topspeed;
            pictureBox10.Left += picturebox10leftspeed;
            pictureBox10.Top += picturebox10topspeed;
            pictureBox11.Left += picturebox11leftspeed;
            pictureBox11.Top += picturebox11topspeed;
            YellowSquare.Left += yellowleftspeed;
            YellowSquare.Top += yellowtopspeed;
            BrownSquare.Left += brownleftspeed;
            BrownSquare.Top += browntopspeed;
            pictureBox13.Left += picturebox13leftspeed;
            pictureBox13.Top += picturebox13topspeed;
            pictureBox14.Left += picturebox14leftspeed;
            pictureBox14.Top += picturebox14topspeed;
            if (BlackSquare.Left <= panel1.Left)
            {
                blackleftspeed = -blackleftspeed;
            }
            if (BlackSquare.Right >= panel1.Right)
            {
                blackleftspeed = -blackleftspeed;
            }
            if (BlackSquare.Bottom <= panel1.Bottom)
            {
                blacktopspeed = -blacktopspeed;
            }
            if (BlackSquare.Top >= panel1.Top)
            {
                blacktopspeed = -blacktopspeed;
            }
            if (pictureBox1.Left <= panel1.Left)
            {
                picturebox1leftspeed = -picturebox1leftspeed;
            }
            if (pictureBox1.Right >= panel1.Right)
            {
                picturebox1leftspeed = -picturebox1leftspeed;
            }
            if (pictureBox1.Bottom <= panel1.Bottom)
            {
                picturebox1topspeed = -picturebox1topspeed;
            }
            if (pictureBox1.Top >= panel1.Top)
            {
                picturebox1topspeed = -picturebox1topspeed;
            }
            if (pictureBox2.Left <= panel1.Left)
            {
                picturebox2leftspeed = -picturebox2leftspeed;
            }
            if (pictureBox2.Right >= panel1.Right)
            {
                picturebox2leftspeed = -picturebox2leftspeed;
            }
            if (pictureBox2.Bottom <= panel1.Bottom)
            {
                picturebox2topspeed = -picturebox2topspeed;
            }
            if (pictureBox2.Top >= panel1.Top)
            {
                picturebox2topspeed = -picturebox2topspeed;
            }
            if (pictureBox3.Left <= panel1.Left)
            {
                picturebox3leftspeed = -picturebox3leftspeed;
            }
            if (pictureBox3.Right >= panel1.Right)
            {
                picturebox3leftspeed = -picturebox3leftspeed;
            }
            if (pictureBox3.Bottom <= panel1.Bottom)
            {
                picturebox3topspeed = -picturebox3topspeed;
            }
            if (pictureBox3.Top >= panel1.Top)
            {
                picturebox3topspeed = -picturebox3topspeed;
            }
            if (pictureBox4.Left <= panel1.Left)
            {
                picturebox4leftspeed = -picturebox4leftspeed;
            }
            if (pictureBox4.Right >= panel1.Right)
            {
                picturebox4leftspeed = -picturebox4leftspeed;
            }
            if (pictureBox4.Bottom <= panel1.Bottom)
            {
                picturebox4topspeed = -picturebox4topspeed;
            }
            if (pictureBox4.Top >= panel1.Top)
            {
                picturebox4topspeed = -picturebox4topspeed;
            }
            if (pictureBox5.Left <= panel1.Left)
            {
                picturebox5leftspeed = -picturebox5leftspeed;
            }
            if (pictureBox5.Right >= panel1.Right)
            {
                picturebox5leftspeed = -picturebox5leftspeed;
            }
            if (pictureBox5.Bottom <= panel1.Bottom)
            {
                picturebox5topspeed = -picturebox5topspeed;
            }
            if (pictureBox5.Top >= panel1.Top)
            {
                picturebox5topspeed = -picturebox5topspeed;
            }
            if (pictureBox6.Left <= panel1.Left)
            {
                picturebox6leftspeed = -picturebox6leftspeed;
            }
            if (pictureBox6.Right >= panel1.Right)
            {
                picturebox6leftspeed = -picturebox6leftspeed;
            }
            if (pictureBox6.Bottom <= panel1.Bottom)
            {
                picturebox6topspeed = -picturebox6topspeed;
            }
            if (pictureBox6.Top >= panel1.Top)
            {
                picturebox6topspeed = -picturebox6topspeed;
            }
            if (pictureBox7.Left <= panel1.Left)
            {
                picturebox7leftspeed = -picturebox7leftspeed;
            }
            if (pictureBox7.Right >= panel1.Right)
            {
                picturebox7leftspeed = -picturebox7leftspeed;
            }
            if (pictureBox7.Bottom <= panel1.Bottom)
            {
                picturebox7topspeed = -picturebox7topspeed;
            }
            if (pictureBox7.Top >= panel1.Top)
            {
                picturebox7topspeed = -picturebox7topspeed;
            }
            if (pictureBox8.Left <= panel1.Left)
            {
                picturebox8leftspeed = -picturebox8leftspeed;
            }
            if (pictureBox8.Right >= panel1.Right)
            {
                picturebox8leftspeed = -picturebox8leftspeed;
            }
            if (pictureBox8.Bottom <= panel1.Bottom)
            {
                picturebox8topspeed = -picturebox8topspeed;
            }
            if (pictureBox8.Top >= panel1.Top)
            {
                picturebox8topspeed = -picturebox8topspeed;
            }
            if (pictureBox9.Left <= panel1.Left)
            {
                picturebox9leftspeed = -picturebox9leftspeed;
            }
            if (pictureBox9.Right >= panel1.Right)
            {
                picturebox9leftspeed = -picturebox9leftspeed;
            }
            if (pictureBox9.Bottom <= panel1.Bottom)
            {
                picturebox9topspeed = -picturebox9topspeed;
            }
            if (pictureBox9.Top >= panel1.Top)
            {
                picturebox9topspeed = -picturebox9topspeed;
            }
            if (pictureBox10.Left <= panel1.Left)
            {
                picturebox10leftspeed = -picturebox10leftspeed;
            }
            if (pictureBox10.Right >= panel1.Right)
            {
                picturebox10leftspeed = -picturebox10leftspeed;
            }
            if (pictureBox10.Bottom <= panel1.Bottom)
            {
                picturebox10topspeed = -picturebox10topspeed;
            }
            if (pictureBox10.Top >= panel1.Top)
            {
                picturebox10topspeed = -picturebox10topspeed;
            }
            if (pictureBox11.Left <= panel1.Left)
            {
                picturebox11leftspeed = -picturebox11leftspeed;
            }
            if (pictureBox11.Right >= panel1.Right)
            {
                picturebox11leftspeed = -picturebox11leftspeed;
            }
            if (pictureBox11.Bottom <= panel1.Bottom)
            {
                picturebox11topspeed = -picturebox11topspeed;
            }
            if (pictureBox11.Top >= panel1.Top)
            {
                picturebox11topspeed = -picturebox11topspeed;
            }
            if (YellowSquare.Left <= panel1.Left)
            {
                yellowleftspeed = -yellowleftspeed;
            }
            if (YellowSquare.Right >= panel1.Right)
            {
                yellowleftspeed = -yellowleftspeed;
            }
            if (YellowSquare.Bottom <= panel1.Bottom)
            {
                yellowtopspeed = -yellowtopspeed;
            }
            if (YellowSquare.Top >= panel1.Top)
            {
                yellowtopspeed = -yellowtopspeed;
            }
            if (BrownSquare.Left <= panel1.Left)
            {
                brownleftspeed = -brownleftspeed;
            }
            if (BrownSquare.Right >= panel1.Right)
            {
                brownleftspeed = -brownleftspeed;
            }
            if (BrownSquare.Bottom <= panel1.Bottom)
            {
                browntopspeed = -browntopspeed;
            }
            if (BrownSquare.Top >= panel1.Top)
            {
                browntopspeed = -browntopspeed;
            }
            if (pictureBox13.Left <= panel1.Left)
            {
                picturebox13leftspeed = -picturebox13leftspeed;
            }
            if (pictureBox13.Right >= panel1.Right)
            {
                picturebox13leftspeed = -picturebox13leftspeed;
            }
            if (pictureBox13.Bottom <= panel1.Bottom)
            {
                picturebox13topspeed = -picturebox13topspeed;
            }
            if (pictureBox13.Top >= panel1.Top)
            {
                picturebox13topspeed = -picturebox13topspeed;
            }
            if (pictureBox14.Left <= panel1.Left)
            {
                picturebox14leftspeed = -picturebox14leftspeed;
            }
            if (pictureBox14.Right >= panel1.Right)
            {
                picturebox14leftspeed = -picturebox14leftspeed;
            }
            if (pictureBox14.Bottom <= panel1.Bottom)
            {
                picturebox14topspeed = -picturebox14topspeed;
            }
            if (pictureBox14.Top >= panel1.Top)
            {
                picturebox14topspeed = -picturebox14topspeed;
            }

            if (RedSquare.Bounds.IntersectsWith(YellowSquare.Bounds))
            {
                timer1.Enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label2.Left = (this.ClientSize.Width - label2.Width) / 2;
                label2.Top = (this.ClientSize.Height - label2.Height) / 2 - 100;
                label3.Left = (this.ClientSize.Width - label3.Width) / 2 + 300;
                label3.Top = (this.ClientSize.Height - label3.Height) / 2 - 100;
                label4.Left = (this.ClientSize.Width - label4.Width) / 2;
                label4.Top = (this.ClientSize.Height - label4.Height) / 2 - 200;
                Move.Enabled = false;
                ScoreLabel.Enabled = false;
                label3.Text = Convert.ToString(Score);
                label3.Text = ScoreLabelText0.Text;
            }
            if (RedSquare.Bounds.IntersectsWith(BlackSquare.Bounds))
            {
                timer1.Enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label2.Left = (this.ClientSize.Width - label2.Width) / 2;
                label2.Top = (this.ClientSize.Height - label2.Height) / 2 - 100;
                label3.Left = (this.ClientSize.Width - label3.Width) / 2 + 300;
                label3.Top = (this.ClientSize.Height - label3.Height) / 2 - 100;
                label4.Left = (this.ClientSize.Width - label4.Width) / 2;
                label4.Top = (this.ClientSize.Height - label4.Height) / 2 - 200;
                Move.Enabled = false;
                ScoreLabel.Enabled = false;
                label3.Text = ScoreLabelText0.Text;
            }
            if (RedSquare.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                timer1.Enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label2.Left = (this.ClientSize.Width - label2.Width) / 2;
                label2.Top = (this.ClientSize.Height - label2.Height) / 2 - 100;
                label3.Left = (this.ClientSize.Width - label3.Width) / 2 + 300;
                label3.Top = (this.ClientSize.Height - label3.Height) / 2 - 100;
                label4.Left = (this.ClientSize.Width - label4.Width) / 2;
                label4.Top = (this.ClientSize.Height - label4.Height) / 2 - 200;
                Move.Enabled = false;
                ScoreLabel.Enabled = false;
                label3.Text = ScoreLabelText0.Text;
            }
            if (RedSquare.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                timer1.Enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label2.Left = (this.ClientSize.Width - label2.Width) / 2;
                label2.Top = (this.ClientSize.Height - label2.Height) / 2 - 100;
                label3.Left = (this.ClientSize.Width - label3.Width) / 2 + 300;
                label3.Top = (this.ClientSize.Height - label3.Height) / 2 - 100;
                label4.Left = (this.ClientSize.Width - label4.Width) / 2;
                label4.Top = (this.ClientSize.Height - label4.Height) / 2 - 200;
                Move.Enabled = false;
                ScoreLabel.Enabled = false;
                label3.Text = ScoreLabelText0.Text;
            }
            if (RedSquare.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                timer1.Enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label2.Left = (this.ClientSize.Width - label2.Width) / 2;
                label2.Top = (this.ClientSize.Height - label2.Height) / 2 - 100;
                label3.Left = (this.ClientSize.Width - label3.Width) / 2 + 300;
                label3.Top = (this.ClientSize.Height - label3.Height) / 2 - 100;
                label4.Left = (this.ClientSize.Width - label4.Width) / 2;
                label4.Top = (this.ClientSize.Height - label4.Height) / 2 - 200;
                Move.Enabled = false;
                ScoreLabel.Enabled = false;
                label3.Text = ScoreLabelText0.Text;
            }
            if (RedSquare.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                timer1.Enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label2.Left = (this.ClientSize.Width - label2.Width) / 2;
                label2.Top = (this.ClientSize.Height - label2.Height) / 2 - 100;
                label3.Left = (this.ClientSize.Width - label3.Width) / 2 + 300;
                label3.Top = (this.ClientSize.Height - label3.Height) / 2 - 100;
                label4.Left = (this.ClientSize.Width - label4.Width) / 2;
                label4.Top = (this.ClientSize.Height - label4.Height) / 2 - 200;
                Move.Enabled = false;
                ScoreLabel.Enabled = false;
                label3.Text = ScoreLabelText0.Text;
            }
            if (RedSquare.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                timer1.Enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label2.Left = (this.ClientSize.Width - label2.Width) / 2;
                label2.Top = (this.ClientSize.Height - label2.Height) / 2 - 100;
                label3.Left = (this.ClientSize.Width - label3.Width) / 2 + 300;
                label3.Top = (this.ClientSize.Height - label3.Height) / 2 - 100;
                label4.Left = (this.ClientSize.Width - label4.Width) / 2;
                label4.Top = (this.ClientSize.Height - label4.Height) / 2 - 200;
                Move.Enabled = false;
                ScoreLabel.Enabled = false;
                label3.Text = ScoreLabelText0.Text;
            }
            if (RedSquare.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                timer1.Enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label2.Left = (this.ClientSize.Width - label2.Width) / 2;
                label2.Top = (this.ClientSize.Height - label2.Height) / 2 - 100;
                label3.Left = (this.ClientSize.Width - label3.Width) / 2 + 300;
                label3.Top = (this.ClientSize.Height - label3.Height) / 2 - 100;
                label4.Left = (this.ClientSize.Width - label4.Width) / 2;
                label4.Top = (this.ClientSize.Height - label4.Height) / 2 - 200;
                Move.Enabled = false;
                ScoreLabel.Enabled = false;
                label3.Text = ScoreLabelText0.Text;
            }
            if (RedSquare.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                timer1.Enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label2.Left = (this.ClientSize.Width - label2.Width) / 2;
                label2.Top = (this.ClientSize.Height - label2.Height) / 2 - 100;
                label3.Left = (this.ClientSize.Width - label3.Width) / 2 + 300;
                label3.Top = (this.ClientSize.Height - label3.Height) / 2 - 100;
                label4.Left = (this.ClientSize.Width - label4.Width) / 2;
                label4.Top = (this.ClientSize.Height - label4.Height) / 2 - 200;
                Move.Enabled = false;
                ScoreLabel.Enabled = false;
                label3.Text = ScoreLabelText0.Text;
            }
            if (RedSquare.Bounds.IntersectsWith(pictureBox8.Bounds))
            {
                timer1.Enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label2.Left = (this.ClientSize.Width - label2.Width) / 2;
                label2.Top = (this.ClientSize.Height - label2.Height) / 2 - 100;
                label3.Left = (this.ClientSize.Width - label3.Width) / 2 + 300;
                label3.Top = (this.ClientSize.Height - label3.Height) / 2 - 100;
                label4.Left = (this.ClientSize.Width - label4.Width) / 2;
                label4.Top = (this.ClientSize.Height - label4.Height) / 2 - 200;
                Move.Enabled = false;
                ScoreLabel.Enabled = false;
                label3.Text = ScoreLabelText0.Text;
            }
            if (RedSquare.Bounds.IntersectsWith(pictureBox9.Bounds))
            {
                timer1.Enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label2.Left = (this.ClientSize.Width - label2.Width) / 2;
                label2.Top = (this.ClientSize.Height - label2.Height) / 2 - 100;
                label3.Left = (this.ClientSize.Width - label3.Width) / 2 + 300;
                label3.Top = (this.ClientSize.Height - label3.Height) / 2 - 100;
                label4.Left = (this.ClientSize.Width - label4.Width) / 2;
                label4.Top = (this.ClientSize.Height - label4.Height) / 2 - 200;
                Move.Enabled = false;
                ScoreLabel.Enabled = false;
                label3.Text = ScoreLabelText0.Text;
            }
            if (RedSquare.Bounds.IntersectsWith(pictureBox10.Bounds))
            {
                timer1.Enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label2.Left = (this.ClientSize.Width - label2.Width) / 2;
                label2.Top = (this.ClientSize.Height - label2.Height) / 2 - 100;
                label3.Left = (this.ClientSize.Width - label3.Width) / 2 + 300;
                label3.Top = (this.ClientSize.Height - label3.Height) / 2 - 100;
                label4.Left = (this.ClientSize.Width - label4.Width) / 2;
                label4.Top = (this.ClientSize.Height - label4.Height) / 2 - 200;
                Move.Enabled = false;
                ScoreLabel.Enabled = false;
                label3.Text = ScoreLabelText0.Text;
            }
            if (RedSquare.Bounds.IntersectsWith(pictureBox11.Bounds))
            {
                timer1.Enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label2.Left = (this.ClientSize.Width - label2.Width) / 2;
                label2.Top = (this.ClientSize.Height - label2.Height) / 2 - 100;
                label3.Left = (this.ClientSize.Width - label3.Width) / 2 + 300;
                label3.Top = (this.ClientSize.Height - label3.Height) / 2 - 100;
                label4.Left = (this.ClientSize.Width - label4.Width) / 2;
                label4.Top = (this.ClientSize.Height - label4.Height) / 2 - 200;
                Move.Enabled = false;
                ScoreLabel.Enabled = false;
                label3.Text = ScoreLabelText0.Text;
            }
            if (RedSquare.Bounds.IntersectsWith(YellowSquare.Bounds))
            {
                timer1.Enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label2.Left = (this.ClientSize.Width - label2.Width) / 2;
                label2.Top = (this.ClientSize.Height - label2.Height) / 2 - 100;
                label3.Left = (this.ClientSize.Width - label3.Width) / 2 + 300;
                label3.Top = (this.ClientSize.Height - label3.Height) / 2 - 100;
                label4.Left = (this.ClientSize.Width - label4.Width) / 2;
                label4.Top = (this.ClientSize.Height - label4.Height) / 2 - 200;
                Move.Enabled = false;
                ScoreLabel.Enabled = false;
                label3.Text = ScoreLabelText0.Text;
            }
            if (RedSquare.Bounds.IntersectsWith(BrownSquare.Bounds))
            {
                timer1.Enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label2.Left = (this.ClientSize.Width - label2.Width) / 2;
                label2.Top = (this.ClientSize.Height - label2.Height) / 2 - 100;
                label3.Left = (this.ClientSize.Width - label3.Width) / 2 + 300;
                label3.Top = (this.ClientSize.Height - label3.Height) / 2 - 100;
                label4.Left = (this.ClientSize.Width - label4.Width) / 2;
                label4.Top = (this.ClientSize.Height - label4.Height) / 2 - 200;
                Move.Enabled = false;
                ScoreLabel.Enabled = false;
                label3.Text = ScoreLabelText0.Text;
            }
            if (RedSquare.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                timer1.Enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label2.Left = (this.ClientSize.Width - label2.Width) / 2;
                label2.Top = (this.ClientSize.Height - label2.Height) / 2 - 100;
                label3.Left = (this.ClientSize.Width - label3.Width) / 2 + 300;
                label3.Top = (this.ClientSize.Height - label3.Height) / 2 - 100;
                label4.Left = (this.ClientSize.Width - label4.Width) / 2;
                label4.Top = (this.ClientSize.Height - label4.Height) / 2 - 200;
                Move.Enabled = false;
                ScoreLabel.Enabled = false;
                label3.Text = ScoreLabelText0.Text;
            }
            if (RedSquare.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                timer1.Enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label2.Left = (this.ClientSize.Width - label2.Width) / 2;
                label2.Top = (this.ClientSize.Height - label2.Height) / 2 - 100;
                label3.Left = (this.ClientSize.Width - label3.Width) / 2 + 300;
                label3.Top = (this.ClientSize.Height - label3.Height) / 2 - 100;
                label4.Left = (this.ClientSize.Width - label4.Width) / 2;
                label4.Top = (this.ClientSize.Height - label4.Height) / 2 - 200;
                Move.Enabled = false;
                ScoreLabel.Enabled = false;
                label3.Text = ScoreLabelText0.Text;
            }



        }

        private void BlackSquare_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            Point pt1 = new Point();
            pt1.X = 50;
            pt1.Y = 50;
            pictureBox1.Location = pt1;
            timer2.Enabled = false;
            timer3.Enabled = true;

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Point pt2 = new Point();
            pt2.X = 50;
            pt2.Y = 50;
            pictureBox2.Location = pt2;
            timer3.Enabled = false;
            timer4.Enabled = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Point pt3 = new Point();
            pt3.X = 50;
            pt3.Y = 50;
            pictureBox3.Location = pt3;
            timer4.Enabled = false;
            timer5.Enabled = true;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            Point pt4 = new Point();
            pt4.X = 50;
            pt4.Y = 50;
            pictureBox4.Location = pt4;
            timer5.Enabled = false;
            timer6.Enabled = true;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            Point pt5 = new Point();
            pt5.X = 50;
            pt5.Y = 50;
            pictureBox5.Location = pt5;
            timer6.Enabled = false;
            timer7.Enabled = true;
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            Point pt6 = new Point();
            pt6.X = 50;
            pt6.Y = 50;
            pictureBox6.Location = pt6;
            timer7.Enabled = false;
            timer8.Enabled = true;
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            Point pt7 = new Point();
            pt7.X = 50;
            pt7.Y = 50;
            pictureBox7.Location = pt7;
            timer8.Enabled = false;
            timer9.Enabled = true;
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            Point pt8 = new Point();
            pt8.X = 50;
            pt8.Y = 50;
            pictureBox8.Location = pt8;
            timer9.Enabled = false;
            timer10.Enabled = true;
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            Point pt9 = new Point();
            pt9.X = 50;
            pt9.Y = 50;
            pictureBox9.Location = pt9;
            timer10.Enabled = false;
            timer11.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            Cursor.Hide();
        }

        private void ScoreLabel_Tick(object sender, EventArgs e)
        {
            s++;
            ScoreLabelText0.Text = s.ToString();
            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.R))
            {
                if (timer1.Enabled == true)
                {
                    timer1.Enabled = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    Move.Enabled = true;
                    s = 0;
                    ScoreLabel.Enabled = true;
                    Point bsq = new Point();
                    bsq.X = 50;
                    bsq.Y = 50;
                    BlackSquare.Location = bsq;
                    Point pb1 = new Point();
                    pb1.X = 2000;
                    pb1.Y = 2000;
                    pictureBox1.Location = pb1;
                    Point pb2 = new Point();
                    pb2.X = 2000;
                    pb2.Y = 2000;
                    pictureBox2.Location = pb2;
                    Point pb3 = new Point();
                    pb3.X = 2000;
                    pb3.Y = 2000;
                    pictureBox3.Location = pb3;
                    Point pb4 = new Point();
                    pb4.X = 2000;
                    pb4.Y = 2000;
                    pictureBox4.Location = pb4;
                    Point pb5 = new Point();
                    pb5.X = 2000;
                    pb5.Y = 2000;
                    pictureBox5.Location = pb5;
                    Point pb6 = new Point();
                    pb6.X = 2000;
                    pb6.Y = 2000;
                    pictureBox6.Location = pb6;
                    Point pb7 = new Point();
                    pb7.X = 2000;
                    pb7.Y = 2000;
                    pictureBox7.Location = pb7;
                    Point pb8 = new Point();
                    pb8.X = 2000;
                    pb8.Y = 2000;
                    pictureBox8.Location = pb8;
                    Point pb9 = new Point();
                    pb9.X = 2000;
                    pb9.Y = 2000;
                    pictureBox9.Location = pb9;
                    Point pb10 = new Point();
                    pb10.X = 2000;
                    pb10.Y = 2000;
                    pictureBox10.Location = pb10;
                    Point pb11 = new Point();
                    pb11.X = 2000;
                    pb11.Y = 2000;
                    pictureBox11.Location = pb11;
                    Point ysq = new Point();
                    ysq.X = 2000;
                    ysq.Y = 2000;
                    YellowSquare.Location = ysq;
                    Point brsq = new Point();
                    brsq.X = 2000;
                    brsq.Y = 2000;
                    BrownSquare.Location = brsq;
                    Point pb13 = new Point();
                    pb13.X = 2000;
                    pb13.Y = 2000;
                    pictureBox13.Location = pb13;
                    Point pb14 = new Point();
                    pb14.X = 2000;
                    pb14.Y = 2000;
                    pictureBox14.Location = pb14;
                    timer2.Enabled = false;
                    timer3.Enabled = false;
                    timer4.Enabled = false;
                    timer5.Enabled = false;
                    timer6.Enabled = false;
                    timer7.Enabled = false;
                    timer8.Enabled = false;
                    timer9.Enabled = false;
                    timer10.Enabled = false;
                    timer11.Enabled = false;
                    timer12.Enabled = false;
                    timer13.Enabled = false;
                    timer14.Enabled = false;
                    timer15.Enabled = false;
                    timer16.Enabled = false;
                    timer2.Enabled = true;
                }
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            Point pt10 = new Point();
            pt10.X = 50;
            pt10.Y = 50;
            pictureBox10.Location = pt10;
            timer11.Enabled = false;
            timer12.Enabled = true;
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            Point pt11 = new Point();
            pt11.X = 50;
            pt11.Y = 50;
            pictureBox11.Location = pt11;
            timer12.Enabled = false;
            timer13.Enabled = true;
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            Point pt13 = new Point();
            pt13.X = 50;
            pt13.Y = 50;
            YellowSquare.Location = pt13;
            timer13.Enabled = false;
            timer14.Enabled = true;
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            Point pt14 = new Point();
            pt14.X = 50;
            pt14.Y = 50;
            pictureBox13.Location = pt14;
            timer14.Enabled = false;
            timer15.Enabled = true;
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            Point pt15 = new Point();
            pt15.X = 50;
            pt15.Y = 50;
            pictureBox14.Location = pt15;
            timer15.Enabled = false;
            timer16.Enabled = true;
        }

        private void timer16_Tick(object sender, EventArgs e)
        {
            Point pt16 = new Point();
            pt16.X = 50;
            pt16.Y = 50;
            BrownSquare.Location = pt16;
            timer16.Enabled = false;
        }
    }
}
