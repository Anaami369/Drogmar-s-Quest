namespace Drogmar_s_Quest
{
    partial class EasyScreen
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
            this.pauseLabel = new System.Windows.Forms.Label();
            this.resumeButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreKeeper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pauseLabel
            // 
            this.pauseLabel.BackColor = System.Drawing.Color.DarkGray;
            this.pauseLabel.Font = new System.Drawing.Font("Algerian", 24.75F);
            this.pauseLabel.ForeColor = System.Drawing.Color.Blue;
            this.pauseLabel.Location = new System.Drawing.Point(387, 353);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(250, 40);
            this.pauseLabel.TabIndex = 6;
            this.pauseLabel.Text = "Game Paused";
            this.pauseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resumeButton
            // 
            this.resumeButton.BackColor = System.Drawing.Color.DarkGray;
            this.resumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resumeButton.Font = new System.Drawing.Font("Algerian", 10F);
            this.resumeButton.ForeColor = System.Drawing.Color.Blue;
            this.resumeButton.Location = new System.Drawing.Point(452, 440);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(128, 38);
            this.resumeButton.TabIndex = 10;
            this.resumeButton.Text = "resume game";
            this.resumeButton.UseVisualStyleBackColor = false;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.DarkGray;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuButton.Font = new System.Drawing.Font("Algerian", 10F);
            this.menuButton.ForeColor = System.Drawing.Color.Blue;
            this.menuButton.Location = new System.Drawing.Point(452, 396);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(128, 38);
            this.menuButton.TabIndex = 9;
            this.menuButton.Text = "return to menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // scoreKeeper
            // 
            this.scoreKeeper.BackColor = System.Drawing.Color.Transparent;
            this.scoreKeeper.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Bold);
            this.scoreKeeper.ForeColor = System.Drawing.Color.White;
            this.scoreKeeper.Location = new System.Drawing.Point(15, 11);
            this.scoreKeeper.Name = "scoreKeeper";
            this.scoreKeeper.Size = new System.Drawing.Size(100, 23);
            this.scoreKeeper.TabIndex = 11;
            // 
            // EasyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Drogmar_s_Quest.Properties.Resources.blueSpace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.scoreKeeper);
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.pauseLabel);
            this.DoubleBuffered = true;
            this.Name = "EasyScreen";
            this.Size = new System.Drawing.Size(1000, 788);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EasyScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EasyScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EasyScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label pauseLabel;
        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreKeeper;
    }
}
