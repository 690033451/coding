using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DB;
using System.Data.SqlClient;

namespace DLL.DAL
{
    public partial class repair
    {
        public DLL.Model.repair GetModelbydefine(String defineId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,computerId,defineId,adminId,adminname,ftype,result,addTime from repair ");
            strSql.Append(" where defineId=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.VarChar,500)
			};
            parameters[0].Value = defineId;

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
    }
}
