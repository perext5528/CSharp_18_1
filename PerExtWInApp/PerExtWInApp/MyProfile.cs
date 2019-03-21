using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerExtWInApp
{
    public partial class MyProfile : Form
    {
        public MyProfile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            textBoxPrint.Clear();
            textBoxPrint.AppendText("학번 : " + textBoxNo.Text + "\n");
            textBoxPrint.AppendText("성명 : " + textBoxName.Text + "\n");
            textBoxPrint.AppendText("취미 : ");
            if (checkBox1.Checked==true)
                textBoxPrint.AppendText(checkBox1.Text+" " );
            if (checkBox2.Checked == true)
                textBoxPrint.AppendText(checkBox2.Text + " ");
            if (checkBox3.Checked == true)
                textBoxPrint.AppendText(checkBox3.Text + " ");
            textBoxPrint.AppendText("\n");
            textBoxPrint.AppendText("\n");
            textBoxPrint.AppendText("띠요오오오오옹");
        }
    }
}
