using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DB;//Please add references
namespace DLL.DAL
{
    /// <summary>
    /// 数据访问类:repair
    /// </summary>
    public partial class repair
    {
        public repair()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from repair");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(DLL.Model.repair model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into repair(");
            strSql.Append("computerId,defineId,adminId,adminname,ftype,result,addTime)");
            strSql.Append(" values (");
            strSql.Append("@computerId,@defineId,@adminId,@adminname,@ftype,@result,@addTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@computerId", SqlDbType.Int,4),
					new SqlParameter("@defineId", SqlDbType.VarChar,500),
					new SqlParameter("@adminId", SqlDbType.Int,4),
					new SqlParameter("@adminname", SqlDbType.VarChar,500),
					new SqlParameter("@ftype", SqlDbType.VarChar,500),
					new SqlParameter("@result", SqlDbType.VarChar),
					new SqlParameter("@addTime", SqlDbType.DateTime)};
            parameters[0].Value = model.computerId;
            parameters[1].Value = model.defineId;
            parameters[2].Value = model.adminId;
            parameters[3].Value = model.adminname;
            parameters[4].Value = model.ftype;
            parameters[5].Value = model.result;
            parameters[6].Value = System.DateTime.Now;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(DLL.Model.repair model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update repair set ");
            strSql.Append("computerId=@computerId,");
            strSql.Append("defineId=@defineId,");
            strSql.Append("adminId=@adminId,");
            strSql.Append("adminname=@adminname,");
            strSql.Append("ftype=@ftype,");
            strSql.Append("result=@result,");
            strSql.Append("addTime=@addTime");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@computerId", SqlDbType.Int,4),
					new SqlParameter("@defineId", SqlDbType.VarChar,500),
					new SqlParameter("@adminId", SqlDbType.Int,4),
					new SqlParameter("@adminname", SqlDbType.VarChar,500),
					new SqlParameter("@ftype", SqlDbType.VarChar,500),
					new SqlParameter("@result", SqlDbType.VarChar),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.computerId;
            parameters[1].Value = model.defineId;
            parameters[2].Value = model.adminId;
            parameters[3].Value = model.adminname;
            parameters[4].Value = model.ftype;
            parameters[5].Value = model.result;
            parameters[6].Value = model.addTime;
            parameters[7].Value = model.id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from repair ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from repair ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public DLL.Model.repair GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,computerId,defineId,adminId,adminname,ftype,result,addTime from repair ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            DLL.Model.repair model = new DLL.Model.repair();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["computerId"] != null && ds.Tables[0].Rows[0]["computerId"].ToString() != "")
                {
                    model.computerId = int.Parse(ds.Tables[0].Rows[0]["computerId"].ToString());
                }
                if (ds.Tables[0].Rows[0]["defineId"] != null && ds.Tables[0].Rows[0]["defineId"].ToString() != "")
                {
                    model.defineId = ds.Tables[0].Rows[0]["defineId"].ToString();
                }
                if (ds.Tables[0].Rows[0]["adminId"] != null && ds.Tables[0].Rows[0]["adminId"].ToString() != "")
                {
                    model.adminId = int.Parse(ds.Tables[0].Rows[0]["adminId"].ToString());
                }
                if (ds.Tables[0].Rows[0]["adminname"] != null && ds.Tables[0].Rows[0]["adminname"].ToString() != "")
                {
                    model.adminname = ds.Tables[0].Rows[0]["adminname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ftype"] != null && ds.Tables[0].Rows[0]["ftype"].ToString() != "")
                {
                    model.ftype = ds.Tables[0].Rows[0]["ftype"].ToString();
                }
                if (ds.Tables[0].Rows[0]["result"] != null && ds.Tables[0].Rows[0]["result"].ToString() != "")
                {
                    model.result = ds.Tables[0].Rows[0]["result"].ToString();
                }
                if (ds.Tables[0].Rows[0]["addTime"] != null && ds.Tables[0].Rows[0]["addTime"].ToString() != "")
                {
                    model.addTime = DateTime.Parse(ds.Tables[0].Rows[0]["addTime"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,computerId,defineId,adminId,adminname,ftype,result,addTime ");
            strSql.Append(" FROM repair ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" id,computerId,defineId,adminId,adminname,ftype,result,addTime ");
            strSql.Append(" FROM repair ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM repair ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from repair T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "repair";
            parameters[1].Value = "id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  Method
    }
}

