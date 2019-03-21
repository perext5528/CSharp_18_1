using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;   //IComparer 인터페이스를 사용하기 위함

namespace CsHeaderSort
{
    public partial class Form1 : Form
    {
        bool isSort = true; //오름차순 정렬을 나타내는 변수로 사용
        class ItemComparer : IComparer
        {
            int column;
            bool flag;
            public ItemComparer(int column, bool flag)  //생성자 메소드
            {
                this.column = column;
                this.flag = flag;
            }
            public int Compare(object a, object b)
            {
                object obj1, obj2;
                if (flag)
                {
                    obj1 = a;
                    obj2 = b;
                }
                else
                {
                    obj1 = b;
                    obj2 = a;
                }

                return String.Compare(
                    (obj1 as ListViewItem).SubItems[column].Text,
                    (obj2 as ListViewItem).SubItems[column].Text
                    );
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxTel.Text == "")
                MessageBox.Show("이름 또는 전화번호를 입력하세요.", "알림");
            else
            {
                var strArray = new string[] { textBoxName.Text, textBoxTel.Text };
                ListViewItem lvItem = new ListViewItem(strArray);
                listView1.Items.Add(lvItem);

                textBoxName.Clear();
                textBoxTel.Clear();
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            listView1.ListViewItemSorter = new ItemComparer(e.Column, isSort);
            isSort = !isSort;
        }
    }
}
