using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class log : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.delete.Visible = false;   
            bind();
        }
       
    }
    protected void bind()
    {
        DataSet ds = new DLL.BLL.loginfo().GetList("1=1 order by addTime desc");
        rptList.DataSource = ds;
        rptList.DataBind();
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

    protected void xiaoshi(object sender, EventArgs e)
    {
        this.delete.Visible = false;        
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        this.delete.Visible = true;        
        //new DLL.BLL.loginfo().deleteAll();
        //Response.Redirect("log.aspx");
    }
    protected void qingkong(object sender, EventArgs e)
    {        
        new DLL.BLL.loginfo().deleteAll();
        Response.Redirect("log.aspx");
    }
}