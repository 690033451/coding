using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DLL;
using DB;

namespace DLL.DAL
{
    public partial class loginfo
    {
        public Boolean deleteAll()
        {
            DbHelperSQL.ExecuteSql("delete  from loginfo ");
            int rows = DbHelperSQL.ExecuteSql("select * from loginfo");
            if(rows > 0)
            {
                return false;
            }
            return true;
        }
    }
}
