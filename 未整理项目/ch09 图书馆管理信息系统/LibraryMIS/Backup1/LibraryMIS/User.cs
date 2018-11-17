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
	/// User 的摘要说明。
	/// </summary>
	public class User : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btDel;
		private System.Windows.Forms.Button btModify;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private OleDbConnection oleConnection1 = null;

		public User()
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
			this.label1 = new System.Windows.Forms.Label();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.btClose = new System.Windows.Forms.Button();
			this.btDel = new System.Windows.Forms.Button();
			this.btModify = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("楷体_GB2312", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(152, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 22;
			this.label1.Text = "用 户 列 表";
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
			this.dataGrid1.Location = new System.Drawing.Point(8, 44);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
			this.dataGrid1.Size = new System.Drawing.Size(448, 246);
			this.dataGrid1.TabIndex = 21;
			// 
			// btClose
			// 
			this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btClose.ForeColor = System.Drawing.Color.Black;
			this.btClose.Location = new System.Drawing.Point(472, 208);
			this.btClose.Name = "btClose";
			this.btClose.TabIndex = 25;
			this.btClose.Text = "退出";
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// btDel
			// 
			this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btDel.ForeColor = System.Drawing.Color.Black;
			this.btDel.Location = new System.Drawing.Point(472, 144);
			this.btDel.Name = "btDel";
			this.btDel.TabIndex = 24;
			this.btDel.Text = "删除";
			this.btDel.Click += new System.EventHandler(this.btDel_Click);
			// 
			// btModify
			// 
			this.btModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btModify.ForeColor = System.Drawing.Color.Black;
			this.btModify.Location = new System.Drawing.Point(472, 80);
			this.btModify.Name = "btModify";
			this.btModify.TabIndex = 23;
			this.btModify.Text = "修改";
			this.btModify.Visible = false;
			this.btModify.Click += new System.EventHandler(this.btModify_Click);
			// 
			// User
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(560, 302);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.btDel);
			this.Controls.Add(this.btModify);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGrid1);
			this.Name = "User";
			this.Text = "用户列表";
			this.Load += new System.EventHandler(this.User_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		DataSet ds;
		private void User_Load(object sender, System.EventArgs e)
		{
			oleConnection1.Open();
			string sql = "select MName as 用户名,MCode as 密码,manage as 权限1,work as 权限2,query as 权限3 from manager";
			OleDbDataAdapter adp = new OleDbDataAdapter(sql,oleConnection1);
			ds = new DataSet();
			ds.Clear();
			adp.Fill(ds,"user");
			dataGrid1.DataSource = ds.Tables["user"].DefaultView;
			dataGrid1.CaptionText = "共有"+ds.Tables["user"].Rows.Count+"条记录";
			oleConnection1.Close();
		}

		ModifyUser modifyUser;
		private void btModify_Click(object sender, System.EventArgs e)
		{
			if (dataGrid1.CurrentRowIndex>=0&&dataGrid1.DataSource!=null&&dataGrid1[dataGrid1.CurrentCell]!=null)
			{
				modifyUser = new ModifyUser();
				modifyUser.textName.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim();
				modifyUser.ShowDialog();
			}
		}

		private void btDel_Click(object sender, System.EventArgs e)
		{
			if (dataGrid1.CurrentRowIndex>=0&&dataGrid1.DataSource!=null&&dataGrid1[dataGrid1.CurrentCell]!=null)
			{
				oleConnection1.Open();
				string sql="delete * from manager where MName = '"+ds.Tables["user"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim()+"'";
				OleDbCommand cmd = new OleDbCommand(sql,oleConnection1);
				cmd.ExecuteNonQuery();
				MessageBox.Show("删除用户'"+ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim()+"'成功","提示");
				
				oleConnection1.Close();
			} 
			else
				return;
		}

		private void btClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
