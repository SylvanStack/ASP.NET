using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 线程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;//.net  不允许跨线程访问  取消夸访问检查
        }

        Thread th;
        private void button1_Click(object sender, EventArgs e)
        {
            //创建一个线程去执行方法
            // th = new Thread(Test);
            //th.IsBackground = true;//设置线程为后台线程  默认都是前台线程
            // th.Start();//由cpu决定
            // th.Abort();//终止线程的办法
            Thread tr = new Thread(TestThread);
            tr.IsBackground = true;
            tr.Start(9999);//和委托调用方法差不多
           
        }
        private void TestThread(object n)//线程只能接收object的参数
        {
            int nn = (int)n;
            for (int i = 0; i <= nn; i++)
            {
               //   Console.WriteLine(i);
                textBox1.Text = i.ToString();
            }
        }

        private void Test()
        {
            for (int i = 0; i <= 10000 ; i++)
            {
                Console.WriteLine(i);
                //textBox1.Text = i.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //关闭窗体时  判断th线程是否为null
            if(th!=null)
            {
                th.Abort();//结束线程
            }
        }
    }
}
