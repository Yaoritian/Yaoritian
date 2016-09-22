using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string sql = "";
        LoginIn.isAccount(sql);
        //第一种方法是 在UI层拼接好sql 传 BLL再传DAL
        //第二种方法是 在UI层传账号密码 到BLL层 拼接好后传到DAL层
    }
}