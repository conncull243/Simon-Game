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

namespace Simon_Game
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            GameScreen.score -= 1;
            overLabel.Text = "Game Over. Your score was: " + Convert.ToString(GameScreen.score);
        }
    }
}
