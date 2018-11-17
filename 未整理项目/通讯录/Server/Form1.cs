using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 用户BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.用户BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.学生库DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“学生库DataSet.用户”中。您可以根据需要移动或删除它。
            this.用户TableAdapter.Fill(this.学生库DataSet.用户);

        }
    }
}
