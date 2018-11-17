namespace MyClass1
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonMax = new System.Windows.Forms.Button();
            this.textMax = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textTest = new System.Windows.Forms.TextBox();
            this.textNum = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textScore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ADD = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.SortByScore = new System.Windows.Forms.Button();
            this.SortByNum = new System.Windows.Forms.Button();
            this.buttonAve = new System.Windows.Forms.Button();
            this.textAve = new System.Windows.Forms.TextBox();
            this.ColumnStu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStu,
            this.ColumnName,
            this.ColumnScore});
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(409, 449);
            this.dataGridView1.TabIndex = 0;
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(516, 12);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(84, 58);
            this.buttonMax.TabIndex = 1;
            this.buttonMax.Text = "求最大值";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // textMax
            // 
            this.textMax.Location = new System.Drawing.Point(516, 76);
            this.textMax.Name = "textMax";
            this.textMax.ReadOnly = true;
            this.textMax.Size = new System.Drawing.Size(84, 21);
            this.textMax.TabIndex = 2;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(426, 102);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(84, 58);
            this.buttonFind.TabIndex = 3;
            this.buttonFind.Text = "查找";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textTest
            // 
            this.textTest.Location = new System.Drawing.Point(528, 167);
            this.textTest.Name = "textTest";
            this.textTest.Size = new System.Drawing.Size(84, 21);
            this.textTest.TabIndex = 4;
            this.textTest.TextChanged += new System.EventHandler(this.textTest_TextChanged);
            // 
            // textNum
            // 
            this.textNum.Location = new System.Drawing.Point(427, 236);
            this.textNum.MaxLength = 5;
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(132, 21);
            this.textNum.TabIndex = 6;
            this.textNum.TextChanged += new System.EventHandler(this.textNum_TextChanged);
            this.textNum.MouseLeave += new System.EventHandler(this.textNum_MouseLeave);
            this.textNum.Validated += new System.EventHandler(this.textNum_Validated);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(427, 288);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(132, 21);
            this.textName.TabIndex = 7;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            this.textName.Validating += new System.ComponentModel.CancelEventHandler(this.textName_Validating);
            this.textName.Validated += new System.EventHandler(this.textName_Validated);
            // 
            // textScore
            // 
            this.textScore.Location = new System.Drawing.Point(427, 347);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(132, 21);
            this.textScore.TabIndex = 8;
            this.textScore.TextChanged += new System.EventHandler(this.textScore_TextChanged);
            this.textScore.Validating += new System.ComponentModel.CancelEventHandler(this.textScore_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "学号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "分数";
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(427, 391);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(53, 48);
            this.ADD.TabIndex = 12;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(495, 391);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(54, 46);
            this.Remove.TabIndex = 13;
            this.Remove.Text = "REMOVE";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // SortByScore
            // 
            this.SortByScore.Location = new System.Drawing.Point(257, 20);
            this.SortByScore.Name = "SortByScore";
            this.SortByScore.Size = new System.Drawing.Size(93, 23);
            this.SortByScore.TabIndex = 16;
            this.SortByScore.Text = "SortByScore";
            this.SortByScore.UseVisualStyleBackColor = true;
            this.SortByScore.Click += new System.EventHandler(this.SortByScore_Click);
            // 
            // SortByNum
            // 
            this.SortByNum.Location = new System.Drawing.Point(26, 20);
            this.SortByNum.Name = "SortByNum";
            this.SortByNum.Size = new System.Drawing.Size(93, 23);
            this.SortByNum.TabIndex = 17;
            this.SortByNum.Text = "SortByNum";
            this.SortByNum.UseVisualStyleBackColor = true;
            this.SortByNum.Click += new System.EventHandler(this.SortByNum_Click);
            // 
            // buttonAve
            // 
            this.buttonAve.Location = new System.Drawing.Point(426, 12);
            this.buttonAve.Name = "buttonAve";
            this.buttonAve.Size = new System.Drawing.Size(84, 58);
            this.buttonAve.TabIndex = 18;
            this.buttonAve.Text = "平均分";
            this.buttonAve.UseVisualStyleBackColor = true;
            this.buttonAve.Click += new System.EventHandler(this.buttonAve_Click);
            // 
            // textAve
            // 
            this.textAve.Location = new System.Drawing.Point(427, 76);
            this.textAve.Name = "textAve";
            this.textAve.ReadOnly = true;
            this.textAve.Size = new System.Drawing.Size(83, 21);
            this.textAve.TabIndex = 19;
            // 
            // ColumnStu
            // 
            this.ColumnStu.DataPropertyName = "StudentNum";
            this.ColumnStu.HeaderText = "学号";
            this.ColumnStu.Name = "ColumnStu";
            this.ColumnStu.ReadOnly = true;
            this.ColumnStu.ToolTipText = "this is number";
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "名字";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnScore
            // 
            this.ColumnScore.DataPropertyName = "Score";
            this.ColumnScore.HeaderText = "分数";
            this.ColumnScore.Name = "ColumnScore";
            this.ColumnScore.ReadOnly = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Items.AddRange(new object[] {
            "学号",
            "名字",
            "分数"});
            this.listBox.Location = new System.Drawing.Point(427, 163);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(72, 28);
            this.listBox.TabIndex = 20;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "为";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(618, 160);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(74, 32);
            this.buttonUpdate.TabIndex = 22;
            this.buttonUpdate.Text = "刷新";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 535);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textAve);
            this.Controls.Add(this.buttonAve);
            this.Controls.Add(this.SortByNum);
            this.Controls.Add(this.SortByScore);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textNum);
            this.Controls.Add(this.textTest);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.TextBox textMax;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textTest;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button SortByScore;
        private System.Windows.Forms.Button SortByNum;
        private System.Windows.Forms.Button buttonAve;
        private System.Windows.Forms.TextBox textAve;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnScore;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

