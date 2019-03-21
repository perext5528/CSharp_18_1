using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CsCarInfo
{
    

    public partial class FormMain : Form
    {
        string strConn = "Server=localhost;Database=mydb;Uid=root;Pwd=joowan0935;sslmode=none";//sslmode=none : 예외 처리
        //MySql DB 설정, UID, PW 설정
        MySqlConnection conn = null;
        private string currNum; //선택된 행 번호

        public FormMain()
        {
            InitializeComponent();
        }

        private void ShowDataOnListView()
        {
            listView.Items.Clear();//리스트뷰 내의 모든 항목 삭제
            string sql = "select * from carinfo";//SQL Query문 변수
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader data = cmd.ExecuteReader(); //Query 결과값을 한 레코드씩 읽음
            while (data.Read())
            {
                string[] strArray = new string[]    //실제 DB의 데이터
                {
                    data["num"].ToString(),
                    data["name"].ToString(),
                    data["year"].ToString(),
                    data["price"].ToString(),
                    data["door"].ToString()
                };
                ListViewItem IvItem = new ListViewItem(strArray);
                listView.Items.Add(IvItem);
            }
            data.Close();
        }
        
        //폼을 불러오는 경우
        private void FormMain_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(strConn);    //Connector 객체 생성
            conn.Open();    //DB 열기
            ShowDataOnListView();   //
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn != null)   //폼을 종료하는 중 conn 객체가 살아있는 경우
                conn.Close();
        }

        //리스트뷰 항목이 선택된 경우 텍스트필드에 해당 항목의 내용 출력
        private void listView_Click(object sender, EventArgs e)
        {
            currNum = listView.SelectedItems[0].SubItems[0].Text;
            tbName.Text = listView.SelectedItems[0].SubItems[1].Text;
            tbYear.Text = listView.SelectedItems[0].SubItems[2].Text;
            tbPrice.Text = listView.SelectedItems[0].SubItems[3].Text;
            tbDoor.Text = listView.SelectedItems[0].SubItems[4].Text;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(tbName.Text == "" || tbYear.Text == "" || tbPrice.Text == "" ||tbDoor.Text == "")
            {
                MessageBox.Show("데이터를 모두 입력하세요.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql = "insert into CarInfo(name, year, price, door) values('"
                + tbName.Text + "', '"
                + tbYear.Text + "', '"
                + tbPrice.Text + "', '"
                + tbDoor.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int n = cmd.ExecuteNonQuery();
            if (n == 1)
            {
                MessageBox.Show("정상적으로 데이터가 입력되었습니다.", "알림",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowDataOnListView();
                tbName.Text = "";
                tbYear.Text = "";
                tbPrice.Text = "";
                tbDoor.Text = "";
            }
            else
            {
                MessageBox.Show("정상적으로 데이터가 입력되지 않았습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbYear.Text == "" || tbPrice.Text == "" || tbDoor.Text == "")
            {
                MessageBox.Show("데이터를 모두 입력하세요.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string sql = "select * from carinfo";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataRow[] row = ds.Tables[0].Select("num=" + Convert.ToInt32(currNum),
                    null, DataViewRowState.CurrentRows);
                sql = "update CarInfo set "
                    + "name = '" + tbName.Text + "',"
                    + "year = '" + tbYear.Text + "',"
                    + "price = '" + tbPrice.Text + "',"
                    + "door = '" + tbDoor.Text + "' "
                    + "where num = " + row[0]["num"] + ";";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                ShowDataOnListView();
                MessageBox.Show("정상적으로 데이터가 수정되었습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("정상적으로 데이터가 수정되지 않았습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbYear.Text == "" || tbPrice.Text == "" || tbDoor.Text == "")
            {
                MessageBox.Show("데이터를 모두 입력하세요.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string sql = "select * from carinfo";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataRow[] row = ds.Tables[0].Select("num=" + Convert.ToInt32(currNum),
                    null, DataViewRowState.CurrentRows);
                sql = "delete from CarInfo " + "where num = " + row[0]["num"] + ";";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                ShowDataOnListView();
                MessageBox.Show("정상적으로 데이터가 삭제되었습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);            
            }
            catch
            {
                MessageBox.Show("정상적으로 데이터가 삭제되지 않았습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
