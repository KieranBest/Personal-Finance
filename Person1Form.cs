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
    public partial class Person1Form : Form
    {
        public Person1Form()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1000, 800);
        }

        public void closePreviousForm(Form formName = new Form())
        {
            formName.close();
        }
    }
}
