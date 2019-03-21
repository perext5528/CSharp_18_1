using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsNotePad
{
    public partial class FormFind : Form
    {
       

        public FormFind()
        {
            InitializeComponent();
        }


        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxWord_TextChanged(object sender, EventArgs e)
        {
            if (textBoxWord.Text == "")
                buttonNext.Enabled = false;
            else
                buttonNext.Enabled = true;
        }
    }
}
