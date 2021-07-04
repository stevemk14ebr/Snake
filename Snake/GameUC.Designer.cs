namespace Snake
{
    partial class Snake
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameCanvas = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Start_Btn = new System.Windows.Forms.Button();
            this.DareBtn = new System.Windows.Forms.Button();
            this.ScoreTxtBox = new System.Windows.Forms.TextBox();
            this.ScoreLbl = new System.Windows.Forms.Label();
            this.btn_Home = new System.Windows.Forms.Button();
            this.howDareYouLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // GameCanvas
            // 
            this.GameCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GameCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameCanvas.Location = new System.Drawing.Point(5, 9);
            this.GameCanvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GameCanvas.Name = "GameCanvas";
            this.GameCanvas.Size = new System.Drawing.Size(787, 536);
            this.GameCanvas.TabIndex = 0;
            this.GameCanvas.TabStop = false;
            this.GameCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.GameCanvasPaint);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 120;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Start_Btn
            // 
            this.Start_Btn.BackColor = System.Drawing.Color.Firebrick;
            this.Start_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Btn.Location = new System.Drawing.Point(801, 40);
            this.Start_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Start_Btn.Name = "Start_Btn";
            this.Start_Btn.Size = new System.Drawing.Size(273, 28);
            this.Start_Btn.TabIndex = 1;
            this.Start_Btn.Text = "Start/Pause";
            this.Start_Btn.UseVisualStyleBackColor = false;
            this.Start_Btn.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // DareBtn
            // 
            this.DareBtn.BackColor = System.Drawing.Color.Firebrick;
            this.DareBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DareBtn.Location = new System.Drawing.Point(799, 515);
            this.DareBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DareBtn.Name = "DareBtn";
            this.DareBtn.Size = new System.Drawing.Size(275, 28);
            this.DareBtn.TabIndex = 2;
            this.DareBtn.Text = "I Dare You To Press Me";
            this.DareBtn.UseVisualStyleBackColor = false;
            this.DareBtn.Click += new System.EventHandler(this.HowDareYouButtonClick);
            // 
            // ScoreTxtBox
            // 
            this.ScoreTxtBox.Enabled = false;
            this.ScoreTxtBox.Location = new System.Drawing.Point(859, 76);
            this.ScoreTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ScoreTxtBox.Name = "ScoreTxtBox";
            this.ScoreTxtBox.ReadOnly = true;
            this.ScoreTxtBox.Size = new System.Drawing.Size(213, 22);
            this.ScoreTxtBox.TabIndex = 3;
            // 
            // ScoreLbl
            // 
            this.ScoreLbl.AutoSize = true;
            this.ScoreLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScoreLbl.Location = new System.Drawing.Point(801, 78);
            this.ScoreLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreLbl.Name = "ScoreLbl";
            this.ScoreLbl.Size = new System.Drawing.Size(49, 17);
            this.ScoreLbl.TabIndex = 4;
            this.ScoreLbl.Text = "Score:";
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Location = new System.Drawing.Point(801, 9);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(273, 28);
            this.btn_Home.TabIndex = 5;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // lbl_Game
            // 
            this.howDareYouLabel.AutoSize = true;
            this.howDareYouLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howDareYouLabel.ForeColor = System.Drawing.Color.White;
            this.howDareYouLabel.Location = new System.Drawing.Point(803, 114);
            this.howDareYouLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.howDareYouLabel.MaximumSize = new System.Drawing.Size(243, 234);
            this.howDareYouLabel.Name = "lbl_Game";
            this.howDareYouLabel.Size = new System.Drawing.Size(0, 25);
            this.howDareYouLabel.TabIndex = 6;
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.howDareYouLabel);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.ScoreLbl);
            this.Controls.Add(this.ScoreTxtBox);
            this.Controls.Add(this.DareBtn);
            this.Controls.Add(this.Start_Btn);
            this.Controls.Add(this.GameCanvas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Snake";
            this.Size = new System.Drawing.Size(1081, 552);
            ((System.ComponentModel.ISupportInitialize)(this.GameCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GameCanvas;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button Start_Btn;
        private System.Windows.Forms.Button DareBtn;
        private System.Windows.Forms.TextBox ScoreTxtBox;
        private System.Windows.Forms.Label ScoreLbl;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Label howDareYouLabel;
    }
}