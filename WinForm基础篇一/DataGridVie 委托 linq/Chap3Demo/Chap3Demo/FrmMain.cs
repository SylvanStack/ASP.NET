using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap3Demo
{
    public delegate void RefreshHandler();

    public partial class FrmMain : Form
    {
        /// <summary>
        /// 员工集合列表
        /// </summary>
        public List<SE> Engineers { get; set; } = new List<SE>();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Engineers.Add(new SE
            {
                ID = "100001",
                Name = "孙悟空",
                Age = 20,
                Gender = true
            });

            dgvMain.DataSource = new BindingList<SE>(Engineers);
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            //new FrmModify(Engineers, () =>
            //{
            //    dgvMain.DataSource = new BindingList<SE>(Engineers);
            //}).ShowDialog

            RefreshHandler handler = new RefreshHandler(MyRefresh);
            new FrmModify(Engineers, handler, null).ShowDialog();
        }

        private void MyRefresh()
        {
            dgvMain.DataSource = new BindingList<SE>(Engineers);
        }

        private void tsbtnUpdate_Click(object sender, EventArgs e)
        {
            string selectedId = (string)dgvMain.SelectedRows[0].Cells[0].Value;
            RefreshHandler handler = new RefreshHandler(MyRefresh);
            new FrmModify(Engineers, handler, selectedId).ShowDialog();
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            string selectedId = (string)dgvMain.SelectedRows[0].Cells[0].Value;
            DialogResult result = MessageBox.Show("是否确认删除编号为：" + selectedId + "的记录。", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var se = Engineers.FirstOrDefault(c => c.ID == selectedId);
                Engineers.Remove(se);
                MyRefresh();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvMain.DataSource = new BindingList<SE>
                (Engineers.Where(c =>
                c.ID.Contains(txtKeyword.Text.Trim()))
                .ToList());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        
        }
    }
}
