namespace DataEditor
{
    partial class InputDataDialog
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
            this.lb_type = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tb_value = new System.Windows.Forms.TextBox();
            this.lb_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(12, 9);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(29, 12);
            this.lb_type.TabIndex = 0;
            this.lb_type.Text = "타입";
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_type.Location = new System.Drawing.Point(47, 6);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(165, 20);
            this.cb_type.TabIndex = 1;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.cb_type_SelectedIndexChanged);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(12, 35);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(29, 12);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "이름";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(47, 32);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(165, 21);
            this.tb_name.TabIndex = 3;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(56, 126);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "확인";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(137, 126);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "취소";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tb_value
            // 
            this.tb_value.Location = new System.Drawing.Point(47, 59);
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(165, 21);
            this.tb_value.TabIndex = 6;
            // 
            // lb_value
            // 
            this.lb_value.AutoSize = true;
            this.lb_value.Location = new System.Drawing.Point(24, 62);
            this.lb_value.Name = "lb_value";
            this.lb_value.Size = new System.Drawing.Size(17, 12);
            this.lb_value.TabIndex = 7;
            this.lb_value.Text = "값";
            // 
            // InputDataDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 161);
            this.Controls.Add(this.lb_value);
            this.Controls.Add(this.tb_value);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.lb_type);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputDataDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InputDataDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox tb_value;
        private System.Windows.Forms.Label lb_value;
    }
}