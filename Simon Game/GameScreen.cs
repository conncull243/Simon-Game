using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Simon_Game
{
    public partial class GameScreen : UserControl
    {
        SoundPlayer bluePlay = new SoundPlayer(Properties.Resources.blue);
        SoundPlayer yellowPlay = new SoundPlayer(Properties.Resources.yellow);
        SoundPlayer redPlay = new SoundPlayer(Properties.Resources.red);
        SoundPlayer greenPlay = new SoundPlayer(Properties.Resources.green);
        SoundPlayer mistake = new SoundPlayer(Properties.Resources.mistake);

        int guess = 0;

        public static int score = 0;

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            scoreLabel.Text = "Your score is: " + score;
            Form1.pattern.Clear();
            Refresh();
            Thread.Sleep(2000);
            ComputerTurn();
        }

        private void GameOver()
        {
            mistake.Play();
            Form f = this.FindForm();
            redButton.Visible = false;
            greenButton.Visible = false;
            blueButton.Visible = false;
            yellowButton.Visible = false;
            scoreLabel.Visible = false;
            GameOverScreen gos = new GameOverScreen();
            f.Controls.Remove(this);
            f.Controls.Add(gos);
            this.Refresh();
        }

        private void ComputerTurn()
        {
            Thread.Sleep(1000);
            Refresh();
            scoreLabel.Text = "Your score is: " + Convert.ToString(score);
            score++;
            guess = 0;
            Random randNum = new Random();
            Form1.pattern.Add(randNum.Next(0, 4));

            for (int i = 0; i < Form1.pattern.Count(); i++)
            {

                if (Form1.pattern[i] == 0)
                {
                    greenPlay.Play();
                    greenButton.BackColor = Color.LightGreen;
                    Refresh();
                    Thread.Sleep(400);
                    greenButton.BackColor = Color.Green;
                }

                else if (Form1.pattern[i] == 1)
                {
                    redPlay.Play();
                    redButton.BackColor = Color.Coral;
                    Refresh();
                    Thread.Sleep(400);
                    redButton.BackColor = Color.Red;
                }

                else if (Form1.pattern[i] == 2)
                {
                    yellowPlay.Play();
                    yellowButton.BackColor = Color.LightYellow;
                    Refresh();
                    Thread.Sleep(400);
                    yellowButton.BackColor = Color.Yellow;
                }

                else if (Form1.pattern[i] == 3)
                {
                    bluePlay.Play();
                    blueButton.BackColor = Color.LightBlue;
                    Refresh();
                    Thread.Sleep(400);
                    blueButton.BackColor = Color.Blue;
                }
            }
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 0)
            {
                greenPlay.Play();
                greenButton.BackColor = Color.LightGreen;

                Refresh();
                Thread.Sleep(400);

                greenButton.BackColor = Color.Green;
                guess++;
                Refresh();

                if (guess == Form1.pattern.Count())
                {
                    ComputerTurn();
                }
            }

            else
            {
                GameOver();
            }
        }


        private void redButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 1)
            {
                redPlay.Play();
                redButton.BackColor = Color.Coral;

                Refresh();
                Thread.Sleep(400);

                redButton.BackColor = Color.Red;
                guess++;
                Refresh();

                if (guess == Form1.pattern.Count())
                {
                    ComputerTurn();
                }
            }
            
            else
            {
                GameOver();
            }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 2)  
            {
                yellowPlay.Play();
                yellowButton.BackColor = Color.LightYellow;

                Refresh();
                Thread.Sleep(400);

                yellowButton.BackColor = Color.Yellow;
                guess++;
                Refresh();

                if (guess == Form1.pattern.Count())
                {
                    ComputerTurn();
                }
            }
            
            else
            {
                GameOver();
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 3)
            {
                bluePlay.Play();
                blueButton.BackColor = Color.LightBlue;

                Refresh();
                Thread.Sleep(400);

                blueButton.BackColor = Color.Blue;
                guess++;
                Refresh();

                if (guess == Form1.pattern.Count())
                {
                    ComputerTurn();
                }
            }

            else
            {
                GameOver();
            }
        }
    }
}
