using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DB;

namespace DLL.BLL
{
    public partial class computer
    {
        public int GetId(String defineId)
        {
            return dal.GetId(defineId);
        }
        public DataSet repaircount()
        {
            return dal.repaircount();
        }
        public String thiscount(int cid)
        {
            return dal.thiscount(cid);
        }
         public bool addcomputers(DLL.Model.computer model,int num)
        {
            return dal.addcomputers(model, num);
        }
         public DataSet select(String type, String selecttype, String context)
         {
             return dal.select(type,selecttype,context);
         }
    }
}
