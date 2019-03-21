using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsPoll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String hobby = null;
            String Sports = null;

            foreach(RadioButton c in groupBox1.Controls)
            {
                if (c.Checked == true)
                    hobby = c.Text;
            }
            foreach(CheckBox c in groupBox2.Controls)
            {
                if (c.Checked == true)
                    Sports += c.Text+", ";
            }
            labelHobby.Text = hobby;
            labelSports.Text = Sports;
        }
    }
}
