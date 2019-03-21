using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalMultiTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] str = cbSelect.SelectedItem.ToString().Split(new char[] { ' ' });
            int multi = int.Parse(str[0]);
            for(int i = 1; i < 10; i++)
            {
                string s = String.Format("{0,2:D} * {1,2:D} = {2,2:D}", multi, i, multi * i);
                listBox1.Items.Add(s);
            }
        }
    }
}
