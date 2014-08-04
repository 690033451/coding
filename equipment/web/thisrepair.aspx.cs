using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class thisrepair : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            bind();
        }
       
    }
    protected void bind()
    {
        DataSet ds = new DLL.BLL.repair().GetList("computerId=" + Request.QueryString["parameter"]+"order by addTime desc");
        rptrepair.DataSource = ds;
        rptrepair.DataBind();
        if (ds != null)
        {
            if (ds.Tables.Count != 0)
            {
                if (ds.Tables[0].Rows.Count < 10)
                {
                    DataPager1.Visible = false;
                }
            }
        }
    }
    protected void rptList_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
    {
        DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
        bind();
    }
    protected void buttonredetail_Click(object sender, EventArgs e)
    {
        Response.Redirect("detail.aspx?parameter=" + Request.QueryString["parameter"]);
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("thisrepairadd.aspx?parameter=" + Request.QueryString["parameter"]);
    }
    protected void LinkButtondetail_Click(object sender, EventArgs e)
    {
        Response.Redirect("Detail.aspx?parameter=" + Request.QueryString["parameter"]);
    }
}