using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace LibraryMIS
{
	/// <summary>
	/// BookOut 的摘要说明。
	/// </summary>
	public class BookOut : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textPName;
		private System.Windows.Forms.TextBox textPID;
		private System.Windows.Forms.TextBox textMoney;
		private System.Windows.Forms.TextBox textIden;
		private System.Windows.Forms.TextBox textPN;
		private System.Windows.Forms.TextBox textPSex;
		private System.Windows.Forms.Button btOut;
		private System.Windows.Forms.DateTimePicker date1;
		private System.Windows.Forms.TextBox textPrice;
		private System.Windows.Forms.TextBox textBDate;
		private System.Windows.Forms.TextBox textType;
		private System.Windows.Forms.TextBox textPublish;
		private System.Windows.Forms.TextBox textWriter;
		private System.Windows.Forms.TextBox textBName;
		private System.Windows.Forms.TextBox textBID;
		private System.Windows.Forms.DataGrid dataGrid1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.DataGrid dataGrid3;
		private System.Windows.Forms.DataGrid dataGrid4;
		private OleDbConnection oleConnection1 = null;

		public BookOut()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			this.oleConnection1 = new OleDbConnection(LibraryMIS.database.dbConnection.connection);

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textMoney = new System.Windows.Forms.TextBox();
			this.textIden = new System.Windows.Forms.TextBox();
			this.textPN = new System.Windows.Forms.TextBox();
			this.textPSex = new System.Windows.Forms.TextBox();
			this.textPName = new System.Windows.Forms.TextBox();
			this.textPID = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label15 = new System.Windows.Forms.Label();
			this.btOut = new System.Windows.Forms.Button();
			this.date1 = new System.Windows.Forms.DateTimePicker();
			this.label14 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textPrice = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBDate = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textType = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textPublish = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textWriter = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBID = new System.Windows.Forms.TextBox();
			this.dataGrid3 = new System.Windows.Forms.DataGrid();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGrid4 = new System.Windows.Forms.DataGrid();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid4)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textMoney);
			this.groupBox1.Controls.Add(this.textIden);
			this.groupBox1.Controls.Add(this.textPN);
			this.groupBox1.Controls.Add(this.textPSex);
			this.groupBox1.Controls.Add(this.textPName);
			this.groupBox1.Controls.Add(this.textPID);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dataGrid2);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(184, 224);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "借阅者信息";
			// 
			// textMoney
			// 
			this.textMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textMoney.Location = new System.Drawing.Point(72, 192);
			this.textMoney.Name = "textMoney";
			this.textMoney.ReadOnly = true;
			this.textMoney.TabIndex = 11;
			this.textMoney.Text = "";
			// 
			// textIden
			// 
			this.textIden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textIden.Location = new System.Drawing.Point(72, 160);
			this.textIden.Name = "textIden";
			this.textIden.ReadOnly = true;
			this.textIden.TabIndex = 10;
			this.textIden.Text = "";
			// 
			// textPN
			// 
			this.textPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPN.Location = new System.Drawing.Point(72, 128);
			this.textPN.Name = "textPN";
			this.textPN.ReadOnly = true;
			this.textPN.TabIndex = 9;
			this.textPN.Text = "";
			// 
			// textPSex
			// 
			this.textPSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPSex.Location = new System.Drawing.Point(72, 96);
			this.textPSex.Name = "textPSex";
			this.textPSex.ReadOnly = true;
			this.textPSex.TabIndex = 8;
			this.textPSex.Text = "";
			// 
			// textPName
			// 
			this.textPName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPName.Location = new System.Drawing.Point(72, 64);
			this.textPName.Name = "textPName";
			this.textPName.ReadOnly = true;
			this.textPName.TabIndex = 7;
			this.textPName.Text = "";
			// 
			// textPID
			// 
			this.textPID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPID.Location = new System.Drawing.Point(72, 32);
			this.textPID.Name = "textPID";
			this.textPID.TabIndex = 6;
			this.textPID.Text = "";
			this.textPID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPID_KeyDown);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 192);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 16);
			this.label5.TabIndex = 5;
			this.label5.Text = "罚  款";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 160);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 16);
			this.label6.TabIndex = 4;
			this.label6.Text = "身  份";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "身份证";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 16);
			this.label4.TabIndex = 2;
			this.label4.Text = "性  别";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "姓  名";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "借书证号";
			// 
			// dataGrid2
			// 
			this.dataGrid2.AllowSorting = false;
			this.dataGrid2.AlternatingBackColor = System.Drawing.Color.LightGray;
			this.dataGrid2.BackColor = System.Drawing.Color.DarkGray;
			this.dataGrid2.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dataGrid2.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid2.CaptionFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGrid2.CaptionForeColor = System.Drawing.Color.Navy;
			this.dataGrid2.DataMember = "";
			this.dataGrid2.ForeColor = System.Drawing.Color.Black;
			this.dataGrid2.GridLineColor = System.Drawing.Color.Black;
			this.dataGrid2.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dataGrid2.HeaderBackColor = System.Drawing.Color.Silver;
			this.dataGrid2.HeaderForeColor = System.Drawing.Color.Black;
			this.dataGrid2.LinkColor = System.Drawing.Color.Navy;
			this.dataGrid2.Location = new System.Drawing.Point(144, 8);
			this.dataGrid2.Name = "dataGrid2";
			this.dataGrid2.ParentRowsBackColor = System.Drawing.Color.White;
			this.dataGrid2.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGrid2.ReadOnly = true;
			this.dataGrid2.SelectionBackColor = System.Drawing.Color.Navy;
			this.dataGrid2.SelectionForeColor = System.Drawing.Color.White;
			this.dataGrid2.Size = new System.Drawing.Size(40, 24);
			this.dataGrid2.TabIndex = 24;
			this.dataGrid2.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.btOut);
			this.groupBox2.Controls.Add(this.date1);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.groupBox4);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.textBID);
			this.groupBox2.Controls.Add(this.dataGrid3);
			this.groupBox2.Location = new System.Drawing.Point(200, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(360, 224);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "借书";
			// 
			// label15
			// 
			this.label15.ForeColor = System.Drawing.Color.Red;
			this.label15.Location = new System.Drawing.Point(256, 24);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(56, 16);
			this.label15.TabIndex = 24;
			this.label15.Text = "请按回车";
			// 
			// btOut
			// 
			this.btOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btOut.Location = new System.Drawing.Point(240, 184);
			this.btOut.Name = "btOut";
			this.btOut.TabIndex = 23;
			this.btOut.Text = "借出";
			this.btOut.Click += new System.EventHandler(this.btOut_Click);
			// 
			// date1
			// 
			this.date1.Location = new System.Drawing.Point(80, 184);
			this.date1.Name = "date1";
			this.date1.Size = new System.Drawing.Size(112, 21);
			this.date1.TabIndex = 22;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(24, 184);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(56, 16);
			this.label14.TabIndex = 21;
			this.label14.Text = "借书日期";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.textPrice);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.textBDate);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.textType);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.textPublish);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.textWriter);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.textBName);
			this.groupBox4.Location = new System.Drawing.Point(8, 48);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(344, 120);
			this.groupBox4.TabIndex = 13;
			this.groupBox4.TabStop = false;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(192, 88);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(32, 16);
			this.label13.TabIndex = 22;
			this.label13.Text = "价格";
			// 
			// textPrice
			// 
			this.textPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPrice.Location = new System.Drawing.Point(232, 88);
			this.textPrice.Name = "textPrice";
			this.textPrice.ReadOnly = true;
			this.textPrice.TabIndex = 23;
			this.textPrice.Text = "";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(16, 88);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 16);
			this.label12.TabIndex = 20;
			this.label12.Text = "出版日期";
			// 
			// textBDate
			// 
			this.textBDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBDate.Location = new System.Drawing.Point(72, 88);
			this.textBDate.Name = "textBDate";
			this.textBDate.ReadOnly = true;
			this.textBDate.TabIndex = 21;
			this.textBDate.Text = "";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(192, 56);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(32, 16);
			this.label11.TabIndex = 18;
			this.label11.Text = "类型";
			// 
			// textType
			// 
			this.textType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textType.Location = new System.Drawing.Point(232, 56);
			this.textType.Name = "textType";
			this.textType.ReadOnly = true;
			this.textType.TabIndex = 19;
			this.textType.Text = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(16, 56);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 16);
			this.label10.TabIndex = 16;
			this.label10.Text = "出版社";
			// 
			// textPublish
			// 
			this.textPublish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPublish.Location = new System.Drawing.Point(72, 56);
			this.textPublish.Name = "textPublish";
			this.textPublish.ReadOnly = true;
			this.textPublish.TabIndex = 17;
			this.textPublish.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(192, 24);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 16);
			this.label9.TabIndex = 14;
			this.label9.Text = "作者";
			// 
			// textWriter
			// 
			this.textWriter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textWriter.Location = new System.Drawing.Point(232, 24);
			this.textWriter.Name = "textWriter";
			this.textWriter.ReadOnly = true;
			this.textWriter.TabIndex = 15;
			this.textWriter.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 24);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 16);
			this.label8.TabIndex = 12;
			this.label8.Text = "图书名";
			// 
			// textBName
			// 
			this.textBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBName.Location = new System.Drawing.Point(72, 24);
			this.textBName.Name = "textBName";
			this.textBName.ReadOnly = true;
			this.textBName.TabIndex = 13;
			this.textBName.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(48, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 16);
			this.label7.TabIndex = 12;
			this.label7.Text = "图书编号";
			// 
			// textBID
			// 
			this.textBID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBID.Location = new System.Drawing.Point(104, 24);
			this.textBID.Name = "textBID";
			this.textBID.Size = new System.Drawing.Size(136, 21);
			this.textBID.TabIndex = 12;
			this.textBID.Text = "";
			this.textBID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBID_KeyDown);
			// 
			// dataGrid3
			// 
			this.dataGrid3.AllowSorting = false;
			this.dataGrid3.AlternatingBackColor = System.Drawing.Color.LightGray;
			this.dataGrid3.BackColor = System.Drawing.Color.DarkGray;
			this.dataGrid3.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGrid3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dataGrid3.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid3.CaptionFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGrid3.CaptionForeColor = System.Drawing.Color.Navy;
			this.dataGrid3.DataMember = "";
			this.dataGrid3.ForeColor = System.Drawing.Color.Black;
			this.dataGrid3.GridLineColor = System.Drawing.Color.Black;
			this.dataGrid3.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dataGrid3.HeaderBackColor = System.Drawing.Color.Silver;
			this.dataGrid3.HeaderForeColor = System.Drawing.Color.Black;
			this.dataGrid3.LinkColor = System.Drawing.Color.Navy;
			this.dataGrid3.Location = new System.Drawing.Point(312, 8);
			this.dataGrid3.Name = "dataGrid3";
			this.dataGrid3.ParentRowsBackColor = System.Drawing.Color.White;
			this.dataGrid3.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGrid3.ReadOnly = true;
			this.dataGrid3.SelectionBackColor = System.Drawing.Color.Navy;
			this.dataGrid3.SelectionForeColor = System.Drawing.Color.White;
			this.dataGrid3.Size = new System.Drawing.Size(40, 24);
			this.dataGrid3.TabIndex = 25;
			this.dataGrid3.Visible = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGrid4);
			this.groupBox3.Controls.Add(this.dataGrid1);
			this.groupBox3.Location = new System.Drawing.Point(8, 240);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(552, 112);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "已借图书";
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowSorting = false;
			this.dataGrid1.AlternatingBackColor = System.Drawing.Color.LightGray;
			this.dataGrid1.BackColor = System.Drawing.Color.DarkGray;
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGrid1.CaptionForeColor = System.Drawing.Color.Navy;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.ForeColor = System.Drawing.Color.Black;
			this.dataGrid1.GridLineColor = System.Drawing.Color.Black;
			this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dataGrid1.HeaderBackColor = System.Drawing.Color.Silver;
			this.dataGrid1.HeaderForeColor = System.Drawing.Color.Black;
			this.dataGrid1.LinkColor = System.Drawing.Color.Navy;
			this.dataGrid1.Location = new System.Drawing.Point(8, 16);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
			this.dataGrid1.Size = new System.Drawing.Size(536, 88);
			this.dataGrid1.TabIndex = 23;
			// 
			// dataGrid4
			// 
			this.dataGrid4.AllowSorting = false;
			this.dataGrid4.AlternatingBackColor = System.Drawing.Color.LightGray;
			this.dataGrid4.BackColor = System.Drawing.Color.DarkGray;
			this.dataGrid4.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGrid4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dataGrid4.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid4.CaptionFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGrid4.CaptionForeColor = System.Drawing.Color.Navy;
			this.dataGrid4.DataMember = "";
			this.dataGrid4.ForeColor = System.Drawing.Color.Black;
			this.dataGrid4.GridLineColor = System.Drawing.Color.Black;
			this.dataGrid4.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dataGrid4.HeaderBackColor = System.Drawing.Color.Silver;
			this.dataGrid4.HeaderForeColor = System.Drawing.Color.Black;
			this.dataGrid4.LinkColor = System.Drawing.Color.Navy;
			this.dataGrid4.Location = new System.Drawing.Point(272, 16);
			this.dataGrid4.Name = "dataGrid4";
			this.dataGrid4.ParentRowsBackColor = System.Drawing.Color.White;
			this.dataGrid4.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGrid4.ReadOnly = true;
			this.dataGrid4.SelectionBackColor = System.Drawing.Color.Navy;
			this.dataGrid4.SelectionForeColor = System.Drawing.Color.White;
			this.dataGrid4.Size = new System.Drawing.Size(160, 24);
			this.dataGrid4.TabIndex = 24;
			this.dataGrid4.Visible = false;
			// 
			// BookOut
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(568, 358);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "BookOut";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "借书";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid4)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		DataSet ds;
		private void textPID_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData.ToString()=="Enter")
			{
				oleConnection1.Open();
				string sql1 = "select PName as 姓名,PSex as 性别,PN as 身份证,PMoney as 罚款,identity as 身份 "+
					"from person where PID='"+textPID.Text.Trim()+"'";
				string sql3 = "select BID from bookOut where PID = '"+textPID.Text.Trim()+"'";

				OleDbDataAdapter adp = new OleDbDataAdapter(sql1,oleConnection1);	
				OleDbDataAdapter adp3 = new OleDbDataAdapter(sql3,oleConnection1);

				ds = new DataSet();
				ds.Clear();

				adp.Fill(ds,"person");
				adp3.Fill(ds,"bookid");

				dataGrid2.DataSource = ds.Tables["person"].DefaultView;
				dataGrid4.DataSource = ds.Tables["bookid"].DefaultView;

				if (ds.Tables[0].Rows.Count!=0)
				{
					textPName.Text = ds.Tables["person"].Rows[dataGrid2.CurrentCell.RowNumber][0].ToString().Trim();
					textPSex.Text = ds.Tables["person"].Rows[dataGrid2.CurrentCell.RowNumber][1].ToString().Trim();
					textPN.Text = ds.Tables["person"].Rows[dataGrid2.CurrentCell.RowNumber][2].ToString().Trim();
					textMoney.Text = ds.Tables["person"].Rows[dataGrid2.CurrentCell.RowNumber][3].ToString().Trim();
					textIden.Text = ds.Tables["person"].Rows[dataGrid2.CurrentCell.RowNumber][4].ToString().Trim();
					dataGrid2.CaptionText = "共有"+ds.Tables["person"].Rows.Count+"条记录";
				}
				else
					MessageBox.Show("没有该借书证号","提示");

				for (int x=0;x<ds.Tables["bookid"].Rows.Count;x++)
				{
					string sql2="select book.BID as 图书编号,BName as 图书名,BWriter as 作者,BPublish as 出版社,BDate as 出版日期,BPrice as 价格,"+
						"type as 类型,ODate as 借书日期,(select longTime from identityinfo where identity=(select identity from person where PID='"+textPID.Text.Trim()+"'))"+
						" as 最长借书时间,dateAdd('m',最长借书时间,ODate) as 应还日期 from book,bookOut where book.BID=bookOut.BID and book.BID = '"+ds.Tables["bookid"].Rows[x][0]+"'"+
						" and PID='"+textPID.Text.Trim()+"'";
					OleDbDataAdapter adp2 = new OleDbDataAdapter(sql2,oleConnection1);
					adp2.Fill(ds,"bookout");
					dataGrid1.DataSource = ds.Tables["bookout"].DefaultView;
					dataGrid1.CaptionText = "已借图书"+ds.Tables["bookout"].Rows.Count+"本";
				}
				
				oleConnection1.Close();
			}
		}

		private void textBID_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData.ToString()=="Enter")
			{
				oleConnection1.Open();
				string sql = "select BName as 图书名,BWriter as 作者,BPublish as 出版社,BDate as 出版日期,BPrice as 价格,"+
					"type as 类型 from book where BID='"+textBID.Text.Trim()+"'";
				OleDbDataAdapter adp = new OleDbDataAdapter(sql,oleConnection1);
				ds = new DataSet();
				ds.Clear();
				adp.Fill(ds,"book");
				dataGrid3.DataSource = ds.Tables["book"].DefaultView;
				if (ds.Tables[0].Rows.Count!=0)
				{
					textBName.Text = ds.Tables[0].Rows[dataGrid3.CurrentCell.RowNumber][0].ToString().Trim();
					textWriter.Text = ds.Tables[0].Rows[dataGrid3.CurrentCell.RowNumber][1].ToString().Trim();
					textPublish.Text = ds.Tables[0].Rows[dataGrid3.CurrentCell.RowNumber][2].ToString().Trim();
					textBDate.Text = ds.Tables[0].Rows[dataGrid3.CurrentCell.RowNumber][3].ToString().Trim();
					textPrice.Text = ds.Tables[0].Rows[dataGrid3.CurrentCell.RowNumber][4].ToString().Trim();
					textType.Text = ds.Tables[0].Rows[dataGrid3.CurrentCell.RowNumber][5].ToString().Trim();
					dataGrid3.CaptionText = "共有"+ds.Tables["book"].Rows.Count+"条记录";
				}
				else
					MessageBox.Show("没有该图书编号","提示");
				oleConnection1.Close();
			}
		}

		private void btOut_Click(object sender, System.EventArgs e)
		{
			if (textPID.Text.Trim()==""||textBID.Text.Trim()=="")
				MessageBox.Show("请输入完整信息","提示");
			else
			{
				oleConnection1.Open();
				string sql="select * from bookOut where BID='"+textBID.Text.Trim()+"' and PID='"+textPID.Text.Trim()+"'";
				OleDbCommand cmd = new OleDbCommand(sql,oleConnection1);
				if (null!=cmd.ExecuteScalar())
					MessageBox.Show("你已经借了一本该书","提示");
				else
				{
					sql = "insert into bookOut (BID,PID,ODate) values ('"+textBID.Text.Trim()+"','"+textPID.Text.Trim()+"','"+date1.Text.Trim()+"')";
					cmd.CommandText=sql;
					cmd.ExecuteNonQuery();
					MessageBox.Show("借出成功","提示");
				}
				
			}
		}
	}
}
