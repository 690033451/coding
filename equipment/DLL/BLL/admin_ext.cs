using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Web;




namespace DLL.BLL
{
    public partial class  admin
    {
        DLL.Model.loginfo loginfo = new DLL.Model.loginfo();
        /// <summary>
        /// 登录检验
        /// </summary>
        public string Login(string loginname, string password)
        {
            String str = dal.Login(loginname,password);
            if (str != "")
            {
                HttpRequest Request = HttpContext.Current.Request; 
                loginfo.adminname = System.Web.HttpContext.Current.Session["Username"].ToString();
                loginfo.action = "登录";
                loginfo.objectname ="电脑IP："+ Request.UserHostAddress;
                new DLL.BLL.loginfo().Add(loginfo);           
            }
            return str;
        }
        /// <summary>
        /// 根据id获取用户名
        /// </summary>
        public String getname(int id)
        {
            DLL.Model.admin admin = new DLL.DAL.admin().GetModel(id);
            return admin.username;
        }
    }
}
