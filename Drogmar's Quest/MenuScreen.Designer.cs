namespace Drogmar_s_Quest
{
    partial class MenuScreen
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
            this.playButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playUnderline = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.exitUnderline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playButton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.playButton.ForeColor = System.Drawing.Color.Cyan;
            this.playButton.Location = new System.Drawing.Point(535, 372);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(194, 77);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play Game";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.Enter += new System.EventHandler(this.playButton_Enter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(3, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(997, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "WELCOME TO DROGMAR\'S QUEST";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playUnderline
            // 
            this.playUnderline.BackColor = System.Drawing.Color.Transparent;
            this.playUnderline.BackgroundImage = global::Drogmar_s_Quest.Properties.Resources.lightSaber;
            this.playUnderline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playUnderline.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.playUnderline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.playUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playUnderline.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.playUnderline.ForeColor = System.Drawing.Color.Black;
            this.playUnderline.Location = new System.Drawing.Point(535, 454);
            this.playUnderline.Name = "playUnderline";
            this.playUnderline.Size = new System.Drawing.Size(194, 28);
            this.playUnderline.TabIndex = 13;
            this.playUnderline.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.Cyan;
            this.exitButton.Location = new System.Drawing.Point(292, 372);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(194, 77);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.Enter += new System.EventHandler(this.exitButton_Enter);
            // 
            // exitUnderline
            // 
            this.exitUnderline.BackColor = System.Drawing.Color.Transparent;
            this.exitUnderline.BackgroundImage = global::Drogmar_s_Quest.Properties.Resources.lightSaber;
            this.exitUnderline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitUnderline.Location = new System.Drawing.Point(292, 453);
            this.exitUnderline.Name = "exitUnderline";
            this.exitUnderline.Size = new System.Drawing.Size(194, 29);
            this.exitUnderline.TabIndex = 16;
            this.exitUnderline.UseVisualStyleBackColor = false;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Drogmar_s_Quest.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.exitUnderline);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playUnderline);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playButton);
            this.DoubleBuffered = true;
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1000, 788);
            this.Load += new System.EventHandler(this.MenuScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playUnderline;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button exitUnderline;
    }
}
