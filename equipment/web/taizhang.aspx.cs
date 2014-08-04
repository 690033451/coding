using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class taizhang : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
        if (Session["Username"] == null)
            Response.Redirect("index.aspx");
    }
    protected void bind()
    {
        DataSet ds = new DLL.BLL.computer().GetList("type!='其他设备' order by addTime desc");
        rptList.DataSource = ds;
        rptList.DataBind();
        //if (ds != null)
        //{
        //    if (ds.Tables.Count != 0)
        //    {
        //        if (ds.Tables[0].Rows.Count < 10)
        //        {
        //            DataPager1.Visible = false;
        //        }
        //    }
        //}
    }
}