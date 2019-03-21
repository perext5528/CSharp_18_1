using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CsDiary
{
    public partial class Form1 : Form
    {
        string[] memo = new string[366];    //날짜 배열
        string strYear = DateTime.Now.Year.ToString(); //년도 변수 설정

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DateTime orgDate = Convert.ToDateTime("#1/1/" + strYear + "#");
            DateTime curDate = dateTimePicker1.Value;
            long diff = DateAndTime.DateDiff(DateInterval.Day, orgDate, curDate);
            if (textBoxMemo.TextLength > 0)
            {
                memo[diff] = textBoxMemo.Text;
                MessageBox.Show("일기가 저장되었습니다.", "알림");
                //textBoxMemo.Clear();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime orgDate = Convert.ToDateTime("#1/1/" + strYear + "#");
            DateTime curDate = dateTimePicker1.Value;
            long diff = DateAndTime.DateDiff(DateInterval.Day, orgDate, curDate);
            textBoxMemo.Text = memo[diff];
        }
    }
}
