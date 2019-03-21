namespace CsImageViwer
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbView = new System.Windows.Forms.ToolStripButton();
            this.tsbUp = new System.Windows.Forms.ToolStripButton();
            this.tsbFormat = new System.Windows.Forms.ToolStripDropDownButton();
            this.큰아이콘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.작은아이ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.간단히ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자세히ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0_computer.ico");
            this.imageList1.Images.SetKeyName(1, "1_hdd.ico");
            this.imageList1.Images.SetKeyName(2, "1_removable.ico");
            this.imageList1.Images.SetKeyName(3, "1_cd.ico");
            this.imageList1.Images.SetKeyName(4, "2_folder.ico");
            this.imageList1.Images.SetKeyName(5, "2_folder-open.ico");
            this.imageList1.Images.SetKeyName(6, "File.gif");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "3_image.ico");
            this.imageList2.Images.SetKeyName(1, "3_movie.ico");
            this.imageList2.Images.SetKeyName(2, "3_song.ico");
            this.imageList2.Images.SetKeyName(3, "3_document.ico");
            this.imageList2.Images.SetKeyName(4, "2_folder.ico");
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbView,
            this.tsbUp,
            this.tsbFormat});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(800, 38);
            this.toolStripMenu.TabIndex = 0;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(63, 35);
            this.tsbOpen.Text = "파일 열기";
            this.tsbOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbView
            // 
            this.tsbView.Image = ((System.Drawing.Image)(resources.GetObject("tsbView.Image")));
            this.tsbView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbView.Name = "tsbView";
            this.tsbView.Size = new System.Drawing.Size(71, 35);
            this.tsbView.Text = "이미지보기";
            this.tsbView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbUp
            // 
            this.tsbUp.Image = ((System.Drawing.Image)(resources.GetObject("tsbUp.Image")));
            this.tsbUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUp.Name = "tsbUp";
            this.tsbUp.Size = new System.Drawing.Size(59, 35);
            this.tsbUp.Text = "상위폴더";
            this.tsbUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbFormat
            // 
            this.tsbFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.큰아이콘ToolStripMenuItem,
            this.작은아이ToolStripMenuItem,
            this.간단히ToolStripMenuItem,
            this.자세히ToolStripMenuItem});
            this.tsbFormat.Image = ((System.Drawing.Image)(resources.GetObject("tsbFormat.Image")));
            this.tsbFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFormat.Name = "tsbFormat";
            this.tsbFormat.Size = new System.Drawing.Size(72, 35);
            this.tsbFormat.Text = "보기 형식";
            this.tsbFormat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // 큰아이콘ToolStripMenuItem
            // 
            this.큰아이콘ToolStripMenuItem.Name = "큰아이콘ToolStripMenuItem";
            this.큰아이콘ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.큰아이콘ToolStripMenuItem.Text = "큰 아이콘";
            // 
            // 작은아이ToolStripMenuItem
            // 
            this.작은아이ToolStripMenuItem.Name = "작은아이ToolStripMenuItem";
            this.작은아이ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.작은아이ToolStripMenuItem.Text = "작은 아이";
            // 
            // 간단히ToolStripMenuItem
            // 
            this.간단히ToolStripMenuItem.Name = "간단히ToolStripMenuItem";
            this.간단히ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.간단히ToolStripMenuItem.Text = "간단히";
            // 
            // 자세히ToolStripMenuItem
            // 
            this.자세히ToolStripMenuItem.Name = "자세히ToolStripMenuItem";
            this.자세히ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.자세히ToolStripMenuItem.Text = "자세히";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 38);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 412);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(266, 412);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chDate,
            this.chType,
            this.chSize});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(530, 412);
            this.listView1.SmallImageList = this.imageList2;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "이름";
            this.chName.Width = 208;
            // 
            // chDate
            // 
            this.chDate.Text = "날짜";
            this.chDate.Width = 133;
            // 
            // chType
            // 
            this.chType.Text = "유형";
            this.chType.Width = 100;
            // 
            // chSize
            // 
            this.chSize.Text = "크기";
            this.chSize.Width = 83;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "이미지 뷰어";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbView;
        private System.Windows.Forms.ToolStripButton tsbUp;
        private System.Windows.Forms.ToolStripDropDownButton tsbFormat;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem 큰아이콘ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 작은아이ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 간단히ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자세히ToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chSize;
    }
}

