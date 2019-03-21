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
    public partial class _180409 : Form
    {
        public _180409()
        {
            InitializeComponent();
        }

        private void _180409_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = button1.BackColor;
            if(cd.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = cd.Color;
            }
        }
        
        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)

                button1.BackColor = Color.Red;

            else if (listBox1.SelectedIndex == 1)
                button1.BackColor = Color.Green;
            else
                button1.BackColor = Color.Blue;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                button2.Font = fd.Font;
                button2.ForeColor = fd.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files(*.txt)|*.txt|Image Files|*.jpg;*.bmp;*.png|Word Files(*.docx)|*.docx|띠용(*.*)|*.*|All Files(*.*)|*.*";
            ofd.FilterIndex = 2;//필터 인덱스는 시작이 1부터
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(ofd.FileName);
                
            }
        }
    }
}
