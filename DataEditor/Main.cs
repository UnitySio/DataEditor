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

            tv_main.AllowDrop = true;
            tv_main.DragEnter += tv_main_DragEnter;
            tv_main.DragOver += tv_main_DragOver;
            tv_main.DragDrop += tv_main_DragDrop;
            tv_main.AfterSelect += tv_main_AfterSelect;
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tv_main_DragEnter(object sender, DragEventArgs e)
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

        private void tv_main_DragOver(object sender, DragEventArgs e)
        {
            Point targetPoint = tv_main.PointToClient(new Point(e.X, e.Y));
            TreeNode targetNode = tv_main.GetNodeAt(targetPoint);
            if (targetNode != null)
            {
                e.Effect = DragDropEffects.Copy;
                tv_main.SelectedNode = targetNode;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void tv_main_DragDrop(object sender, DragEventArgs e)
        {
            Point dropPoint = tv_main.PointToClient(new Point(e.X, e.Y));
            TreeNode targetNode = tv_main.GetNodeAt(dropPoint);

            var nodeType = ((NodeData)targetNode.Tag).Type;
            if (nodeType != DataType.Group)
            {
                MessageBox.Show("그룹에만 추가할 수 있습니다.");
                return;
            }

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

        private void tv_main_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = e.Node;
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
            else
            {
                pictureBox1.Hide();
            }
        }

        private void 노드추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new InputDataDialog("노드 추가");
            bool isOK = dialog.ShowDialog() == DialogResult.OK;
            bool isValue = !string.IsNullOrEmpty(dialog.Value);

            TreeNode node = new TreeNode(dialog.Name + (isValue ? " : " + dialog.Value : ""))
            {
                Tag = new NodeData { Type = dialog.Group }
            };

            var selectedNode = tv_main.SelectedNode;
            if (selectedNode == null)
            {
                if (isOK)
                {
                    tv_main.Nodes.Add(node);
                }
                return;
            }

            if (isOK)
            {
                selectedNode.Nodes.Add(node);
                selectedNode.Expand();
            }
        }

        private void 노드삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedNode = tv_main.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.");
                return;
            }

            selectedNode.Remove();
        }
    }
}
