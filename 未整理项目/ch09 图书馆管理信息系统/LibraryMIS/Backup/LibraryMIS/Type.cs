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
	/// Type 的摘要说明。
	/// </summary>
	public class Type : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btDel;
		private System.Windows.Forms.Button btModify;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button btAdd;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label1;
		private OleDbConnection oleConnection1 = null;

		public Type()
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
			this.btDel = new System.Windows.Forms.Button();
			this.btModify = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.btAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// btClose
			// 
			this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btClose.ForeColor = System.Drawing.Color.Black;
			this.btClose.Location = new System.Drawing.Point(472, 256);
			this.btClose.Name = "btClose";
			this.btClose.TabIndex = 18;
			this.btClose.Text = "退出";
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// btDel
			// 
			this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btDel.ForeColor = System.Drawing.Color.Black;
			this.btDel.Location = new System.Drawing.Point(472, 192);
			this.btDel.Name = "btDel";
			this.btDel.TabIndex = 17;
			this.btDel.Text = "删除";
			this.btDel.Click += new System.EventHandler(this.btDel_Click);
			// 
			// btModify
			// 
			this.btModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btModify.ForeColor = System.Drawing.Color.Black;
			this.btModify.Location = new System.Drawing.Point(472, 128);
			this.btModify.Name = "btModify";
			this.btModify.TabIndex = 16;
			this.btModify.Text = "修改";
			this.btModify.Click += new System.EventHandler(this.btModify_Click);
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
			this.dataGrid1.Location = new System.Drawing.Point(8, 48);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
			this.dataGrid1.Size = new System.Drawing.Size(448, 246);
			this.dataGrid1.TabIndex = 15;
			// 
			// btAdd
			// 
			this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btAdd.ForeColor = System.Drawing.Color.Black;
			this.btAdd.Location = new System.Drawing.Point(472, 64);
			this.btAdd.Name = "btAdd";
			this.btAdd.TabIndex = 19;
			this.btAdd.Text = "添加";
			this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("楷体_GB2312", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(152, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 20;
			this.label1.Text = "图 书 类 型";
			// 
			// Type
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(560, 302);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btAdd);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.btDel);
			this.Controls.Add(this.btModify);
			this.Controls.Add(this.dataGrid1);
			this.Name = "Type";
			this.Text = "图书类型";
			this.Load += new System.EventHandler(this.Type_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		DataSet ds;
		private void Type_Load(object sender, System.EventArgs e)
		{
			oleConnection1.Open();
			string sql = "select type as 类型,tRemark as 类型描述,TID as 类型编号 from type";
			OleDbDataAdapter adp = new OleDbDataAdapter(sql,oleConnection1);
			ds = new DataSet();
			ds.Clear();
			adp.Fill(ds,"type");
			dataGrid1.DataSource = ds.Tables["type"].DefaultView;
			dataGrid1.CaptionText = "共有"+ds.Tables["type"].Rows.Count+"条记录";
			oleConnection1.Close();
		}

		AddType addType;
		private void btAdd_Click(object sender, System.EventArgs e)
		{
			addType = new AddType();
			addType.ShowDialog();
		}

		ModifyType modifyType;
		private void btModify_Click(object sender, System.EventArgs e)
		{
			if (dataGrid1.DataSource != null || dataGrid1[dataGrid1.CurrentCell] != null)
			{
				modifyType = new ModifyType();
				modifyType.textName.Text=ds.Tables["type"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim();
				modifyType.textRemark.Text=ds.Tables["type"].Rows[dataGrid1.CurrentCell.RowNumber][1].ToString().Trim();
				modifyType.Tag=ds.Tables["type"].Rows[dataGrid1.CurrentCell.RowNumber][2].ToString().Trim();
				modifyType.Show();
			}
			else
				MessageBox.Show("没有指定类型信息！","提示");
		}

		private void btDel_Click(object sender, System.EventArgs e)
		{
			if (dataGrid1.CurrentRowIndex>=0&&dataGrid1.DataSource!=null&&dataGrid1[dataGrid1.CurrentCell]!=null)
			{
				oleConnection1.Open();
				string sql="select * from book where type='"+ds.Tables["type"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim()+"'";
				OleDbCommand cmd = new OleDbCommand(sql,oleConnection1);
				OleDbDataReader dr;
				dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					MessageBox.Show("删除类型'"+ds.Tables["type"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim()+"'失败，请先删掉该类型图书！","提示");
					dr.Close();
				} 
				else
				{
					dr.Close();
					sql = "delete * from type where type not in(select distinct type from book) and TID "+
						"= "+ds.Tables["type"].Rows[dataGrid1.CurrentCell.RowNumber][2].ToString().Trim()+"";
					cmd.CommandText = sql;
					cmd.ExecuteNonQuery();
					MessageBox.Show("删除类型'"+ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim()+"'成功","提示");
				}
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
