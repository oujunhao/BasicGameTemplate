using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicGameTemplate
{
    public partial class ScoreScreen : UserControl
    {

        IList<GameSystemServices.Highscore> highscores;

        public ScoreScreen()
        {
            InitializeComponent();
        }

        private void ScoreScreen_Load(object sender, EventArgs e)
        {
            highscores = Form1.service.getHighscores();
            foreach (GameSystemServices.Highscore highscore in highscores)
            {
                rankLabel.Text += highscore.Rank + ".\n";
                playerNameLabel.Text += highscore.Name + "\n";
                scoreLabel.Text += "Level " + highscore.Score + "\n";
            }
        }

        private void ScoreScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //when the escape key is pressed the game ends and goes back to the main menu
            if (e.KeyCode == Keys.Escape)
            {
                Form1.changeScreen(this, "MenuScreen");
            }
        }
    }
}
