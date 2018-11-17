using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Data;
using System.Text.RegularExpressions;

public partial class User_Registered : System.Web.UI.Page
{
    DBSQLServer db = new DBSQLServer();
    Boolean flag = false, fl = false, fll = false; String nan;
    protected void Page_Load(object sender, EventArgs e)
    {
        (Master.FindControl("pOne") as Panel).Visible = false;
        (Master.FindControl("pTwo") as Panel).Visible = false;
    }
    protected void btnReg_Click(object sender, EventArgs e)
    {
        int selCntFirst = Convert.ToInt32(db.selDB("select count(*) ID from register where userName='" + userName.Text + "'"));

        if (fl == true)
        {
            Response.Write("<script>alert('*请选择性别');</script>");
        }
        else
        {
            if (flag == true)
            {
                nan = "男";
                fll = true;
            }
            if (flag == false)
            {
                nan = "女";
                fll = true;
            }
        }
        if (fll == true && CompareValidator1.IsValid==true&&rfvConPassWord.IsValid==true)
        {
            string psd = FormsAuthentication.HashPasswordForStoringInConfigFile(userPassWord.Text, "MD5");
            db.updateQuery("insert into register(userName,userSex,userBorn,userPhone,userMail,userQQ,userPassWord,create_date) values('" + userName.Text + "','" + nan + "','" + tbBorn.Text.ToString() + "','" + tbPhone.Text + "','" + tbMail.Text + "','" + tbTencent.Text + "','" + psd + "','" + DateTime.Now.ToString() + "')");
            Response.Write("<script>alert('用户注册成功！感谢您的加入！')</script>");
            Response.Write("<script language=javascript>javascript:location.href='Default.aspx'</script>");
            Response.Write("<script>alert('为了信息安全，请您手动输入信息登陆！')</script>");
            return;
        }
        else
        {
            Response.Write("<script>alert('注册失败！')</script>");
        }
    }
    //清空
    protected void btnClear_Click(object sender, EventArgs e)
    {
        userName.Text = null;
        rbMale.Checked = false;
        rbFeMale.Checked = false;
        tbBorn.Text = null;
        tbPhone.Text = null;
        tbMail.Text = null;
        tbTencent.Text = null;
        userPassWord.Text = null;
        //conPassWord.Text = null;
        Response.Redirect(Request.Url.ToString());
    }
    //用户名查重校验
    protected void userName_TextChanged(object sender, EventArgs e)
    {
        int selCntFirst = Convert.ToInt32(db.selDB("select count(*) ID from register where userName='" + userName.Text.Trim() + "'"));
        rfvUserName.ErrorMessage = "";
        if (selCntFirst != 0)
        {
            lbUserNameMsg.Text = "*用户名已经存在";
            lbUserNameMsg.ForeColor = System.Drawing.Color.Red;
            lbUserNameMsg.Visible = true;
            return;
        }
        else
        {
            lbUserNameMsg.ForeColor = System.Drawing.Color.Green;
            lbUserNameMsg.Text = "";
            lbUserNameMsg.Visible = true;
            return;
        }
    }
    //性别
    protected void RadioButton_CheckedChanged(object sender, EventArgs e)
    {
        if (rbMale.Checked == false && rbFeMale.Checked == false)
        {
            lbUserSexMsg.ForeColor = System.Drawing.Color.Red;
            lbUserSexMsg.Text = "*请选择性别";
            lbUserSexMsg.Visible = true;
            fl = true;
            return;
        }
        else
        {
            /*用于获取当前事件是由哪个RadioButton控件引起的。
             *这是一个RadioButton事件，
             *所以将object类型的sender参数强制转换成了RadioButton类型的参数。
             */
            //RadioButton selectedRadioButton = (RadioButton)sender;
            //sex = selectedRadioButton.Text;
            flag = true;
            lbUserSexMsg.ForeColor = System.Drawing.Color.Green;
            lbUserSexMsg.Text = "";
            lbUserSexMsg.Visible = true;
            return;
        }

    }
    //出生日期
    protected void tbBorn_TextChanged(object sender, EventArgs e)
    {
        lbDateMsg.ForeColor = System.Drawing.Color.Green;
        lbDateMsg.Text = "";
        rfvTbBorn.Visible = false;
        lbDateMsg.Visible = true;
        return;
    }
    //电话
    protected void tbPhone_TextChanged(object sender, EventArgs e)
    {
        string tel = @"(^1[3578][01379]\d{8}$)|(^1[34578][01256]\d{8}$)|(^(134[012345678]\d{7}|1[34578][012356789]\d{8})$)|((\(\d{3}\)|\d{3}-)?\d{8})";
        Regex telReg = new Regex(tel);
        if (telReg.IsMatch(tbPhone.Text.Trim()))
        {
            lbTbPhoneMsg.ForeColor = System.Drawing.Color.Green;
            lbTbPhoneMsg.Text = "";
            rfvTbPhone.Visible = false;
            lbTbPhoneMsg.Visible = true;
            return;
        }
        else
        {
            lbTbPhoneMsg.ForeColor = System.Drawing.Color.Red;
            lbTbPhoneMsg.Text = "*电话号码不合法";
            rfvTbPhone.Visible = false;
            lbTbPhoneMsg.Visible = true;
            return;
        }
    }
    //邮箱
    protected void tbMail_TextChanged(object sender, EventArgs e)
    {
        string mail = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
        Regex mailReg = new Regex(mail);
        if (mailReg.IsMatch(tbMail.Text.Trim()))
        {
            lbTbMailMsg.ForeColor = System.Drawing.Color.Green;
            lbTbMailMsg.Text = "";
            rfvTbMail.Visible = false;
            lbTbMailMsg.Visible = true;
            return;
        }
        else
        {
            lbTbMailMsg.ForeColor = System.Drawing.Color.Red;
            lbTbMailMsg.Text = "*邮箱不合法";
            rfvTbMail.Visible = false;
            lbTbMailMsg.Visible = true;
            return;
        }
    }
    //腾讯QQ
    protected void tbTencent_TextChanged(object sender, EventArgs e)
    {
        string tencent = @"^\s*[.0-9]{5,12}\s*$";
        Regex tencentReg = new Regex(tencent);
        if (tencentReg.IsMatch(tbTencent.Text.Trim()))
        {
            lbTbTencentMsg.ForeColor = System.Drawing.Color.Green;
            lbTbTencentMsg.Text = "";
            rfvTbTencent.Visible = false;
            lbTbTencentMsg.Visible = true;
            return;
        }
        else
        {
            lbTbTencentMsg.ForeColor = System.Drawing.Color.Red;
            lbTbTencentMsg.Text = "*QQ号不合法";
            rfvTbTencent.Visible = false;
            lbTbTencentMsg.Visible = true;
            return;
        }
    }
}