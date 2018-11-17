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
	/// Form1 的摘要说明。
	/// </summary>
	public class Login : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioPerson;
		private System.Windows.Forms.RadioButton radioManage;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private OleDbConnection oleConnection1 = null;

		public Login()
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
				if (components != null) 
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
			this.password = new System.Windows.Forms.TextBox();
			this.name = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioPerson = new System.Windows.Forms.RadioButton();
			this.radioManage = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btClose
			// 
			this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btClose.ForeColor = System.Drawing.Color.Black;
			this.btClose.Location = new System.Drawing.Point(166, 208);
			this.btClose.Name = "btClose";
			this.btClose.TabIndex = 20;
			this.btClose.Text = "取消";
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// btAdd
			// 
			this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btAdd.ForeColor = System.Drawing.Color.Black;
			this.btAdd.Location = new System.Drawing.Point(46, 208);
			this.btAdd.Name = "btAdd";
			this.btAdd.TabIndex = 19;
			this.btAdd.Text = "确定";
			this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
			// 
			// password
			// 
			this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.password.Location = new System.Drawing.Point(136, 168);
			this.password.Name = "password";
			this.password.PasswordChar = '*';
			this.password.TabIndex = 18;
			this.password.Text = "admin";
			// 
			// name
			// 
			this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.name.Location = new System.Drawing.Point(136, 128);
			this.name.Name = "name";
			this.name.TabIndex = 17;
			this.name.Text = "admin";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(64, 168);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 16;
			this.label3.Text = "密   码";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(62, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 23);
			this.label2.TabIndex = 15;
			this.label2.Text = "图书证号";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("楷体_GB2312", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(30, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(232, 29);
			this.label1.TabIndex = 14;
			this.label1.Text = "图书馆管理信息系统";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioPerson);
			this.groupBox1.Controls.Add(this.radioManage);
			this.groupBox1.Location = new System.Drawing.Point(48, 64);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 48);
			this.groupBox1.TabIndex = 21;
			this.groupBox1.TabStop = false;
			// 
			// radioPerson
			// 
			this.radioPerson.Location = new System.Drawing.Point(128, 16);
			this.radioPerson.Name = "radioPerson";
			this.radioPerson.Size = new System.Drawing.Size(48, 24);
			this.radioPerson.TabIndex = 1;
			this.radioPerson.Text = "读者";
			// 
			// radioManage
			// 
			this.radioManage.Location = new System.Drawing.Point(24, 16);
			this.radioManage.Name = "radioManage";
			this.radioManage.Size = new System.Drawing.Size(72, 24);
			this.radioManage.TabIndex = 0;
			this.radioManage.Text = "管理人员";
			// 
			// Login
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(292, 246);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.btAdd);
			this.Controls.Add(this.password);
			this.Controls.Add(this.name);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "登录";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Login());
		}

		private void btAdd_Click(object sender, System.EventArgs e)
		{
			if(name.Text.Trim()==""||password.Text.Trim()=="")
				MessageBox.Show("请输入用户名和密码","提示");
			else
			{
				oleConnection1.Open();
				OleDbCommand cmd=new OleDbCommand("",oleConnection1);
				if (radioManage.Checked==true)
				{
					string sql="select * from manager where MName='"+name.Text.Trim()+"' and MCode='"+password.Text.Trim()+"'";
					cmd.CommandText=sql;
					if (null!=cmd.ExecuteScalar())
					{
						//隐藏登录窗口
						this.Visible=false;  
						//创建并打开主界面
						main main=new main();
						main.Tag=this.FindForm();
						OleDbDataReader dr;
						cmd.CommandText=sql;
						dr=cmd.ExecuteReader();
						dr.Read();
			
						main.menuItem1.Visible=(bool)(dr.GetValue(2));
						main.menuItem2.Visible=(bool)(dr.GetValue(2));
						main.menuItem3.Visible=(bool)(dr.GetValue(2));
						main.menuItem5.Visible=(bool)(dr.GetValue(4));
					
						main.menuItem4.Visible=(bool)(dr.GetValue(3));
						main.menuItem5.Visible=(bool)(dr.GetValue(4));

						main.toolBarButton1.Visible=(bool)(dr.GetValue(2));
						main.toolBarButton2.Visible=(bool)(dr.GetValue(2));
						main.toolBarButton3.Visible=(bool)(dr.GetValue(3));
						main.toolBarButton4.Visible=(bool)(dr.GetValue(3));
						main.toolBarButton5.Visible=(bool)(dr.GetValue(4));
	
						main.statusBarPanel2.Text=name.Text.Trim();
						main.statusBarPanel6.Text="管理员";
				
						main.ShowDialog(); 
					}
					else
						MessageBox.Show("用户名或密码错误","警告");					
				}
				else if (radioPerson.Checked==true)
				{
					string sql="select * from person where PID='"+name.Text.Trim()+"' and PCode='"+password.Text.Trim()+"'";
					cmd.CommandText=sql;
					if (null!=cmd.ExecuteScalar())
					{
						//隐藏登录窗口
						this.Visible=false;  
						//创建并打开主界面
						main main=new main();
						main.Tag=this.FindForm();
						OleDbDataReader dr;
						cmd.CommandText=sql;
						dr=cmd.ExecuteReader();
						dr.Read();
			
						main.menuItem1.Visible=(bool)(dr.GetValue(9));
						main.menuItem2.Visible=(bool)(dr.GetValue(9));
						main.menuItem3.Visible=(bool)(dr.GetValue(9));
						main.menuItem4.Visible=(bool)(dr.GetValue(9));
						main.toolBarButton1.Visible=(bool)(dr.GetValue(9));
						main.toolBarButton2.Visible=(bool)(dr.GetValue(9));
						main.toolBarButton3.Visible=(bool)(dr.GetValue(9));
						main.toolBarButton4.Visible=(bool)(dr.GetValue(9));
	
						main.statusBarPanel2.Text=name.Text.Trim();
						main.statusBarPanel6.Text="读者";
				
						main.ShowDialog(); 
					}
					else
						MessageBox.Show("用户名或密码错误","警告");			
				} 
				else
					MessageBox.Show("没有选择角色","提示");
				oleConnection1.Close();
			}
		}

		private void btClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
