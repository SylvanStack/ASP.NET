using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LibraryMIS
{
	/// <summary>
	/// AddUser 的摘要说明。
	/// </summary>
	public class AddUser : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textPWDNew;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textPassword;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioManage;
		private System.Windows.Forms.RadioButton radioWork;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private OleDbConnection oleConnection1 = null;

		public AddUser()
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
			this.textPWDNew = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textPassword = new System.Windows.Forms.TextBox();
			this.textName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btClose = new System.Windows.Forms.Button();
			this.btAdd = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioManage = new System.Windows.Forms.RadioButton();
			this.radioWork = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textPWDNew
			// 
			this.textPWDNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPWDNew.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textPWDNew.ForeColor = System.Drawing.SystemColors.ControlText;
			this.textPWDNew.Location = new System.Drawing.Point(87, 97);
			this.textPWDNew.Name = "textPWDNew";
			this.textPWDNew.PasswordChar = '*';
			this.textPWDNew.Size = new System.Drawing.Size(120, 21);
			this.textPWDNew.TabIndex = 38;
			this.textPWDNew.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(23, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 17);
			this.label3.TabIndex = 44;
			this.label3.Text = "密码确认";
			// 
			// textPassword
			// 
			this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textPassword.ForeColor = System.Drawing.SystemColors.ControlText;
			this.textPassword.Location = new System.Drawing.Point(87, 57);
			this.textPassword.Name = "textPassword";
			this.textPassword.PasswordChar = '*';
			this.textPassword.Size = new System.Drawing.Size(120, 21);
			this.textPassword.TabIndex = 37;
			this.textPassword.Text = "";
			// 
			// textName
			// 
			this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.textName.Location = new System.Drawing.Point(87, 17);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(120, 21);
			this.textName.TabIndex = 36;
			this.textName.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(23, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 17);
			this.label2.TabIndex = 43;
			this.label2.Text = "密    码";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(23, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 17);
			this.label1.TabIndex = 42;
			this.label1.Text = "用户名称";
			// 
			// btClose
			// 
			this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.btClose.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btClose.Location = new System.Drawing.Point(136, 192);
			this.btClose.Name = "btClose";
			this.btClose.TabIndex = 41;
			this.btClose.Text = "退出";
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// btAdd
			// 
			this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btAdd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.btAdd.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btAdd.Location = new System.Drawing.Point(24, 192);
			this.btAdd.Name = "btAdd";
			this.btAdd.TabIndex = 40;
			this.btAdd.Text = "添加";
			this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioWork);
			this.groupBox1.Controls.Add(this.radioManage);
			this.groupBox1.Location = new System.Drawing.Point(24, 128);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(184, 48);
			this.groupBox1.TabIndex = 45;
			this.groupBox1.TabStop = false;
			// 
			// radioManage
			// 
			this.radioManage.Location = new System.Drawing.Point(96, 16);
			this.radioManage.Name = "radioManage";
			this.radioManage.Size = new System.Drawing.Size(64, 24);
			this.radioManage.TabIndex = 0;
			this.radioManage.Text = "管理员";
			// 
			// radioWork
			// 
			this.radioWork.Location = new System.Drawing.Point(24, 16);
			this.radioWork.Name = "radioWork";
			this.radioWork.Size = new System.Drawing.Size(64, 24);
			this.radioWork.TabIndex = 1;
			this.radioWork.Text = "工作员";
			// 
			// AddUser
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(232, 230);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textPWDNew);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textPassword);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.btAdd);
			this.Name = "AddUser";
			this.Text = "添加用户";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btAdd_Click(object sender, System.EventArgs e)
		{
			if (textName.Text.Trim()==""||textPassword.Text.Trim()==""||textPWDNew.Text.Trim()==""||radioManage.Checked==false&&radioWork.Checked==false)
			{
				MessageBox.Show("请输入完整信息！","警告");
			} 
			else
			{
				if (textPassword.Text.Trim()!=textPWDNew.Text.Trim())
				{
					MessageBox.Show("两次密码输入不一致！","警告");
				} 
				else
				{
					oleConnection1.Open();
					OleDbCommand cmd = new OleDbCommand("",oleConnection1);
					string sql = "select * from manager where MName = '"+textName.Text.Trim()+"'";
					cmd.CommandText = sql;

					if (null == cmd.ExecuteScalar())
					{
						if (radioManage.Checked==true)
							sql =  "insert into manager "+
								"values ('"+textName.Text.Trim()+"','"+textPWDNew.Text.Trim()+"',true,false,false)";
						else
							sql =  "insert into manager "+
								"values ('"+textName.Text.Trim()+"','"+textPWDNew.Text.Trim()+"',false,true,false)";
						
						cmd.CommandText = sql;
						cmd.ExecuteNonQuery();
						MessageBox.Show("添加用户成功！","提示");
						this.Close();
					} 
					else
					{
						MessageBox.Show("用户名"+textName.Text.Trim()+"已经存在！","提示");
						textPWDNew.Text = "";
						textPassword.Text="";
					}
						
					oleConnection1.Close();
				}
				
			}
		}

		private void btClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
