using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LibraryMIS
{
	/// <summary>
	/// ModifyBook 的摘要说明。
	/// </summary>
	public class ModifyBook : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.DateTimePicker date1;
		public System.Windows.Forms.TextBox textPrice;
		public System.Windows.Forms.TextBox textNum;
		public System.Windows.Forms.TextBox textPublish;
		public System.Windows.Forms.TextBox textWriter;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox textRemark;
		public System.Windows.Forms.TextBox textID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox textType;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private OleDbConnection oleConnection1 = null;

		public ModifyBook()
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
			this.btClose = new System.Windows.Forms.Button();
			this.btAdd = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textType = new System.Windows.Forms.TextBox();
			this.date1 = new System.Windows.Forms.DateTimePicker();
			this.textPrice = new System.Windows.Forms.TextBox();
			this.textNum = new System.Windows.Forms.TextBox();
			this.textPublish = new System.Windows.Forms.TextBox();
			this.textWriter = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textRemark = new System.Windows.Forms.TextBox();
			this.textID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btClose
			// 
			this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btClose.ForeColor = System.Drawing.Color.Black;
			this.btClose.Location = new System.Drawing.Point(328, 240);
			this.btClose.Name = "btClose";
			this.btClose.TabIndex = 9;
			this.btClose.Text = "取消";
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// btAdd
			// 
			this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btAdd.ForeColor = System.Drawing.Color.Black;
			this.btAdd.Location = new System.Drawing.Point(112, 240);
			this.btAdd.Name = "btAdd";
			this.btAdd.TabIndex = 8;
			this.btAdd.Text = "确定";
			this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textType);
			this.groupBox1.Controls.Add(this.date1);
			this.groupBox1.Controls.Add(this.textPrice);
			this.groupBox1.Controls.Add(this.textNum);
			this.groupBox1.Controls.Add(this.textPublish);
			this.groupBox1.Controls.Add(this.textWriter);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textName);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textRemark);
			this.groupBox1.Controls.Add(this.textID);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("楷体_GB2312", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(8, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(496, 216);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "修改图书";
			// 
			// textType
			// 
			this.textType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textType.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textType.Location = new System.Drawing.Point(384, 80);
			this.textType.Name = "textType";
			this.textType.ReadOnly = true;
			this.textType.TabIndex = 11;
			this.textType.Text = "";
			// 
			// date1
			// 
			this.date1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.date1.Location = new System.Drawing.Point(72, 80);
			this.date1.Name = "date1";
			this.date1.Size = new System.Drawing.Size(100, 21);
			this.date1.TabIndex = 3;
			this.date1.Value = new System.DateTime(2007, 8, 23, 0, 0, 0, 0);
			// 
			// textPrice
			// 
			this.textPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPrice.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textPrice.Location = new System.Drawing.Point(232, 120);
			this.textPrice.Name = "textPrice";
			this.textPrice.TabIndex = 6;
			this.textPrice.Text = "";
			// 
			// textNum
			// 
			this.textNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textNum.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textNum.Location = new System.Drawing.Point(72, 120);
			this.textNum.Name = "textNum";
			this.textNum.TabIndex = 5;
			this.textNum.Text = "";
			// 
			// textPublish
			// 
			this.textPublish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPublish.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textPublish.Location = new System.Drawing.Point(232, 80);
			this.textPublish.Name = "textPublish";
			this.textPublish.TabIndex = 4;
			this.textPublish.Text = "";
			// 
			// textWriter
			// 
			this.textWriter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textWriter.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textWriter.Location = new System.Drawing.Point(384, 40);
			this.textWriter.Name = "textWriter";
			this.textWriter.TabIndex = 2;
			this.textWriter.Text = "";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label9.Location = new System.Drawing.Point(352, 80);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 16);
			this.label9.TabIndex = 10;
			this.label9.Text = "类型";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label8.Location = new System.Drawing.Point(16, 120);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 16);
			this.label8.TabIndex = 9;
			this.label8.Text = "数   量";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label7.Location = new System.Drawing.Point(192, 120);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 16);
			this.label7.TabIndex = 8;
			this.label7.Text = "价 格";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label6.Location = new System.Drawing.Point(192, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 16);
			this.label6.TabIndex = 7;
			this.label6.Text = "出版社";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label5.Location = new System.Drawing.Point(16, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 16);
			this.label5.TabIndex = 6;
			this.label5.Text = "出版日期";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label4.Location = new System.Drawing.Point(352, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "作者";
			// 
			// textName
			// 
			this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textName.Location = new System.Drawing.Point(232, 40);
			this.textName.Name = "textName";
			this.textName.TabIndex = 1;
			this.textName.Text = "";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label3.Location = new System.Drawing.Point(192, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "图书名";
			// 
			// textRemark
			// 
			this.textRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRemark.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textRemark.Location = new System.Drawing.Point(72, 160);
			this.textRemark.Multiline = true;
			this.textRemark.Name = "textRemark";
			this.textRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textRemark.Size = new System.Drawing.Size(408, 48);
			this.textRemark.TabIndex = 7;
			this.textRemark.Text = "";
			// 
			// textID
			// 
			this.textID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textID.Location = new System.Drawing.Point(72, 40);
			this.textID.Name = "textID";
			this.textID.ReadOnly = true;
			this.textID.TabIndex = 1;
			this.textID.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label2.Location = new System.Drawing.Point(16, 168);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "备   注";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(16, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "图书编号";
			// 
			// ModifyBook
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(512, 278);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.btAdd);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ModifyBook";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "修改图书";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btAdd_Click(object sender, System.EventArgs e)
		{
			if (textName.Text.Trim()==""||textWriter.Text.Trim()==""||textNum.Text.Trim()=="")
				MessageBox.Show("请填写完整信息","提示");
			else
			{
				oleConnection1.Open();
				string sql = "update book set BName='"+textName.Text.Trim()+"',BWriter='"+textWriter.Text.Trim()+"',BPublish='"+textPublish.Text.Trim()+"',"+ 
					"BDate='"+date1.Text.Trim()+"',BNum='"+textNum.Text.Trim()+"',BPrice='"+textPrice.Text.Trim()+"',BRemark='"+textRemark.Text.Trim()+"'"+
					" where BID='"+textID.Text.Trim()+"'";
				OleDbCommand cmd = new OleDbCommand(sql,oleConnection1);
				cmd.ExecuteNonQuery();
				MessageBox.Show("修改成功","提示");
				this.Close();
				oleConnection1.Close();
			}
		}

		private void btClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
