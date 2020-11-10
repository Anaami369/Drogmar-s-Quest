namespace Drogmar_s_Quest
{
    partial class HighScoreScreen
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreOutput = new System.Windows.Forms.Label();
            this.nameOutput = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(269, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(485, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Score";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreOutput
            // 
            this.scoreOutput.BackColor = System.Drawing.Color.Transparent;
            this.scoreOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.scoreOutput.ForeColor = System.Drawing.Color.Cyan;
            this.scoreOutput.Location = new System.Drawing.Point(480, 354);
            this.scoreOutput.Name = "scoreOutput";
            this.scoreOutput.Size = new System.Drawing.Size(234, 409);
            this.scoreOutput.TabIndex = 11;
            this.scoreOutput.Text = "ui";
            this.scoreOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameOutput
            // 
            this.nameOutput.BackColor = System.Drawing.Color.Transparent;
            this.nameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nameOutput.ForeColor = System.Drawing.Color.Cyan;
            this.nameOutput.Location = new System.Drawing.Point(267, 354);
            this.nameOutput.Name = "nameOutput";
            this.nameOutput.Size = new System.Drawing.Size(217, 409);
            this.nameOutput.TabIndex = 10;
            this.nameOutput.Text = "iu";
            this.nameOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.outputLabel.ForeColor = System.Drawing.Color.Cyan;
            this.outputLabel.Location = new System.Drawing.Point(267, 324);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(447, 439);
            this.outputLabel.TabIndex = 9;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(272, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "HIGH SCORES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.backButton.ForeColor = System.Drawing.Color.Cyan;
            this.backButton.Location = new System.Drawing.Point(10, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(160, 60);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // HighScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Drogmar_s_Quest.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreOutput);
            this.Controls.Add(this.nameOutput);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.DoubleBuffered = true;
            this.Name = "HighScoreScreen";
            this.Size = new System.Drawing.Size(1000, 788);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label scoreOutput;
        private System.Windows.Forms.Label nameOutput;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
    }
}
