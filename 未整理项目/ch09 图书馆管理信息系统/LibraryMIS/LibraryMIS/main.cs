using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LibraryMIS
{
	/// <summary>
	/// main 的摘要说明。
	/// </summary>
	public class main : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		public System.Windows.Forms.MenuItem menuItem1;
		public System.Windows.Forms.MenuItem menuItem2;
		public System.Windows.Forms.MenuItem menuItem3;
		public System.Windows.Forms.MenuItem menuItem4;
		public System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.ToolBar toolBar1;
		public System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		public System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.StatusBarPanel statusBarPanel3;
		private System.Windows.Forms.StatusBarPanel statusBarPanel4;
		private System.Windows.Forms.StatusBarPanel statusBarPanel5;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
		public System.Windows.Forms.StatusBarPanel statusBarPanel6;
		public System.Windows.Forms.ToolBarButton toolBarButton1;
		public System.Windows.Forms.ToolBarButton toolBarButton3;
		public System.Windows.Forms.ToolBarButton toolBarButton4;
		public System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.ComponentModel.IContainer components;

		public main()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(main));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem20 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel6 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel4 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel5 = new System.Windows.Forms.StatusBarPanel();
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel5)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem4,
																					  this.menuItem5,
																					  this.menuItem6,
																					  this.menuItem7});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem8,
																					  this.menuItem16});
			this.menuItem1.Text = "系统管理";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 0;
			this.menuItem8.Text = "添加用户";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 1;
			this.menuItem16.Text = "浏览用户";
			this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem9,
																					  this.menuItem17});
			this.menuItem2.Text = "图书管理";
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 0;
			this.menuItem9.Text = "图书分类";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 1;
			this.menuItem17.Text = "浏览图书";
			this.menuItem17.Click += new System.EventHandler(this.menuItem17_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem10,
																					  this.menuItem18});
			this.menuItem3.Text = "读者管理";
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 0;
			this.menuItem10.Text = "浏览身份";
			this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
			// 
			// menuItem18
			// 
			this.menuItem18.Index = 1;
			this.menuItem18.Text = "浏览读者";
			this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 3;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem19,
																					  this.menuItem20});
			this.menuItem4.Text = "借还管理";
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 0;
			this.menuItem19.Text = "借书";
			this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
			// 
			// menuItem20
			// 
			this.menuItem20.Index = 1;
			this.menuItem20.Text = "还书";
			this.menuItem20.Click += new System.EventHandler(this.menuItem20_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 4;
			this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem11,
																					  this.menuItem12});
			this.menuItem5.Text = "查询操作";
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 0;
			this.menuItem11.Text = "图书查询";
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 1;
			this.menuItem12.Text = "借阅查询";
			this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 5;
			this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem13,
																					  this.menuItem14});
			this.menuItem6.Text = "用户登录";
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 0;
			this.menuItem13.Text = "修改密码";
			this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 1;
			this.menuItem14.Text = "重新登录";
			this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 6;
			this.menuItem7.Text = "帮助";
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 387);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusBarPanel1,
																						  this.statusBarPanel6,
																						  this.statusBarPanel2,
																						  this.statusBarPanel3,
																						  this.statusBarPanel4,
																						  this.statusBarPanel5});
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size(600, 22);
			this.statusBar1.TabIndex = 1;
			// 
			// statusBarPanel6
			// 
			this.statusBarPanel6.Width = 60;
			// 
			// statusBarPanel2
			// 
			this.statusBarPanel2.Width = 60;
			// 
			// statusBarPanel3
			// 
			this.statusBarPanel3.Width = 120;
			// 
			// statusBarPanel5
			// 
			this.statusBarPanel5.Width = 130;
			// 
			// toolBar1
			// 
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton1,
																						this.toolBarButton2,
																						this.toolBarButton3,
																						this.toolBarButton4,
																						this.toolBarButton5,
																						this.toolBarButton6});
			this.toolBar1.ButtonSize = new System.Drawing.Size(60, 23);
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(600, 29);
			this.toolBar1.TabIndex = 2;
			this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBar1.Click += new System.EventHandler(this.toolBar1_ButtonClick);
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 0;
			this.toolBarButton1.Text = "系统";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 14;
			this.toolBarButton2.Text = "读者";
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageIndex = 4;
			this.toolBarButton3.Text = "借书";
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.ImageIndex = 10;
			this.toolBarButton4.Text = "还书";
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.ImageIndex = 13;
			this.toolBarButton5.Text = "查询";
			// 
			// toolBarButton6
			// 
			this.toolBarButton6.ImageIndex = 9;
			this.toolBarButton6.Text = "用户";
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// main
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(600, 409);
			this.Controls.Add(this.toolBar1);
			this.Controls.Add(this.statusBar1);
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "主界面";
			this.Load += new System.EventHandler(this.main_Load);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel5)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
		
		}

		AddUser addUser;
		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			addUser = new AddUser();
			for(int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			addUser.MdiParent = this;
			addUser.WindowState = FormWindowState.Maximized;
			addUser.Show();
		}

		Type type;
		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			type = new Type();
			for (int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			type.MdiParent = this;
			type.WindowState = FormWindowState.Maximized;
			type.Show();
		}

		Book book;
		private void menuItem17_Click(object sender, System.EventArgs e)
		{
			book = new Book();
			for (int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			book.MdiParent = this;
			book.WindowState = FormWindowState.Maximized;
			book.Show();
		}

		Person person;
		private void menuItem18_Click(object sender, System.EventArgs e)
		{
			person = new Person();
			for (int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			person.MdiParent = this;
			person.WindowState = FormWindowState.Maximized;
			person.Show();
		}

		Identity identity;
		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			identity = new Identity();
			for (int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			identity.MdiParent = this;
			identity.WindowState = FormWindowState.Maximized;
			identity.Show();
		}

		BookOut bookOut;
		private void menuItem19_Click(object sender, System.EventArgs e)
		{
			bookOut = new BookOut();
			for (int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			bookOut.MdiParent = this;
			bookOut.WindowState = FormWindowState.Maximized;
			bookOut.Show();
		}

		BookIn bookIn;
		private void menuItem20_Click(object sender, System.EventArgs e)
		{
			bookIn = new BookIn();
			for (int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			bookIn.MdiParent = this;
			bookIn.WindowState = FormWindowState.Maximized;
			bookIn.Show();
		}

		BookQuery bookQuery;
		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			bookQuery = new BookQuery();
			for (int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			bookQuery.MdiParent = this;
			bookQuery.WindowState = FormWindowState.Maximized;
			bookQuery.Show();
		}

		PersonQuery personQuery;
		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			personQuery = new PersonQuery();
			for (int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			personQuery.MdiParent = this;
			personQuery.Tag = this.statusBarPanel2.Text.Trim();
			personQuery.WindowState = FormWindowState.Maximized;
			personQuery.Show();
		}

		ModifyCode modifyCode;
		private void menuItem13_Click(object sender, System.EventArgs e)
		{
			modifyCode = new ModifyCode();
			for(int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			modifyCode.MdiParent = this;
			modifyCode.Tag = this.statusBarPanel2.Text.Trim();
			modifyCode.label5.Text = this.statusBarPanel6.Text.Trim();
			modifyCode.WindowState = FormWindowState.Maximized;
			modifyCode.Show();
		}

		private void menuItem14_Click(object sender, System.EventArgs e)
		{
			((System.Windows.Forms.Form)this.Tag).Visible=true;
			this.Close();
		}

		private void main_Load(object sender, System.EventArgs e)
		{
			statusBarPanel1.Text = "当前登录用户";
			statusBarPanel3.Text = DateTime.Now.ToString();
			statusBarPanel4.Text = "作者：ddl";
			statusBarPanel5.Text = "图书馆管理信息系统";
		}

		User user;
		private void menuItem16_Click(object sender, System.EventArgs e)
		{
			user = new User();
			for (int x=0;x<this.MdiChildren.Length;x++)
			{
				Form tempChild = (Form)this.MdiChildren[x];
				tempChild.Close();
			}
			user.MdiParent = this;
			user.WindowState = FormWindowState.Maximized;
			user.Show();
		}

		private void toolBar1_ButtonClick(object sender, System.EventArgs e)
		{
			
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch(toolBar1.Buttons.IndexOf(e.Button))
			{
				case 0:
					Form addUser = new AddUser();
					for(int x=0;x<this.MdiChildren.Length;x++)
					{
						Form tempChild = (Form)this.MdiChildren[x];
						tempChild.Close();
					}
					addUser.MdiParent = this;
					addUser.WindowState = FormWindowState.Maximized;
					addUser.Show();
					break;
				case 1:
					Form person = new Person();
					for(int x=0;x<this.MdiChildren.Length;x++)
					{
						Form tempChild = (Form)this.MdiChildren[x];
						tempChild.Close();
					}
					person.MdiParent = this;
					person.WindowState = FormWindowState.Maximized;
					person.Show();
					break;
				case 2:
					Form bookOut = new BookOut();
					for(int x=0;x<this.MdiChildren.Length;x++)
					{
						Form tempChild = (Form)this.MdiChildren[x];
						tempChild.Close();
					}
					bookOut.MdiParent = this;
					bookOut.WindowState = FormWindowState.Maximized;
					bookOut.Show();
					break;
				case 3:
					Form bookIn = new BookIn();
					for(int x=0;x<this.MdiChildren.Length;x++)
					{
						Form tempChild = (Form)this.MdiChildren[x];
						tempChild.Close();
					}
					bookIn.MdiParent = this;
					bookIn.WindowState = FormWindowState.Maximized;
					bookIn.Show();
					break;
				case 4:
					Form bookQuery = new BookQuery();
					for(int x=0;x<MdiChildren.Length;x++)
					{
						Form tempChild = (Form)MdiChildren[x];
						tempChild.Close();
					}
					bookQuery.MdiParent = this;
					bookQuery.WindowState = FormWindowState.Maximized;
					bookQuery.Show();
					break;
				case 5:
					ModifyCode modifyCode = new ModifyCode();
					for(int x=0;x<MdiChildren.Length;x++)
					{
						Form tempChild = (Form)MdiChildren[x];
						tempChild.Close();
					}
					modifyCode.MdiParent = this;
					modifyCode.Tag = this.statusBarPanel2.Text.Trim();
					modifyCode.label5.Text = this.statusBarPanel6.Text.Trim();
					modifyCode.WindowState = FormWindowState.Maximized;
					modifyCode.Show();
					break;
			}
		}
	}
}
