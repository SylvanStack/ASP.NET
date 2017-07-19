using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Process[] list = Process.GetProcesses(".");
            for (int i = 0; i < list.Length; i++)
            {
                ListViewItem li = new ListViewItem();
                li.Text = list[i].ProcessName;
                li.SubItems.AddRange(new string[] { list[i].Id.ToString(),list[i].PrivateMemorySize64.ToString() });
                listView1.Items.Add(li); 
            }

        }
        HelpProvider HP;
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("要想获得帮助，请按F1");
            HP = new HelpProvider();
            string Source = "Help.txt";
            HP.HelpNamespace = Source;
            HP.SetShowHelp(this, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDialog PrintDialog1 = new PrintDialog();
           PrintDocument docToPrint = new System.Drawing.Printing.PrintDocument();

            //docToPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e);

            //docToPrint.PrintPage += new PrintPageEventHandler(docToPrint_PrintPage);
            
            PrintDialog1.AllowSomePages = true; PrintDialog1.ShowHelp = true;
            
            PrintDialog1.Document = docToPrint;
            
            DialogResult result = PrintDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog filename = new OpenFileDialog();
            filename.InitialDirectory = System.Windows.Forms.Application.StartupPath;
            filename.Filter = "files (*.*)|*.*|txt files (*.txt)|*.txt";
            filename.FilterIndex = 2;
            filename.RestoreDirectory = true;
            if (filename.ShowDialog()==DialogResult.OK)
            {
                string path = filename.FileName.ToString();
               // string name = path.Substring(path.LastIndexOf("\\"+1));
                output(path);
               // output("用户选择的文件名称为：" + name);
            }
        }
        public void output(string log)
        {
            richTextBox1.AppendText(log);//(DateTime.Now.ToString("HH:mm:ss")+log+"\r\n");
            Console.WriteLine(log);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "files (*.*)|*.*|txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter ss = new StreamWriter(@saveFileDialog1.FileName, true))
                {
                    ss.Write(richTextBox1.Text);
                }
            }
        }
    }
}
