using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_SecurityConfigurations : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            AdminUserName.Text = ConfigurationManager.AppSettings["adminUserName"];
            AdminPassword.Text = ConfigurationManager.AppSettings["adminPassword"];
            DefaultPassword.Text = ConfigurationManager.AppSettings["newUserPassword"];
        }
    }

    protected void FillInForm_Click(object sender, EventArgs e)
    {
        var userName = Parent.FindControl("UserName") as TextBox;
        var password = Parent.FindControl("Password") as TextBox;
        if(userName != null && password != null)
        {
            userName.Text = AdminUserName.Text;
            password.TextMode = TextBoxMode.SingleLine;
            password.Text = AdminPassword.Text;
        }
    }
}