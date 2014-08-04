using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adds : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.queren.Visible = false;

        }
    }

    protected void saveImageButton_Click1(object sender, EventArgs e)
    {
        DLL.Model.loginfo loginfo = new DLL.Model.loginfo();
        DLL.Model.repair repair = new DLL.Model.repair();
        repair.defineId = cidTextBox.Text.ToString().Trim();
        repair.computerId = new DLL.BLL.computer().GetId(repair.defineId);
        repair.ftype = ftypeTextBox.Text.ToString().Trim();
        repair.result = resultTextBox.Text.ToString().Trim();
        repair.adminId = int.Parse(Session["Userid"].ToString());
        repair.adminname = Session["Username"].ToString();
        if (repair.defineId!="")
        {        
            new DLL.BLL.repair().Add(repair);
            Response.Redirect("repair.aspx");
        }
        else
        {
            this.queren.Visible = true;
        }
    }
    protected void Buttonqueren_Click(object sender, EventArgs e)
    {
        this.queren.Visible = false;
    }
}