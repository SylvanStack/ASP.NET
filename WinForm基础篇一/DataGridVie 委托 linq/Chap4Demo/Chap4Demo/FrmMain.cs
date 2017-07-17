using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chap4Demo
{

    public delegate void RefreshHandler();
    public partial class FrmMain : Form
    {

        /// <summary>
        /// 员工集合列表
        /// </summary>
        public List<SE> Engineers = new List<SE>();
       // public List<SE> Engineers { get; set; }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engineers.Add(new SE
            {
                ID = "100001",
                JobName = "孙悟空",
                Age = 20,
                Gender= true,
            });

            Engineers.Add(new SE
            {
                ID = "100002",
                JobName = "猪八戒",
                Age =19,
                Gender = false,
            });

            dgvMain.DataSource = new List<SE>(Engineers);

        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddEm_Click(object sender, EventArgs e)
        {
            RefreshHandler handler = new RefreshHandler(MyRefresh);
            new FrmModify(Engineers, handler, null).ShowDialog();
        }

        private void MyRefresh()
        {
            dgvMain.DataSource = new BindingList<SE>(Engineers);
        }

        private void btnChangeEm_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedId =
                    (string)dgvMain.SelectedRows[0].Cells[0].Value;
                RefreshHandler handler = new RefreshHandler(MyRefresh);
                new FrmModify(Engineers, handler, selectedId).ShowDialog();
            }
            catch
            {
                MessageBox.Show("请选择正确的行信息");
            }
        }
    }
}
