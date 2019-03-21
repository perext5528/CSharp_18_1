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
    public partial class Form_First : Form
    {
        class MyForm : Form
        {

        }
        public Form_First()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            MyForm form = new MyForm();
            form.Text = "MyForm";
            form.MdiParent = this;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            MyForm form = new MyForm();
            form.Show();
            
        }

        private void Form_First_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
