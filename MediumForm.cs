using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5
{
    public partial class MediumForm : Form
    {
        bool goRight;
        bool goLeft;
        int speed = 20;

        int ballx = 10;
        int bally = 10;

        int score = 0;

        private Random rnd = new Random();
        public MediumForm()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Tag == "block")
                {
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    c.BackColor = randomColor;
                }
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            //if the player pressed the left key AND the player is inside the panel
            // then we set the car left boolean to true
            if (e.KeyCode == Keys.Left && player.Left > 0)
            {
                goLeft = true;
            }
            // if player pressed the right key and the player left plus player width is less then the panel1 width
            // then we set the player right to true
            if (e.KeyCode == Keys.Right && player.Left + player.Width < 920)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.P)
            {

                MediumTimer.Stop();
                DialogResult result = MessageBox.Show("Game is Paused, Press Ok Button to Resume the Game", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    MediumTimer.Start();
                }
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            // if the LEFT key is up we set the car left to false
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            // if the RIGHT key is up we set the car right to false
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

        }

        private void MediumTimer_Tick(object sender, EventArgs e)
        {
            ball.Left += ballx;
            ball.Top += bally;

            GameScore.Text = "Score: " + score;

            if (goLeft) { player.Left -= speed; } // move left
            if (goRight) { player.Left += speed; } // move right

            if (player.Left < 1)
            {
                goLeft = false;
            }
            else if (player.Left + player.Width > 924)
            {
                goRight = false;
            }
            if (ball.Left + ball.Width > ClientSize.Width || ball.Left < 0)
            {
                ballx = -ballx; // this will bounce the object from the left or right border
            }

            if (ball.Top < 0 || ball.Bounds.IntersectsWith(player.Bounds))
            {
                bally = -bally; // this will bounce the object from top and bottom border
            }

            if (ball.Top + ball.Height > ClientSize.Height)
            {
                gameOver();
            }
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Tag == "block")
                {
                    if (ball.Bounds.IntersectsWith(c.Bounds))
                    {
                        this.Controls.Remove(c);
                        bally = -bally;
                        score++;
                    }
                }
            }

            if (score >= 20)
            {
                gameWin();
            }
        }
        private void gameOver()
        {
            MediumTimer.Stop();
            new LosingForm().Show();
        }
        private void gameWin()
        {
            MediumTimer.Stop();
            new WinnerForm().Show();
        }
    }
}
