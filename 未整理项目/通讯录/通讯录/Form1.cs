using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 通讯录
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 联系人BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.联系人BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.学生库DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“学生库DataSet.联系人”中。您可以根据需要移动或删除它。
            this.联系人TableAdapter.Fill(this.学生库DataSet.联系人);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void 联系人BindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
