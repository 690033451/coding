using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.TOOL
{
    public class Dateparse
    {
        public String dateChange(String date) 
        {
            String newdate="";
            String year = date.Trim().Substring(0,4);
            String month =date.Trim().Substring(5,2);
            String day = date.Trim().Substring(8,2);
           // String hour = date.Trim().Substring(10,2);
            //String min = date.Trim().Substring(13,2);
            //String second = date.Trim().Substring(16,2);
            newdate = month + "/" + day + "/" + year;           
            return newdate.Trim();
        }
    }
}
