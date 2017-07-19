using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace ExaminationList
{
    public partial class MainForm : Form
    {
        //定义几个检查项目
        HealthCheckItem height, weight, sight, hearing, liverFun, ekg, bWaves, bloodPressure, bloodTest;
        //定义1个系统默认检查套餐“入学体检”
        HealthCheckSet setA;

        //保存原始的Item数据
        Dictionary<string, HealthCheckItem> AllItems = new Dictionary<string, HealthCheckItem>();
        //保存套餐中的Item数据
        Dictionary<string, HealthCheckItem> items = new Dictionary<string, HealthCheckItem>();
        //使用字典保存套餐集合
        public Dictionary<string, HealthCheckSet> HealthSet = new Dictionary<string, HealthCheckSet>();

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 创建所有检查项目，并保存在AllItems集合中
        /// </summary>
        public void InitItems()
        {
            //创建Item对象并保存到集合中 --注意如果使用List<T> 必须与下拉列表中的索引一致
            height = new HealthCheckItem("身高", 5, "用于检查身高.");
            weight = new HealthCheckItem("体重", 5, "用于检查体重.");
            sight = new HealthCheckItem("视力", 10, "用于检查视力.");
            hearing = new HealthCheckItem("听力", 10, "用于检查听力.");
            liverFun = new HealthCheckItem("肝功能", 50, "用于检查肝功能.");
            bWaves = new HealthCheckItem("B超", 30, "用于检查B超.");
            ekg = new HealthCheckItem("心电图", 50, "用于检查心电图.");
            bloodPressure = new HealthCheckItem("血压", 20, "用于检查血压.");
            bloodTest = new HealthCheckItem("血常规", 20, "用于检查血常规.");
            AllItems.Add(height.Name, height);
            AllItems.Add(weight.Name, weight);
            AllItems.Add(sight.Name, sight);
            AllItems.Add(hearing.Name, hearing);
            AllItems.Add(liverFun.Name, liverFun);
            AllItems.Add(bWaves.Name, bWaves);
            AllItems.Add(ekg.Name, ekg);
            AllItems.Add(bloodPressure.Name, bloodPressure);
            AllItems.Add(bloodTest.Name, bloodTest);
        }

        /// <summary>
        /// 生成默认套餐数据
        /// </summary>
        private void InitSets()
        {
            //创建1种默认套餐对象
            items = new Dictionary<string, HealthCheckItem>();
            items.Add(height.Name, height);
            items.Add(weight.Name, weight);
            items.Add(liverFun.Name, liverFun);

            setA = new HealthCheckSet("入学体检", items);
            //计算套餐价格
            setA.CalcPrice();
            this.HealthSet.Add("入学体检", setA);
        }

        /// <summary>
        /// 加载体检套餐
        /// </summary>
        public void InitHealthSetList()
        {
            this.cboSets.Items.Clear();
            this.cboSets.Items.Add("请选择");

            foreach (string key in this.HealthSet.Keys)
            {
                this.cboSets.Items.Add(key);
            }
            this.cboSets.SelectedIndex = 0;
        }

        //窗体加载
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.lblSetName.Text = "";
            this.lblSetPrice.Text = "";
            this.btnAdd.Enabled = false;
            this.btnDel.Enabled = false;

            //初始化所有检查项目
            InitItems();
            //初始化默认套餐
            InitSets();
            //加载套餐列表
            InitHealthSetList();
        }

        /// <summary>
        /// 填充套餐的DataGridView
        /// </summary>
        /// <param name="set"></param>
        private void UpdateSet(HealthCheckSet set)
        {
            //注意：Dictionary的Values转换为List，可以使用ToList() .该方法必须引入命名空间System.Linq;(.NET FrameWork 4)
            this.dgvHealthList.DataSource = new BindingList<HealthCheckItem>(set.Items.Values.ToList());
        }

        //选择“套餐”下拉列表事件
        private void cboSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            string setName = this.cboSets.Text;
            if (setName == "请选择")
            {
                this.dgvHealthList.DataSource = new BindingList<HealthCheckItem>();
                lblSetName.Text = "";
                lblSetPrice.Text = "";
                return;
            }
            //设置套餐名称
            lblSetName.Text = this.HealthSet[setName].Name;
            //设置套餐总价
            lblSetPrice.Text = this.HealthSet[setName].Price.ToString();
            //更新套餐检查项目
            UpdateSet(HealthSet[setName]);
            //设置删除按钮为“可用状态”
            this.btnDel.Enabled = true;
        }

        //删除检查项目
        private void btnDel_Click(object sender, EventArgs e)
        {
            string setName = this.cboSets.Text;

            if (this.dgvHealthList.SelectedRows.Count == 0)
            {
                MessageBox.Show("没有选择删除项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //获取选中检查项目的索引
            int index = this.dgvHealthList.SelectedRows[0].Index;
            string key = this.dgvHealthList.SelectedRows[0].Cells[0].Value.ToString();

            //删除检察项
            this.HealthSet[setName].Items.Remove(key);

            //重新计算价格
            this.HealthSet[setName].CalcPrice();
            //更新DataGridView显示
            UpdateSet(HealthSet[setName]);
            //重设标签显示
            this.lblSetName.Text = setA.Name;
            this.lblSetPrice.Text = setA.Price.ToString();
            MessageBox.Show("删除成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //根据是否选择体检项目，设置“添加”显示状态
        private void cboItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboItems.Text != "请选择")
            {
                this.btnAdd.Enabled = true;
            }
            else
            {
                this.btnAdd.Enabled = false;
            }
        }

        //“添加”检查项目
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region 输入判断
            if (this.cboItems.SelectedIndex == 0)
            {
                MessageBox.Show("请选择一个项目。");
                return;
            }

            string cboSetText = this.cboSets.Text;
            if (cboSetText == "请选择")
            {
                MessageBox.Show("请选择套餐！");
                return;
            }
            #endregion
            #region 添加操作
            int index = this.cboItems.SelectedIndex - 1;
            string wantAdd = this.cboItems.Text;
            if (!this.HealthSet[cboSetText].Items.Keys.ToList().Contains(wantAdd))
            {
                //添加检查项
                this.HealthSet[cboSetText].Items.Add(wantAdd, AllItems[wantAdd]);
                //重新计算总价格
                this.HealthSet[cboSetText].CalcPrice();
                //更新
                UpdateSet(this.HealthSet[cboSetText]);
                this.lblSetName.Text = this.HealthSet[cboSetText].Name;  //刷新窗体集合A名称
                this.lblSetPrice.Text = this.HealthSet[cboSetText].Price.ToString();    //刷新集合A价格
                MessageBox.Show("添加成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("该项目存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

        }

        //新建套餐
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtHealthName.Text.Trim()))
            {
                MessageBox.Show("请输入套餐名称!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            HealthCheckSet Hch = new HealthCheckSet();
            this.HealthSet.Add(this.txtHealthName.Text.Trim(), Hch);

            this.InitHealthSetList();
            this.cboSets.SelectedIndex = this.HealthSet.Count;
            MessageBox.Show("添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}