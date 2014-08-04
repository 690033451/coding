using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class thisrepairadd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DLL.Model.computer computer2 = new DLL.BLL.computer().GetModel(int.Parse(Request.QueryString["parameter"]));
        if(!IsPostBack)
        {
            LabeldefineId.Text = computer2.defineId;
        }
    }
    protected void saveImageButton_Click(object sender, EventArgs e)
    {
        DLL.Model.computer computer2 = new DLL.BLL.computer().GetModel(int.Parse(Request.QueryString["parameter"]));
        DLL.Model.loginfo loginfo = new DLL.Model.loginfo();
        DLL.Model.repair repair = new DLL.Model.repair();
        repair.computerId =computer2.id;
        repair.defineId = computer2.defineId;
        repair.ftype = ftypeTextBox.Text.ToString().Trim();
        repair.result = resultTextBox.Text.ToString().Trim();
        repair.adminId = int.Parse(Session["Userid"].ToString());
        repair.adminname = Session["Username"].ToString();
        new DLL.BLL.repair().Add(repair);
        Response.Redirect("thisrepair.aspx?parameter=" + Request.QueryString["parameter"]);
    }
    protected void LinkButtondetail_Click(object sender, EventArgs e)
    {
        Response.Redirect("Detail.aspx?parameter=" + Request.QueryString["parameter"]);
    }
}