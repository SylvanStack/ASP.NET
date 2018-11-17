namespace Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label 用户名Label;
            System.Windows.Forms.Label 密码Label;
            System.Windows.Forms.Label 联系人数量最大值Label;
            System.Windows.Forms.Label 组别数量最大值Label;
            this.学生库DataSet = new Server.学生库DataSet();
            this.用户BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.用户TableAdapter = new Server.学生库DataSetTableAdapters.用户TableAdapter();
            this.tableAdapterManager = new Server.学生库DataSetTableAdapters.TableAdapterManager();
            this.用户BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.用户BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.用户名TextBox = new System.Windows.Forms.TextBox();
            this.密码TextBox = new System.Windows.Forms.TextBox();
            this.联系人数量最大值TextBox = new System.Windows.Forms.TextBox();
            this.组别数量最大值TextBox = new System.Windows.Forms.TextBox();
            用户名Label = new System.Windows.Forms.Label();
            密码Label = new System.Windows.Forms.Label();
            联系人数量最大值Label = new System.Windows.Forms.Label();
            组别数量最大值Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.学生库DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.用户BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.用户BindingNavigator)).BeginInit();
            this.用户BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // 学生库DataSet
            // 
            this.学生库DataSet.DataSetName = "学生库DataSet";
            this.学生库DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 用户BindingSource
            // 
            this.用户BindingSource.DataMember = "用户";
            this.用户BindingSource.DataSource = this.学生库DataSet;
            // 
            // 用户TableAdapter
            // 
            this.用户TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Server.学生库DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.用户TableAdapter = this.用户TableAdapter;
            // 
            // 用户BindingNavigator
            // 
            this.用户BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.用户BindingNavigator.BindingSource = this.用户BindingSource;
            this.用户BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.用户BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.用户BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.用户BindingNavigatorSaveItem});
            this.用户BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.用户BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.用户BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.用户BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.用户BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.用户BindingNavigator.Name = "用户BindingNavigator";
            this.用户BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.用户BindingNavigator.Size = new System.Drawing.Size(293, 25);
            this.用户BindingNavigator.TabIndex = 0;
            this.用户BindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 17);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // 用户BindingNavigatorSaveItem
            // 
            this.用户BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.用户BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("用户BindingNavigatorSaveItem.Image")));
            this.用户BindingNavigatorSaveItem.Name = "用户BindingNavigatorSaveItem";
            this.用户BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.用户BindingNavigatorSaveItem.Text = "保存数据";
            this.用户BindingNavigatorSaveItem.Click += new System.EventHandler(this.用户BindingNavigatorSaveItem_Click);
            // 
            // 用户名Label
            // 
            用户名Label.AutoSize = true;
            用户名Label.Location = new System.Drawing.Point(35, 64);
            用户名Label.Name = "用户名Label";
            用户名Label.Size = new System.Drawing.Size(47, 12);
            用户名Label.TabIndex = 1;
            用户名Label.Text = "用户名:";
            // 
            // 用户名TextBox
            // 
            this.用户名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.用户BindingSource, "用户名", true));
            this.用户名TextBox.Location = new System.Drawing.Point(148, 61);
            this.用户名TextBox.Name = "用户名TextBox";
            this.用户名TextBox.Size = new System.Drawing.Size(100, 21);
            this.用户名TextBox.TabIndex = 2;
            // 
            // 密码Label
            // 
            密码Label.AutoSize = true;
            密码Label.Location = new System.Drawing.Point(35, 91);
            密码Label.Name = "密码Label";
            密码Label.Size = new System.Drawing.Size(35, 12);
            密码Label.TabIndex = 3;
            密码Label.Text = "密码:";
            // 
            // 密码TextBox
            // 
            this.密码TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.用户BindingSource, "密码", true));
            this.密码TextBox.Location = new System.Drawing.Point(148, 88);
            this.密码TextBox.Name = "密码TextBox";
            this.密码TextBox.Size = new System.Drawing.Size(100, 21);
            this.密码TextBox.TabIndex = 4;
            // 
            // 联系人数量最大值Label
            // 
            联系人数量最大值Label.AutoSize = true;
            联系人数量最大值Label.Location = new System.Drawing.Point(35, 118);
            联系人数量最大值Label.Name = "联系人数量最大值Label";
            联系人数量最大值Label.Size = new System.Drawing.Size(107, 12);
            联系人数量最大值Label.TabIndex = 5;
            联系人数量最大值Label.Text = "联系人数量最大值:";
            // 
            // 联系人数量最大值TextBox
            // 
            this.联系人数量最大值TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.用户BindingSource, "联系人数量最大值", true));
            this.联系人数量最大值TextBox.Location = new System.Drawing.Point(148, 115);
            this.联系人数量最大值TextBox.Name = "联系人数量最大值TextBox";
            this.联系人数量最大值TextBox.Size = new System.Drawing.Size(100, 21);
            this.联系人数量最大值TextBox.TabIndex = 6;
            // 
            // 组别数量最大值Label
            // 
            组别数量最大值Label.AutoSize = true;
            组别数量最大值Label.Location = new System.Drawing.Point(35, 145);
            组别数量最大值Label.Name = "组别数量最大值Label";
            组别数量最大值Label.Size = new System.Drawing.Size(95, 12);
            组别数量最大值Label.TabIndex = 7;
            组别数量最大值Label.Text = "组别数量最大值:";
            // 
            // 组别数量最大值TextBox
            // 
            this.组别数量最大值TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.用户BindingSource, "组别数量最大值", true));
            this.组别数量最大值TextBox.Location = new System.Drawing.Point(148, 142);
            this.组别数量最大值TextBox.Name = "组别数量最大值TextBox";
            this.组别数量最大值TextBox.Size = new System.Drawing.Size(100, 21);
            this.组别数量最大值TextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 205);
            this.Controls.Add(用户名Label);
            this.Controls.Add(this.用户名TextBox);
            this.Controls.Add(密码Label);
            this.Controls.Add(this.密码TextBox);
            this.Controls.Add(联系人数量最大值Label);
            this.Controls.Add(this.联系人数量最大值TextBox);
            this.Controls.Add(组别数量最大值Label);
            this.Controls.Add(this.组别数量最大值TextBox);
            this.Controls.Add(this.用户BindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.学生库DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.用户BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.用户BindingNavigator)).EndInit();
            this.用户BindingNavigator.ResumeLayout(false);
            this.用户BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private 学生库DataSet 学生库DataSet;
        private System.Windows.Forms.BindingSource 用户BindingSource;
        private 学生库DataSetTableAdapters.用户TableAdapter 用户TableAdapter;
        private 学生库DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator 用户BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton 用户BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox 用户名TextBox;
        private System.Windows.Forms.TextBox 密码TextBox;
        private System.Windows.Forms.TextBox 联系人数量最大值TextBox;
        private System.Windows.Forms.TextBox 组别数量最大值TextBox;
    }
}

