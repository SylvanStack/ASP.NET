namespace RentalSystem
{
    partial class MainForm
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
            this.tbRent = new System.Windows.Forms.TabControl();
            this.tpRent = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRenter = new System.Windows.Forms.TextBox();
            this.btnQueryRent = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.lblrentauto = new System.Windows.Forms.Label();
            this.lvRent = new System.Windows.Forms.ListView();
            this.chNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chYears = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLetting = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCapacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpReturn = new System.Windows.Forms.TabPage();
            this.lvReturn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtRentDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnQueryReturn = new System.Windows.Forms.Button();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Label();
            this.tpAdd = new System.Windows.Forms.TabPage();
            this.txtLoad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLetting = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cobColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutoNum = new System.Windows.Forms.TextBox();
            this.rdoTruck = new System.Windows.Forms.RadioButton();
            this.rdoCar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbRent.SuspendLayout();
            this.tpRent.SuspendLayout();
            this.tpReturn.SuspendLayout();
            this.tpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRent
            // 
            this.tbRent.Controls.Add(this.tpRent);
            this.tbRent.Controls.Add(this.tpReturn);
            this.tbRent.Controls.Add(this.tpAdd);
            this.tbRent.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbRent.Location = new System.Drawing.Point(12, 71);
            this.tbRent.Name = "tbRent";
            this.tbRent.SelectedIndex = 0;
            this.tbRent.Size = new System.Drawing.Size(540, 452);
            this.tbRent.TabIndex = 0;
            // 
            // tpRent
            // 
            this.tpRent.Controls.Add(this.label7);
            this.tpRent.Controls.Add(this.txtRenter);
            this.tpRent.Controls.Add(this.btnQueryRent);
            this.tpRent.Controls.Add(this.btnRent);
            this.tpRent.Controls.Add(this.lblrentauto);
            this.tpRent.Controls.Add(this.lvRent);
            this.tpRent.Location = new System.Drawing.Point(4, 24);
            this.tpRent.Name = "tpRent";
            this.tpRent.Padding = new System.Windows.Forms.Padding(3);
            this.tpRent.Size = new System.Drawing.Size(532, 424);
            this.tpRent.TabIndex = 1;
            this.tpRent.Text = "租车";
            this.tpRent.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 5;
            this.label7.Text = "租用者";
            // 
            // txtRenter
            // 
            this.txtRenter.Location = new System.Drawing.Point(234, 322);
            this.txtRenter.Name = "txtRenter";
            this.txtRenter.Size = new System.Drawing.Size(100, 23);
            this.txtRenter.TabIndex = 4;
            // 
            // btnQueryRent
            // 
            this.btnQueryRent.Location = new System.Drawing.Point(175, 373);
            this.btnQueryRent.Name = "btnQueryRent";
            this.btnQueryRent.Size = new System.Drawing.Size(75, 23);
            this.btnQueryRent.TabIndex = 3;
            this.btnQueryRent.Text = "刷新";
            this.btnQueryRent.UseVisualStyleBackColor = true;
            this.btnQueryRent.Click += new System.EventHandler(this.btnQueryRent_Click);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(259, 373);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 23);
            this.btnRent.TabIndex = 2;
            this.btnRent.Text = "租车";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // lblrentauto
            // 
            this.lblrentauto.AutoSize = true;
            this.lblrentauto.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblrentauto.Location = new System.Drawing.Point(207, 18);
            this.lblrentauto.Name = "lblrentauto";
            this.lblrentauto.Size = new System.Drawing.Size(85, 19);
            this.lblrentauto.TabIndex = 1;
            this.lblrentauto.Text = "可租车辆";
            // 
            // lvRent
            // 
            this.lvRent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNum,
            this.chName,
            this.chColor,
            this.chYears,
            this.chLetting,
            this.chCapacity});
            this.lvRent.Location = new System.Drawing.Point(6, 40);
            this.lvRent.Name = "lvRent";
            this.lvRent.Size = new System.Drawing.Size(508, 263);
            this.lvRent.TabIndex = 0;
            this.lvRent.UseCompatibleStateImageBehavior = false;
            this.lvRent.View = System.Windows.Forms.View.Details;
            // 
            // chNum
            // 
            this.chNum.Text = "车牌号";
            // 
            // chName
            // 
            this.chName.Text = "车名";
            this.chName.Width = 69;
            // 
            // chColor
            // 
            this.chColor.Text = "颜色";
            // 
            // chYears
            // 
            this.chYears.Text = "使用时间";
            this.chYears.Width = 68;
            // 
            // chLetting
            // 
            this.chLetting.Text = "日租金";
            this.chLetting.Width = 76;
            // 
            // chCapacity
            // 
            this.chCapacity.Text = "卡车载重";
            this.chCapacity.Width = 181;
            // 
            // tpReturn
            // 
            this.tpReturn.Controls.Add(this.lvReturn);
            this.tpReturn.Controls.Add(this.txtRentDate);
            this.tpReturn.Controls.Add(this.label8);
            this.tpReturn.Controls.Add(this.btnQueryReturn);
            this.tpReturn.Controls.Add(this.btnCompute);
            this.tpReturn.Controls.Add(this.btnReturn);
            this.tpReturn.Location = new System.Drawing.Point(4, 24);
            this.tpReturn.Name = "tpReturn";
            this.tpReturn.Padding = new System.Windows.Forms.Padding(3);
            this.tpReturn.Size = new System.Drawing.Size(532, 424);
            this.tpReturn.TabIndex = 2;
            this.tpReturn.Text = "还车";
            this.tpReturn.UseVisualStyleBackColor = true;
            // 
            // lvReturn
            // 
            this.lvReturn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvReturn.Location = new System.Drawing.Point(6, 40);
            this.lvReturn.Name = "lvReturn";
            this.lvReturn.Size = new System.Drawing.Size(508, 263);
            this.lvReturn.TabIndex = 10;
            this.lvReturn.UseCompatibleStateImageBehavior = false;
            this.lvReturn.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "车牌号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "车名";
            this.columnHeader2.Width = 69;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "颜色";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "使用时间";
            this.columnHeader4.Width = 68;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "日租金";
            this.columnHeader5.Width = 76;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "卡车载重";
            this.columnHeader6.Width = 181;
            // 
            // txtRentDate
            // 
            this.txtRentDate.Location = new System.Drawing.Point(233, 326);
            this.txtRentDate.Name = "txtRentDate";
            this.txtRentDate.Size = new System.Drawing.Size(100, 23);
            this.txtRentDate.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 14);
            this.label8.TabIndex = 8;
            this.label8.Text = "租用天数";
            // 
            // btnQueryReturn
            // 
            this.btnQueryReturn.Location = new System.Drawing.Point(163, 376);
            this.btnQueryReturn.Name = "btnQueryReturn";
            this.btnQueryReturn.Size = new System.Drawing.Size(75, 23);
            this.btnQueryReturn.TabIndex = 4;
            this.btnQueryReturn.Text = "刷新";
            this.btnQueryReturn.UseVisualStyleBackColor = true;
            this.btnQueryReturn.Click += new System.EventHandler(this.btnQueryReturn_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(244, 376);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 2;
            this.btnCompute.Text = "选择结算";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = true;
            this.btnReturn.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturn.Location = new System.Drawing.Point(229, 18);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(47, 19);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "结算";
            // 
            // tpAdd
            // 
            this.tpAdd.Controls.Add(this.txtLoad);
            this.tpAdd.Controls.Add(this.label6);
            this.tpAdd.Controls.Add(this.btnAdd);
            this.tpAdd.Controls.Add(this.label5);
            this.tpAdd.Controls.Add(this.txtLetting);
            this.tpAdd.Controls.Add(this.txtYears);
            this.tpAdd.Controls.Add(this.label4);
            this.tpAdd.Controls.Add(this.cobColor);
            this.tpAdd.Controls.Add(this.label3);
            this.tpAdd.Controls.Add(this.txtName);
            this.tpAdd.Controls.Add(this.label2);
            this.tpAdd.Controls.Add(this.txtAutoNum);
            this.tpAdd.Controls.Add(this.rdoTruck);
            this.tpAdd.Controls.Add(this.rdoCar);
            this.tpAdd.Controls.Add(this.label1);
            this.tpAdd.Location = new System.Drawing.Point(4, 24);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdd.Size = new System.Drawing.Size(532, 424);
            this.tpAdd.TabIndex = 0;
            this.tpAdd.Text = "新车入库";
            this.tpAdd.UseVisualStyleBackColor = true;
            // 
            // txtLoad
            // 
            this.txtLoad.Location = new System.Drawing.Point(267, 326);
            this.txtLoad.Name = "txtLoad";
            this.txtLoad.Size = new System.Drawing.Size(148, 23);
            this.txtLoad.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(123, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "卡车载重";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(213, 377);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "入库";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "每日租金";
            // 
            // txtLetting
            // 
            this.txtLetting.Location = new System.Drawing.Point(267, 278);
            this.txtLetting.Name = "txtLetting";
            this.txtLetting.Size = new System.Drawing.Size(148, 23);
            this.txtLetting.TabIndex = 10;
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(267, 223);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(148, 23);
            this.txtYears.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "使用时间";
            // 
            // cobColor
            // 
            this.cobColor.FormattingEnabled = true;
            this.cobColor.Items.AddRange(new object[] {
            "红色",
            "蓝色",
            "银灰色",
            "白色",
            "黑色",
            "香槟色",
            "绿色"});
            this.cobColor.Location = new System.Drawing.Point(267, 168);
            this.cobColor.Name = "cobColor";
            this.cobColor.Size = new System.Drawing.Size(148, 22);
            this.cobColor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "颜色";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(267, 116);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 23);
            this.txtName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "车型";
            // 
            // txtAutoNum
            // 
            this.txtAutoNum.Location = new System.Drawing.Point(267, 62);
            this.txtAutoNum.Name = "txtAutoNum";
            this.txtAutoNum.Size = new System.Drawing.Size(148, 23);
            this.txtAutoNum.TabIndex = 3;
            // 
            // rdoTruck
            // 
            this.rdoTruck.AutoSize = true;
            this.rdoTruck.Location = new System.Drawing.Point(244, 23);
            this.rdoTruck.Name = "rdoTruck";
            this.rdoTruck.Size = new System.Drawing.Size(53, 18);
            this.rdoTruck.TabIndex = 2;
            this.rdoTruck.Text = "卡车";
            this.rdoTruck.UseVisualStyleBackColor = true;
            this.rdoTruck.CheckedChanged += new System.EventHandler(this.rdoTruck_CheckedChanged);
            // 
            // rdoCar
            // 
            this.rdoCar.AutoSize = true;
            this.rdoCar.Checked = true;
            this.rdoCar.Location = new System.Drawing.Point(185, 23);
            this.rdoCar.Name = "rdoCar";
            this.rdoCar.Size = new System.Drawing.Size(53, 18);
            this.rdoCar.TabIndex = 1;
            this.rdoCar.TabStop = true;
            this.rdoCar.Text = "轿车";
            this.rdoCar.UseVisualStyleBackColor = true;
            this.rdoCar.CheckedChanged += new System.EventHandler(this.rdoCar_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "车牌号";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(186, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "汽车租赁系统";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(477, 538);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 573);
            this.Controls.Add(this.tbRent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "汽车租赁系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tbRent.ResumeLayout(false);
            this.tpRent.ResumeLayout(false);
            this.tpRent.PerformLayout();
            this.tpReturn.ResumeLayout(false);
            this.tpReturn.PerformLayout();
            this.tpAdd.ResumeLayout(false);
            this.tpAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbRent;
        private System.Windows.Forms.TabPage tpAdd;
        private System.Windows.Forms.TabPage tpRent;
        private System.Windows.Forms.TabPage tpReturn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoTruck;
        private System.Windows.Forms.RadioButton rdoCar;
        private System.Windows.Forms.TextBox txtAutoNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cobColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLetting;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblrentauto;
        private System.Windows.Forms.ListView lvRent;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label btnReturn;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtLoad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnQueryRent;
        private System.Windows.Forms.Button btnQueryReturn;
        private System.Windows.Forms.ColumnHeader chNum;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chColor;
        private System.Windows.Forms.ColumnHeader chYears;
        private System.Windows.Forms.ColumnHeader chLetting;
        private System.Windows.Forms.TextBox txtRenter;
        private System.Windows.Forms.ColumnHeader chCapacity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRentDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lvReturn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

