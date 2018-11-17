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
	/// BookQuery 的摘要说明。
	/// </summary>
	public class BookQuery : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textID;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.TextBox textWriter;
		private System.Windows.Forms.Button btQuery;
		private System.Windows.Forms.Button btClear;
		private System.Windows.Forms.Button btClose;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private OleDbConnection oleConnection1 = null;

		public BookQuery()
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
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.label9 = new System.Windows.Forms.Label();
			this.textID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textWriter = new System.Windows.Forms.TextBox();
			this.btQuery = new System.Windows.Forms.Button();
			this.btClear = new System.Windows.Forms.Button();
			this.btClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
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
			this.dataGrid1.Location = new System.Drawing.Point(8, 80);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
			this.dataGrid1.Size = new System.Drawing.Size(568, 224);
			this.dataGrid1.TabIndex = 21;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(55, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 16);
			this.label9.TabIndex = 22;
			this.label9.Text = "图书编号";
			// 
			// textID
			// 
			this.textID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textID.Location = new System.Drawing.Point(111, 16);
			this.textID.Name = "textID";
			this.textID.TabIndex = 23;
			this.textID.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(223, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 24;
			this.label1.Text = "图书名";
			// 
			// textName
			// 
			this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textName.Location = new System.Drawing.Point(272, 16);
			this.textName.Name = "textName";
			this.textName.TabIndex = 25;
			this.textName.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(384, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 16);
			this.label2.TabIndex = 26;
			this.label2.Text = "作者";
			// 
			// textWriter
			// 
			this.textWriter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textWriter.Location = new System.Drawing.Point(416, 16);
			this.textWriter.Name = "textWriter";
			this.textWriter.TabIndex = 27;
			this.textWriter.Text = "";
			// 
			// btQuery
			// 
			this.btQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btQuery.Location = new System.Drawing.Point(104, 48);
			this.btQuery.Name = "btQuery";
			this.btQuery.TabIndex = 28;
			this.btQuery.Text = "查询";
			this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
			// 
			// btClear
			// 
			this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btClear.Location = new System.Drawing.Point(240, 48);
			this.btClear.Name = "btClear";
			this.btClear.TabIndex = 29;
			this.btClear.Text = "清空";
			this.btClear.Click += new System.EventHandler(this.btClear_Click);
			// 
			// btClose
			// 
			this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btClose.Location = new System.Drawing.Point(384, 48);
			this.btClose.Name = "btClose";
			this.btClose.TabIndex = 30;
			this.btClose.Text = "退出";
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// BookQuery
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(582, 316);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.btClear);
			this.Controls.Add(this.btQuery);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textWriter);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.textID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dataGrid1);
			this.Name = "BookQuery";
			this.Text = "图书查询";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btQuery_Click(object sender, System.EventArgs e)
		{
			string sql1 = "(BNum-(select count(*) from bookOut where ";
			string sql = "select BID as 图书编号,BName as 图书名,BWriter as 作者,BPublish as 出版社,BDate as 出版日期,BPrice as 价格,"+
				"BNum as 数量,type as 类型,BRemark as 备注, ";
			if (textID.Text.Trim() != "")
			{
				sql1 = sql1+" BID= "+"'"+textID.Text.Trim()+"')) as 库存数量 ";
				sql = sql+sql1+"from book where BID= "+"'"+textID.Text.Trim()+"'";
			}	
			else if (textName.Text.Trim() != "")
			{
				sql1 = sql1+" BID=(select BID from book where BName='"+textName.Text+"'))) as 库存数量 ";
				sql = sql+sql1+"from book where BName= "+"'"+textName.Text+"'";
			}
			else if (textWriter.Text.Trim() != "")
			{
				sql1 = sql1+" BID=(select BID from book where BWriter='"+textWriter.Text+"'))) as 库存数量 ";
				sql = sql+sql1+"from book where BWriter= "+"'"+textWriter.Text+"'";
			}
			else
			{
				MessageBox.Show("请输入查询条件","提示");
				return;
			}

			oleConnection1.Open();
			OleDbDataAdapter adp = new OleDbDataAdapter(sql,oleConnection1);
			DataSet ds = new DataSet();
			ds.Clear();
			adp.Fill(ds,"book");
			dataGrid1.DataSource=ds.Tables[0].DefaultView;
			dataGrid1.CaptionText="共有"+ds.Tables[0].Rows.Count+"条查询记录";
			oleConnection1.Close();
		}

		private void btClear_Click(object sender, System.EventArgs e)
		{
			textID.Text="";
			textName.Text="";
			textWriter.Text="";
		}

		private void btClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

	}
}
