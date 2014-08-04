using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DLL;

namespace DLL.BLL
{
    public partial class repair
    {
        public DLL.Model.repair GetModelbydefine(String defineId)
        {
            return dal.GetModelbydefine(defineId);
        }

    }
}
