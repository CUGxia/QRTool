namespace QualificationReviewTool
{
    partial class EditCellWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCellWin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.s_time_picker = new System.Windows.Forms.DateTimePicker();
            this.s_time_text_box = new System.Windows.Forms.TextBox();
            this.s_name_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.solution_textbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancle_btn = new System.Windows.Forms.Button();
            this.submit_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.s_time_picker);
            this.panel1.Controls.Add(this.s_time_text_box);
            this.panel1.Controls.Add(this.s_name_textbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 120);
            this.panel1.TabIndex = 4;
            // 
            // s_time_picker
            // 
            this.s_time_picker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.s_time_picker.Location = new System.Drawing.Point(104, 89);
            this.s_time_picker.Name = "s_time_picker";
            this.s_time_picker.Size = new System.Drawing.Size(314, 23);
            this.s_time_picker.TabIndex = 4;
            this.s_time_picker.ValueChanged += new System.EventHandler(this.s_time_picker_ValueChanged);
            // 
            // s_time_text_box
            // 
            this.s_time_text_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.s_time_text_box.Location = new System.Drawing.Point(104, 52);
            this.s_time_text_box.Name = "s_time_text_box";
            this.s_time_text_box.Size = new System.Drawing.Size(314, 23);
            this.s_time_text_box.TabIndex = 3;
            this.s_time_text_box.TextChanged += new System.EventHandler(this.s_time_text_box_TextChanged);
            // 
            // s_name_textbox
            // 
            this.s_name_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.s_name_textbox.Enabled = false;
            this.s_name_textbox.Location = new System.Drawing.Point(104, 16);
            this.s_name_textbox.Name = "s_name_textbox";
            this.s_name_textbox.Size = new System.Drawing.Size(314, 23);
            this.s_name_textbox.TabIndex = 2;
            this.s_name_textbox.TextChanged += new System.EventHandler(this.s_name_textbox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "回访时间:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "推荐时间:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "负责人员:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.solution_textbox);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 277);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "解决方案";
            // 
            // solution_textbox
            // 
            this.solution_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.solution_textbox.Location = new System.Drawing.Point(7, 23);
            this.solution_textbox.Multiline = true;
            this.solution_textbox.Name = "solution_textbox";
            this.solution_textbox.ReadOnly = true;
            this.solution_textbox.Size = new System.Drawing.Size(447, 111);
            this.solution_textbox.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.cancle_btn);
            this.panel2.Controls.Add(this.submit_btn);
            this.panel2.Location = new System.Drawing.Point(12, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 47);
            this.panel2.TabIndex = 7;
            // 
            // cancle_btn
            // 
            this.cancle_btn.Location = new System.Drawing.Point(259, 7);
            this.cancle_btn.Name = "cancle_btn";
            this.cancle_btn.Size = new System.Drawing.Size(80, 30);
            this.cancle_btn.TabIndex = 5;
            this.cancle_btn.Text = "取消";
            this.cancle_btn.UseVisualStyleBackColor = true;
            this.cancle_btn.Click += new System.EventHandler(this.cancle_btn_Click);
            // 
            // submit_btn
            // 
            this.submit_btn.BackColor = System.Drawing.Color.Transparent;
            this.submit_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.submit_btn.Location = new System.Drawing.Point(120, 7);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(80, 30);
            this.submit_btn.TabIndex = 4;
            this.submit_btn.Text = "确认";
            this.submit_btn.UseVisualStyleBackColor = false;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // EditCellWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 353);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditCellWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "解决方案模板";
            this.Load += new System.EventHandler(this.EditCellWin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker s_time_picker;
        private System.Windows.Forms.TextBox s_time_text_box;
        private System.Windows.Forms.TextBox s_name_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox solution_textbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancle_btn;
        private System.Windows.Forms.Button submit_btn;
    }
}