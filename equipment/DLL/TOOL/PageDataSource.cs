using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;

namespace DLL.TOOL
{
    public class PageDataSource
    {
        /// <summary>
        /// 分页
        /// </summary>
        public static PagedDataSource Fy(PagedDataSource pds, int _pagesize, int _pagenum, string herf, Literal l1, Literal l2, Literal l3, Literal l4, Literal l5, Literal l6, Literal l7, Literal l8, Literal l9, Literal l10)
        {
            pds.AllowPaging = true;
            pds.PageSize = _pagesize;
            pds.CurrentPageIndex = _pagenum;
            string leftstyle = " width:18px; height:18px; display: inline-block; vertical-align:middle; background: url('/image/fen1.jpg');";
            string left = "<a href=\"{0}\" style=\"{1}\"></a>";
            string rightstyle = " width:18px; height:18px; display: inline-block; vertical-align:middle; background: url('/image/fen2.jpg');";
            string right = "<a href=\"{0}\" style=\"{1}\"></a>";
            string mid = "<a href='{0}' class='{1}'>[{2}]</a>";
            string midclass = "dl1";


            //共多少条/页
            if (pds.PageCount != 1)
            {
                //页数
                l1.Text = "共" + pds.DataSourceCount + "条 当前" + (pds.CurrentPageIndex + 1) + "/" + pds.PageCount + "页&nbsp;&nbsp;&nbsp;&nbsp;";

                if (pds.IsLastPage)
                {
                    l2.Text = String.Format(left, String.Format(herf, (pds.PageCount - 2).ToString()), leftstyle) + "&nbsp;&nbsp;";
                    l3.Text = pds.PageCount - 4 > 0 ? String.Format(mid, String.Format(herf, (pds.PageCount - 5).ToString()), midclass, (pds.PageCount - 4).ToString()) : "";
                    l4.Text = pds.PageCount - 3 > 0 ? String.Format(mid, String.Format(herf, (pds.PageCount - 4).ToString()), midclass, (pds.PageCount - 3).ToString()) : "";
                    l5.Text = pds.PageCount - 2 > 0 ? String.Format(mid, String.Format(herf, (pds.PageCount - 3).ToString()), midclass, (pds.PageCount - 2).ToString()) : "";
                    l6.Text = pds.PageCount - 1 > 0 ? String.Format(mid, String.Format(herf, (pds.PageCount - 2).ToString()), midclass, (pds.PageCount - 1).ToString()) : "";
                    l7.Text = pds.PageCount.ToString();
                    l8.Text = "";
                    l9.Text = "";
                    l10.Text = "";
                }

                if (pds.IsFirstPage)
                {
                    l2.Text = "";
                    l3.Text = "1";
                    l4.Text = pds.CurrentPageIndex + 2 <= pds.PageCount ? String.Format(mid, String.Format(herf, (pds.CurrentPageIndex + 1).ToString()), midclass, (pds.CurrentPageIndex + 2).ToString()) : "";
                    l5.Text = pds.CurrentPageIndex + 3 <= pds.PageCount ? String.Format(mid, String.Format(herf, (pds.CurrentPageIndex + 2).ToString()), midclass, (pds.CurrentPageIndex + 3).ToString()) : "";
                    l6.Text = pds.CurrentPageIndex + 4 <= pds.PageCount ? String.Format(mid, String.Format(herf, (pds.CurrentPageIndex + 3).ToString()), midclass, (pds.CurrentPageIndex + 4).ToString()) : "";
                    l7.Text = pds.CurrentPageIndex + 5 <= pds.PageCount ? String.Format(mid, String.Format(herf, (pds.CurrentPageIndex + 4).ToString()), midclass, (pds.CurrentPageIndex + 5).ToString()) : "";
                    l8.Text = pds.CurrentPageIndex + 2 <= pds.PageCount ? "&nbsp;&nbsp;" + String.Format(right, String.Format(herf, (pds.CurrentPageIndex + 1).ToString()), rightstyle) : "";
                    l9.Text = "";
                    l10.Text = "";
                }


                if ((!pds.IsFirstPage) && (!pds.IsLastPage))
                {
                    l2.Text = String.Format(left, String.Format(herf, (pds.CurrentPageIndex - 1).ToString()), leftstyle) + "&nbsp;&nbsp;"; ;
                    l3.Text = (pds.CurrentPageIndex - 2 > 0) ? String.Format(mid, String.Format(herf, (pds.CurrentPageIndex - 3).ToString()), midclass, (pds.CurrentPageIndex - 2).ToString()) : "";
                    l4.Text = (pds.CurrentPageIndex - 1 > 0) ? String.Format(mid, String.Format(herf, (pds.CurrentPageIndex - 2).ToString()), midclass, (pds.CurrentPageIndex - 1).ToString()) : "";
                    l5.Text = pds.CurrentPageIndex > 0 ? String.Format(mid, String.Format(herf, (pds.CurrentPageIndex - 1).ToString()), midclass, (pds.CurrentPageIndex).ToString()) : "";
                    l6.Text = (pds.CurrentPageIndex + 1).ToString();
                    l7.Text = pds.CurrentPageIndex + 1 < pds.PageCount ? String.Format(mid, String.Format(herf, (pds.CurrentPageIndex + 1).ToString()), midclass, (pds.CurrentPageIndex + 2).ToString()) : "";
                    l8.Text = (pds.CurrentPageIndex + 2 < pds.PageCount) ? String.Format(mid, String.Format(herf, (pds.CurrentPageIndex + 2).ToString()), midclass, (pds.CurrentPageIndex + 3).ToString()) : "";
                    l9.Text = (pds.CurrentPageIndex + 3 < pds.PageCount) ? String.Format(mid, String.Format(herf, (pds.CurrentPageIndex + 3).ToString()), midclass, (pds.CurrentPageIndex + 4).ToString()) : "";
                    l10.Text = "&nbsp;&nbsp;" + String.Format(right, String.Format(herf, (pds.CurrentPageIndex + 1).ToString()), rightstyle);

                }
            }
            return pds;
        }
    }
}
