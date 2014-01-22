namespace TicTacToe___WFA
{
    partial class nextPersonTurn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nextPersonTurn));
            this.doneButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.user1TextBox = new System.Windows.Forms.TextBox();
            this.user2TextBox = new System.Windows.Forms.TextBox();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // doneButton
            // 
            this.doneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doneButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.Location = new System.Drawing.Point(100, 215);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 33);
            this.doneButton.TabIndex = 0;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(21, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(229, 37);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Enter Your Names";
            // 
            // user1TextBox
            // 
            this.user1TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user1TextBox.Location = new System.Drawing.Point(28, 65);
            this.user1TextBox.Name = "user1TextBox";
            this.user1TextBox.Size = new System.Drawing.Size(222, 25);
            this.user1TextBox.TabIndex = 2;
            this.user1TextBox.Text = "(This User is \'X\')";
            this.user1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.user1TextBox.Click += new System.EventHandler(this.user1TextBox_Click);
            this.user1TextBox.Leave += new System.EventHandler(this.user1TextBox_Leave);
            // 
            // user2TextBox
            // 
            this.user2TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user2TextBox.Location = new System.Drawing.Point(28, 105);
            this.user2TextBox.Name = "user2TextBox";
            this.user2TextBox.Size = new System.Drawing.Size(222, 25);
            this.user2TextBox.TabIndex = 3;
            this.user2TextBox.Text = "(This User is \'O\')";
            this.user2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.user2TextBox.Click += new System.EventHandler(this.user2TextBox_Click);
            this.user2TextBox.Leave += new System.EventHandler(this.user2TextBox_Leave);
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtitleLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.subtitleLabel.Location = new System.Drawing.Point(0, 146);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(276, 13);
            this.subtitleLabel.TabIndex = 4;
            this.subtitleLabel.Text = "  Display (Annoying) Alerts When New Turn Begins?  ";
            this.subtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.yesRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yesRadioButton.Location = new System.Drawing.Point(66, 174);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(41, 17);
            this.yesRadioButton.TabIndex = 5;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = false;
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.noRadioButton.Checked = true;
            this.noRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noRadioButton.Location = new System.Drawing.Point(169, 174);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(40, 17);
            this.noRadioButton.TabIndex = 6;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = false;
            // 
            // nextPersonTurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(274, 260);
            this.Controls.Add(this.noRadioButton);
            this.Controls.Add(this.yesRadioButton);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.user2TextBox);
            this.Controls.Add(this.user1TextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.doneButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "nextPersonTurn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.nextPersonTurn_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox user1TextBox;
        private System.Windows.Forms.TextBox user2TextBox;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.RadioButton noRadioButton;
    }
}