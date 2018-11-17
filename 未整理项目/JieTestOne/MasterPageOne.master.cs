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
public partial class MasterPageOne : System.Web.UI.MasterPage
{
    DBSQLServer db = new DBSQLServer();
    protected void Page_Load(object sender, EventArgs e)
    {
        //创建session
        HttpContext.Current.Session[Session.SessionID + "Name"] = userName.Text;
        HttpContext.Current.Session[Session.SessionID + "Password"] = userPassWord.Text;
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //if (userName.Text == "1" && userPassWord.Text == "1")
        //{
        //    //btnLogin.Attributes.Add("onclick", "yincang()");
        //    lbComeName.Text = HttpContext.Current.Session[Session.SessionID + "Name"].ToString();
        //    pOne.Visible = false;
        //    pTwo.Visible = true;
        //}
        int selCnt = Convert.ToInt32(db.selDB("select count(*) ID from register where userName='" + userName.Text + "'"));
        if (userName.Text == null || selCnt == 0)
        {
            Response.Write("<script>alert('用户名输入错误或不存在');</script>");
            return;
        }
        else
        {
            string psd = FormsAuthentication.HashPasswordForStoringInConfigFile(userPassWord.Text, "MD5");
            string selCntFirst = db.selDB("select userPassWord from register where userName='" + userName.Text + "'").ToString();
            if (!psd.Equals(selCntFirst)||userPassWord.Text==null)
            {
                Response.Write("<script>alert('密码输入错误');</script>");
                return;
            }
            else
            {
                lbComeName.Text = HttpContext.Current.Session[Session.SessionID + "Name"].ToString();
                pOne.Visible = false;
                pTwo.Visible = true;
                Response.Write("<script>alert('欢迎您回来');</script>");
                return;
            }
        }
    }
    //自动登录
    protected void cbAutomaticLogin_CheckedChanged(object sender, EventArgs e)
    {
        if (cbAutomaticLogin.Checked == true)
        {
            lbComeName.Text = HttpContext.Current.Session[Session.SessionID + "Name"].ToString();
            userPassWord.Text = HttpContext.Current.Session[Session.SessionID + "Password"].ToString();
        }
    }
    protected void lbtnLoginOut_Click(object sender, EventArgs e)
    {
        pTwo.Visible = false;
        if (HttpContext.Current.Session[Session.SessionID + "Name"] != null)
        {
            userName.Text = HttpContext.Current.Session[Session.SessionID + "Name"].ToString();
            userPassWord.Text = HttpContext.Current.Session[Session.SessionID + "Password"].ToString();
        }
        Session.Clear();
        pOne.Visible = true;
    }
}
