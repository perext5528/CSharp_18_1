using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPoll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string hobby = null;
            string sports = null;

            foreach (RadioButton c in this.gbHobby.Controls)
                if (c.Checked == true) hobby = c.Text;
            foreach (CheckBox c in this.gbSports.Controls)
                if (c.Checked == true) sports += c.Text + " ";
            lbHobby.Text = hobby;
            lbSports.Text = sports;
        }
    }
}
