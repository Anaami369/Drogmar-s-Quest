namespace Drogmar_s_Quest
{
    partial class GameOverScreen
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
            this.exitButton = new System.Windows.Forms.Button();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Enabled = false;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold);
            this.exitButton.Location = new System.Drawing.Point(250, 301);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(194, 77);
            this.exitButton.TabIndex = 256;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.Enter += new System.EventHandler(this.exitButton_Enter);
            this.exitButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.exitButton_PreviewKeyDown);
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.White;
            this.playAgainButton.Enabled = false;
            this.playAgainButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.playAgainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.playAgainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.playAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playAgainButton.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold);
            this.playAgainButton.Location = new System.Drawing.Point(574, 301);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(194, 77);
            this.playAgainButton.TabIndex = 255;
            this.playAgainButton.TabStop = false;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            this.playAgainButton.Enter += new System.EventHandler(this.playAgainButton_Enter);
            this.playAgainButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.playAgainButton_PreviewKeyDown);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("Algerian", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.Orange;
            this.gameOverLabel.Location = new System.Drawing.Point(1, 132);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(997, 105);
            this.gameOverLabel.TabIndex = 251;
            this.gameOverLabel.Text = "Game Over";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Drogmar_s_Quest.Properties.Resources.menuSpace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.gameOverLabel);
            this.DoubleBuffered = true;
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(1000, 788);
            this.Load += new System.EventHandler(this.GameOverScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Label gameOverLabel;
    }
}
