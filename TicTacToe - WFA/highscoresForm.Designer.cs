namespace TicTacToe___WFA
{
    partial class highscoresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(highscoresForm));
            this.highscoresTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // highscoresTextBox
            // 
            this.highscoresTextBox.BackColor = System.Drawing.Color.White;
            this.highscoresTextBox.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.highscoresTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoresTextBox.Location = new System.Drawing.Point(40, 49);
            this.highscoresTextBox.Multiline = true;
            this.highscoresTextBox.Name = "highscoresTextBox";
            this.highscoresTextBox.ReadOnly = true;
            this.highscoresTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.highscoresTextBox.Size = new System.Drawing.Size(108, 162);
            this.highscoresTextBox.TabIndex = 0;
            this.highscoresTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.titleLabel.Location = new System.Drawing.Point(21, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(147, 37);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Highscores";
            // 
            // highscoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(192, 222);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.highscoresTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "highscoresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "High Scores";
            this.Load += new System.EventHandler(this.highscoresForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox highscoresTextBox;
        private System.Windows.Forms.Label titleLabel;
    }
}