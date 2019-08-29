using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class GameOverUC : UserControl
    {
        public mainForm homeForm { get; set; }

        public GameOverUC()
        {
            InitializeComponent();
        }

        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            homeForm.Show();
            homeForm.SnekGame();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            homeForm.Show();
            homeForm.Home();
        }
    }
}
