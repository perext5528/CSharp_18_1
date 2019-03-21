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
using System.Management;


namespace CsImageViwer
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            const int removableDisk = 2;
            const int localDisk = 3;
            const int compactDisc = 5;
            const int ramDisk = 6;
            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_LogicalDisk");
            ManagementObjectCollection qc = mos.Get();

            System.Environment.CurrentDirectory = "C:\\";
            treeView1.Nodes.Clear();

            TreeNode rootNode, driveNode;
            int imageIndex = 0;
            int selectIndex = 0;

            treeView1.BeginUpdate();

            rootNode = new TreeNode("내 컴퓨터", imageIndex, selectIndex);
            treeView1.Nodes.Add(rootNode);
            foreach (ManagementObject drive in qc)
            {
                switch (int.Parse(drive["DriveType"].ToString()))
                {
                    case removableDisk: imageIndex = 2; selectIndex = 2; break;
                    case localDisk: imageIndex = 1; selectIndex = 1; break;
                    case compactDisc: imageIndex = 3; selectIndex = 3; break;
                    case ramDisk: imageIndex = 2; selectIndex = 2; break;
                    default: imageIndex = 0; selectIndex = 0; break;
                }
                driveNode = new TreeNode(drive["Name"].ToString(),
                    imageIndex, selectIndex);
                treeView1.Nodes[0].Nodes.Add(driveNode);
                string str = drive["Name"] + "\\";
                if (Directory.Exists(str) == true)
                {
                    DirectoryInfo root = new DirectoryInfo(str);
                    if (root.GetDirectories().Length > 0)
                    {
                        TreeNode temp = new TreeNode("임시", 1, 1);
                        driveNode.Nodes.Add(temp);
                    }
                }
                treeView1.EndUpdate();
            }

            
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Level <= 0) return;
            e.Node.Nodes.Clear();
            DirectoryInfo dir = new DirectoryInfo(e.Node.FullPath.Remove(0, 6));
            foreach(DirectoryInfo d in dir.GetFileSystemInfos())
            {
                if (d.Attributes.ToString().Contains("Hidden") == true ||
                    d.Attributes.ToString().Contains("System") == true) continue;
                TreeNode n = new TreeNode(d.Name, 6, 6);
                e.Node.Nodes.Add(n);
                try
                {
                    if (d.GetDirectories().Length > 0)
                    {
                        TreeNode temp = new TreeNode("임시", 1, 1);
                        n.Nodes.Add(temp);
                    }
                }
                catch { }
            }
        }
    }
}
