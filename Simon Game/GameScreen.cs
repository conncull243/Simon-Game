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
        public GameScreen()
        {
            InitializeComponent();
            SoundPlayer player = new SoundPlayer();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Form1.pattern.Clear();
            Refresh();
            Thread.Sleep(2000);
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            Random randNum = new Random();
            Form1.pattern.Add(randNum.Next(1, 4));

        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            
            greenButton.BackColor = Color.LightGreen;
            Refresh();
            Thread.Sleep(400);
            greenButton.BackColor = Color.Green;
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            redButton.BackColor = Color.Coral;
            Refresh();
            Thread.Sleep(400);
            redButton.BackColor = Color.Red;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            yellowButton.BackColor = Color.LightYellow;
            Refresh();
            Thread.Sleep(400);
            yellowButton.BackColor = Color.Yellow;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            blueButton.BackColor = Color.LightBlue;
            Refresh();
            Thread.Sleep(400);
            blueButton.BackColor = Color.Blue;
        }
    }
}
