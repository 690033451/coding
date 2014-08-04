using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class print : System.Web.UI.Page
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
    private void Export(String FileType, String FileName)
    {

        bind();
        Response.Clear();
        Response.BufferOutput = true;
        //设定输出字符集
        Response.Charset = "GB2312";
        Response.ContentEncoding = System.Text.Encoding.UTF8;
        Response.AppendHeader("Content-Disposition", "attachment;filename="
        + HttpUtility.UrlEncode(FileName, System.Text.Encoding.UTF8));
        //设置输出流HttpMiME类型(导出文件格式)
        Response.ContentType = FileType;
        //关闭ViewState
        Page.EnableViewState = false;
        System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("ZH-CN", true);
        System.IO.StringWriter stringWriter = new System.IO.StringWriter(cultureInfo);
        HtmlTextWriter textWriter = new HtmlTextWriter(stringWriter);
        rptList.RenderControl(textWriter);
        //把HTML写回游览器
        Response.Write(stringWriter.ToString());
        Response.End();
        Response.Flush();
    }
    protected void bind()
    {
        DataSet ds = new DLL.BLL.computer().GetList("flag!=2 order by addTime desc");
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
    //protected void rptList_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
    //{
    //    DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
    //    bind();
    //}
    protected void Buttonprint_Click(object sender, EventArgs e)
    {
        Export("application/ms-excel", "台帐.xls");
    }
}