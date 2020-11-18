namespace Drogmar_s_Quest
{
    partial class BossScreen
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
            this.components = new System.ComponentModel.Container();
            this.resumeButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.pauseLabel = new System.Windows.Forms.Label();
            this.scoreKeeper = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playAgainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resumeButton
            // 
            this.resumeButton.BackColor = System.Drawing.Color.DarkGray;
            this.resumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resumeButton.Font = new System.Drawing.Font("Algerian", 10F);
            this.resumeButton.ForeColor = System.Drawing.Color.Blue;
            this.resumeButton.Location = new System.Drawing.Point(444, 377);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(130, 38);
            this.resumeButton.TabIndex = 8;
            this.resumeButton.Text = "resume game";
            this.resumeButton.UseVisualStyleBackColor = false;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            this.resumeButton.Paint += new System.Windows.Forms.PaintEventHandler(this.BossScreen_Paint);
            this.resumeButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BossScreen_KeyUp);
            this.resumeButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.BossScreen_PreviewKeyDown);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.DarkGray;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuButton.Font = new System.Drawing.Font("Algerian", 10F);
            this.menuButton.ForeColor = System.Drawing.Color.Blue;
            this.menuButton.Location = new System.Drawing.Point(444, 333);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(130, 38);
            this.menuButton.TabIndex = 7;
            this.menuButton.Text = "Quit game";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // pauseLabel
            // 
            this.pauseLabel.BackColor = System.Drawing.Color.DarkGray;
            this.pauseLabel.Font = new System.Drawing.Font("Algerian", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseLabel.ForeColor = System.Drawing.Color.Blue;
            this.pauseLabel.Location = new System.Drawing.Point(382, 290);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(250, 40);
            this.pauseLabel.TabIndex = 6;
            this.pauseLabel.Text = "Game Paused";
            this.pauseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreKeeper
            // 
            this.scoreKeeper.BackColor = System.Drawing.Color.Transparent;
            this.scoreKeeper.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Bold);
            this.scoreKeeper.ForeColor = System.Drawing.Color.White;
            this.scoreKeeper.Location = new System.Drawing.Point(14, 11);
            this.scoreKeeper.Name = "scoreKeeper";
            this.scoreKeeper.Size = new System.Drawing.Size(100, 23);
            this.scoreKeeper.TabIndex = 10;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.DarkGray;
            this.playAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playAgainButton.Font = new System.Drawing.Font("Algerian", 10F);
            this.playAgainButton.ForeColor = System.Drawing.Color.Blue;
            this.playAgainButton.Location = new System.Drawing.Point(444, 377);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(130, 38);
            this.playAgainButton.TabIndex = 11;
            this.playAgainButton.Text = "Play again";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // BossScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Drogmar_s_Quest.Properties.Resources.redSpace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.scoreKeeper);
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.pauseLabel);
            this.DoubleBuffered = true;
            this.Name = "BossScreen";
            this.Size = new System.Drawing.Size(1000, 788);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BossScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BossScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.BossScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label pauseLabel;
        private System.Windows.Forms.Label scoreKeeper;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button playAgainButton;
    }
}
