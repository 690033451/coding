using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class detail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            DLL.TOOL.EnumToDropdownlist.EnumToDropdown(DropDownListflag, typeof(DLL.BaseCode.BaseCode.state));
            DLL.TOOL.EnumToDropdownlist.EnumToDropdown(DropDownListdepartment, typeof(DLL.BaseCode.BaseCode.department));
            DLL.TOOL.EnumToDropdownlist.EnumToDropdown(DropDownListtype, typeof(DLL.BaseCode.BaseCode.type));
            DLL.TOOL.EnumToDropdownlist.EnumToDropdown(DropDownListnet, typeof(DLL.BaseCode.BaseCode.nettype));
            DLL.Model.computer computer = new DLL.BLL.computer().GetModel(int.Parse(Request.QueryString["parameter"]));
            DropDownListdepartment.SelectedIndex = Enum.Parse(typeof(DLL.BaseCode.BaseCode.department), computer.department).GetHashCode();
            DropDownListtype.SelectedIndex = Enum.Parse(typeof(DLL.BaseCode.BaseCode.type), computer.type).GetHashCode();
            DropDownListnet.SelectedIndex = Enum.Parse(typeof(DLL.BaseCode.BaseCode.nettype), computer.nettype).GetHashCode();
            DropDownListflag.SelectedIndex = computer.flag;
            TextBox1.Text = computer.buyTime.ToString();
            TextBox2.Text = computer.giveTime.ToString();
            if (computer.defineId != null)
            {
                TextBoxdefineId.Text = computer.defineId;
            }
          
            if (computer.innerIP != null)
            {
                TextBoxiIP.Text = computer.innerIP;
            }
            if (computer.outerIP != null)
            {
                TextBoxoIP.Text = computer.outerIP;
            }
            if (computer.brand != null)
            {
                TextBoxbrand.Text = computer.brand;
            }
            if (computer.version != null)
            {
                TextBoxversion.Text = computer.version;
            }
            if (computer.screenInfo != null)
            {
                TextBoxsInfo.Text = computer.screenInfo;
            }
            if (computer.printerInfo != null)
            {
                TextBoxpInfo.Text = computer.printerInfo;
            }
            if (computer.scannerInfo != null)
            {
                TextBoxscInfo.Text = computer.scannerInfo;
            }
            if (computer.roomNum != null)
            {
                TextBoxroom.Text = computer.roomNum.ToString();
            }
            if (computer.username != null)
            {
                TextBoxuser.Text = computer.username;
            }
            if (computer.description != null)
            {
                TextBoxdescri.Text = computer.description;
            }
            if (computer.mac != null)
            {
                TextBoxMac.Text = computer.mac;
            }
        }
    }

    protected void ImageButtonsave_Click(object sender, EventArgs e)
    {

        DLL.Model.computer computer2 = new DLL.BLL.computer().GetModel(int.Parse(Request.QueryString["parameter"]));
        computer2.defineId = TextBoxdefineId.Text.ToString();
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
        computer2.updateId = int.Parse(Session["Userid"].ToString());

        try
        {
            computer2.buyTime = Convert.ToDateTime(TextBox1.Text);
        }catch
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
        
        if (computer2.defineId == null)
        {
            computer2.defineId = "待定";
        }
        if (computer2.nettype == null)
        {
            computer2.nettype = "待定";
        }
        if (computer2.innerIP == null)
        {
            computer2.innerIP = "待定";
        }
        if (computer2.outerIP == null)
        {
            computer2.outerIP = "待定";
        }
        if (computer2.brand == null)
        {
            computer2.brand = "待定";
        }
        if (computer2.version == null)
        {
            computer2.version = "待定";
        }
        if (computer2.screenInfo == null)
        {
            computer2.screenInfo = "待定";
        }
        if (computer2.printerInfo == null)
        {
            computer2.printerInfo = "待定";
        }
        if (computer2.scannerInfo == null)
        {
            computer2.scannerInfo = "待定";
        }
        if (computer2.roomNum == null)
        {
            computer2.roomNum = "待定";
        }
        if (computer2.username == null)
        {
            computer2.username = "待定";
        }
        if (computer2.description == null)
        {
            computer2.description = "待定";
        }
        if (computer2.mac == null)
        {
            computer2.mac = "待定";
        }
        new DLL.BLL.computer().Update(computer2);
        Response.Redirect("detail.aspx?parameter=" + computer2.id);
    }
}