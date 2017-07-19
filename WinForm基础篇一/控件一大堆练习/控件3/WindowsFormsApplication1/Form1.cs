using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public bool isFileHaveName { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start("::{20D04FE0-3AEA-1069-A2D8-08002B30309D}");
            //using (OpenFileDialog dlg = new OpenFileDialog())
            //{
            //    DialogResult dr = new DialogResult();
            //    if (dr == DialogResult.OK)
            //    {
            //        string file = dlg.FileName;
            //        this.pictureBox1.Image = Image.FromFile(file);

            //    }
            //}
            //if (this.openFileDialog1.CheckFileExists)
            //{
            //    this.pictureBox1.ImageLocation = this.openFileDialog1.FileName;
            //}

            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                textBox1.Text = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = this.colorDialog1.Color;
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;
                System.Threading.Thread.Sleep(30);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            notifyIcon1.Visible = false;
            if (textBox1.Text == "")
            {
                this.errorProvider1.SetError(this.textBox1,"请输入用户名");
            }
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
              notifyIcon1.ShowBalloonTip(600,"提示","我是图标",ToolTipIcon.Info);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ToolTip ttTip = new ToolTip();
            ttTip.AutoPopDelay = 1000; ttTip.InitialDelay = 1000; ttTip.ReshowDelay = 500;
            ttTip.SetToolTip(this.textBox1,"请输入真实姓名");
            toolTip1.ToolTipTitle = "提示";
            toolTip1.Show("请输入真实姓名", textBox1, textBox1.Location, 1000);
        }

    }
}
    