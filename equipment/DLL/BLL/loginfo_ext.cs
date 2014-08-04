using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL.BLL
{
    public partial class loginfo
    {
        public Boolean deleteAll()
        {
            Boolean flag = dal.deleteAll();
            if ( flag==true)
            {
                DLL.Model.loginfo loginfo = new DLL.Model.loginfo();
                loginfo.adminname = System.Web.HttpContext.Current.Session["Username"].ToString();
                loginfo.action = "删除";
                loginfo.objectname = "所有日志";
                new DLL.BLL.loginfo().Add(loginfo);                
            }
            return flag;
        }
    }
}
