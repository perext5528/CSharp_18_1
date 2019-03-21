using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsLogin
{
    public partial class Form1 : Form
    {
        String id = "guest";
        String pw = "test";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ID.Text.Equals(id) && this.PW.Text.Equals(pw))
            {
                MessageBox.Show("로그인에 성공하였습니다.", "로그인 알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("아이디가 없거나 패스워드가 틀립니다.", "로그인 오류", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PW_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
