using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class User_CampusAmbassadorQuery : System.Web.UI.Page
{
    DBSQLServer db = new DBSQLServer();
    protected void Page_Load(object sender, EventArgs e)
    {
        (Master.FindControl("pLogo") as Panel).Visible = false;
        (Master.FindControl("pLogo2") as Panel).Visible = true;
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        tbSearch.Text = null;
    }
    protected void btnSelToGV_Click(object sender, EventArgs e)
    {
        selResult.Text = null;
        DataSet sda = db.sel_gv("select ID,userName,userSex,userBorn,userPhone,userMail,userQQ,create_date from register", "register");
        gvSearch.DataKeyNames = new string[] { "ID" };
        gvSearch.DataSource = sda;
        gvSearch.DataBind();
    }
    protected void btnSel_Click(object sender, EventArgs e)
    {
        int selCntFirst = Convert.ToInt32(db.selDB("select count(*) ID from register where userName='" + tbSearch.Text.Trim() + "'"));
        if (tbSearch.Text.Trim() == null)
        {
            selResult.Text = "请输入用户名进行查询";
        }
        else
        {
            if (selCntFirst != 0)
            {
                DataSet sda = db.sel_gv("select ID,userName,userSex,userBorn,userPhone,userMail,userQQ,create_date from register where userName='" + tbSearch.Text.Trim() + "'", "register");
                gvSearch.DataKeyNames = new string[] { "ID" };
                gvSearch.DataSource = sda;
                gvSearch.DataBind();
            }
            else
            {
                selResult.Text = "未搜索到结果";
            }
        }
    }
}