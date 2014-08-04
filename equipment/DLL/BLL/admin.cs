using System;
using System.Data;
using System.Collections.Generic;
using DLL.Model;
namespace DLL.BLL
{
    /// <summary>
    /// admin
    /// </summary>
    public partial class admin
    {
        private readonly DLL.DAL.admin dal = new DLL.DAL.admin();
        public admin()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            return dal.Exists(id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(DLL.Model.admin model)
        {
            int adminid = dal.Add(model);
            if (adminid != 0) 
            {
                loginfo.adminname = System.Web.HttpContext.Current.Session["Username"].ToString();
                loginfo.action = "添加";
                loginfo.objectname = "管理员：" + model.username;
                new DLL.BLL.loginfo().Add(loginfo);   
            }                        
            return adminid;
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(DLL.Model.admin model)
        {
            Boolean flag = dal.Update(model);
            if (flag == true)
            {
                loginfo.adminname = System.Web.HttpContext.Current.Session["Username"].ToString();
                loginfo.action = "修改";
                loginfo.objectname = "管理员：" + model.username + "的信息";
                new DLL.BLL.loginfo().Add(loginfo);
            }
            return flag;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            loginfo.objectname = "管理员：" + getname(id);
            Boolean flag = dal.Delete(id);
            if (flag == true)
            {
                loginfo.adminname = System.Web.HttpContext.Current.Session["Username"].ToString();
                loginfo.action = "删除";
                new DLL.BLL.loginfo().Add(loginfo);
            }

            return flag;
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            return dal.DeleteList(idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public DLL.Model.admin GetModel(int id)
        {

            return dal.GetModel(id);
        }

      

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<DLL.Model.admin> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<DLL.Model.admin> DataTableToList(DataTable dt)
        {
            List<DLL.Model.admin> modelList = new List<DLL.Model.admin>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                DLL.Model.admin model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new DLL.Model.admin();
                    if (dt.Rows[n]["id"] != null && dt.Rows[n]["id"].ToString() != "")
                    {
                        model.id = int.Parse(dt.Rows[n]["id"].ToString());
                    }
                    if (dt.Rows[n]["username"] != null && dt.Rows[n]["username"].ToString() != "")
                    {
                        model.username = dt.Rows[n]["username"].ToString();
                    }
                    if (dt.Rows[n]["tel"] != null && dt.Rows[n]["tel"].ToString() != "")
                    {
                        model.tel = dt.Rows[n]["tel"].ToString();
                    }
                    if (dt.Rows[n]["userId"] != null && dt.Rows[n]["userId"].ToString() != "")
                    {
                        model.userId = dt.Rows[n]["userId"].ToString();
                    }
                    if (dt.Rows[n]["password"] != null && dt.Rows[n]["password"].ToString() != "")
                    {
                        model.password = dt.Rows[n]["password"].ToString();
                    }
                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  Method
    }
}

