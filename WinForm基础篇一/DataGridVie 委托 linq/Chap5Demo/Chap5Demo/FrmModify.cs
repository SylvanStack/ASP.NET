using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chap5Demo
{
    public partial class FrmModify : Form
    {
        private List<SE> Engineers { get; set; }
        private Action RefreshMainForm { get; set; }
        private RefreshHandler Handler { get; set; }

        public string SelectedID { get; set; }

        public FrmModify(List<SE> engineers, RefreshHandler handler, string selectedId)
        {
            InitializeComponent();

            Engineers = engineers;
            Handler = handler;
            SelectedID = selectedId;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (CheckInput())
            {

                if (string.IsNullOrEmpty(SelectedID))
                {
                    Engineers.Add(new SE
                    {
                        ID = txtID.Text.Trim(),
                        Name = txtName.Text.Trim(),
                        Age = int.Parse(txtAge.Text.Trim()),
                        Gender = radioButton1.Checked
                    });
                }
                else
                {
                    SE selectedSe = Engineers
                        .FirstOrDefault(c => c.ID == SelectedID);
                    //selectedSe.ID = txtID.Text.Trim();
                    selectedSe.Name = txtName.Text.Trim();
                    selectedSe.Age = int.Parse(txtAge.Text.Trim());
                    selectedSe.Gender = radioButton1.Checked;
                }

                if (RefreshMainForm != null) RefreshMainForm();

                if (Handler != null) Handler();

                Close();
            }
        }



        /// <summary>
        /// 验证用户输入
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtID.Text.Trim()))
            {
                MessageBox.Show("员工工号不能为空");
                txtID.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("员工姓名不能为空");
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtAge.Text.Trim()))
            {
                MessageBox.Show("员工年龄不能为空");
                txtAge.Focus();
                return false;
            }

            //bool isExists = false;
            //foreach (var item in Engineers)
            //{
            //    if (item.ID == txtID.Text.Trim())
            //    {
            //        isExists = true;
            //        break;
            //    }
            //}

            //if (isExists)
            //{
            //    MessageBox.Show("员工工号不能重复");
            //    txtID.Focus();
            //    return false;
            //}

            if (string.IsNullOrEmpty(SelectedID) && Engineers.Any(c => c.ID == txtID.Text.Trim()))
            {
                MessageBox.Show("员工工号不能重复");
                txtID.Focus();
                return false;
            }

            int age = 0;
            if (!int.TryParse(txtAge.Text.Trim(), out age))
            {
                MessageBox.Show("年龄必须为数字");
                txtAge.Focus();
                return false;
            }

            if (!(age >= 16 && age <= 80))
            {
                MessageBox.Show("年龄必须在16-80岁之间");
                txtAge.Focus();
                return false;
            }

            return true;
        }

        private void FrmModify_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SelectedID))
            {
                txtID.ReadOnly = true;
                //Lambda
                //SE selectedSe = Engineers
                //    .FirstOrDefault(c => c.ID == SelectedID);
                SE selectedSe = null;
                foreach (var item in Engineers)
                {
                    if (item.ID == SelectedID)
                    {
                        selectedSe = item;
                        break;
                    }
                }

                if (selectedSe != null)
                {
                    txtID.Text = selectedSe.ID;
                    txtName.Text = selectedSe.Name;
                    txtAge.Text = selectedSe.Age.ToString();
                    radioButton1.Checked = !(radioButton1.Checked = selectedSe.Gender);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
