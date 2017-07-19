using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<string> listPath = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 播放按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            MusicPlay();
        }
        /// <summary>
        /// 停止按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            btnPlay.Text = "播放";
            MusicPlayer.Ctlcontrols.stop();
        }
        /// <summary>
        /// form1的Load的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            MusicPlayer.settings.autoStart = false;
            //notifyIcon1.ShowBalloonTip(500, "控件实例", "请尽情观赏", ToolTipIcon.Info);
        }
        /// <summary>
        /// 打开文件对话框的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\刘长江\音乐";
            ofd.Filter = "音乐文件|*wav|mp3文件|*.mp3|所有文件|*.*";
            ofd.Title = "请选择音乐文件(⊙o⊙)";
            ofd.Multiselect = true;
            ofd.ShowDialog();

            string[] path = ofd.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                listPath.Add(path[i]);
                listBox1.Items.Add(Path.GetFileName(path[i]));
            }
        }
        /// <summary>
        /// listBox1的双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("请先选择音乐！","提示");
            }
            try
            {
                MusicPlayer.URL = listPath[listBox1.SelectedIndex];
                MusicPlayer.Ctlcontrols.play();
                btnPlay.Text = "暂停";
            }
            catch { }
            statusStrip1.Items[0].Text = Path.GetFileName(listPath[listBox1.SelectedIndex]);
        }
        /// <summary>
        /// 上一个歌曲播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            index--;
            if (index == -1)
                index = listBox1.Items.Count-1;
            listBox1.SelectedIndex = index;
            MusicPlayer.URL = listPath[index];
            MusicPlayer.Ctlcontrols.play();
            statusStrip1.Items[0].Text = Path.GetFileName(listPath[listBox1.SelectedIndex]);
        }
        /// <summary>
        /// 下一个歌曲播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDown_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            index++;
            if (index == listBox1.Items.Count)
                index = 0;
            listBox1.SelectedIndex = index;
            MusicPlayer.URL = listPath[index];
            MusicPlayer.Ctlcontrols.play();
            statusStrip1.Items[0].Text = Path.GetFileName(listPath[listBox1.SelectedIndex]);
        }
        /// <summary>
        /// 计时器的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0,1);
            label2.Text = label1.Text;
        }
        /// <summary>
        /// 小图标的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
        /// <summary>
        /// 音乐播放方法
        /// </summary>
        private void MusicPlay()
        {
            if (btnPlay.Text == "播放")
            {
                btnPlay.Text = "暂停";
                MusicPlayer.Ctlcontrols.play();
            }
            else
            {
                btnPlay.Text = "播放";
                MusicPlayer.Ctlcontrols.pause();
            }
        }
       
        /// <summary>
        /// 修改list Box1的颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            listBox1.ForeColor = colorDialog1.Color;
        }
        /// <summary>
        /// 修改listBox1的字体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            listBox1.Font = fontDialog1.Font;
        }

        Random rnd = new Random();  //产生随机数
        /// <summary>
        /// 设置进度条的值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProgress_Click(object sender, EventArgs e)
        {
            int i = (toolStripProgressBar1.Value + rnd.Next(1000)) % toolStripProgressBar1.Maximum;
            toolStripProgressBar1.Value = i;
        }
        /// <summary>
        /// 打印对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            PrintDocument pDocument = new PrintDocument();
            //设置操作文件
            pageSetupDialog1.Document = pDocument;
            //启用边距
            pageSetupDialog1.AllowMargins = true;
            //启用对话框的方向部分
            pageSetupDialog1.AllowOrientation = true;
            //启用对话框的纸张部分
            pageSetupDialog1.AllowPaper = true;
            //启用“打印机”按钮
            pageSetupDialog1.AllowPrinter = true;
            //显示页面设置对话框
            pageSetupDialog1.ShowDialog();
        }
        /// <summary>
        /// 从数据库中获取数据表
        /// </summary>
        /// <returns></returns>
        public DataTable GetTable()
        {
            string collectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["conStr"].ToString();
            SqlConnection conn = new SqlConnection(collectionstring);
            SqlDataAdapter sad = new SqlDataAdapter("select top 7 productID,sum(num * salePrice) as 售价金额,sum(num * inPrice) as 进价金额 from saleInfo group by productID ", conn);
            DataSet ds = new DataSet();
            sad.Fill(ds, "table");
            conn.Close();
            return ds.Tables[0];
        }
        /// <summary>
        /// 柱状图的显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChart_Click(object sender, EventArgs e)
        {
            //存储数据点和序列特性
            //Series s1 = new Series("s1");
            //chart1.Series.Add(s1);
            //chart1.DataSource = GetTable();
            //chart1.Series["s1"].XValueMember = "productID";
            //chart1.Series["s1"].YValueMembers = "金额";
            //Series s1 = new Series("s1");
            //chart1.Series.Add(s1);

            //chart1.Series["s1"].Points.DataBindXY(myRade, "ProductCode", myRade, "金额");
            //myRade为DataReader
            chart1.Series.Clear();
            Series s1 = new Series("s1");
            Series s2 = new Series("s2");
            chart1.Series.Add(s1);
            chart1.Series.Add(s2);
            chart1.DataSource = GetTable();
            chart1.Series["s1"].XValueMember = "productID";
            chart1.Series["s1"].YValueMembers = "售价金额";
            chart1.Series["s2"].XValueMember = "productID";
            chart1.Series["s2"].YValueMembers = "进价金额";
            chart1.DataBind();
        }

        private void tsmItemPlay_Click(object sender, EventArgs e)
        {
            MusicPlay();
        }

        private void tsmItemPause_Click(object sender, EventArgs e)
        {
            MusicPlay();
        }

        private void tsmItemClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
