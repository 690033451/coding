using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class editor_admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DLL.Model.admin admin = new DLL.BLL.admin().GetModel(int.Parse(Request.QueryString["parameter"]));
            loginTextBox.Text = admin.userId;
            psyTextBox.Text = admin.password;
            telTextBox.Text = admin.tel;
            userTextBox.Text = admin.username;
        }

    }
    protected void saveImageButton_Click(object sender, EventArgs e)
    {
        DLL.Model.admin admin = new DLL.BLL.admin().GetModel(int.Parse(Request.QueryString["parameter"]));
        admin.userId = loginTextBox.Text;
        if (psyTextBox.Text != "")
        {
            admin.password = psyTextBox.Text;
        }
        admin.tel = telTextBox.Text;
        admin.username = userTextBox.Text;
        new DLL.BLL.admin().Update(admin);
        Response.Redirect("List_admin.aspx");
    }
}