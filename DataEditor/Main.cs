using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataEditor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            treeView1.AllowDrop = true;
            treeView1.DragEnter += new DragEventHandler(treeView1_DragEnter);
            treeView1.DragOver += new DragEventHandler(treeView1_DragOver);
            treeView1.DragDrop += new DragEventHandler(treeView1_DragDrop);
            treeView1.AfterSelect += new TreeViewEventHandler(treeView1_AfterSelect);
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void treeView1_DragOver(object sender, DragEventArgs e)
        {
            Point targetPoint = treeView1.PointToClient(new Point(e.X, e.Y));
            TreeNode targetNode = treeView1.GetNodeAt(targetPoint);
            if (targetNode != null)
            {
                e.Effect = DragDropEffects.Copy;
                treeView1.SelectedNode = targetNode;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            Point dropPoint = treeView1.PointToClient(new Point(e.X, e.Y));
            TreeNode targetNode = treeView1.GetNodeAt(dropPoint);

            List<TreeNode> nodes = new List<TreeNode>();

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (targetNode != null && files != null)
            {
                foreach (string file in files)
                {
                    var name = Path.GetFileName(file);
                    var ext = Path.GetExtension(file).ToLower();
                    var type = DataType.None;

                    if (ext.Equals(".png"))
                    {
                        type = DataType.Image;
                    }
                    else if (ext.Equals(".mp3"))
                    {
                        type = DataType.Sound;
                    }
                    else
                    {
                        MessageBox.Show("지원하지 않는 파일 형식이 있습니다.");
                        return;
                    }

                    var data = File.ReadAllBytes(file);
                    var nodeData = new NodeData { Data = data, Type = type };
                    var node = new TreeNode(name) { Tag = nodeData };
                    nodes.Add(node);
                }

                targetNode.Nodes.AddRange(nodes.ToArray());
                targetNode.Expand();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = e.Node;
            if (node.Tag == null)
            {
                pictureBox1.Hide();
                return;
            }

            var data = (NodeData)node.Tag;
            if (data.Type == DataType.Image)
            {
                pictureBox1.Show();

                using (var ms = new MemoryStream(data.Data))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void 노드추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedNode = treeView1.SelectedNode;
            if (selectedNode == null)
            {
                InputDialog inputDialog = new InputDialog("노드 추가", "추가할 노드의 이름을 입력해 주세요.");
                if (inputDialog.ShowDialog() == DialogResult.OK)
                {
                    treeView1.Nodes.Add(inputDialog.Result);
                }
                return;
            }

            selectedNode.Nodes.Add("New Node");
        }

        private void 노드삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedNode = treeView1.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.");
                return;
            }

            selectedNode.Remove();
        }
    }
}
