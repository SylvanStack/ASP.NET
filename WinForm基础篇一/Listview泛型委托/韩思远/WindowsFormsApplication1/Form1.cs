using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public delegate void MyDelegate(object sender, EventArgs e);
        public delegate string  MyDelegate1(string str);

        public event MyDelegate MyEvent;
        public event MyDelegate1 MyEvent1;


        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();             //实例化一个Form2;

          /*  MyEventArgs me = new MyEventArgs();               //自定义的事件数据类实例；

           
            me.MyValue = "1234143";   //Form1中textBox的值传给事件数据类实例；

            this.MyEvent += new MyDelegate(f2.SetTextValue);        //事件订阅自己建的委托；

            MyEvent(this, me);       //执行事件；*/

            
            this.MyEvent1 +=   new MyDelegate1( f2.SetText);

            string a = GetString();

            MyEvent1(a);


            f2.ShowDialog();      //Form2显示
           
        }

        public string GetString()
        {
            string str="";
            for (int i = 0; listView1.SelectedItems.Count> i; i++)
            {
                str += listView1.Items[listView1.SelectedIndices[i]].SubItems[i];
            }
            return str;
        }
       

      /* public class MyEventArgs : EventArgs
        {
           
            public string MyValue = "";

        
        }*/



        public void Afterchange(string text)
        {
          
        }

        
        /// <summary>
        /// 加载各项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.Columns.Add("", 0);
            listView1.Columns.Add("图书编号", 80);
            listView1.Columns.Add("图书名称", 160);
            listView1.Columns.Add("图书价格", 80);

            ListViewItem q = new ListViewItem("q",0);
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

            listView1.Items.AddRange(new ListViewItem[] { q, w, r });
             
           
        }
    }

    public class MyEventArgs : EventArgs
    {

        public string MyValue = "";


    }

}
