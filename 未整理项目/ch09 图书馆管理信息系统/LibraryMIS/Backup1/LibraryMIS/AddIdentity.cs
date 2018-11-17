using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LibraryMIS
{
	/// <summary>
	/// AddIdentity 的摘要说明。
	/// </summary>
	public class AddIdentity : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox textId;
		private System.Windows.Forms.ComboBox comboDate;
		private System.Windows.Forms.ComboBox comboNum;
		private OleDbConnection oleConnection1 = null;

		public AddIdentity()
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
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboNum = new System.Windows.Forms.ComboBox();
			this.comboDate = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btClose
			// 
			this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btClose.ForeColor = System.Drawing.Color.Black;
			this.btClose.Location = new System.Drawing.Point(136, 176);
			this.btClose.Name = "btClose";
			this.btClose.TabIndex = 9;
			this.btClose.Text = "取消";
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// btAdd
			// 
			this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btAdd.ForeColor = System.Drawing.Color.Black;
			this.btAdd.Location = new System.Drawing.Point(32, 176);
			this.btAdd.Name = "btAdd";
			this.btAdd.TabIndex = 8;
			this.btAdd.Text = "确定";
			this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.comboNum);
			this.groupBox1.Controls.Add(this.comboDate);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textId);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("楷体_GB2312", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(8, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(232, 152);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "添加身份";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(192, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 15);
			this.label5.TabIndex = 6;
			this.label5.Text = "本";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(192, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 15);
			this.label4.TabIndex = 5;
			this.label4.Text = "月";
			// 
			// comboNum
			// 
			this.comboNum.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.comboNum.Items.AddRange(new object[] {
														  "5",
														  "10",
														  "15",
														  "20"});
			this.comboNum.Location = new System.Drawing.Point(112, 120);
			this.comboNum.Name = "comboNum";
			this.comboNum.Size = new System.Drawing.Size(80, 20);
			this.comboNum.TabIndex = 4;
			// 
			// comboDate
			// 
			this.comboDate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.comboDate.Items.AddRange(new object[] {
														   "1",
														   "2",
														   "3",
														   "4",
														   "5",
														   "6"});
			this.comboDate.Location = new System.Drawing.Point(112, 80);
			this.comboDate.Name = "comboDate";
			this.comboDate.Size = new System.Drawing.Size(80, 20);
			this.comboDate.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label3.Location = new System.Drawing.Point(32, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "最大借阅数量";
			// 
			// textId
			// 
			this.textId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textId.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textId.Location = new System.Drawing.Point(112, 40);
			this.textId.Name = "textId";
			this.textId.Size = new System.Drawing.Size(96, 21);
			this.textId.TabIndex = 1;
			this.textId.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label2.Location = new System.Drawing.Point(32, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "最长借阅时间";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(40, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "身   份";
			// 
			// AddIdentity
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(248, 214);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.btAdd);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddIdentity";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "添加身份";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btAdd_Click(object sender, System.EventArgs e)
		{
			if (textId.Text.Trim()==""||comboNum.Text.Trim()==""||comboDate.Text.Trim()=="")
				MessageBox.Show("请填写完整信息","提示");
			else
			{
				oleConnection1.Open();
				string sql="select * from identityinfo where identity='"+textId.Text.Trim()+"'";
				OleDbCommand cmd = new OleDbCommand(sql,oleConnection1);
				if (null!=cmd.ExecuteScalar())
					MessageBox.Show("身份重复","提示");
				else
				{
					sql="insert into identityinfo values ('"+textId.Text.Trim()+"',"+comboDate.Text.Trim()+","+comboNum.Text.Trim()+")";
					cmd.CommandText = sql;
					cmd.ExecuteNonQuery();
					MessageBox.Show("添加成功","提示");
					textId.Text="";
					comboDate.Text="";
					comboNum.Text="";
				}
				oleConnection1.Close();
			}
		}

		private void btClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
