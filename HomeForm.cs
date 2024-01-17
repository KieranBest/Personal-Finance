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
        public HomeForm()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1000, 800);
        }

        private void Person1Button_Click(object sender, EventArgs e)
        {          
            Person1Form form = new Person1Form();
            form.Show();
            Person1Form.closePreviousForm(HomeForm);
        }
    }
}
