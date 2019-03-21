using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsMulTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //int dan = comboBoxSelect.SelectedIndex + 2; // 아래 24, 25 Line과 동일한 의미
            string[] str = comboBoxSelect.SelectedItem.ToString().Split(new char[] { ' ' });
            int dan = int.Parse(str[0]);
            for(int i = 1; i < 10; i++)
            {
                string result = String.Format("{0,2:D} * {1,2:D} = {2,2:D}", dan, i, dan*i); //중괄호 안 처음 숫자는 인덱스, 콤마 뒤 자릿수, 콜론 뒤 자료형
                listBox1.Items.Add(result);
            }
        }
    }
}
