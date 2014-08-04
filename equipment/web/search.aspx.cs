using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DLL;

public partial class search : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DLL.TOOL.EnumToDropdownlist.EnumToDropdown(DropDownListtype, typeof(DLL.BaseCode.BaseCode.type));
            DropDownListtype.SelectedIndex = 0;
        }     
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         DLL.Model.computer computer = new DLL.Model.computer();
         computer.defineId = TextBoxdefine.Text.Trim();
         computer.brand = TextBoxbrand.Text.Trim();
         computer.version = TextBoxversion.Text.Trim();
         computer.username = TextBoxuser.Text.Trim();
         computer.type = Enum.GetName(typeof(DLL.BaseCode.BaseCode.type), DropDownListtype.SelectedIndex);
         computer.nettype = TextBoxnet.Text.Trim();
         computer.department = TextBoxdepart.Text.Trim();
         computer.roomNum = TextBoxroom.Text.Trim();
         
    }
}