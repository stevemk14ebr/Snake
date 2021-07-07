using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Snake
{
    public partial class Snake : UserControl, IMessageFilter
    {
        public event Action<int> DifficultyChanged;
        public MainForm homeForm { get; set; }
        SnakePlayer player;
        FoodManager foodManager;
        Random r = new Random();
        private int score = 0;
        public Snake()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
            player = new SnakePlayer(this);
            foodManager = new FoodManager(GameCanvas.Width, GameCanvas.Height);
            foodManager.AddRandomFood(10);
            ScoreTxtBox.Text = score.ToString();
            DifficultyChanged += SetTimer;
        }

        public void ToggleTimer()
        {
            GameTimer.Enabled = !GameTimer.Enabled;
        }

        public void ResetGame()
        {
            homeForm.Show();
            homeForm.GameOver();

            player = new SnakePlayer(this);
            foodManager = new FoodManager(GameCanvas.Width, GameCanvas.Height);
            foodManager.AddRandomFood(10);
            score = 0;
        }

        public bool PreFilterMessage(ref Message msg)
        {
            Console.WriteLine((Keys)0x0101 == Keys.Up);
            return false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void GameCanvasPaint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            player.Draw(canvas);
            foodManager.Draw(canvas);
        }

        private void CheckForCollisions()
        {
            if (player.IsIntersectingRect(new Rectangle(-100, 0, 100, GameCanvas.Height)))
                player.OnHitWall(Direction.Left);

            if (player.IsIntersectingRect(new Rectangle(0, -100, GameCanvas.Width, 100)))
                player.OnHitWall(Direction.Up);

            if (player.IsIntersectingRect(new Rectangle(GameCanvas.Width, 0, 100, GameCanvas.Height)))
                player.OnHitWall(Direction.Right);

            if (player.IsIntersectingRect(new Rectangle(0, GameCanvas.Height, GameCanvas.Width, 100)))
                player.OnHitWall(Direction.Down);

            //Is hitting food
            List<Rectangle> SnakeRects = player.GetRects();
            foreach (Rectangle rect in SnakeRects)
            {
                if (foodManager.IsIntersectingRect(rect, true))
                {
                    foodManager.AddRandomFood();
                    player.AddBodySegments(1);
                    score++;
                    ScoreTxtBox.Text = score.ToString();
                }
            }
        }

        private void SetPlayerMovement()
        {
            //if (Input.IsKeyDown(Keys.Left) || Input.IsKeyDown(Keys.A))
            //{
            //    player.SetDirection(Direction.Left);
            //}
            //else if (Input.IsKeyDown(Keys.Right) || Input.IsKeyDown(Keys.D))
            //{
            //    player.SetDirection(Direction.Right);
            //}
            //else if (Input.IsKeyDown(Keys.Up) || Input.IsKeyDown(Keys.W))
            //{
            //    player.SetDirection(Direction.Up);
            //}
            //else if (Input.IsKeyDown(Keys.Down) || Input.IsKeyDown(Keys.S))
            //{
            //    player.SetDirection(Direction.Down);
            //}
            player.MovePlayer();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            SetPlayerMovement();
            CheckForCollisions();
            GameCanvas.Invalidate();
        }

        private void StartButtonClick(object sender, EventArgs e)
        {
            ToggleTimer();
        }

        private void SetTimer(int val)
        {
            this.GameTimer.Interval = val;
        }
        private void HowDareYouButtonClick(object sender, EventArgs e)
        {
            int index = r.Next(4);
            switch (index)
            {
                case 0:
                    howDareYouLabel.Text = "How dare you listen!";
                    break;
                case 1:
                    howDareYouLabel.Text = "This is a dark path you are on!";
                    break;
                case 2:
                    howDareYouLabel.Text = "I knew you wouldn't listen!";
                    break;
                case 3:
                    howDareYouLabel.Text = "Have some food!!!!!!!!!!  :)";
                    foodManager.AddRandomFood(20);
                    GameCanvas.Invalidate();
                    break;
                default:
                    break;
            }
        }
  
        private void GameCanvas_Click(object sender, EventArgs e) { }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            homeForm.Show();
            homeForm.Home();
        }

        public void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            Keys code = e.KeyCode;
            if (code == Keys.Left || code == Keys.A)
            {
                player.SetDirection(Direction.Left);
            }
            else if (code == Keys.Right || code == Keys.D)
            {
                player.SetDirection(Direction.Right);
            }
            else if (code == Keys.Up || code == Keys.W)
            {
                player.SetDirection(Direction.Up);
            }
            else if (code == Keys.Down || code == Keys.S)
            {
                player.SetDirection(Direction.Down);
            }
        }


        private void difficultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chosenDifficulty = (sender as ComboBox).Text;
            if (chosenDifficulty == "Easy")
            {
                DifficultyChanged?.Invoke(200);
            }
            else if (chosenDifficulty == "Medium")
            {
                DifficultyChanged?.Invoke(125);
            }
            else if (chosenDifficulty == "Hard")
            {
                DifficultyChanged?.Invoke(75);
            }
            else if (chosenDifficulty == "Master")
            {
                DifficultyChanged?.Invoke(25);
            }
        }
    }
}
