using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LibraryMIS
{
	/// <summary>
	/// ModifyUser 的摘要说明。
	/// </summary>
	public class ModifyUser : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioWork;
		private System.Windows.Forms.RadioButton radioManage;
		public System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btModify;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private OleDbConnection oleConnection1 = null;

		public ModifyUser()
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
			this.radioWork = new System.Windows.Forms.RadioButton();
			this.radioManage = new System.Windows.Forms.RadioButton();
			this.textName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btClose = new System.Windows.Forms.Button();
			this.btModify = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioWork);
			this.groupBox1.Controls.Add(this.radioManage);
			this.groupBox1.Location = new System.Drawing.Point(24, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(184, 48);
			this.groupBox1.TabIndex = 54;
			this.groupBox1.TabStop = false;
			// 
			// radioWork
			// 
			this.radioWork.Location = new System.Drawing.Point(24, 16);
			this.radioWork.Name = "radioWork";
			this.radioWork.Size = new System.Drawing.Size(64, 24);
			this.radioWork.TabIndex = 1;
			this.radioWork.Text = "工作员";
			// 
			// radioManage
			// 
			this.radioManage.Location = new System.Drawing.Point(96, 16);
			this.radioManage.Name = "radioManage";
			this.radioManage.Size = new System.Drawing.Size(64, 24);
			this.radioManage.TabIndex = 0;
			this.radioManage.Text = "管理员";
			// 
			// textName
			// 
			this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.textName.Location = new System.Drawing.Point(86, 16);
			this.textName.Name = "textName";
			this.textName.ReadOnly = true;
			this.textName.Size = new System.Drawing.Size(120, 21);
			this.textName.TabIndex = 46;
			this.textName.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(22, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 17);
			this.label1.TabIndex = 51;
			this.label1.Text = "用户名称";
			// 
			// btClose
			// 
			this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.btClose.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btClose.Location = new System.Drawing.Point(136, 128);
			this.btClose.Name = "btClose";
			this.btClose.TabIndex = 50;
			this.btClose.Text = "退出";
			// 
			// btModify
			// 
			this.btModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btModify.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.btModify.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btModify.Location = new System.Drawing.Point(24, 128);
			this.btModify.Name = "btModify";
			this.btModify.TabIndex = 49;
			this.btModify.Text = "修改";
			this.btModify.Click += new System.EventHandler(this.btModify_Click);
			// 
			// ModifyUser
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(232, 166);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.btModify);
			this.Name = "ModifyUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "修改权限";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btModify_Click(object sender, System.EventArgs e)
		{
			if (radioManage.Checked==false&&radioWork.Checked==false)
				MessageBox.Show("请选择权限","提示");
			else
			{
				oleConnection1.Open();
				string sql;
				if (radioManage.Checked==true)
					sql = "update manager set manage=true,work=false,query=false where MName='"+textName.Text.Trim()+"'";
				else
					sql = "update manager set manage=false,work=true,query=false where MName='"+textName.Text.Trim()+"'";

				OleDbCommand cmd = new OleDbCommand(sql,oleConnection1);
				cmd.ExecuteNonQuery();
				MessageBox.Show("修改成功","提示");
				this.Close();
				
				oleConnection1.Close();
			}
		}
	}
}
