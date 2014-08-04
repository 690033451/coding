using System;
using System.Data;
using System.Collections.Generic;
using DLL.Model;
namespace DLL.BLL
{
    /// <summary>
    /// computer
    /// </summary>
    public partial class computer
    {
        private readonly DLL.DAL.computer dal = new DLL.DAL.computer();
        DLL.Model.loginfo loginfo = new DLL.Model.loginfo();
        public computer()
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
        public int Add(DLL.Model.computer model)
        {
            int computerId = dal.Add(model);
            if(computerId!=0)
            {
                loginfo.adminname = System.Web.HttpContext.Current.Session["Username"].ToString();
                loginfo.action = "添加";
                loginfo.objectname = "设备编号为：" + model.defineId;
                new DLL.BLL.loginfo().Add(loginfo);   
            }
            return computerId;
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(DLL.Model.computer model)
        {
            Boolean flag = dal.Update(model);
            if(flag==true)
            {
                loginfo.adminname = System.Web.HttpContext.Current.Session["Username"].ToString();
                if(model.flag!=2&&model.flag!=3)
                {
                   loginfo.action = "更改";
                }
                else if (model.flag == 2)
                {
                    loginfo.action = "报废";
                }
                else if (model.flag == 3)
                {
                    loginfo.action = "借出";
                }
                loginfo.objectname = "设备编号为：" + model.defineId;
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
        public DLL.Model.computer GetModel(int id)
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
        public List<DLL.Model.computer> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<DLL.Model.computer> DataTableToList(DataTable dt)
        {
            List<DLL.Model.computer> modelList = new List<DLL.Model.computer>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                DLL.Model.computer model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new DLL.Model.computer();
                    if (dt.Rows[n]["id"] != null && dt.Rows[n]["id"].ToString() != "")
                    {
                        model.id = int.Parse(dt.Rows[n]["id"].ToString());
                    }
                    if (dt.Rows[n]["defineId"] != null && dt.Rows[n]["defineId"].ToString() != "")
                    {
                        model.defineId = dt.Rows[n]["defineId"].ToString();
                    }
                    if (dt.Rows[n]["type"] != null && dt.Rows[n]["type"].ToString() != "")
                    {
                        model.type = dt.Rows[n]["type"].ToString();
                    }
                    if (dt.Rows[n]["brand"] != null && dt.Rows[n]["brand"].ToString() != "")
                    {
                        model.brand = dt.Rows[n]["brand"].ToString();
                    }
                    if (dt.Rows[n]["version"] != null && dt.Rows[n]["version"].ToString() != "")
                    {
                        model.version = dt.Rows[n]["version"].ToString();
                    }
                    if (dt.Rows[n]["mac"] != null && dt.Rows[n]["mac"].ToString() != "")
                    {
                        model.mac = dt.Rows[n]["mac"].ToString();
                    }
                    if (dt.Rows[n]["nettype"] != null && dt.Rows[n]["nettype"].ToString() != "")
                    {
                        model.nettype = dt.Rows[n]["nettype"].ToString();
                    }
                    if (dt.Rows[n]["innerIP"] != null && dt.Rows[n]["innerIP"].ToString() != "")
                    {
                        model.innerIP = dt.Rows[n]["innerIP"].ToString();
                    }
                    if (dt.Rows[n]["outerIP"] != null && dt.Rows[n]["outerIP"].ToString() != "")
                    {
                        model.outerIP = dt.Rows[n]["outerIP"].ToString();
                    }
                    if (dt.Rows[n]["screenInfo"] != null && dt.Rows[n]["screenInfo"].ToString() != "")
                    {
                        model.screenInfo = dt.Rows[n]["screenInfo"].ToString();
                    }
                    if (dt.Rows[n]["printerInfo"] != null && dt.Rows[n]["printerInfo"].ToString() != "")
                    {
                        model.printerInfo = dt.Rows[n]["printerInfo"].ToString();
                    }
                    if (dt.Rows[n]["scannerInfo"] != null && dt.Rows[n]["scannerInfo"].ToString() != "")
                    {
                        model.scannerInfo = dt.Rows[n]["scannerInfo"].ToString();
                    }
                    if (dt.Rows[n]["roomNum"] != null && dt.Rows[n]["roomNum"].ToString() != "")
                    {
                        model.roomNum = dt.Rows[n]["roomNum"].ToString();
                    }
                    if (dt.Rows[n]["department"] != null && dt.Rows[n]["department"].ToString() != "")
                    {
                        model.department = dt.Rows[n]["department"].ToString();
                    }
                    if (dt.Rows[n]["username"] != null && dt.Rows[n]["username"].ToString() != "")
                    {
                        model.username = dt.Rows[n]["username"].ToString();
                    }
                    if (dt.Rows[n]["addId"] != null && dt.Rows[n]["addId"].ToString() != "")
                    {
                        model.addId = int.Parse(dt.Rows[n]["addId"].ToString());
                    }
                    if (dt.Rows[n]["addtime"] != null && dt.Rows[n]["addtime"].ToString() != "")
                    {
                        model.addtime = DateTime.Parse(dt.Rows[n]["addtime"].ToString());
                    }
                    if (dt.Rows[n]["updateId"] != null && dt.Rows[n]["updateId"].ToString() != "")
                    {
                        model.updateId = int.Parse(dt.Rows[n]["updateId"].ToString());
                    }
                    if (dt.Rows[n]["updateTime"] != null && dt.Rows[n]["updateTime"].ToString() != "")
                    {
                        model.updateTime = DateTime.Parse(dt.Rows[n]["updateTime"].ToString());
                    }
                    if (dt.Rows[n]["description"] != null && dt.Rows[n]["description"].ToString() != "")
                    {
                        model.description = dt.Rows[n]["description"].ToString();
                    }
                    if (dt.Rows[n]["flag"] != null && dt.Rows[n]["flag"].ToString() != "")
                    {
                        model.flag = int.Parse(dt.Rows[n]["flag"].ToString());
                    }
                    if (dt.Rows[n]["buyTime"] != null && dt.Rows[n]["buyTime"].ToString() != "")
                    {
                        model.buyTime = DateTime.Parse(dt.Rows[n]["buyTime"].ToString());
                    }
                    if (dt.Rows[n]["giveTime"] != null && dt.Rows[n]["giveTime"].ToString() != "")
                    {
                        model.giveTime = DateTime.Parse(dt.Rows[n]["giveTime"].ToString());
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

