using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DB;
using System.Data.SqlClient;
using DLL;
namespace DLL.DAL
{
    public partial class computer
    {
        public DataSet repaircount()
        {
            String strSql = "select Top 5 defineId ,count(id) as 数量 from repair where defineId in (select defineId from computer where flag=1) group by defineId order by 数量 desc";
            return DbHelperSQL.Query(strSql.ToString());
        }
        public String thiscount(int cid)
         {            
             String strSql="select count(id) from repair where computerId ='"+cid.ToString()+"'";
             DataSet ds =DbHelperSQL.Query(strSql.ToString());
             DataTable dt = ds.Tables[0];
             DataRow dr = dt.Rows[0];           
             return dr[0].ToString();
         }
        public bool addcomputers(DLL.Model.computer model,int num)
        {
            model.roomNum = "0000";
            model.mac = "00-00-00-00-00-00";
            model.department = "请选择";
            model.nettype = "请选择";
            model.outerIP = "0.0.0.0";
            model.innerIP = "0.0.0.0";
            model.printerInfo = "空";
            model.scannerInfo = "空";
            model.screenInfo = "空";
            model.description = "空";
            model.username = "待定";
            
            if (num > 0)
            {
                do
                {
                    Add(model);
                    num--;
                } while (num > 0);
            }
            return false;
        }
        public int GetId(String defineId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,defineId,type,brand,version,mac,nettype,innerIP,outerIP,screenInfo,printerInfo,scannerInfo,roomNum,department,username,addId,addtime,updateId,updateTime,description,flag from computer ");
            strSql.Append(" where defineId=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,500)
			};
            parameters[0].Value = defineId;

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
                return model.id;
            }
            else
            {
                return 0;
            }
        }
        public DataSet searchCom(DLL.Model.computer model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from computer where 1=1");
            if (model.defineId != null) 
            {
                strSql.Append("and defineId = ");
            }
            return DbHelperSQL.Query(strSql.ToString());

        }
        /* 设备列表页检索*/
        public DataSet select(String type,String selecttype,String context)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from computer where 1=1");
            if(type!="请选择")
            {
                strSql.Append("and type='" + type+"'");
            }
            if(selecttype!="请选择"&&context!="")
            {
                strSql.Append("and "+selecttype+"='" + context+"'");
            }
            strSql.Append("order by addtime desc");
            //switch(selecttype)
            //{
            //    case 0: break;
            //    case 1: strSql.Append("and roomNum=" + context); break;
            //    case 2: strSql.Append("and defineId=" + context); break;
            //    case 3: strSql.Append("and department=" + context); break;
            //    //case 4: strSql.Append("and type=" + context); break;
            //}
            return DbHelperSQL.Query(strSql.ToString());
        }
    }
      
}
