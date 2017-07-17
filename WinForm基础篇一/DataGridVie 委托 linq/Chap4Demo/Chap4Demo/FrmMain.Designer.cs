namespace Chap4Demo
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddEm = new System.Windows.Forms.ToolStripButton();
            this.btnChangeEm = new System.Windows.Forms.ToolStripButton();
            this.btnDelEm = new System.Windows.Forms.ToolStripButton();
            this.btnPCm = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFindEm = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddEm,
            this.btnChangeEm,
            this.btnDelEm,
            this.btnPCm});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(664, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddEm
            // 
            this.btnAddEm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddEm.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEm.Image")));
            this.btnAddEm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddEm.Name = "btnAddEm";
            this.btnAddEm.Size = new System.Drawing.Size(36, 22);
            this.btnAddEm.Text = "新增";
            this.btnAddEm.Click += new System.EventHandler(this.btnAddEm_Click);
            // 
            // btnChangeEm
            // 
            this.btnChangeEm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnChangeEm.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeEm.Image")));
            this.btnChangeEm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangeEm.Name = "btnChangeEm";
            this.btnChangeEm.Size = new System.Drawing.Size(36, 22);
            this.btnChangeEm.Text = "修改";
            this.btnChangeEm.Click += new System.EventHandler(this.btnChangeEm_Click);
            // 
            // btnDelEm
            // 
            this.btnDelEm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelEm.Image = ((System.Drawing.Image)(resources.GetObject("btnDelEm.Image")));
            this.btnDelEm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelEm.Name = "btnDelEm";
            this.btnDelEm.Size = new System.Drawing.Size(36, 22);
            this.btnDelEm.Text = "删除";
            // 
            // btnPCm
            // 
            this.btnPCm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPCm.Image = ((System.Drawing.Image)(resources.GetObject("btnPCm.Image")));
            this.btnPCm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPCm.Name = "btnPCm";
            this.btnPCm.Size = new System.Drawing.Size(60, 22);
            this.btnPCm.Text = "打卡记录";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFindEm);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索条件";
            // 
            // btnFindEm
            // 
            this.btnFindEm.Location = new System.Drawing.Point(476, 49);
            this.btnFindEm.Name = "btnFindEm";
            this.btnFindEm.Size = new System.Drawing.Size(75, 23);
            this.btnFindEm.TabIndex = 2;
            this.btnFindEm.Text = "搜索";
            this.btnFindEm.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工工号";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.JobName,
            this.Age,
            this.GenderText});
            this.dgvMain.Location = new System.Drawing.Point(0, 144);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.Size = new System.Drawing.Size(662, 282);
            this.dgvMain.TabIndex = 2;
            this.dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "员工工号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // JobName
            // 
            this.JobName.DataPropertyName = "JobName";
            this.JobName.HeaderText = "员工姓名";
            this.JobName.Name = "JobName";
            this.JobName.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "年龄";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // GenderText
            // 
            this.GenderText.DataPropertyName = "GenderText";
            this.GenderText.HeaderText = "性别";
            this.GenderText.Name = "GenderText";
            this.GenderText.ReadOnly = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 420);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMain";
            this.Text = "员工信息维护";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddEm;
        private System.Windows.Forms.ToolStripButton btnChangeEm;
        private System.Windows.Forms.ToolStripButton btnDelEm;
        private System.Windows.Forms.ToolStripButton btnPCm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFindEm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderText;
    }
}

