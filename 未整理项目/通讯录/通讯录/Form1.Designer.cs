namespace 通讯录
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label 编号Label;
            System.Windows.Forms.Label 用户名Label;
            System.Windows.Forms.Label 组别Label;
            System.Windows.Forms.Label 姓名Label;
            System.Windows.Forms.Label 工作单位Label;
            System.Windows.Forms.Label 联系电话Label;
            System.Windows.Forms.Label 电子邮箱Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.学生库DataSet = new 通讯录.学生库DataSet();
            this.联系人BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.联系人TableAdapter = new 通讯录.学生库DataSetTableAdapters.联系人TableAdapter();
            this.tableAdapterManager = new 通讯录.学生库DataSetTableAdapters.TableAdapterManager();
            this.联系人BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.联系人BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.编号TextBox = new System.Windows.Forms.TextBox();
            this.用户名TextBox = new System.Windows.Forms.TextBox();
            this.组别TextBox = new System.Windows.Forms.TextBox();
            this.姓名TextBox = new System.Windows.Forms.TextBox();
            this.工作单位TextBox = new System.Windows.Forms.TextBox();
            this.联系电话TextBox = new System.Windows.Forms.TextBox();
            this.电子邮箱TextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            编号Label = new System.Windows.Forms.Label();
            用户名Label = new System.Windows.Forms.Label();
            组别Label = new System.Windows.Forms.Label();
            姓名Label = new System.Windows.Forms.Label();
            工作单位Label = new System.Windows.Forms.Label();
            联系电话Label = new System.Windows.Forms.Label();
            电子邮箱Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.学生库DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.联系人BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.联系人BindingNavigator)).BeginInit();
            this.联系人BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // 编号Label
            // 
            编号Label.AutoSize = true;
            编号Label.Location = new System.Drawing.Point(34, 62);
            编号Label.Name = "编号Label";
            编号Label.Size = new System.Drawing.Size(35, 12);
            编号Label.TabIndex = 1;
            编号Label.Text = "编号:";
            // 
            // 用户名Label
            // 
            用户名Label.AutoSize = true;
            用户名Label.Location = new System.Drawing.Point(22, 97);
            用户名Label.Name = "用户名Label";
            用户名Label.Size = new System.Drawing.Size(47, 12);
            用户名Label.TabIndex = 3;
            用户名Label.Text = "用户名:";
            // 
            // 组别Label
            // 
            组别Label.AutoSize = true;
            组别Label.Location = new System.Drawing.Point(34, 202);
            组别Label.Name = "组别Label";
            组别Label.Size = new System.Drawing.Size(35, 12);
            组别Label.TabIndex = 5;
            组别Label.Text = "组别:";
            // 
            // 姓名Label
            // 
            姓名Label.AutoSize = true;
            姓名Label.Location = new System.Drawing.Point(34, 132);
            姓名Label.Name = "姓名Label";
            姓名Label.Size = new System.Drawing.Size(35, 12);
            姓名Label.TabIndex = 7;
            姓名Label.Text = "姓名:";
            // 
            // 工作单位Label
            // 
            工作单位Label.AutoSize = true;
            工作单位Label.Location = new System.Drawing.Point(10, 237);
            工作单位Label.Name = "工作单位Label";
            工作单位Label.Size = new System.Drawing.Size(59, 12);
            工作单位Label.TabIndex = 9;
            工作单位Label.Text = "工作单位:";
            // 
            // 联系电话Label
            // 
            联系电话Label.AutoSize = true;
            联系电话Label.Location = new System.Drawing.Point(10, 167);
            联系电话Label.Name = "联系电话Label";
            联系电话Label.Size = new System.Drawing.Size(59, 12);
            联系电话Label.TabIndex = 11;
            联系电话Label.Text = "联系电话:";
            // 
            // 电子邮箱Label
            // 
            电子邮箱Label.AutoSize = true;
            电子邮箱Label.Location = new System.Drawing.Point(263, 231);
            电子邮箱Label.Name = "电子邮箱Label";
            电子邮箱Label.Size = new System.Drawing.Size(59, 12);
            电子邮箱Label.TabIndex = 13;
            电子邮箱Label.Text = "电子邮箱:";
            // 
            // 学生库DataSet
            // 
            this.学生库DataSet.DataSetName = "学生库DataSet";
            this.学生库DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 联系人BindingSource
            // 
            this.联系人BindingSource.DataMember = "联系人";
            this.联系人BindingSource.DataSource = this.学生库DataSet;
            // 
            // 联系人TableAdapter
            // 
            this.联系人TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = 通讯录.学生库DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.联系人TableAdapter = this.联系人TableAdapter;
            // 
            // 联系人BindingNavigator
            // 
            this.联系人BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.联系人BindingNavigator.BindingSource = this.联系人BindingSource;
            this.联系人BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.联系人BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.联系人BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.联系人BindingNavigatorSaveItem});
            this.联系人BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.联系人BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.联系人BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.联系人BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.联系人BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.联系人BindingNavigator.Name = "联系人BindingNavigator";
            this.联系人BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.联系人BindingNavigator.Size = new System.Drawing.Size(549, 25);
            this.联系人BindingNavigator.TabIndex = 0;
            this.联系人BindingNavigator.Text = "bindingNavigator1";
            this.联系人BindingNavigator.RefreshItems += new System.EventHandler(this.联系人BindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // 联系人BindingNavigatorSaveItem
            // 
            this.联系人BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.联系人BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("联系人BindingNavigatorSaveItem.Image")));
            this.联系人BindingNavigatorSaveItem.Name = "联系人BindingNavigatorSaveItem";
            this.联系人BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.联系人BindingNavigatorSaveItem.Text = "保存数据";
            this.联系人BindingNavigatorSaveItem.Click += new System.EventHandler(this.联系人BindingNavigatorSaveItem_Click);
            // 
            // 编号TextBox
            // 
            this.编号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.联系人BindingSource, "编号", true));
            this.编号TextBox.Location = new System.Drawing.Point(104, 53);
            this.编号TextBox.Name = "编号TextBox";
            this.编号TextBox.Size = new System.Drawing.Size(45, 21);
            this.编号TextBox.TabIndex = 2;
            // 
            // 用户名TextBox
            // 
            this.用户名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.联系人BindingSource, "用户名", true));
            this.用户名TextBox.Location = new System.Drawing.Point(104, 88);
            this.用户名TextBox.Name = "用户名TextBox";
            this.用户名TextBox.Size = new System.Drawing.Size(139, 21);
            this.用户名TextBox.TabIndex = 4;
            // 
            // 组别TextBox
            // 
            this.组别TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.联系人BindingSource, "组别", true));
            this.组别TextBox.Location = new System.Drawing.Point(104, 193);
            this.组别TextBox.Name = "组别TextBox";
            this.组别TextBox.Size = new System.Drawing.Size(139, 21);
            this.组别TextBox.TabIndex = 6;
            // 
            // 姓名TextBox
            // 
            this.姓名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.联系人BindingSource, "姓名", true));
            this.姓名TextBox.Location = new System.Drawing.Point(104, 123);
            this.姓名TextBox.Name = "姓名TextBox";
            this.姓名TextBox.Size = new System.Drawing.Size(139, 21);
            this.姓名TextBox.TabIndex = 8;
            // 
            // 工作单位TextBox
            // 
            this.工作单位TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.联系人BindingSource, "工作单位", true));
            this.工作单位TextBox.Location = new System.Drawing.Point(104, 228);
            this.工作单位TextBox.Name = "工作单位TextBox";
            this.工作单位TextBox.Size = new System.Drawing.Size(139, 21);
            this.工作单位TextBox.TabIndex = 10;
            // 
            // 联系电话TextBox
            // 
            this.联系电话TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.联系人BindingSource, "联系电话", true));
            this.联系电话TextBox.Location = new System.Drawing.Point(104, 158);
            this.联系电话TextBox.Name = "联系电话TextBox";
            this.联系电话TextBox.Size = new System.Drawing.Size(139, 21);
            this.联系电话TextBox.TabIndex = 12;
            // 
            // 电子邮箱TextBox
            // 
            this.电子邮箱TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.联系人BindingSource, "电子邮箱", true));
            this.电子邮箱TextBox.Location = new System.Drawing.Point(342, 222);
            this.电子邮箱TextBox.Name = "电子邮箱TextBox";
            this.电子邮箱TextBox.Size = new System.Drawing.Size(187, 21);
            this.电子邮箱TextBox.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(249, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 160);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "增加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 341);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(编号Label);
            this.Controls.Add(this.编号TextBox);
            this.Controls.Add(用户名Label);
            this.Controls.Add(this.用户名TextBox);
            this.Controls.Add(组别Label);
            this.Controls.Add(this.组别TextBox);
            this.Controls.Add(姓名Label);
            this.Controls.Add(this.姓名TextBox);
            this.Controls.Add(工作单位Label);
            this.Controls.Add(this.工作单位TextBox);
            this.Controls.Add(联系电话Label);
            this.Controls.Add(this.联系电话TextBox);
            this.Controls.Add(电子邮箱Label);
            this.Controls.Add(this.电子邮箱TextBox);
            this.Controls.Add(this.联系人BindingNavigator);
            this.Name = "Form1";
            this.Text = "新增联系人";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.学生库DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.联系人BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.联系人BindingNavigator)).EndInit();
            this.联系人BindingNavigator.ResumeLayout(false);
            this.联系人BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private 学生库DataSet 学生库DataSet;
        private System.Windows.Forms.BindingSource 联系人BindingSource;
        private 学生库DataSetTableAdapters.联系人TableAdapter 联系人TableAdapter;
        private 学生库DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator 联系人BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton 联系人BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox 编号TextBox;
        private System.Windows.Forms.TextBox 用户名TextBox;
        private System.Windows.Forms.TextBox 组别TextBox;
        private System.Windows.Forms.TextBox 姓名TextBox;
        private System.Windows.Forms.TextBox 工作单位TextBox;
        private System.Windows.Forms.TextBox 联系电话TextBox;
        private System.Windows.Forms.TextBox 电子邮箱TextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

