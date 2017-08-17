using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;

namespace NPOI练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> slt = new List<Student>();
            for (int i = 1; i <= 20; i++)
            {
                Student s = new Student();
                s.SName = "张三" + i;
                slt.Add(s);
            }

            dataGridView1.DataSource = new BindingList<Student>(slt);
        }

        /// <summary>
        /// 创建
        /// </summary>
        public void CreateSheet()
        {
            IWorkbook workbook = new HSSFWorkbook();//创建Workbook对象
            ISheet sheet = workbook.CreateSheet("Sheet1");//创建工作表
            IRow row = sheet.CreateRow(0);//在工作表中添加一行
            ICell cell = row.CreateCell(0);//在行中添加一列
            cell.SetCellValue("test");//设置列的内容
        }

        /// <summary>
        /// 读取
        /// </summary>
        /// <param name="stream"></param>
        public void GetSheet(Stream stream)
        {
            List<Student> stu = new List<Student>();
            IWorkbook workbook = new HSSFWorkbook(stream);//从流内容创建Workbook对象
            ISheet sheet = workbook.GetSheetAt(0);//获取第一个工作表
            IRow row = sheet.GetRow(0);//获取工作表第一行
            ICell cell = row.GetCell(0);//获取行的第一列
            string value = cell.ToString();//获取列的值
            for (int j = 0; j <20; j++)
            {

                Student s = new Student();
                s.SName = sheet.GetRow(j).GetCell(0).ToString();
                s.SId = sheet.GetRow(j).GetCell(1).ToString();
                s.SSex = sheet.GetRow(j).GetCell(2).ToString();
                s.SDate = sheet.GetRow(j).GetCell(3).ToString();
                s.SAge = sheet.GetRow(j).GetCell(4).ToString();
                stu.Add(s);

            }
            dataGridView1.DataSource = new BindingList<Student>(stu);
            MessageBox.Show("读取成功");
        }

        ///// <summary>
        ///// 从DataTable读取内容来创建Workbook对象：
        ///// </summary>
        ///// <param name="table"></param>
        ///// <returns></returns>
        //public static MemoryStream RenderToExcel(DataTable table)
        //{
        //    MemoryStream ms = new MemoryStream();

        //    using (table)
        //    {
        //        using (IWorkbook workbook = new HSSFWorkbook())
        //        {
        //            using (ISheet sheet = workbook.CreateSheet())
        //            {
        //                IRow headerRow = sheet.CreateRow(0);

        //                // handling header.
        //                foreach (DataColumn column in table.Columns)
        //                    headerRow.CreateCell(column.Ordinal).SetCellValue(column.Caption);//If Caption not set, returns the ColumnName value

        //                // handling value.
        //                int rowIndex = 1;

        //                foreach (DataRow row in table.Rows)
        //                {
        //                    IRow dataRow = sheet.CreateRow(rowIndex);

        //                    foreach (DataColumn column in table.Columns)
        //                    {
        //                        dataRow.CreateCell(column.Ordinal).SetCellValue(row[column].ToString());
        //                    }

        //                    rowIndex++;
        //                }

        //                workbook.Write(ms);
        //                ms.Flush();
        //                ms.Position = 0;
        //            }
        //        }
        //    }
        //    return ms;
        //}

        //public static MemoryStream RenderToExcel(IDataReader reader)
        //{
        //    MemoryStream ms = new MemoryStream();

        //    using (reader)
        //    {
        //        using (IWorkbook workbook = new HSSFWorkbook())
        //        {
        //            using (ISheet sheet = workbook.CreateSheet())
        //            {
        //                IRow headerRow = sheet.CreateRow(0);
        //                int cellCount = reader.FieldCount;

        //                // handling header.
        //                for (int i = 0; i < cellCount; i++)
        //                {
        //                    headerRow.CreateCell(i).SetCellValue(reader.GetName(i));
        //                }

        //                // handling value.
        //                int rowIndex = 1;
        //                while (reader.Read())
        //                {
        //                    IRow dataRow = sheet.CreateRow(rowIndex);

        //                    for (int i = 0; i < cellCount; i++)
        //                    {
        //                        dataRow.CreateCell(i).SetCellValue(reader[i].ToString());
        //                    }

        //                    rowIndex++;
        //                }

        //                workbook.Write(ms);
        //                ms.Flush();
        //                ms.Position = 0;
        //            }
        //        }
        //    }
        //    return ms;
        //}

        //static void SaveToFile(MemoryStream ms, string fileName)
        //{
        //    using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
        //    {
        //        byte[] data = ms.ToArray();

        //        fs.Write(data, 0, data.Length);
        //        fs.Flush();

        //        data = null;
        //    }
        //}

        //static void RenderToBrowser(MemoryStream ms, HttpContent context, string fileName)
        //{
        //    if (context.Request.Browser.Browser == "IE")
        //        fileName = HttpUtility.UrlEncode(fileName);
        //    context.Response.AddHeader("Content-Disposition", "attachment;fileName=" + fileName);
        //    context.Response.BinaryWrite(ms.ToArray());
        //}

        public void ExportExcel(string fileName, DataGridView dgv)
        {
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xls";
            saveDialog.Filter = "Excel文件|*.xls";
            saveDialog.FileName = fileName;
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;

            HSSFWorkbook workbook = new HSSFWorkbook();
            MemoryStream ms = new MemoryStream();

            ISheet sheet = workbook.CreateSheet("Sheet1");

            int rowCount = dgv.Rows.Count;
            int colCount = dgv.Columns.Count;

            for (int i = 0; i < rowCount; i++)
            {
                IRow dataRow = sheet.CreateRow(i);
                for (int j = 0; j < colCount; j++)
                {
                    if (dgv.Columns[j].Visible && dgv.Rows[i].Cells[j].Value != null)
                    {
                        ICell cell = dataRow.CreateCell(j);
                        cell.SetCellValue(dgv.Rows[i].Cells[j].Value.ToString());
                    }
                }
            }

            workbook.Write(ms);
            FileStream file = new FileStream(saveFileName, FileMode.Create);
            workbook.Write(file);
            file.Close();
            workbook = null;
            ms.Close();
            ms.Dispose();

            MessageBox.Show(fileName + " 保存成功", "提示", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportExcel("新建文档", dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sa = openFileDialog1_FileOk(null, null);
            if (sa == "")
            {
                MessageBox.Show("出错");
            }
            FileStream file = new FileStream(sa, FileMode.OpenOrCreate);
            GetSheet(file);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateSheet();
        }

        private string openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fName = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "文本文件|*.*|C#文件|*.cs|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fName = openFileDialog.FileName;
            }
            return fName;
        }

    }

}
