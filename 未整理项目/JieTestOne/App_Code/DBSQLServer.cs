using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;

/// <summary>
/// DBSQLServer 的摘要说明
/// </summary>
public class DBSQLServer
{
    public DBSQLServer()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    /*
     * 增删改
     */
    public void updateQuery(string str)
    {
        string strCon = "Integrated Security=SSPI; Data Source=(local);Initial Catalog=JieTestOne";

        SqlConnection myConn = new SqlConnection(strCon);
        myConn.Open();
        SqlCommand cmd = new SqlCommand(str, myConn);
        cmd.ExecuteNonQuery();
        myConn.Close();
    }
    //查询
    //ExcuteScalar();
    //object类型
    public object selDB(string str)
    {
        string strCon = "Integrated Security=SSPI; Data Source=(local);Initial Catalog=JieTestOne";

        SqlConnection myConn = new SqlConnection(strCon);
        myConn.Open();
        SqlCommand cmd = new SqlCommand(str, myConn);
        return cmd.ExecuteScalar();
        //myConn.Close();
    }
    //GridView查询
    //DataAdapter  Fill()
    //DataSet
    public DataSet sel_gv(string str, string tbName)
    {
        //链接数据库的字符串
        string strCon = "Integrated Security=SSPI; Data Source=(local);Initial Catalog=JieTestOne";

        //链接数据库
        SqlConnection myConn = new SqlConnection(strCon);

        //打开
        myConn.Open();

        //执行操作
        SqlDataAdapter da = new SqlDataAdapter(str, strCon);

        DataSet ds = new DataSet();

        da.Fill(ds, tbName);

        return ds;
    }
}