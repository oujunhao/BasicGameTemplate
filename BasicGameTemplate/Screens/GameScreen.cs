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
    public partial class GameScreen : UserControl
    {
        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown;

        //player2 button control keys - DO NOT CHANGE
        Boolean aDown, sDown, dDown, wDown, cDown, vDown, xDown, zDown;

        public GameScreen()
        {
            InitializeComponent();
        }

        public void PauseScreen()
        {
            gameTimer.Enabled = false;

            leftArrowDown = downArrowDown = rightArrowDown = upArrowDown = bDown = nDown = mDown = spaceDown = false;
            aDown = sDown = dDown = wDown = cDown = vDown = xDown = zDown = false;

            //dispay a message
            Graphics g = this.CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.FromArgb(50, 0, 0, 0));
            SolidBrush textBrush = new SolidBrush(Color.White);

            Font f = new Font("Arial", 12);

            g.FillRectangle(sb, ClientRectangle);  //ClientRectangle is rectangle the size of control

            StringFormat sf = new StringFormat();
           // sf.LineAlignment = StringAlignment.Center; // align the y value
            sf.Alignment = StringAlignment.Center;  // align the x value
            //g.DrawString("My String", this.Font, Brushes.Black, ClientRectangle, sf);

            g.DrawString("Press Green Button to Continue \n" +
                "Press Red Button to Exit", f, textBrush, this.Width/2 , 150, sf);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //when the escape key is pressed the game ends and goes back to the main menu
            if (e.KeyCode == Keys.Escape)
            {
                PauseScreen();
                //Form1.changeScreen(this, "MenuScreen");
            }

            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Space:
                    if (gameTimer.Enabled) { spaceDown = true; }
                    else { gameTimer.Enabled = true; }
                    break;
                case Keys.M:
                    if (gameTimer.Enabled) { mDown = true; }
                    else { Form1.changeScreen(this, "MenuScreen"); }
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
            }
        }

        /// <summary>
        /// This is the Game Engine and repeats on each interval of the timer. For example
        /// if the interval is set to 16 then it will run each 16ms or approx. 50 times
        /// per second
        /// </summary>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //main character movements

            //npc character movements

            //collisions checks and other processing

            //calls the GameScreen_Paint method to draw the screen.
            Refresh();
        }

        /// <summary>
        /// Create all on screen graphics in this method
        /// </summary>
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
