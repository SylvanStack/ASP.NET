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

namespace 摇奖机程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool b = false;//是否再次点击 不是再次点击
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(b== false)
            {
                b = true;
                button1.Text = "停止";
                Thread tr = new Thread(PlayGame);
                tr.IsBackground = true;
                tr.Name = "新线程";
                tr.Start();
            }
            else
            {
                b = false;
                button1.Text = "开始";

            }
                   
        }

        private void PlayGame()
        {
            Random rm = new Random();
            while(b)
            {
                label1.Text = rm.Next(0, 10).ToString();
                label2.Text = rm.Next(0, 10).ToString();
                label3.Text = rm.Next(0, 10).ToString();
            }
        }
    }
}
