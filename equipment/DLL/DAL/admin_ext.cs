using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DB;
using System.Data;
using System.Data.SqlClient;
using DLL;

namespace DLL.DAL
{
    public partial class admin
    {
        /// <summary>
        /// 登录检验
        /// </summary>
        public string Login(string loginname, string password)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id from admin");
            strSql.Append(" where userId=@loginname and password=@password");
            SqlParameter[] parameters = {
					new SqlParameter("@loginname", SqlDbType.VarChar,50),
                    new SqlParameter("@password", SqlDbType.VarChar,50)
			};
            parameters[0].Value = loginname;
            parameters[1].Value = DLL.TOOL.Strings.Encrypt(password);
            //parameters[1].Value = password;
            if (DLL.DB.SQLHelper.DataSetSelect(strSql.ToString(), parameters).Tables[0].Rows.Count == 0)
            {
                return "";
            }
            else
            {
                DLL.Model.admin user = new DLL.DAL.admin().GetModel(int.Parse(DLL.DB.SQLHelper.FastSelect(strSql.ToString(), parameters)));
                String name = user.username;                
                System.Web.HttpContext.Current.Session["Username"] = name;
                System.Web.HttpContext.Current.Session["Userid"] = user.id;
                return "List_equipment.aspx";
            }
        }
    }
}
