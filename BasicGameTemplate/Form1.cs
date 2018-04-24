﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameSystemServices;

namespace BasicGameTemplate
{
    public partial class Form1 : Form
    {
        // Copy code from your game at http://138.197.136.94:5000/games
        // It should look like:
        const string gameToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJnYW1lSWQiOiI1YWRhMTRlYTQ5NWExZjA3YzkwZmI1NjAiLCJjYXJkSWQiOiIxIiwiaWF0IjoxNTI0NTg5NDc4fQ.2Ck8GZgw68hLlGDOBuyj7QZE7rN68KZW3AmaT3EYvwo";
        // If you leave this the way it is, it won't work
        public static Service service = new Service(Environment.GetCommandLineArgs(), gameToken);
        // Delete the above three lines after you've copied

        bool fullScreen = false;  // true: program runs fullscreen || false: program runs in window
       
        public Form1()
        {
            InitializeComponent();

            Cursor.Hide();

            // open the main menu for the game
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);

            #region open in full screen or not
            if (fullScreen)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;

                int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
                int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
                // centre the new screen in the middle of the form
                ms.Location = new Point((screenWidth - ms.Width) / 2, (screenHeight - ms.Height) / 2);
            }
            else
            {
                // centre the new screen in the middle of the form
                ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
            }
            #endregion
        }

        /// <summary>
        /// Will remove the current UserControl on the screen and replace it with
        /// a new one
        /// </summary>
        /// <param name="current">The UserControl to be closed</param>
        /// <param name="next">The name of the UserControl to be opened</param>
        public static void changeScreen(UserControl current, string next)
        {
            //f is set to the form that the current control is on
            Form f = current.FindForm();
            f.Controls.Remove(current);
            UserControl ns = null;
           
            ///If any screens, (UserControls), are added to the program they need to
            ///be added within this switch block as well.
            switch (next)
            {
                case "MenuScreen":
                    ns = new MenuScreen();
                    break;
                case "GameScreen":
                    ns = new GameScreen();
                    break;
                case "ScoreScreen":
                    ns = new ScoreScreen();
                    break;
            }

            ns.Size = new Size(ns.Width, ns.Height);
            ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
            
            f.Controls.Add(ns);
            ns.Focus();
        }

    }
}
