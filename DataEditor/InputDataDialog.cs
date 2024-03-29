using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEditor
{
    public partial class InputDataDialog : Form
    {
        public DataType Group { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public InputDataDialog(string title, string name = "", string group = "Group")
        {
            InitializeComponent();

            cb_type.Items.Add("Group");
            cb_type.Items.Add("Int");
            cb_type.Items.Add("Float");
            cb_type.Items.Add("String");

            Text = title;
            Name = name;
            cb_type.SelectedIndex = cb_type.Items.IndexOf(group);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Group = (DataType)cb_type.SelectedIndex + 1;
            Name = tb_name.Text;
            Value = tb_value.Text;
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_type.SelectedIndex == 0)
            {
                tb_value.Enabled = false;
            }
            else
            {
                tb_value.Enabled = true;
            }
        }
    }
}
