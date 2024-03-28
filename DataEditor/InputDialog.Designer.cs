namespace DataEditor
{
    partial class InputDialog
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
            this.tb_inputBox = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.lb_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_inputBox
            // 
            this.tb_inputBox.Location = new System.Drawing.Point(12, 126);
            this.tb_inputBox.Name = "tb_inputBox";
            this.tb_inputBox.Size = new System.Drawing.Size(179, 21);
            this.tb_inputBox.TabIndex = 0;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(197, 126);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 1;
            this.btn_confirm.Text = "확인";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // lb_text
            // 
            this.lb_text.AutoSize = true;
            this.lb_text.Location = new System.Drawing.Point(10, 58);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(29, 12);
            this.lb_text.TabIndex = 2;
            this.lb_text.Text = "내용";
            this.lb_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lb_text);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.tb_inputBox);
            this.Name = "InputDialog";
            this.Text = "InputDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_inputBox;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label lb_text;
    }
}