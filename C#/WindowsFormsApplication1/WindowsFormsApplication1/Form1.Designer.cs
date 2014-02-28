namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button = new System.Windows.Forms.Button();
            this.HangmanLabel = new System.Windows.Forms.Label();
            this.WordLabel = new System.Windows.Forms.Label();
            this.Guess = new System.Windows.Forms.TextBox();
            this.Notification = new System.Windows.Forms.Label();
            this.RetryButton = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.Color.Silver;
            this.Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Button.Location = new System.Drawing.Point(87, 206);
            this.Button.Margin = new System.Windows.Forms.Padding(0);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(134, 39);
            this.Button.TabIndex = 0;
            this.Button.Text = "Guess";
            this.Button.UseVisualStyleBackColor = false;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // HangmanLabel
            // 
            this.HangmanLabel.AutoSize = true;
            this.HangmanLabel.Location = new System.Drawing.Point(126, 39);
            this.HangmanLabel.Name = "HangmanLabel";
            this.HangmanLabel.Size = new System.Drawing.Size(0, 13);
            this.HangmanLabel.TabIndex = 1;
            // 
            // WordLabel
            // 
            this.WordLabel.AutoSize = true;
            this.WordLabel.Location = new System.Drawing.Point(126, 147);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(0, 13);
            this.WordLabel.TabIndex = 2;
            // 
            // Guess
            // 
            this.Guess.BackColor = System.Drawing.Color.Black;
            this.Guess.ForeColor = System.Drawing.Color.Red;
            this.Guess.Location = new System.Drawing.Point(99, 172);
            this.Guess.Name = "Guess";
            this.Guess.Size = new System.Drawing.Size(102, 20);
            this.Guess.TabIndex = 3;
            // 
            // Notification
            // 
            this.Notification.AutoSize = true;
            this.Notification.Location = new System.Drawing.Point(12, 9);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(0, 13);
            this.Notification.TabIndex = 4;
            // 
            // RetryButton
            // 
            this.RetryButton.BackColor = System.Drawing.Color.Silver;
            this.RetryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RetryButton.Location = new System.Drawing.Point(207, 168);
            this.RetryButton.Name = "RetryButton";
            this.RetryButton.Size = new System.Drawing.Size(73, 26);
            this.RetryButton.TabIndex = 5;
            this.RetryButton.Text = "Play Again";
            this.RetryButton.UseVisualStyleBackColor = false;
            this.RetryButton.Visible = false;
            this.RetryButton.Click += new System.EventHandler(this.RetryButton_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(0, 253);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(46, 13);
            this.ScoreLabel.TabIndex = 6;
            this.ScoreLabel.Text = "Scores: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.RetryButton);
            this.Controls.Add(this.Notification);
            this.Controls.Add(this.Guess);
            this.Controls.Add(this.WordLabel);
            this.Controls.Add(this.HangmanLabel);
            this.Controls.Add(this.Button);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Hangman Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label HangmanLabel;
        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.TextBox Guess;
        private System.Windows.Forms.Label Notification;
        private System.Windows.Forms.Button RetryButton;
        private System.Windows.Forms.Label ScoreLabel;
    }
}

