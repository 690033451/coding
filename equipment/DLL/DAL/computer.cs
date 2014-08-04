using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DB;//Please add references
namespace DLL.DAL
{
    /// <summary>
    /// 数据访问类:computer
    /// </summary>
    public partial class computer
    {
        public computer()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from computer");
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
        public int Add(DLL.Model.computer model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into computer(");
            strSql.Append("defineId,type,brand,version,mac,nettype,innerIP,outerIP,screenInfo,printerInfo,scannerInfo,roomNum,department,username,addId,addtime,updateId,updateTime,description,flag,buyTime,giveTime)");
            strSql.Append(" values (");
            strSql.Append("@defineId,@type,@brand,@version,@mac,@nettype,@innerIP,@outerIP,@screenInfo,@printerInfo,@scannerInfo,@roomNum,@department,@username,@addId,@addtime,@updateId,@updateTime,@description,@flag,@buyTime,@giveTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@defineId", SqlDbType.VarChar,500),
					new SqlParameter("@type", SqlDbType.VarChar,500),
					new SqlParameter("@brand", SqlDbType.VarChar,500),
					new SqlParameter("@version", SqlDbType.VarChar,500),
					new SqlParameter("@mac", SqlDbType.VarChar,500),
					new SqlParameter("@nettype", SqlDbType.VarChar,500),
					new SqlParameter("@innerIP", SqlDbType.VarChar,500),
					new SqlParameter("@outerIP", SqlDbType.VarChar,500),
					new SqlParameter("@screenInfo", SqlDbType.VarChar),
					new SqlParameter("@printerInfo", SqlDbType.VarChar),
					new SqlParameter("@scannerInfo", SqlDbType.VarChar),
					new SqlParameter("@roomNum", SqlDbType.VarChar,500),
					new SqlParameter("@department", SqlDbType.VarChar,500),
					new SqlParameter("@username", SqlDbType.VarChar,500),
					new SqlParameter("@addId", SqlDbType.Int,4),
					new SqlParameter("@addtime", SqlDbType.DateTime),
					new SqlParameter("@updateId", SqlDbType.Int,4),
					new SqlParameter("@updateTime", SqlDbType.DateTime),
					new SqlParameter("@description", SqlDbType.VarChar),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@buyTime", SqlDbType.DateTime),
					new SqlParameter("@giveTime", SqlDbType.DateTime)};
            parameters[0].Value = model.defineId;
            parameters[1].Value = model.type;
            parameters[2].Value = model.brand;
            parameters[3].Value = model.version;
            parameters[4].Value = model.mac;
            parameters[5].Value = model.nettype;
            parameters[6].Value = model.innerIP;
            parameters[7].Value = model.outerIP;
            parameters[8].Value = model.screenInfo;
            parameters[9].Value = model.printerInfo;
            parameters[10].Value = model.scannerInfo;
            parameters[11].Value = model.roomNum;
            parameters[12].Value = model.department;
            parameters[13].Value = model.username;
            parameters[14].Value = model.addId;
            parameters[15].Value = System.DateTime.Now;
            parameters[16].Value = model.updateId;
            parameters[17].Value = System.DateTime.Now;
            parameters[18].Value = model.description;
            parameters[19].Value = model.flag;
            parameters[20].Value = model.buyTime;
            parameters[21].Value = model.giveTime;
            if (model.buyTime == null) 
            {
                parameters[20].Value = System.DateTime.Now;
            }
            if (model.giveTime == null)
            {
                parameters[21].Value = System.DateTime.MaxValue;
            }

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
        public bool Update(DLL.Model.computer model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update computer set ");
            strSql.Append("defineId=@defineId,");
            strSql.Append("type=@type,");
            strSql.Append("brand=@brand,");
            strSql.Append("version=@version,");
            strSql.Append("mac=@mac,");
            strSql.Append("nettype=@nettype,");
            strSql.Append("innerIP=@innerIP,");
            strSql.Append("outerIP=@outerIP,");
            strSql.Append("screenInfo=@screenInfo,");
            strSql.Append("printerInfo=@printerInfo,");
            strSql.Append("scannerInfo=@scannerInfo,");
            strSql.Append("roomNum=@roomNum,");
            strSql.Append("department=@department,");
            strSql.Append("username=@username,");
            strSql.Append("addId=@addId,");
            strSql.Append("addtime=@addtime,");
            strSql.Append("updateId=@updateId,");
            strSql.Append("updateTime=@updateTime,");
            strSql.Append("description=@description,");
            strSql.Append("flag=@flag,");
            strSql.Append("buyTime=@buyTime,");
            strSql.Append("giveTime=@giveTime");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@defineId", SqlDbType.VarChar,500),
					new SqlParameter("@type", SqlDbType.VarChar,500),
					new SqlParameter("@brand", SqlDbType.VarChar,500),
					new SqlParameter("@version", SqlDbType.VarChar,500),
					new SqlParameter("@mac", SqlDbType.VarChar,500),
					new SqlParameter("@nettype", SqlDbType.VarChar,500),
					new SqlParameter("@innerIP", SqlDbType.VarChar,500),
					new SqlParameter("@outerIP", SqlDbType.VarChar,500),
					new SqlParameter("@screenInfo", SqlDbType.VarChar),
					new SqlParameter("@printerInfo", SqlDbType.VarChar),
					new SqlParameter("@scannerInfo", SqlDbType.VarChar),
					new SqlParameter("@roomNum", SqlDbType.VarChar,500),
					new SqlParameter("@department", SqlDbType.VarChar,500),
					new SqlParameter("@username", SqlDbType.VarChar,500),
					new SqlParameter("@addId", SqlDbType.Int,4),
					new SqlParameter("@addtime", SqlDbType.DateTime),
					new SqlParameter("@updateId", SqlDbType.Int,4),
					new SqlParameter("@updateTime", SqlDbType.DateTime),
					new SqlParameter("@description", SqlDbType.VarChar),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@buyTime", SqlDbType.DateTime),
					new SqlParameter("@giveTime", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.defineId;
            parameters[1].Value = model.type;
            parameters[2].Value = model.brand;
            parameters[3].Value = model.version;
            parameters[4].Value = model.mac;
            parameters[5].Value = model.nettype;
            parameters[6].Value = model.innerIP;
            parameters[7].Value = model.outerIP;
            parameters[8].Value = model.screenInfo;
            parameters[9].Value = model.printerInfo;
            parameters[10].Value = model.scannerInfo;
            parameters[11].Value = model.roomNum;
            parameters[12].Value = model.department;
            parameters[13].Value = model.username;
            parameters[14].Value = model.addId;
            parameters[15].Value = model.addtime;
            parameters[16].Value = model.updateId;
            parameters[17].Value = System.DateTime.Now;
            parameters[18].Value = model.description;
            parameters[19].Value = model.flag;
            parameters[20].Value = model.buyTime;
            parameters[21].Value = model.giveTime;
            parameters[22].Value = model.id;

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
            strSql.Append("delete from computer ");
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
            strSql.Append("delete from computer ");
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
        public DLL.Model.computer GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,defineId,type,brand,version,mac,nettype,innerIP,outerIP,screenInfo,printerInfo,scannerInfo,roomNum,department,username,addId,addtime,updateId,updateTime,description,flag,buyTime,giveTime from computer ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            DLL.Model.computer model = new DLL.Model.computer();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["defineId"] != null && ds.Tables[0].Rows[0]["defineId"].ToString() != "")
                {
                    model.defineId = ds.Tables[0].Rows[0]["defineId"].ToString();
                }
                if (ds.Tables[0].Rows[0]["type"] != null && ds.Tables[0].Rows[0]["type"].ToString() != "")
                {
                    model.type = ds.Tables[0].Rows[0]["type"].ToString();
                }
                if (ds.Tables[0].Rows[0]["brand"] != null && ds.Tables[0].Rows[0]["brand"].ToString() != "")
                {
                    model.brand = ds.Tables[0].Rows[0]["brand"].ToString();
                }
                if (ds.Tables[0].Rows[0]["version"] != null && ds.Tables[0].Rows[0]["version"].ToString() != "")
                {
                    model.version = ds.Tables[0].Rows[0]["version"].ToString();
                }
                if (ds.Tables[0].Rows[0]["mac"] != null && ds.Tables[0].Rows[0]["mac"].ToString() != "")
                {
                    model.mac = ds.Tables[0].Rows[0]["mac"].ToString();
                }
                if (ds.Tables[0].Rows[0]["nettype"] != null && ds.Tables[0].Rows[0]["nettype"].ToString() != "")
                {
                    model.nettype = ds.Tables[0].Rows[0]["nettype"].ToString();
                }
                if (ds.Tables[0].Rows[0]["innerIP"] != null && ds.Tables[0].Rows[0]["innerIP"].ToString() != "")
                {
                    model.innerIP = ds.Tables[0].Rows[0]["innerIP"].ToString();
                }
                if (ds.Tables[0].Rows[0]["outerIP"] != null && ds.Tables[0].Rows[0]["outerIP"].ToString() != "")
                {
                    model.outerIP = ds.Tables[0].Rows[0]["outerIP"].ToString();
                }
                if (ds.Tables[0].Rows[0]["screenInfo"] != null && ds.Tables[0].Rows[0]["screenInfo"].ToString() != "")
                {
                    model.screenInfo = ds.Tables[0].Rows[0]["screenInfo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["printerInfo"] != null && ds.Tables[0].Rows[0]["printerInfo"].ToString() != "")
                {
                    model.printerInfo = ds.Tables[0].Rows[0]["printerInfo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["scannerInfo"] != null && ds.Tables[0].Rows[0]["scannerInfo"].ToString() != "")
                {
                    model.scannerInfo = ds.Tables[0].Rows[0]["scannerInfo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["roomNum"] != null && ds.Tables[0].Rows[0]["roomNum"].ToString() != "")
                {
                    model.roomNum = ds.Tables[0].Rows[0]["roomNum"].ToString();
                }
                if (ds.Tables[0].Rows[0]["department"] != null && ds.Tables[0].Rows[0]["department"].ToString() != "")
                {
                    model.department = ds.Tables[0].Rows[0]["department"].ToString();
                }
                if (ds.Tables[0].Rows[0]["username"] != null && ds.Tables[0].Rows[0]["username"].ToString() != "")
                {
                    model.username = ds.Tables[0].Rows[0]["username"].ToString();
                }
                if (ds.Tables[0].Rows[0]["addId"] != null && ds.Tables[0].Rows[0]["addId"].ToString() != "")
                {
                    model.addId = int.Parse(ds.Tables[0].Rows[0]["addId"].ToString());
                }
                if (ds.Tables[0].Rows[0]["addtime"] != null && ds.Tables[0].Rows[0]["addtime"].ToString() != "")
                {
                    model.addtime = DateTime.Parse(ds.Tables[0].Rows[0]["addtime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["updateId"] != null && ds.Tables[0].Rows[0]["updateId"].ToString() != "")
                {
                    model.updateId = int.Parse(ds.Tables[0].Rows[0]["updateId"].ToString());
                }
                if (ds.Tables[0].Rows[0]["updateTime"] != null && ds.Tables[0].Rows[0]["updateTime"].ToString() != "")
                {
                    model.updateTime = DateTime.Parse(ds.Tables[0].Rows[0]["updateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["description"] != null && ds.Tables[0].Rows[0]["description"].ToString() != "")
                {
                    model.description = ds.Tables[0].Rows[0]["description"].ToString();
                }
                if (ds.Tables[0].Rows[0]["flag"] != null && ds.Tables[0].Rows[0]["flag"].ToString() != "")
                {
                    model.flag = int.Parse(ds.Tables[0].Rows[0]["flag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["buyTime"] != null && ds.Tables[0].Rows[0]["buyTime"].ToString() != "")
                {
                    model.buyTime = DateTime.Parse(ds.Tables[0].Rows[0]["buyTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["giveTime"] != null && ds.Tables[0].Rows[0]["giveTime"].ToString() != "")
                {
                    model.giveTime = DateTime.Parse(ds.Tables[0].Rows[0]["giveTime"].ToString());
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
            strSql.Append("select id,defineId,type,brand,version,mac,nettype,innerIP,outerIP,screenInfo,printerInfo,scannerInfo,roomNum,department,username,addId,addtime,updateId,updateTime,description,flag,buyTime,giveTime ");
            strSql.Append(" FROM computer ");
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
            strSql.Append(" id,defineId,type,brand,version,mac,nettype,innerIP,outerIP,screenInfo,printerInfo,scannerInfo,roomNum,department,username,addId,addtime,updateId,updateTime,description,flag,buyTime,giveTime ");
            strSql.Append(" FROM computer ");
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
            strSql.Append("select count(1) FROM computer ");
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
            strSql.Append(")AS Row, T.*  from computer T ");
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
            parameters[0].Value = "computer";
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

