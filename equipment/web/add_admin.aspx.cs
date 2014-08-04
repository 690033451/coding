using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DLL;

public partial class add_admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void saveImageButton_Click(object sender, EventArgs e)
    {
        DLL.Model.loginfo loginfo = new DLL.Model.loginfo();
        DLL.Model.admin admin = new DLL.Model.admin();
        admin.userId = loginTextBox.Text.ToString().Trim();
        admin.password = psyTextBox.Text.ToString().Trim();
        admin.username = userTextBox.Text.ToString().Trim();
        admin.tel = telTextBox.Text.ToString().Trim();
        new DLL.BLL.admin().Add(admin);
        Response.Redirect("List_admin.aspx");
    }
}