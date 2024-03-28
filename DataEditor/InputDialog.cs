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
    public partial class InputDialog : Form
    {
        public string Result { get; set; }

        public InputDialog(string title, string text)
        {
            InitializeComponent();

            Text = title;

            lb_text.Text = text;
            lb_text.Left = (ClientSize.Width - lb_text.Width) / 2;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Result = tb_inputBox.Text;
            Close();
        }
    }
}
