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
	/// Person 的摘要说明。
	/// </summary>
	public class Person : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btDel;
		private System.Windows.Forms.Button btModify;
		private System.Windows.Forms.DataGrid dataGrid1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private OleDbConnection oleConnection1 = null;

		public Person()
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
			this.btAdd = new System.Windows.Forms.Button();
			this.btClose = new System.Windows.Forms.Button();
			this.btDel = new System.Windows.Forms.Button();
			this.btModify = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("楷体_GB2312", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(155, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 24);
			this.label1.TabIndex = 26;
			this.label1.Text = "借 阅 者 信 息";
			// 
			// btAdd
			// 
			this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btAdd.ForeColor = System.Drawing.Color.Black;
			this.btAdd.Location = new System.Drawing.Point(475, 60);
			this.btAdd.Name = "btAdd";
			this.btAdd.TabIndex = 25;
			this.btAdd.Text = "添加";
			this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
			// 
			// btClose
			// 
			this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btClose.ForeColor = System.Drawing.Color.Black;
			this.btClose.Location = new System.Drawing.Point(475, 252);
			this.btClose.Name = "btClose";
			this.btClose.TabIndex = 24;
			this.btClose.Text = "退出";
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// btDel
			// 
			this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btDel.ForeColor = System.Drawing.Color.Black;
			this.btDel.Location = new System.Drawing.Point(475, 188);
			this.btDel.Name = "btDel";
			this.btDel.TabIndex = 23;
			this.btDel.Text = "删除";
			this.btDel.Click += new System.EventHandler(this.btDel_Click);
			// 
			// btModify
			// 
			this.btModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btModify.ForeColor = System.Drawing.Color.Black;
			this.btModify.Location = new System.Drawing.Point(475, 124);
			this.btModify.Name = "btModify";
			this.btModify.TabIndex = 22;
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
			this.dataGrid1.Location = new System.Drawing.Point(11, 44);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
			this.dataGrid1.Size = new System.Drawing.Size(448, 246);
			this.dataGrid1.TabIndex = 21;
			// 
			// Person
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
			this.Name = "Person";
			this.Text = "借阅者信息";
			this.Load += new System.EventHandler(this.Person_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		DataSet ds;
		private void Person_Load(object sender, System.EventArgs e)
		{
			oleConnection1.Open();
			string sql = "select PID as 借书证编号,PName as 姓名,PSex as 性别,PPhone as 电话,PN as 身份证,PCode as 密码,"+
				"PMoney as 罚款,identity as 身份,PRemark as 备注 from person";
			OleDbDataAdapter adp = new OleDbDataAdapter(sql,oleConnection1);
			ds = new DataSet();
			ds.Clear();
			adp.Fill(ds,"person");
			dataGrid1.DataSource = ds.Tables["person"].DefaultView;
			dataGrid1.CaptionText = "共有"+ds.Tables["person"].Rows.Count+"条记录";
			oleConnection1.Close();
		}

		AddPerson addPerson;
		private void btAdd_Click(object sender, System.EventArgs e)
		{
			addPerson = new AddPerson();
			addPerson.ShowDialog();
		}

		ModifyPerson modifyPerson;
		private void btModify_Click(object sender, System.EventArgs e)
		{
			if (dataGrid1.DataSource!=null || dataGrid1[dataGrid1.CurrentCell]!=null)
			{
				modifyPerson = new ModifyPerson();
				modifyPerson.textID.Text = ds.Tables["person"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim();
				modifyPerson.textName.Text = ds.Tables["person"].Rows[dataGrid1.CurrentCell.RowNumber][1].ToString().Trim();
				modifyPerson.comboSex.Text = ds.Tables["person"].Rows[dataGrid1.CurrentCell.RowNumber][2].ToString().Trim();
				modifyPerson.textPhone.Text = ds.Tables["person"].Rows[dataGrid1.CurrentCell.RowNumber][3].ToString().Trim();
				modifyPerson.textPN.Text = ds.Tables["person"].Rows[dataGrid1.CurrentCell.RowNumber][4].ToString().Trim();
				modifyPerson.textCode.Text = ds.Tables["person"].Rows[dataGrid1.CurrentCell.RowNumber][5].ToString().Trim();
				modifyPerson.textMoney.Text = ds.Tables["person"].Rows[dataGrid1.CurrentCell.RowNumber][6].ToString().Trim();
				modifyPerson.textiden.Text = ds.Tables["person"].Rows[dataGrid1.CurrentCell.RowNumber][7].ToString().Trim();
				modifyPerson.textRemark.Text = ds.Tables["person"].Rows[dataGrid1.CurrentCell.RowNumber][8].ToString().Trim();
				modifyPerson.Show();
			} 
			else
				MessageBox.Show("没有指定信息！","提示");
		}

		private void btDel_Click(object sender, System.EventArgs e)
		{
			if (dataGrid1.CurrentRowIndex>=0&&dataGrid1.DataSource!=null&&dataGrid1[dataGrid1.CurrentCell]!=null)
			{
				oleConnection1.Open();
				string sql="delete * from person where PID='"+ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim()+"'";
				OleDbCommand cmd = new OleDbCommand(sql,oleConnection1);
				cmd.ExecuteNonQuery();
				MessageBox.Show("删除借阅者'"+ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][1].ToString().Trim()+"'成功","提示");
				
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
