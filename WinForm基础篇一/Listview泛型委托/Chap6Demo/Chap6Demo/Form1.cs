using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chap6Demo
{

    public delegate void Del();

    public partial class Form1 : Form
    {

        List<CE> ce = new List<CE>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ce.Add(new CE
            {
                ID = "01",
                Name = "孙悟空",
                Age = 21,
                Evaluation = "很不错",
                Score = 99,


            });
            ce.Add(new CE
            {
                ID = "02",
                Name = "猪八戒",
                Age = 22,
                Evaluation = "光吃不干",
                Score = 19,
            });
            Init();
        }


        public void Init()
        {
            listView1.Items.Clear();
            for (int i = 0; i < ce.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ce[i].ID.ToString();
                item.SubItems.Add(ce[i].Name);
                item.SubItems.Add(ce[i].Age.ToString());
                item.SubItems.Add(ce[i].Evaluation);
                item.SubItems.Add(ce[i].Score.ToString());
                listView1.Items.Add(item);
            }
        }
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Del myDel = new Del(Init);
                string selectedID = listView1.SelectedItems[0].Text;
                new Form2(ce, myDel, selectedID).ShowDialog();
                // MessageBox.Show(string.Format("{0}",selectedID));
            }
            catch
            {
                string selectedID = listView1.SelectedItems[0].Text;
                MessageBox.Show(string.Format("你选择工号{0}的数据",selectedID));
            }
        }
    }
}
