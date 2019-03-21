using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CsNotePad
{
    public partial class FormNotePad : System.Windows.Forms.Form
    {
        private bool changed = false; //메모장의 내용이 바뀌었는지 여부를 확인하는 변수        
        private string strFind; //찾을 문자열        
        private FormFind formFind;  //찾기 폼

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int updown = -1;
            string str = textBoxNote.Text;  //본문
            string findWord = formFind.textBoxWord.Text;    //찾을 문자열

            if(formFind.checkBoxCap.Checked == false)   //대소문자 구분 안함
            {
                str = str.ToUpper();
                findWord = findWord.ToUpper();
            }

            if (formFind.radioButtonUp.Checked)
            {
                if(this.textBoxNote.SelectionStart != 0)
                {
                    updown = str.LastIndexOf(str, textBoxNote.SelectionStart - 1);                
                }                
            }
            else
            {
                updown = str.IndexOf(str, textBoxNote.SelectionStart + this.textBoxNote.SelectionLength);
            }

            if (updown == -1)
            {
                MessageBox.Show("더 이상 찾을 문자열이 없습니다.", "메모장");
                return;
            }
            else
            {
                textBoxNote.Select(updown, findWord.Length);
                strFind = formFind.textBoxWord.Text;
                this.textBoxNote.Focus();
                this.textBoxNote.ScrollToCaret();
            }
        }

        public FormNotePad()
        {
            InitializeComponent();
        }

        private void saveTextToFile() //파일 저장 기능
        {
            if(this.Text == "제목 없음")
            {
                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel) // 대화 상자 선택 결과가 cancel이 아닌 경우
                {
                    string filename = saveFileDialog1.FileName; //저장하고자 하는 파일 이름
                    StreamWriter sw = new StreamWriter(filename, false); //파일 저장을 위한 Stream 객체 생성
                    sw.Write(textBoxNote.Text); //텍스트 박스 내용을 Stream 객체에 저장
                    sw.Flush(); // 버퍼 비움
                    sw.Close(); // Stream 닫기

                    //var info = new FileInfo(filename);  // 파일 이름을 인자로 갖는 파일 정보 객체 생성
                    //this.Text = info.Name;    // 아래 방법보다 안전한 방법

                    this.Text = filename;   // 프로그램 제목에 파일 이름을 넣음
                }
            }
            else
            {
                string filename = saveFileDialog1.FileName; //저장하고자 하는 파일 이름
                StreamWriter sw = new StreamWriter(filename, false); //파일 저장을 위한 Stream 객체 생성
                sw.Write(textBoxNote.Text); //텍스트 박스 내용을 Stream 객체에 저장
                sw.Flush(); // 버퍼 비움
                sw.Close(); // Stream 닫기

                this.Text = filename;   // 프로그램 제목에 파일 이름을 넣음
            }
        }
        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.changed == true)
            {
                string msg = this.Text + "의 내용이 변경되었습니다.\n변경된 내용을 저장하시겠습니까?";
                var ret = MessageBox.Show(msg, "메모장", 
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); // 대화 상자 리턴값을 받음
                if (ret == DialogResult.Yes)
                {
                    saveTextToFile();
                    // 기존 내용을 지우고 새로운 파일 생성
                    this.Text = "제목 없음";
                    textBoxNote.Text = "";
                    //textBoxNote.ResetText(); //위와 동일
                    this.changed = false;
                }
                else if(ret == DialogResult.No)
                {
                    // 기존 내용을 지우고 새로운 파일 생성
                    this.Text = "제목 없음";
                    textBoxNote.Text = "";
                    this.changed = false;
                }
                else
                {
                    return;
                }
            }
            else
            {
                
            }
            
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);   //파일을 읽어야되므로 StreamReader 객체 생성
                textBoxNote.Text = sr.ReadToEnd();    // 처음부터 마지막까지 읽음
                sr.Close();

                this.Text = openFileDialog1.FileName;   // 메모장 제목 변경
                this.changed = false;
            }
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveTextToFile();
            this.changed = false;
        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName; //저장하고자 하는 파일 이름
                StreamWriter sw = new StreamWriter(filename, false); //파일 저장을 위한 Stream 객체 생성
                sw.Write(textBoxNote.Text); //텍스트 박스 내용을 Stream 객체에 저장
                sw.Flush(); // 버퍼 비움
                sw.Close(); // Stream 닫기
                var f = new FileInfo(filename);
                this.Text = filename;   // 프로그램 제목에 파일 이름을 넣음
                this.changed = false;
            }
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

            //Application.Exit(); // 위 코드와 동일
        }

        private void 실행취소UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNote.Undo();
        }

        private void 잘라내기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNote.Cut();
        }

        private void 복사CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNote.Copy();
        }

        private void 붙여넣기VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNote.Paste();
        }

        private void 삭제DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNote.Text = "";
            //textBoxNote.ResetText(); //동일한 기능
        }
        private void 모두선택AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNote.SelectAll();
        }
        
        
        private void 시간날짜TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToLongTimeString();
            var date = DateTime.Now.ToShortDateString();    //2018-05-14
            //var date = DateTime.Now.ToLongDateString(); //2018년 5월 14일 월요일
            textBoxNote.AppendText(date + " " + time);
        }

        private void 자동줄바꿈WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNote.WordWrap = !textBoxNote.WordWrap;
            자동줄바꿈WToolStripMenuItem.Checked = !자동줄바꿈WToolStripMenuItem.Checked;
        }

        private void 글꼴FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                textBoxNote.Font = fontDialog1.Font;
        }

        private void 메모장정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메모장 버전 1.0v by 김봉근", "메모장");
        }

        private void 찾기FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!(formFind == null || formFind.Visible == false))
            {
                formFind.Focus();
                return;
            }

            formFind = new FormFind();
            if (textBoxNote.SelectionLength == 0)
            {
                formFind.textBoxWord.Text = this.strFind;
            }
            else
            {
                formFind.textBoxWord.Text = this.textBoxNote.SelectedText;
            }
            formFind.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            formFind.Show();
        }

        private void 다음찾기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(formFind == null || formFind.Visible == false))
            {
                formFind.textBoxWord.Text = this.strFind;
                this.buttonNext_Click(this, null);
            }
        }        

        private void textBoxNote_TextChanged(object sender, EventArgs e)
        {
            changed = true; //메모장 내용 편집
        }

        private void FormNotePad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.changed == true)
            {
                e.Cancel = true;
                string msg = this.Text + " 파일의 내용이 변경되었습니다.\n변경된 내용을 저장하시겠습니까?";
                var mbRet = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (mbRet == DialogResult.Yes)
                {
                    saveTextToFile();
                    this.Dispose();
                }
                else if (mbRet == DialogResult.No) this.Dispose();
                else if (mbRet == DialogResult.Cancel) return;
            }
        }
    }
}
