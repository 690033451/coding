using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DLL;

public partial class repair_editor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String url;
        if (!IsPostBack)
        {
            DataSet ds = new DLL.BLL.repair().GetList("id=" + Request.QueryString["parameter"]);
            rpteditor.DataSource = ds;
            rpteditor.DataBind();
            DLL.Model.repair repair = new DLL.BLL.repair().GetModel(int.Parse(Request.QueryString["parameter"]));
            TextBoxftype.Text = repair.ftype;
            TextBoxresult.Text = repair.result;
            url = Request.UrlReferrer.ToString();
            ViewState["url"] = url;
        }
    }

    protected void ImageButtonsave_Click(object sender, EventArgs e)
    {
        DLL.Model.repair repair = new DLL.BLL.repair().GetModel(int.Parse(Request.QueryString["parameter"]));
        repair.ftype = TextBoxftype.Text;
        repair.result = TextBoxresult.Text;
        new DLL.BLL.repair().Update(repair);
        Response.Redirect(ViewState["url"].ToString());
    }
}