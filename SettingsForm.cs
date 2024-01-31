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
    public partial class SettingsForm : Form
    {
        bool numberOfPeopleSelectedB;
        bool sharedSelected;

        int numberOfPeopleSelected;
        bool shared;

        public SettingsForm()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1000, 800);

            if(numberOfPeopleSelectedB != true)
            {
                numberOfPeopleSelectedB = false;
                sharedSelected = false;
            }
        }

        private void person1_Click(object sender, EventArgs e)
        {
            numberOfPeopleSelected = 1;
            numberOfPeopleSelectedB = true;
        }

        private void person2_Click(object sender, EventArgs e)
        {
            numberOfPeopleSelected = 2;
            numberOfPeopleSelectedB = true;

        }

        private void person3_Click(object sender, EventArgs e)
        {
            numberOfPeopleSelected = 3;
            numberOfPeopleSelectedB = true;
        }

        private void person4_Click(object sender, EventArgs e)
        {
            numberOfPeopleSelected = 4;
            numberOfPeopleSelectedB = true;
        }

        private void sharedN_Click(object sender, EventArgs e)
        {
            shared = false;
            sharedSelected = true;
        }

        private void sharedY_Click(object sender, EventArgs e)
        {
            shared = true;
            sharedSelected = true;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            if (!numberOfPeopleSelectedB)
            {
                MessageBox.Show("Please answer the question 'How many people are there?'", "Error");
            }
            else if (!sharedSelected)
            {
                MessageBox.Show("Please answer the question 'Is there a shared account?'", "Error");
            }
            else
            {
                HomeForm homeForm = new HomeForm();
                homeForm.showButtons(numberOfPeopleSelected, shared);
                this.Hide();
                homeForm.Show();
            }
        }
    }
}
