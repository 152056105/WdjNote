﻿namespace WdjNote
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上传到云端ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.团队介绍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.软件版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbWdj = new System.Windows.Forms.RichTextBox();
            this.stsWdj = new System.Windows.Forms.StatusStrip();
            this.tssWdj1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssWdj2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ofdWdj = new System.Windows.Forms.OpenFileDialog();
            this.sfdWdj = new System.Windows.Forms.SaveFileDialog();
            this.tWdj = new System.Windows.Forms.Timer(this.components);
            this.fdWdj = new System.Windows.Forms.FontDialog();
            this.comboWdj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_pre_username = new System.Windows.Forms.Label();
            this.lb_pre_user = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.stsWdj.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.格式ToolStripMenuItem,
            this.用户ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(860, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建文件ToolStripMenuItem,
            this.打开文件ToolStripMenuItem,
            this.保存文件ToolStripMenuItem,
            this.上传到云端ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建文件ToolStripMenuItem
            // 
            this.新建文件ToolStripMenuItem.Name = "新建文件ToolStripMenuItem";
            this.新建文件ToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.新建文件ToolStripMenuItem.Text = "新建文件";
            this.新建文件ToolStripMenuItem.Click += new System.EventHandler(this.新建文件ToolStripMenuItem_Click);
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.打开文件ToolStripMenuItem.Text = "打开文件";
            this.打开文件ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 保存文件ToolStripMenuItem
            // 
            this.保存文件ToolStripMenuItem.Name = "保存文件ToolStripMenuItem";
            this.保存文件ToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.保存文件ToolStripMenuItem.Text = "保存文件";
            this.保存文件ToolStripMenuItem.Click += new System.EventHandler(this.保存文件ToolStripMenuItem_Click);
            // 
            // 上传到云端ToolStripMenuItem
            // 
            this.上传到云端ToolStripMenuItem.Name = "上传到云端ToolStripMenuItem";
            this.上传到云端ToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.上传到云端ToolStripMenuItem.Text = "上传到云端";
            this.上传到云端ToolStripMenuItem.Click += new System.EventHandler(this.上传到云端ToolStripMenuItem_Click);
            // 
            // 格式ToolStripMenuItem
            // 
            this.格式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改格式ToolStripMenuItem});
            this.格式ToolStripMenuItem.Name = "格式ToolStripMenuItem";
            this.格式ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.格式ToolStripMenuItem.Text = "格式";
            // 
            // 修改格式ToolStripMenuItem
            // 
            this.修改格式ToolStripMenuItem.Name = "修改格式ToolStripMenuItem";
            this.修改格式ToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.修改格式ToolStripMenuItem.Text = "修改格式";
            this.修改格式ToolStripMenuItem.Click += new System.EventHandler(this.修改格式ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.团队介绍ToolStripMenuItem,
            this.软件版本ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 团队介绍ToolStripMenuItem
            // 
            this.团队介绍ToolStripMenuItem.Name = "团队介绍ToolStripMenuItem";
            this.团队介绍ToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.团队介绍ToolStripMenuItem.Text = "团队介绍";
            this.团队介绍ToolStripMenuItem.Click += new System.EventHandler(this.团队介绍ToolStripMenuItem_Click);
            // 
            // 软件版本ToolStripMenuItem
            // 
            this.软件版本ToolStripMenuItem.Name = "软件版本ToolStripMenuItem";
            this.软件版本ToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.软件版本ToolStripMenuItem.Text = "软件版本";
            this.软件版本ToolStripMenuItem.Click += new System.EventHandler(this.软件版本ToolStripMenuItem_Click);
            // 
            // 用户ToolStripMenuItem
            // 
            this.用户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改信息ToolStripMenuItem});
            this.用户ToolStripMenuItem.Name = "用户ToolStripMenuItem";
            this.用户ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.用户ToolStripMenuItem.Text = "用户";
            // 
            // 修改信息ToolStripMenuItem
            // 
            this.修改信息ToolStripMenuItem.Name = "修改信息ToolStripMenuItem";
            this.修改信息ToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.修改信息ToolStripMenuItem.Text = "修改信息";
            this.修改信息ToolStripMenuItem.Click += new System.EventHandler(this.修改信息ToolStripMenuItem_Click);
            // 
            // rtbWdj
            // 
            this.rtbWdj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbWdj.Location = new System.Drawing.Point(193, 38);
            this.rtbWdj.Name = "rtbWdj";
            this.rtbWdj.Size = new System.Drawing.Size(666, 502);
            this.rtbWdj.TabIndex = 1;
            this.rtbWdj.Text = "请先新建或打开一个笔记，否则本次输入的数据将会失效！";
            // 
            // stsWdj
            // 
            this.stsWdj.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.stsWdj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssWdj1,
            this.tssWdj2});
            this.stsWdj.Location = new System.Drawing.Point(0, 543);
            this.stsWdj.Name = "stsWdj";
            this.stsWdj.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.stsWdj.Size = new System.Drawing.Size(860, 25);
            this.stsWdj.TabIndex = 2;
            this.stsWdj.Text = "statusStrip1";
            // 
            // tssWdj1
            // 
            this.tssWdj1.Margin = new System.Windows.Forms.Padding(13, 3, 220, 2);
            this.tssWdj1.Name = "tssWdj1";
            this.tssWdj1.Size = new System.Drawing.Size(0, 20);
            // 
            // tssWdj2
            // 
            this.tssWdj2.Margin = new System.Windows.Forms.Padding(400, 3, 0, 2);
            this.tssWdj2.Name = "tssWdj2";
            this.tssWdj2.Size = new System.Drawing.Size(107, 20);
            this.tssWdj2.Text = "显示日期、时间";
            // 
            // ofdWdj
            // 
            this.ofdWdj.FileName = "openFileDialog1";
            // 
            // tWdj
            // 
            this.tWdj.Enabled = true;
            this.tWdj.Interval = 1000;
            this.tWdj.Tick += new System.EventHandler(this.tWdj_Tick);
            // 
            // comboWdj
            // 
            this.comboWdj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWdj.FormattingEnabled = true;
            this.comboWdj.Location = new System.Drawing.Point(413, 7);
            this.comboWdj.Name = "comboWdj";
            this.comboWdj.Size = new System.Drawing.Size(140, 21);
            this.comboWdj.TabIndex = 3;
            this.comboWdj.SelectedIndexChanged += new System.EventHandler(this.comboWdj_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(358, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "分类：";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(14, 38);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.Size = new System.Drawing.Size(173, 470);
            this.treeView1.TabIndex = 5;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lb_pre_username);
            this.panel1.Controls.Add(this.lb_pre_user);
            this.panel1.Location = new System.Drawing.Point(594, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 27);
            this.panel1.TabIndex = 6;
            // 
            // lb_pre_username
            // 
            this.lb_pre_username.AutoSize = true;
            this.lb_pre_username.Location = new System.Drawing.Point(112, 9);
            this.lb_pre_username.Name = "lb_pre_username";
            this.lb_pre_username.Size = new System.Drawing.Size(49, 14);
            this.lb_pre_username.TabIndex = 1;
            this.lb_pre_username.Text = "label3";
            // 
            // lb_pre_user
            // 
            this.lb_pre_user.AutoSize = true;
            this.lb_pre_user.Location = new System.Drawing.Point(29, 10);
            this.lb_pre_user.Name = "lb_pre_user";
            this.lb_pre_user.Size = new System.Drawing.Size(77, 14);
            this.lb_pre_user.TabIndex = 0;
            this.lb_pre_user.Text = "当前用户：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "删除选中项";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboWdj);
            this.Controls.Add(this.stsWdj);
            this.Controls.Add(this.rtbWdj);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "豌豆荚记事本";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.stsWdj.ResumeLayout(false);
            this.stsWdj.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 团队介绍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 软件版本ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbWdj;
        private System.Windows.Forms.StatusStrip stsWdj;
        private System.Windows.Forms.ToolStripStatusLabel tssWdj1;
        private System.Windows.Forms.ToolStripStatusLabel tssWdj2;
        private System.Windows.Forms.OpenFileDialog ofdWdj;
        private System.Windows.Forms.SaveFileDialog sfdWdj;
        private System.Windows.Forms.Timer tWdj;
        private System.Windows.Forms.FontDialog fdWdj;
        private System.Windows.Forms.ComboBox comboWdj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_pre_username;
        private System.Windows.Forms.Label lb_pre_user;
        private System.Windows.Forms.ToolStripMenuItem 用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上传到云端ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建文件ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}