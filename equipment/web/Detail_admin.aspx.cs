using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Detail_admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = new DLL.BLL.admin().GetList("id=" + Request.QueryString["parameter"]);
        rptdetail.DataSource = ds;
        rptdetail.DataBind();

    }
    protected void Buttoneditor_Click(object sender, EventArgs e)
    {
        Response.Redirect("editor_admin.aspx?parameter=" + Request.QueryString["parameter"]);
    }
    protected void Buttonabandon_Click(object sender, EventArgs e)
    {
        DLL.Model.admin admin = new DLL.BLL.admin().GetModel(int.Parse(Request.QueryString["parameter"]));
        new DLL.BLL.admin().Delete(admin.id);
        Response.Redirect("List_admin.aspx");
    }
}