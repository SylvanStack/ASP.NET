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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private string[] global_ListItem;
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //ComboBox cb = sender as ComboBox;
            //if (cb.Text.Length == 1)
            //{
            //    x = cb.Text[0];
            //    this.backgroundWorker1.RunWorkerAsync();
            //}
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //global_ListItem = Form_Setting.Global_DBC.SimilarFilter(x); 
            //这是一个DLL中的方法，用于查找所有以X打头的项目，并放入一个数组中
        }
    }
}
