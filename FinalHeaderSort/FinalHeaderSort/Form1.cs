using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace FinalHeaderSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isSort = true;

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbNum.Text == "")
                MessageBox.Show("이름 또는 전화번호를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var strArray = new String[] { tbName.Text, tbNum.Text };
                var lvItem = new ListViewItem(strArray);
                listView1.Items.Add(lvItem);
                tbName.Clear(); tbNum.Clear();
            }
        }

        class ItemComparer : IComparer
        {
            int column; bool flag;
            public ItemComparer(int column, bool flag)
            {
                this.column = column;
                this.flag = flag;
            }
            public int Compare(object a, object b)
            {
                object obj1, obj2;
                if(flag == true)
                {
                    obj1 = a; obj2 = b;
                }
                else
                {
                    obj1 = b; obj2 = a;
                }
                return String.Compare((obj1 as ListViewItem).SubItems[column].Text, (obj2 as ListViewItem).SubItems[column].Text);
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            listView1.ListViewItemSorter = new ItemComparer(e.Column, isSort);
            isSort = !isSort;
        }
    }
}
