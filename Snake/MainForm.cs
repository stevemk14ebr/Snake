using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class mainForm : Form
    {
        HomeUC homeUC = new HomeUC();
        Snake gameUC = new Snake();
        TutorialUC tutorialUC = new TutorialUC();
        GameOverUC gameOverUC = new GameOverUC();

        public mainForm()
        {
            InitializeComponent();
            Home();
            homeUC.homeForm = this;
            gameUC.homeForm = this;
            tutorialUC.homeForm = this;
            gameOverUC.homeForm = this;
        }

        internal void Home()
        {
            this.Controls.Clear();
            this.Controls.Add(homeUC);
            homeUC.Show();
        }

        internal void SnekGame()
        {
            this.Controls.Clear();
            this.Controls.Add(gameUC);
            gameUC.Show();

        }
        internal void Tutorial()
        {
            this.Controls.Clear();
            this.Controls.Add(tutorialUC);
            tutorialUC.Show();
        }

        internal void GameOver()
        {
            this.Controls.Clear();
            this.Controls.Add(gameOverUC);
            gameOverUC.Show();
        }
    }
}
