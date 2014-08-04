using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DLL.BLL;


public partial class index : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        this.diverror.Visible = false;
    }
    protected void loginImageButton_Click(object sender, ImageClickEventArgs e)
    {
            
        if (usernameTextBox.Text.Trim() != "" && passwordTextBox.Text.Trim() != "")
        {
            string url = new DLL.BLL.admin().Login(usernameTextBox.Text, passwordTextBox.Text);
            if (url == "")
            {                
                this.diverror.Visible = true;                
               // Response.Redirect("index.aspx");
                //Response.Write("<script>alert('用户名密码错误')</script>");
            }
            else { Response.Redirect(url); }
        }
    }
    protected void Buttonqueren_Click(object sender, EventArgs e)
    {
        this.diverror.Visible = false;  
    }
}