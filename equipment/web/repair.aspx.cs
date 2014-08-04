using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class repair : System.Web.UI.Page
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
        DataSet ds = new DLL.BLL.repair().GetList("1=1 order by addTime desc");
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
}