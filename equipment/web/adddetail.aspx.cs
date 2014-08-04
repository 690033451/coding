using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adddetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DLL.TOOL.EnumToDropdownlist.EnumToDropdown(DropDownListflag, typeof(DLL.BaseCode.BaseCode.state));
            DLL.TOOL.EnumToDropdownlist.EnumToDropdown(DropDownListdepartment, typeof(DLL.BaseCode.BaseCode.department));
            DLL.TOOL.EnumToDropdownlist.EnumToDropdown(DropDownListtype, typeof(DLL.BaseCode.BaseCode.type));
            DLL.TOOL.EnumToDropdownlist.EnumToDropdown(DropDownListnet, typeof(DLL.BaseCode.BaseCode.nettype));
            DropDownListtype.SelectedIndex = 0;
            DropDownListdepartment.SelectedIndex = 0;
            DropDownListflag.SelectedIndex = 0;           
        }
    }
    protected void ImageButtonsave_Click(object sender, EventArgs e)
    {
       
        DLL.Model.computer computer2 = new DLL.Model.computer();
        computer2.defineId = TextBoxdefineId.Text.Trim().ToString();
        computer2.type = Enum.GetName(typeof(DLL.BaseCode.BaseCode.type), DropDownListtype.SelectedIndex);
        computer2.brand = TextBoxbrand.Text.ToString();
        computer2.version = TextBoxversion.Text.ToString();
        computer2.nettype = Enum.GetName(typeof(DLL.BaseCode.BaseCode.nettype), DropDownListnet.SelectedIndex);
        computer2.innerIP = TextBoxiIP.Text.ToString();
        computer2.outerIP = TextBoxoIP.Text.ToString();
        computer2.screenInfo = TextBoxsInfo.Text.ToString();
        computer2.printerInfo = TextBoxpInfo.Text.ToString();
        computer2.scannerInfo = TextBoxscInfo.Text.ToString();
        computer2.roomNum = TextBoxroom.Text;
        computer2.department = Enum.GetName(typeof(DLL.BaseCode.BaseCode.department), DropDownListdepartment.SelectedIndex);
        computer2.username = TextBoxuser.Text.ToString();
        computer2.description = TextBoxdescri.Text.ToString();
        computer2.flag = int.Parse(DropDownListflag.SelectedValue);
        computer2.mac = TextBoxMac.Text;
        computer2.addId = int.Parse(Session["Userid"].ToString());
        computer2.updateId = int.Parse(Session["Userid"].ToString());
        try
        {
            computer2.buyTime = Convert.ToDateTime(TextBox1.Text);
        }
        catch
        {
            computer2.buyTime = null;
        }
        try
        {
            computer2.giveTime = Convert.ToDateTime(TextBox2.Text);
        }
        catch
        {
            computer2.giveTime = null;
        }
        new DLL.BLL.computer().Add(computer2);
        Response.Redirect("List_equipment.aspx");

    }
    protected void Buttoncontinue_Click(object sender, EventArgs e)
    {
        DLL.Model.computer computer2 = new DLL.Model.computer();
        computer2.defineId = TextBoxdefineId.Text.Trim().ToString();
        computer2.type = Enum.GetName(typeof(DLL.BaseCode.BaseCode.type), DropDownListtype.SelectedIndex);
        computer2.brand = TextBoxbrand.Text.ToString();
        computer2.version = TextBoxversion.Text.ToString();
        computer2.nettype = Enum.GetName(typeof(DLL.BaseCode.BaseCode.nettype), DropDownListnet.SelectedIndex);
        computer2.innerIP = TextBoxiIP.Text.ToString();
        computer2.outerIP = TextBoxoIP.Text.ToString();
        computer2.screenInfo = TextBoxsInfo.Text.ToString();
        computer2.printerInfo = TextBoxpInfo.Text.ToString();
        computer2.scannerInfo = TextBoxscInfo.Text.ToString();
        computer2.roomNum = TextBoxroom.Text;
        computer2.department = Enum.GetName(typeof(DLL.BaseCode.BaseCode.department), DropDownListdepartment.SelectedIndex);
        computer2.username = TextBoxuser.Text.ToString();
        computer2.description = TextBoxdescri.Text.ToString();
        computer2.flag = int.Parse(DropDownListflag.SelectedValue);
        computer2.mac = TextBoxMac.Text;
        computer2.addId = int.Parse(Session["Userid"].ToString());
        computer2.updateId = int.Parse(Session["Userid"].ToString());
        try
        {
            computer2.buyTime = Convert.ToDateTime(TextBox1.Text);
        }
        catch
        {
            computer2.buyTime = null;
        }
        try
        {
            computer2.giveTime = Convert.ToDateTime(TextBox2.Text);
        }
        catch
        {
            computer2.giveTime = null;
        }
        new DLL.BLL.computer().Add(computer2);
        Response.Redirect("adddetail.aspx");
    }
}