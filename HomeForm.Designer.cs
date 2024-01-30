namespace Personal_Finance
{
    partial class HomeForm
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
            this.HomeLabel = new System.Windows.Forms.Label();
            this.person1Button = new System.Windows.Forms.Button();
            this.person2Button = new System.Windows.Forms.Button();
            this.person3Button = new System.Windows.Forms.Button();
            this.person4Button = new System.Windows.Forms.Button();
            this.sharedButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.person3Button);
            this.Controls.Add(this.person4Button);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.sharedButton);
            this.Controls.Add(this.person1Button);
            this.Controls.Add(this.person2Button);
            this.Controls.Add(this.HomeLabel);
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = true;
            this.HomeLabel.Location = new System.Drawing.Point(245, 83);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(89, 13);
            this.HomeLabel.TabIndex = 0;
            this.HomeLabel.Text = "Personal Finance";
            // 
            // person1Button
            // 
            this.person1Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.person1Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.person1Button.Location = new System.Drawing.Point(41, 227);
            this.person1Button.MaximumSize = new System.Drawing.Size(200, 150);
            this.person1Button.MinimumSize = new System.Drawing.Size(125, 87);
            this.person1Button.Name = "person1Button";
            this.person1Button.Size = new System.Drawing.Size(125, 87);
            this.person1Button.TabIndex = 2;
            this.person1Button.Text = "Person 1";
            this.person1Button.UseVisualStyleBackColor = true;
            this.person1Button.Visible = false;
            this.person1Button.Click += new System.EventHandler(this.Person1Button_Click);
            // 
            // person2Button
            // 
            this.person2Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.person2Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.person2Button.Location = new System.Drawing.Point(331, 227);
            this.person2Button.MaximumSize = new System.Drawing.Size(200, 150);
            this.person2Button.MinimumSize = new System.Drawing.Size(125, 87);
            this.person2Button.Name = "person2Button";
            this.person2Button.Size = new System.Drawing.Size(125, 87);
            this.person2Button.TabIndex = 1;
            this.person2Button.Text = "Person 2";
            this.person2Button.UseVisualStyleBackColor = true;
            this.person2Button.Visible = false;
            this.person2Button.Click += new System.EventHandler(this.Person2Button_Click);
            // 
            // person3Button
            // 
            this.person3Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.person3Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.person3Button.Location = new System.Drawing.Point(41, 333);
            this.person3Button.MaximumSize = new System.Drawing.Size(200, 150);
            this.person3Button.MinimumSize = new System.Drawing.Size(125, 87);
            this.person3Button.Name = "person3Button";
            this.person3Button.Size = new System.Drawing.Size(125, 87);
            this.person3Button.TabIndex = 7;
            this.person3Button.Text = "Person 3";
            this.person3Button.UseVisualStyleBackColor = true;
            this.person3Button.Visible = false;
            // 
            // person4Button
            // 
            this.person4Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.person4Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.person4Button.Location = new System.Drawing.Point(331, 333);
            this.person4Button.MaximumSize = new System.Drawing.Size(200, 150);
            this.person4Button.MinimumSize = new System.Drawing.Size(125, 87);
            this.person4Button.Name = "person4Button";
            this.person4Button.Size = new System.Drawing.Size(125, 87);
            this.person4Button.TabIndex = 6;
            this.person4Button.Text = "Person 4";
            this.person4Button.UseVisualStyleBackColor = true;
            this.person4Button.Visible = false;
            // 
            // sharedButton
            // 
            this.sharedButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sharedButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sharedButton.Location = new System.Drawing.Point(611, 282);
            this.sharedButton.MaximumSize = new System.Drawing.Size(200, 150);
            this.sharedButton.MinimumSize = new System.Drawing.Size(125, 87);
            this.sharedButton.Name = "sharedButton";
            this.sharedButton.Size = new System.Drawing.Size(125, 87);
            this.sharedButton.TabIndex = 3;
            this.sharedButton.Text = "Shared";
            this.sharedButton.UseVisualStyleBackColor = true;
            this.sharedButton.Visible = false;
            this.sharedButton.Click += new System.EventHandler(this.SharedButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.settingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsButton.Location = new System.Drawing.Point(133, 515);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 23);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.Location = new System.Drawing.Point(577, 515);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);

        }

        #endregion

        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.Button person2Button;
        private System.Windows.Forms.Button person1Button;
        private System.Windows.Forms.Button sharedButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button person3Button;
        private System.Windows.Forms.Button person4Button;
    }
}

