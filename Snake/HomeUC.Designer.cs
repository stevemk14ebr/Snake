namespace Snake
{
    partial class HomeUC
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
            this.btn_Tutorial = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.img_SnakeTitle = new System.Windows.Forms.PictureBox();
            this.img_Snake = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_SnakeTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Snake)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Tutorial
            // 
            this.btn_Tutorial.AutoSize = true;
            this.btn_Tutorial.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Tutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tutorial.ForeColor = System.Drawing.Color.Black;
            this.btn_Tutorial.Location = new System.Drawing.Point(285, 617);
            this.btn_Tutorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Tutorial.Name = "btn_Tutorial";
            this.btn_Tutorial.Size = new System.Drawing.Size(151, 75);
            this.btn_Tutorial.TabIndex = 7;
            this.btn_Tutorial.Text = "Tutorial";
            this.btn_Tutorial.UseVisualStyleBackColor = false;
            this.btn_Tutorial.Click += new System.EventHandler(this.btn_Tutorial_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.ForeColor = System.Drawing.Color.Black;
            this.btn_Play.Location = new System.Drawing.Point(799, 617);
            this.btn_Play.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(151, 75);
            this.btn_Play.TabIndex = 6;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // img_SnakeTitle
            // 
            this.img_SnakeTitle.Image = global::Snake.Properties.Resources.PixelSnakeTitle;
            this.img_SnakeTitle.Location = new System.Drawing.Point(351, 38);
            this.img_SnakeTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.img_SnakeTitle.Name = "img_SnakeTitle";
            this.img_SnakeTitle.Size = new System.Drawing.Size(528, 252);
            this.img_SnakeTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_SnakeTitle.TabIndex = 5;
            this.img_SnakeTitle.TabStop = false;
            // 
            // img_Snake
            // 
            this.img_Snake.Image = global::Snake.Properties.Resources.PixelSnake;
            this.img_Snake.Location = new System.Drawing.Point(455, 294);
            this.img_Snake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.img_Snake.Name = "img_Snake";
            this.img_Snake.Size = new System.Drawing.Size(326, 412);
            this.img_Snake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Snake.TabIndex = 4;
            this.img_Snake.TabStop = false;
            // 
            // HomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btn_Tutorial);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.img_SnakeTitle);
            this.Controls.Add(this.img_Snake);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomeUC";
            this.Size = new System.Drawing.Size(1234, 745);
            ((System.ComponentModel.ISupportInitialize)(this.img_SnakeTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Snake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Tutorial;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.PictureBox img_SnakeTitle;
        private System.Windows.Forms.PictureBox img_Snake;
    }
}
