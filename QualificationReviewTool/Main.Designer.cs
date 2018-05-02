namespace QualificationReviewTool
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.export_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insert_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusbar_progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusbar_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusbar_author = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusbar_blog_url = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.import_score_btn = new System.Windows.Forms.Button();
            this.import_stu_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.export_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.insert_ToolStripMenuItem,
            this.clear_ToolStripMenuItem,
            this.about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(651, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.export_ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.菜单ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.import_score_btn_Click);
            // 
            // export_ToolStripMenuItem
            // 
            this.export_ToolStripMenuItem.Name = "export_ToolStripMenuItem";
            this.export_ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.export_ToolStripMenuItem.Text = "导出";
            this.export_ToolStripMenuItem.Click += new System.EventHandler(this.export_btn_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // insert_ToolStripMenuItem
            // 
            this.insert_ToolStripMenuItem.Name = "insert_ToolStripMenuItem";
            this.insert_ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.insert_ToolStripMenuItem.Text = "录入";
            // 
            // clear_ToolStripMenuItem
            // 
            this.clear_ToolStripMenuItem.Name = "clear_ToolStripMenuItem";
            this.clear_ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.clear_ToolStripMenuItem.Text = "清空";
            this.clear_ToolStripMenuItem.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(44, 21);
            this.about.Text = "关于";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusbar_progressbar,
            this.statusbar_status,
            this.toolStripStatusLabel1,
            this.statusbar_author,
            this.statusbar_blog_url});
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(651, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusbar_progressbar
            // 
            this.statusbar_progressbar.Name = "statusbar_progressbar";
            this.statusbar_progressbar.Size = new System.Drawing.Size(171, 16);
            // 
            // statusbar_status
            // 
            this.statusbar_status.AutoToolTip = true;
            this.statusbar_status.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusbar_status.Name = "statusbar_status";
            this.statusbar_status.Size = new System.Drawing.Size(306, 17);
            this.statusbar_status.Text = "Copyright © 2017 CUG Dorad. All Rights Reserved.";
            this.statusbar_status.ToolTipText = "当前状态";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(114, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // statusbar_author
            // 
            this.statusbar_author.Name = "statusbar_author";
            this.statusbar_author.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusbar_author.Size = new System.Drawing.Size(45, 17);
            this.statusbar_author.Text = "Dorad";
            // 
            // statusbar_blog_url
            // 
            this.statusbar_blog_url.IsLink = true;
            this.statusbar_blog_url.Name = "statusbar_blog_url";
            this.statusbar_blog_url.Size = new System.Drawing.Size(129, 17);
            this.statusbar_blog_url.Text = "https://blog.cuger.cn";
            this.statusbar_blog_url.Click += new System.EventHandler(this.statusbar_about_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(562, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(80, 406);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快捷操作栏";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::QualificationReviewTool.Properties.Resources.qrcode_1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 333);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 69);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.import_score_btn);
            this.flowLayoutPanel1.Controls.Add(this.import_stu_btn);
            this.flowLayoutPanel1.Controls.Add(this.insert_btn);
            this.flowLayoutPanel1.Controls.Add(this.export_btn);
            this.flowLayoutPanel1.Controls.Add(this.clear_btn);
            this.flowLayoutPanel1.Controls.Add(this.exit_btn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(69, 176);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // import_score_btn
            // 
            this.import_score_btn.Location = new System.Drawing.Point(3, 4);
            this.import_score_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.import_score_btn.Name = "import_score_btn";
            this.import_score_btn.Size = new System.Drawing.Size(64, 26);
            this.import_score_btn.TabIndex = 0;
            this.import_score_btn.Text = "导入成绩";
            this.import_score_btn.UseVisualStyleBackColor = true;
            this.import_score_btn.Click += new System.EventHandler(this.import_score_btn_Click);
            // 
            // import_stu_btn
            // 
            this.import_stu_btn.Enabled = false;
            this.import_stu_btn.Location = new System.Drawing.Point(3, 38);
            this.import_stu_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.import_stu_btn.Name = "import_stu_btn";
            this.import_stu_btn.Size = new System.Drawing.Size(64, 26);
            this.import_stu_btn.TabIndex = 5;
            this.import_stu_btn.Text = "导入学员";
            this.import_stu_btn.UseVisualStyleBackColor = true;
            this.import_stu_btn.Click += new System.EventHandler(this.import_stu_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Enabled = false;
            this.insert_btn.Location = new System.Drawing.Point(3, 72);
            this.insert_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(64, 26);
            this.insert_btn.TabIndex = 1;
            this.insert_btn.Text = "录入";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // export_btn
            // 
            this.export_btn.Enabled = false;
            this.export_btn.Location = new System.Drawing.Point(3, 106);
            this.export_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(64, 26);
            this.export_btn.TabIndex = 4;
            this.export_btn.Text = "导出";
            this.export_btn.UseVisualStyleBackColor = true;
            this.export_btn.Click += new System.EventHandler(this.export_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Enabled = false;
            this.clear_btn.Location = new System.Drawing.Point(3, 140);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(64, 26);
            this.clear_btn.TabIndex = 2;
            this.clear_btn.Text = "清空";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(3, 174);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(64, 26);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "退出";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(552, 404);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 456);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(559, 391);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QualificationReviewTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insert_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar statusbar_progressbar;
        private System.Windows.Forms.ToolStripStatusLabel statusbar_author;
        private System.Windows.Forms.ToolStripStatusLabel statusbar_blog_url;
        private System.Windows.Forms.ToolStripStatusLabel statusbar_status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button import_score_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button export_btn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem export_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clear_ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button import_stu_btn;
    }
}

