using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 控件
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.Columns.Add("", 0);
            listView1.Columns.Add("图书编号", 80);
            listView1.Columns.Add("图书名称", 160);
            listView1.Columns.Add("图书价格", 80);

            ListViewItem q = new ListViewItem("q", 0);
            q.SubItems.Add("01");
            q.SubItems.Add("c#");
            q.SubItems.Add("122.00");

            ListViewItem w = new ListViewItem("w", 1);
            w.SubItems.Add("02");
            w.SubItems.Add("java");
            w.SubItems.Add("142.00");


            ListViewItem r = new ListViewItem("e", 2);
            r.SubItems.Add("03");
            r.SubItems.Add("c#");
            r.SubItems.Add("113.00");

            ListViewItem t = new ListViewItem("t", 3);
            r.SubItems.Add("04");
            r.SubItems.Add("html");
            r.SubItems.Add("113.00");

            ListViewItem y = new ListViewItem("y", 4);
            r.SubItems.Add("05");
            r.SubItems.Add("CSS");
            r.SubItems.Add("113.00");

            listView1.Items.AddRange(new ListViewItem[] { q, w, r ,t,y});

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3= new Form3();
            f3.ShowDialog();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
