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

namespace FinalDiary
{
    public partial class Form1 : Form
    {
        string[] memo = new string[366];
        string strYear = DateTime.Now.Year.ToString();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var orgDate = Convert.ToDateTime("#1/1/" + strYear + "#");
            DateTime curDate = dateTimePicker1.Value;
            long diff = DateAndTime.DateDiff(DateInterval.Day, orgDate, curDate, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
            memo[diff] = textBox1.Text;
            if (memo[diff].Length > 0)
            {
                MessageBox.Show("일기가 정상적으로 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var orgDate = Convert.ToDateTime("#1/1/" + strYear + "#");
            DateTime curDate = dateTimePicker1.Value;
            long diff = DateAndTime.DateDiff(DateInterval.Day, orgDate, curDate, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
            textBox1.Text = memo[diff];
        }
    }
}
