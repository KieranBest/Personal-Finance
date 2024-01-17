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
            this.Person2Button = new System.Windows.Forms.Button();
            this.Person1Button = new System.Windows.Forms.Button();
            this.SharedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // Person2Button
            // 
            this.Person2Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Person2Button.Location = new System.Drawing.Point(222, 194);
            this.Person2Button.MaximumSize = new System.Drawing.Size(200, 150);
            this.Person2Button.MinimumSize = new System.Drawing.Size(125, 87);
            this.Person2Button.Name = "Person2Button";
            this.Person2Button.Size = new System.Drawing.Size(125, 87);
            this.Person2Button.TabIndex = 1;
            this.Person2Button.Text = "Kim";
            this.Person2Button.UseVisualStyleBackColor = true;
            // 
            // Person1Button
            // 
            this.Person1Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Person1Button.Location = new System.Drawing.Point(41, 194);
            this.Person1Button.MaximumSize = new System.Drawing.Size(200, 150);
            this.Person1Button.MinimumSize = new System.Drawing.Size(125, 87);
            this.Person1Button.Name = "Person1Button";
            this.Person1Button.Size = new System.Drawing.Size(125, 87);
            this.Person1Button.TabIndex = 2;
            this.Person1Button.Text = "Kieran";
            this.Person1Button.UseVisualStyleBackColor = true;
            this.Person1Button.Click += new System.EventHandler(this.Person1Button_Click);
            // 
            // SharedButton
            // 
            this.SharedButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SharedButton.Location = new System.Drawing.Point(398, 194);
            this.SharedButton.MaximumSize = new System.Drawing.Size(200, 150);
            this.SharedButton.MinimumSize = new System.Drawing.Size(125, 87);
            this.SharedButton.Name = "SharedButton";
            this.SharedButton.Size = new System.Drawing.Size(125, 87);
            this.SharedButton.TabIndex = 3;
            this.SharedButton.Text = "Shared";
            this.SharedButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 495);
            this.Controls.Add(this.SharedButton);
            this.Controls.Add(this.Person1Button);
            this.Controls.Add(this.Person2Button);
            this.Controls.Add(this.HomeLabel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.Button Person2Button;
        private System.Windows.Forms.Button Person1Button;
        private System.Windows.Forms.Button SharedButton;
    }
}

