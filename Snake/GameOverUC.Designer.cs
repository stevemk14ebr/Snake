namespace Snake
{
    partial class GameOverUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_PlayAgain = new System.Windows.Forms.Button();
            this.img_Snake = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_GameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_Snake)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Home
            // 
            this.btn_Home.AutoSize = true;
            this.btn_Home.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.Black;
            this.btn_Home.Location = new System.Drawing.Point(211, 610);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(199, 75);
            this.btn_Home.TabIndex = 10;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.BackColor = System.Drawing.Color.Firebrick;
            this.btn_PlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayAgain.ForeColor = System.Drawing.Color.Black;
            this.btn_PlayAgain.Location = new System.Drawing.Point(802, 610);
            this.btn_PlayAgain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(199, 75);
            this.btn_PlayAgain.TabIndex = 9;
            this.btn_PlayAgain.Text = "Play Again";
            this.btn_PlayAgain.UseVisualStyleBackColor = false;
            this.btn_PlayAgain.Click += new System.EventHandler(this.btn_PlayAgain_Click);
            // 
            // img_Snake
            // 
            this.img_Snake.Image = global::Snake.Properties.Resources.DizzyPixelSnake;
            this.img_Snake.Location = new System.Drawing.Point(442, 273);
            this.img_Snake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.img_Snake.Name = "img_Snake";
            this.img_Snake.Size = new System.Drawing.Size(326, 412);
            this.img_Snake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Snake.TabIndex = 8;
            this.img_Snake.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(285, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 108);
            this.label1.TabIndex = 11;
            this.label1.Text = "GAME OVER!";
            // 
            // lbl_GameOver
            // 
            this.lbl_GameOver.AutoSize = true;
            this.lbl_GameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GameOver.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_GameOver.Location = new System.Drawing.Point(204, 200);
            this.lbl_GameOver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GameOver.Name = "lbl_GameOver";
            this.lbl_GameOver.Size = new System.Drawing.Size(797, 37);
            this.lbl_GameOver.TabIndex = 12;
            this.lbl_GameOver.Text = "OUCHY! (You have Collided with a wall or yourself)";
            // 
            // GameOverUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lbl_GameOver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.btn_PlayAgain);
            this.Controls.Add(this.img_Snake);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GameOverUC";
            this.Size = new System.Drawing.Size(1234, 745);
            ((System.ComponentModel.ISupportInitialize)(this.img_Snake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_PlayAgain;
        private System.Windows.Forms.PictureBox img_Snake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_GameOver;
    }
}
