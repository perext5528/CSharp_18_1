namespace CsNotePad
{
    partial class FormFind
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.buttonCancle = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.checkBoxCap = new System.Windows.Forms.CheckBox();
            this.radioButtonUp = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDown = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "찾을 내용";
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(82, 12);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(229, 21);
            this.textBoxWord.TabIndex = 1;
            this.textBoxWord.TextChanged += new System.EventHandler(this.textBoxWord_TextChanged);
            // 
            // buttonCancle
            // 
            this.buttonCancle.Location = new System.Drawing.Point(330, 46);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(91, 23);
            this.buttonCancle.TabIndex = 2;
            this.buttonCancle.Text = "취소(&C)";
            this.buttonCancle.UseVisualStyleBackColor = true;
            this.buttonCancle.Click += new System.EventHandler(this.buttonCancle_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(330, 10);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(91, 23);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "다음찾기(&N)";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // checkBoxCap
            // 
            this.checkBoxCap.AutoSize = true;
            this.checkBoxCap.Location = new System.Drawing.Point(21, 59);
            this.checkBoxCap.Name = "checkBoxCap";
            this.checkBoxCap.Size = new System.Drawing.Size(100, 16);
            this.checkBoxCap.TabIndex = 4;
            this.checkBoxCap.Text = "대소문자 구분";
            this.checkBoxCap.UseVisualStyleBackColor = true;
            // 
            // radioButtonUp
            // 
            this.radioButtonUp.AutoSize = true;
            this.radioButtonUp.Location = new System.Drawing.Point(6, 22);
            this.radioButtonUp.Name = "radioButtonUp";
            this.radioButtonUp.Size = new System.Drawing.Size(47, 16);
            this.radioButtonUp.TabIndex = 5;
            this.radioButtonUp.TabStop = true;
            this.radioButtonUp.Text = "위쪽";
            this.radioButtonUp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDown);
            this.groupBox1.Controls.Add(this.radioButtonUp);
            this.groupBox1.Location = new System.Drawing.Point(152, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 51);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "방향";
            // 
            // radioButtonDown
            // 
            this.radioButtonDown.AutoSize = true;
            this.radioButtonDown.Location = new System.Drawing.Point(94, 22);
            this.radioButtonDown.Name = "radioButtonDown";
            this.radioButtonDown.Size = new System.Drawing.Size(59, 16);
            this.radioButtonDown.TabIndex = 0;
            this.radioButtonDown.TabStop = true;
            this.radioButtonDown.Text = "아래쪽";
            this.radioButtonDown.UseVisualStyleBackColor = true;
            // 
            // FormFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 100);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxCap);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonCancle);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFind";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "찾기";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Button buttonCancle;
        internal System.Windows.Forms.Button buttonNext;
        internal System.Windows.Forms.CheckBox checkBoxCap;
        internal System.Windows.Forms.RadioButton radioButtonUp;
        internal System.Windows.Forms.RadioButton radioButtonDown;
        internal System.Windows.Forms.GroupBox groupBox1;
    }
}