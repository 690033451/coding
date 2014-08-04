using System;
using System.Data;
using System.Collections.Generic;

using DLL.Model;
namespace DLL.BLL
{
    /// <summary>
    /// repair
    /// </summary>
    public partial class repair
    {
        private readonly DLL.DAL.repair dal = new DLL.DAL.repair();
        DLL.Model.loginfo loginfo = new DLL.Model.loginfo(); 
        public repair()
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
        public int Add(DLL.Model.repair model)
        {
            int repairId = dal.Add(model);
            if(repairId!=0)
            {
                loginfo.adminname = System.Web.HttpContext.Current.Session["Username"].ToString();
                loginfo.action = "添加";
                loginfo.objectname = "电脑编号为" + model.computerId + "的维修信息";
                new DLL.BLL.loginfo().Add(loginfo);
            }
            return repairId;
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(DLL.Model.repair model)
        {
            Boolean flag = dal.Update(model);
            if (flag == true) 
            {
                loginfo.adminname = System.Web.HttpContext.Current.Session["Username"].ToString();
                loginfo.action = "修改";
                loginfo.objectname = "电脑编号为" + model.computerId + ")的维修信息";
                new DLL.BLL.loginfo().Add(loginfo);
            }
            return flag;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            return dal.Delete(id);
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
        public DLL.Model.repair GetModel(int id)
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
        public List<DLL.Model.repair> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<DLL.Model.repair> DataTableToList(DataTable dt)
        {
            List<DLL.Model.repair> modelList = new List<DLL.Model.repair>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                DLL.Model.repair model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new DLL.Model.repair();
                    if (dt.Rows[n]["id"] != null && dt.Rows[n]["id"].ToString() != "")
                    {
                        model.id = int.Parse(dt.Rows[n]["id"].ToString());
                    }
                    if (dt.Rows[n]["computerId"] != null && dt.Rows[n]["computerId"].ToString() != "")
                    {
                        model.computerId = int.Parse(dt.Rows[n]["computerId"].ToString());
                    }
                    if (dt.Rows[n]["adminId"] != null && dt.Rows[n]["adminId"].ToString() != "")
                    {
                        model.adminId = int.Parse(dt.Rows[n]["adminId"].ToString());
                    }
                    if (dt.Rows[n]["ftype"] != null && dt.Rows[n]["ftype"].ToString() != "")
                    {
                        model.ftype = dt.Rows[n]["ftype"].ToString();
                    }
                    if (dt.Rows[n]["result"] != null && dt.Rows[n]["result"].ToString() != "")
                    {
                        model.result = dt.Rows[n]["result"].ToString();
                    }
                    if (dt.Rows[n]["addTime"] != null && dt.Rows[n]["addTime"].ToString() != "")
                    {
                        model.addTime = DateTime.Parse(dt.Rows[n]["addTime"].ToString());
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

