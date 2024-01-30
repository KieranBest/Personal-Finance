using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Finance
{
    public partial class HomeForm : Form
    {
        public int numberOfPeople;
        public bool sharedYN;

        public HomeForm()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1000, 800);
            this.Location = new Point(100, 100);
        }

        public void showButtons(int numberOfPeopleSelected, bool shared)
        {
            numberOfPeople = numberOfPeopleSelected;
            sharedYN = shared;
            switch (numberOfPeople)
            {
                case 1:
                    person1Button.Visible = true;
                    break;
                case 2:
                    person1Button.Visible = true;
                    person2Button.Visible = true;
                    break;
                case 3:
                    person1Button.Visible = true;
                    person2Button.Visible = true;
                    person3Button.Visible = true;
                    break;
                case 4:
                    person1Button.Visible = true;
                    person2Button.Visible = true;
                    person3Button.Visible = true;
                    person4Button.Visible = true;
                    break;
            }
            if (sharedYN == true)
            {
                sharedButton.Visible = true;
            }
        }

        private void Person1Button_Click(object sender, EventArgs e)
        {          
            Person1Form form = new Person1Form();
            form.Location = new Point(100, 100);
            form.Size = new System.Drawing.Size(1000, 800);
            form.Show();
            this.Hide();
        }

        private void Person2Button_Click(object sender, EventArgs e)
        {
            Person2Form form = new Person2Form();
            form.Location = new Point(100, 100);
            form.Size = new System.Drawing.Size(1000, 800);
            form.Show();
            this.Hide();
        }

        private void SharedButton_Click(object sender, EventArgs e)
        {
            SharedForm form = new SharedForm();
            form.Location = new Point(100, 100);
            form.Size = new System.Drawing.Size(1000, 800);
            form.Show();
            this.Hide();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.Location = new Point(100, 100);
            form.Size = new System.Drawing.Size(1000, 800);
            MessageBox.Show(numberOfPeople.ToString() + sharedYN);
            form.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
