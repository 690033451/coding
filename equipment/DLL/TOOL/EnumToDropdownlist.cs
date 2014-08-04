using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL.TOOL
{
    public class EnumToDropdownlist
    {
        public static void EnumToDropdown(System.Web.UI.WebControls.DropDownList dl, Type en) 
        {            
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            foreach (int i in Enum.GetValues(en))
            {
                System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem();
                li.Text = Enum.GetName(en, i);
                li.Value = i.ToString();
                list.Add(li);
            }
            dl.DataSource = list;
            dl.DataTextField = "Text";
            dl.DataValueField = "Value";
            dl.DataBind();
        }
        public static void EnumToDropdown(System.Web.UI.WebControls.RadioButtonList dl, Type en)
        {
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            foreach (int i in Enum.GetValues(en))
            {
                System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem();
                li.Text = Enum.GetName(en, i);
                li.Value = i.ToString();
                list.Add(li);
            }
            dl.DataSource = list;
            dl.DataTextField = "Text";
            dl.DataValueField = "Value";
            dl.DataBind();
        }
    }
}
