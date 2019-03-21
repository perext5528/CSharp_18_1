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

namespace FinalNotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool changed = false;
        private string strFind;
        private Form2 form2;


        private void tbNote_TextChanged(object sender, EventArgs e)
        {
            this.changed = true;
        }
        
        private void saveTextToFile()
        {
            if(this.Text == "제목 없음")
            {
                if(this.saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    var str = this.saveFileDialog1.FileName;
                    var sw = new StreamWriter(str, false);
                    sw.Write(this.tbNote.Text);
                    sw.Flush();
                    sw.Close();
                    var f = new FileInfo(str);
                    this.Text = f.Name;
                }
            }
            else
            {
                var fname = this.Text;
                var sw = new StreamWriter(fname, false);
                sw.Write(this.tbNote.Text);
                sw.Flush();
                sw.Close();
                this.Text = fname;
            }
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.changed == true)
            {
                string msg = this.Text + "파일의 내용이 변경되었습니다. \n변경된 내용을 저장하시겠습니까?";
                var mbRet = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if(mbRet == DialogResult.Yes)
                {
                    saveTextToFile();
                    this.tbNote.ResetText();
                    this.Text = "제목 없음";
                    this.changed = false;
                }
                else if(mbRet == DialogResult.No)
                {
                    this.tbNote.ResetText();
                    this.Text = "제목 없음";
                    this.changed = false;                    
                }
                else if(mbRet == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                this.tbNote.ResetText();
                this.Text = "제목 없음";
                this.changed = false;
            }
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string fname = openFileDialog1.FileName;
                var sr = new StreamReader(fname);
                this.tbNote.Text = sr.ReadToEnd();
                sr.Close();
                this.Text = fname;
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
            if(saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string fname = openFileDialog1.FileName;
                var sw = new StreamWriter(fname);
                sw.Write(this.tbNote.Text);
                sw.Flush();
                sw.Close();
                var f = new FileInfo(fname);
                this.Text = f.Name;
                this.changed = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.changed == true)
            {
                e.Cancel = true;
                string msg = this.Text + "파일의 내용이 변경되었습니다.\n변경된 내용을 저장하시겠습니까?";
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

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 실행취소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbNote.Undo();
        }

        private void 잘라내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbNote.Cut();
        }

        private void 복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbNote.Copy();
        }

        private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbNote.Paste();
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbNote.Text = "";
        }

        private void 모두선택ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbNote.SelectAll();
        }

        private void 시간날짜ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToLongTimeString();
            var date = DateTime.Now.ToShortDateString();
            tbNote.AppendText(time + " " + date);
        }

        private void 자동줄바꿈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbNote.WordWrap = !tbNote.WordWrap;
            자동줄바꿈ToolStripMenuItem.Checked = !자동줄바꿈ToolStripMenuItem.Checked;
        }

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                tbNote.Font = fontDialog1.Font;
            }
        }

        

        private void btnNext_Click(object sender, EventArgs e)
        {
            var updown = -1;
            var str = this.tbNote.Text;
            var findWord = form2.tbWord.Text;
            if (form2.cbCap.Checked == false)
            {
                str = str.ToUpper();
                findWord = findWord.ToUpper();
            }
            if (form2.radioButton1.Checked)
            {
                if(this.tbNote.SelectionStart != 0)
                {
                    updown = str.LastIndexOf(findWord, this.tbNote.SelectionStart - 1);
                }
            }
            else
            {
                updown = str.IndexOf(findWord, this.tbNote.SelectionStart + this.tbNote.SelectionLength);
            }

            if(updown == -1)
            {
                MessageBox.Show("더 이상 찾을 문자열이 없습니다.", "메모장", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                this.tbNote.Select(updown, findWord.Length);
                strFind = form2.tbWord.Text;
                this.tbNote.Focus();
                this.tbNote.ScrollToCaret();
            }

        }

        private void 찾기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(form2 == null || form2.Visible == false))
            {
                form2.Focus();
                return;
            }
            form2 = new Form2();
            if (tbNote.SelectionLength == 0)
                form2.tbWord.Text = this.strFind;
            else
                form2.tbWord.Text = this.tbNote.SelectedText;
            form2.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            form2.Show();
        }

        private void 다음찾기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(form2 == null || form2.Visible == false))
            {
                form2.tbWord.Text = this.strFind;
                this.btnNext_Click(this, null);
            }
        }
    }
}
