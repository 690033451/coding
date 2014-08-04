using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DLL.TOOL.EnumToDropdownlist.EnumToDropdown(DropDownListtype, typeof(DLL.BaseCode.BaseCode.type));
            DropDownListtype.SelectedIndex = 0;
        }      

    }


    protected void saveButton_Click(object sender, EventArgs e)
    {
        String type = Enum.GetName(typeof(DLL.BaseCode.BaseCode.type), DropDownListtype.SelectedIndex);        
        String brand = brandTextBox.Text;
        String version = versionTextBox.Text;
        String description = descTextBox.Text;
        DLL.Model.computer computer = new DLL.Model.computer();
        computer.defineId = "待定";
        computer.type = type;
        computer.brand = brand;
        computer.version = version;
        computer.description = description;
        computer.addId = int.Parse(Session["Userid"].ToString());
        int num = int.Parse(TextBoxnum.Text);
        if (computer.defineId == "")
        {
            computer.defineId = "待定";
        }
        if (computer.nettype == "")
        {
            computer.nettype = "待定";
        }
        if (computer.innerIP == "")
        {
            computer.innerIP = "待定";
        }
        if (computer.outerIP == "")
        {
            computer.outerIP = "待定";
        }
        if (computer.brand == "")
        {
            computer.brand = "待定";
        }
        if (computer.version == "")
        {
            computer.version = "待定";
        }
        if (computer.screenInfo == "")
        {
            computer.screenInfo = "待定";
        }
        if (computer.printerInfo == "")
        {
            computer.printerInfo = "待定";
        }
        if (computer.scannerInfo == "")
        {
            computer.scannerInfo = "待定";
        }
        if (computer.roomNum == "")
        {
            computer.roomNum = "待定";
        }
        if (computer.username == "")
        {
            computer.username = "待定";
        }
        if (computer.description == "")
        {
            computer.description = "待定";
        }
        if (computer.mac == "")
        {
            computer.mac = "待定";
        }
        new DLL.BLL.computer().addcomputers(computer,num);
        Response.Redirect("List_equipment.aspx");
    }
}