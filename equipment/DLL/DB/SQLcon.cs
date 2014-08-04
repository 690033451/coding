//======================================================================
//
//        Copyright (C) 2010 
//        All rights reserved
//        CLR版本:            2.0.50727.3053
//        机器名称:            LG-PC
//        文件名:              SQLcon
//        当前系统时间:      2010-4-22 13:43:15
//        当前登录用户名:   Admin
//        用户:   李钢
//
//======================================================================
using System.Configuration;

namespace DLL.DB
{
    public class SQLcon
    {
        /// <summary>
        /// sql连接字符
        /// </summary>
        //        private static readonly string strconn = ConfigurationManager.ConnectionStrings["core"].ConnectionString;
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        /// <returns>返回一个数据库字符串</returns>
        public static string ReturnConnStr()
        {
            string strconn = ConfigurationManager.ConnectionStrings["core"].ConnectionString;
            //if (System.Web.HttpContext.Current.Session["sql"] != null)
            //{
            //    return ConfigurationManager.ConnectionStrings[System.Web.HttpContext.Current.Session["sql"].ToString()].ConnectionString;
            //}
            return strconn;
        }
    }
}
