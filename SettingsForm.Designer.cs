namespace Personal_Finance
{
    partial class SettingsForm
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
            this.background = new System.Windows.Forms.PictureBox();
            this.person1 = new System.Windows.Forms.Button();
            this.person2 = new System.Windows.Forms.Button();
            this.person4 = new System.Windows.Forms.Button();
            this.person3 = new System.Windows.Forms.Button();
            this.sharedN = new System.Windows.Forms.Button();
            this.sharedY = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background.BackColor = System.Drawing.Color.Silver;
            this.background.Location = new System.Drawing.Point(200, 25);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(400, 500);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // person1
            // 
            this.person1.Location = new System.Drawing.Point(476, 105);
            this.person1.Name = "person1";
            this.person1.Size = new System.Drawing.Size(75, 23);
            this.person1.TabIndex = 1;
            this.person1.Text = "1 Person";
            this.person1.UseVisualStyleBackColor = true;
            this.person1.Click += new System.EventHandler(this.person1_Click);
            // 
            // person2
            // 
            this.person2.Location = new System.Drawing.Point(476, 134);
            this.person2.Name = "person2";
            this.person2.Size = new System.Drawing.Size(75, 23);
            this.person2.TabIndex = 2;
            this.person2.Text = "2 People";
            this.person2.UseVisualStyleBackColor = true;
            this.person2.Click += new System.EventHandler(this.person2_Click);
            // 
            // person4
            // 
            this.person4.Location = new System.Drawing.Point(476, 192);
            this.person4.Name = "person4";
            this.person4.Size = new System.Drawing.Size(75, 23);
            this.person4.TabIndex = 4;
            this.person4.Text = "4 People";
            this.person4.UseVisualStyleBackColor = true;
            this.person4.Click += new System.EventHandler(this.person4_Click);
            // 
            // person3
            // 
            this.person3.Location = new System.Drawing.Point(476, 163);
            this.person3.Name = "person3";
            this.person3.Size = new System.Drawing.Size(75, 23);
            this.person3.TabIndex = 3;
            this.person3.Text = "3 People";
            this.person3.UseVisualStyleBackColor = true;
            this.person3.Click += new System.EventHandler(this.person3_Click);
            // 
            // sharedN
            // 
            this.sharedN.Location = new System.Drawing.Point(476, 251);
            this.sharedN.Name = "sharedN";
            this.sharedN.Size = new System.Drawing.Size(75, 23);
            this.sharedN.TabIndex = 5;
            this.sharedN.Text = "No";
            this.sharedN.UseVisualStyleBackColor = true;
            this.sharedN.Click += new System.EventHandler(this.sharedN_Click);
            // 
            // sharedY
            // 
            this.sharedY.Location = new System.Drawing.Point(476, 280);
            this.sharedY.Name = "sharedY";
            this.sharedY.Size = new System.Drawing.Size(75, 23);
            this.sharedY.TabIndex = 6;
            this.sharedY.Text = "Yes";
            this.sharedY.UseVisualStyleBackColor = true;
            this.sharedY.Click += new System.EventHandler(this.sharedY_Click);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(381, 469);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 23);
            this.homeButton.TabIndex = 7;
            this.homeButton.Text = "button1";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // SettingsForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.sharedY);
            this.Controls.Add(this.sharedN);
            this.Controls.Add(this.person4);
            this.Controls.Add(this.person3);
            this.Controls.Add(this.person2);
            this.Controls.Add(this.person1);
            this.Controls.Add(this.background);
            this.Name = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Button person1;
        private System.Windows.Forms.Button person2;
        private System.Windows.Forms.Button person4;
        private System.Windows.Forms.Button person3;
        private System.Windows.Forms.Button sharedN;
        private System.Windows.Forms.Button sharedY;
        private System.Windows.Forms.Button homeButton;
    }
}