using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = "user";
            string pw = "userpass";
            if (this.tbID.Text == id && this.tbPW.Text == pw)
                MessageBox.Show("로그인에 성공하였습니다.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("아이디가 없거나 패스워드가 틀립니다.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
