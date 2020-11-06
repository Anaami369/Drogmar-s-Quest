﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drogmar_s_Quest
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // Goes to the game screen
            LevelScreen ls = new LevelScreen();
            Form form = this.FindForm();

            form.Controls.Add(ls);
            form.Controls.Remove(this);

            ls.Location = new Point((form.Width - ls.Width) / 2, (form.Height - ls.Height) / 2);
        }

        private void playButton_Enter(object sender, EventArgs e)
        {
            playUnderline.Visible = true;
            exitUnderline.Visible = false;
            highScoreUnderline.Visible = false;
        }

        private void highScoreButton_Click(object sender, EventArgs e)
        {
            // Goes to the high scores screen
            HighScoreScreen hs = new HighScoreScreen();
            Form form = this.FindForm();

            form.Controls.Remove(this);
            form.Controls.Add(hs);

            hs.Location = new Point((form.Width - hs.Width) / 2, (form.Height - hs.Height) / 2);
        }

        private void highScoreButton_Enter(object sender, EventArgs e)
        {
            playUnderline.Visible = false;
            exitUnderline.Visible = false;
            highScoreUnderline.Visible = true;
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            playUnderline.Visible = false;
            exitUnderline.Visible = true;
            highScoreUnderline.Visible = false;
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {
            playUnderline.Visible = false;
            exitUnderline.Visible = false;
            highScoreUnderline.Visible = false;
        }
    }
}
