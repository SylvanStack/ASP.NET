namespace StuManage
{
    partial class MianForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MianForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增班级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改班级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除选中学生记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除选中班级记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新登陆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.权限ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.普通学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowAllDataBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除班级信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.TabClass = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TabStudent = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.TabClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.TabStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(812, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "登陆名:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel2.Text = "|  ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel3.Text = "权限：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem1,
            this.重新登陆ToolStripMenuItem,
            this.权限ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增学生ToolStripMenuItem,
            this.新增班级ToolStripMenuItem});
            this.新增ToolStripMenuItem.Enabled = false;
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.新增ToolStripMenuItem.Text = "新增";
            // 
            // 新增学生ToolStripMenuItem
            // 
            this.新增学生ToolStripMenuItem.Name = "新增学生ToolStripMenuItem";
            this.新增学生ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新增学生ToolStripMenuItem.Text = "新增学生";
            this.新增学生ToolStripMenuItem.Click += new System.EventHandler(this.新增学生ToolStripMenuItem_Click);
            // 
            // 新增班级ToolStripMenuItem
            // 
            this.新增班级ToolStripMenuItem.Name = "新增班级ToolStripMenuItem";
            this.新增班级ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新增班级ToolStripMenuItem.Text = "新增班级";
            this.新增班级ToolStripMenuItem.Click += new System.EventHandler(this.新增班级ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改学生ToolStripMenuItem,
            this.修改班级ToolStripMenuItem});
            this.修改ToolStripMenuItem.Enabled = false;
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.修改ToolStripMenuItem.Text = "修改";
            // 
            // 修改学生ToolStripMenuItem
            // 
            this.修改学生ToolStripMenuItem.Name = "修改学生ToolStripMenuItem";
            this.修改学生ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改学生ToolStripMenuItem.Text = "修改学生";
            this.修改学生ToolStripMenuItem.Click += new System.EventHandler(this.修改学生ToolStripMenuItem_Click);
            // 
            // 修改班级ToolStripMenuItem
            // 
            this.修改班级ToolStripMenuItem.Name = "修改班级ToolStripMenuItem";
            this.修改班级ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改班级ToolStripMenuItem.Text = "修改班级";
            this.修改班级ToolStripMenuItem.Click += new System.EventHandler(this.修改班级ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem1
            // 
            this.删除ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除选中学生记录ToolStripMenuItem,
            this.删除选中班级记录ToolStripMenuItem});
            this.删除ToolStripMenuItem1.Enabled = false;
            this.删除ToolStripMenuItem1.Name = "删除ToolStripMenuItem1";
            this.删除ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.删除ToolStripMenuItem1.Text = "删除";
            // 
            // 删除选中学生记录ToolStripMenuItem
            // 
            this.删除选中学生记录ToolStripMenuItem.Name = "删除选中学生记录ToolStripMenuItem";
            this.删除选中学生记录ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.删除选中学生记录ToolStripMenuItem.Text = "删除选中学生记录";
            this.删除选中学生记录ToolStripMenuItem.Click += new System.EventHandler(this.删除选中学生记录ToolStripMenuItem_Click);
            // 
            // 删除选中班级记录ToolStripMenuItem
            // 
            this.删除选中班级记录ToolStripMenuItem.Name = "删除选中班级记录ToolStripMenuItem";
            this.删除选中班级记录ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.删除选中班级记录ToolStripMenuItem.Text = "删除选中班级记录";
            this.删除选中班级记录ToolStripMenuItem.Click += new System.EventHandler(this.删除选中班级记录ToolStripMenuItem_Click);
            // 
            // 重新登陆ToolStripMenuItem
            // 
            this.重新登陆ToolStripMenuItem.Name = "重新登陆ToolStripMenuItem";
            this.重新登陆ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.重新登陆ToolStripMenuItem.Text = "重新登陆";
            this.重新登陆ToolStripMenuItem.ToolTipText = "注销，重新登陆";
            this.重新登陆ToolStripMenuItem.Click += new System.EventHandler(this.重新登陆ToolStripMenuItem_Click);
            // 
            // 权限ToolStripMenuItem
            // 
            this.权限ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.普通学生ToolStripMenuItem,
            this.管理ToolStripMenuItem});
            this.权限ToolStripMenuItem.Name = "权限ToolStripMenuItem";
            this.权限ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.权限ToolStripMenuItem.Text = "权限";
            this.权限ToolStripMenuItem.Click += new System.EventHandler(this.权限ToolStripMenuItem_Click);
            // 
            // 普通学生ToolStripMenuItem
            // 
            this.普通学生ToolStripMenuItem.Name = "普通学生ToolStripMenuItem";
            this.普通学生ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.普通学生ToolStripMenuItem.Text = "普通学生";
            this.普通学生ToolStripMenuItem.Click += new System.EventHandler(this.普通学生ToolStripMenuItem_Click);
            // 
            // 管理ToolStripMenuItem
            // 
            this.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
            this.管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.管理ToolStripMenuItem.Text = "管理";
            this.管理ToolStripMenuItem.Click += new System.EventHandler(this.管理ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShowAllDataBtn);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(8, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // ShowAllDataBtn
            // 
            this.ShowAllDataBtn.Location = new System.Drawing.Point(529, 78);
            this.ShowAllDataBtn.Name = "ShowAllDataBtn";
            this.ShowAllDataBtn.Size = new System.Drawing.Size(121, 33);
            this.ShowAllDataBtn.TabIndex = 5;
            this.ShowAllDataBtn.Text = "显示所有数据";
            this.ShowAllDataBtn.UseVisualStyleBackColor = true;
            this.ShowAllDataBtn.Click += new System.EventHandler(this.ShowAllDataBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(22, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(177, 66);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询对象：";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(85, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "班级";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "学生";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(8, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(796, 340);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "显示：";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除班级信息ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(173, 26);
            // 
            // 删除班级信息ToolStripMenuItem
            // 
            this.删除班级信息ToolStripMenuItem.Name = "删除班级信息ToolStripMenuItem";
            this.删除班级信息ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.删除班级信息ToolStripMenuItem.Text = "删除此条班级信息";
            this.删除班级信息ToolStripMenuItem.Click += new System.EventHandler(this.删除班级信息ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.删除ToolStripMenuItem.Text = "删除此条学生记录";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(729, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TabClass
            // 
            this.TabClass.Controls.Add(this.dataGridView2);
            this.TabClass.Location = new System.Drawing.Point(4, 26);
            this.TabClass.Name = "TabClass";
            this.TabClass.Padding = new System.Windows.Forms.Padding(3);
            this.TabClass.Size = new System.Drawing.Size(772, 270);
            this.TabClass.TabIndex = 1;
            this.TabClass.Text = "显示班级信息";
            this.TabClass.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(760, 258);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // TabStudent
            // 
            this.TabStudent.Controls.Add(this.dataGridView1);
            this.TabStudent.Location = new System.Drawing.Point(4, 26);
            this.TabStudent.Name = "TabStudent";
            this.TabStudent.Padding = new System.Windows.Forms.Padding(3);
            this.TabStudent.Size = new System.Drawing.Size(772, 270);
            this.TabStudent.TabIndex = 0;
            this.TabStudent.Text = "显示学生信息";
            this.TabStudent.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(760, 258);
            this.dataGridView1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabStudent);
            this.tabControl1.Controls.Add(this.TabClass);
            this.tabControl1.Location = new System.Drawing.Point(6, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 300);
            this.tabControl1.TabIndex = 4;
            // 
            // MianForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(812, 566);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MianForm";
            this.Text = "主窗体";
            this.Load += new System.EventHandler(this.MianForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.TabClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.TabStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增班级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改班级ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 删除班级信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 删除选中学生记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除选中班级记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新登陆ToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ToolStripMenuItem 权限ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 普通学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Button ShowAllDataBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage TabClass;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}