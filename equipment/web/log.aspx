<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="log.aspx.cs" Inherits="log" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>系统日志</title>
    <script type="text/javascript">
        $(function () {
            listtab('log');
        $(".lyclose").click(function () { $(".m-layer").hide(); });
        });
    </script>
     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="qianhead">
        <div class="link on">
            <a href="#">系统日志</a>
        </div>
    </div>
    <div class="toolhead">
        <div class="toolheadleft">
        </div>
        <div class="toolheadmid">
            <ul id="nav">
                <li>
                    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="wh" OnClick="LinkButton1_Click">清空日志</asp:LinkButton></li>
            </ul>
        </div>
        <div class="toolheadright">
        </div>
    </div>
    <div class="tip">系统日志</div>
    <table class="table" style="color: #008000">
        <thead>
            <tr>
                <td style="text-align: center; width: 5%">序号</td>
                <td style="text-align: center; width: 20%">操作时间</td>
                <td style="text-align: center; width: 20%">用户</td>
                <td style="text-align: center; width: 20%">操作</td>
                <td style="text-align: center; width: 30%">对象</td>

            </tr>
        </thead>
        <tbody>
            <asp:ListView runat="server" ID="rptList" OnPagePropertiesChanging="rptList_PagePropertiesChanging">
                <ItemTemplate>

                    <tr>
                        <td style="text-align: center; width: 5%"><%# (Container.DataItemIndex+1) %></td>
                        <td style="text-align: center; width: 20%"><%# Eval("addTime") %></td>
                        <td style="text-align: center; width: 20%"><%# Eval("adminname") %></td>
                        <td style="text-align: center; width: 20%"><%# Eval("action") %></td>
                        <td style="text-align: center; width: 30%"><%# Eval("objectname") %></td>
                    </tr>

                </ItemTemplate>
            </asp:ListView>
        </tbody>
    </table>
    <div style="text-align: center; margin-top: 10px;">
        <%-- <asp:DataPager ID="DataPager1" runat="server" PagedControlID="rptList">
            <Fields>
                <asp:NextPreviousPagerField ButtonType="Button" ShowNextPageButton="false" ShowPreviousPageButton="True" />
                <asp:NumericPagerField ButtonType="Button" ButtonCount="10" />
                <asp:NextPreviousPagerField ButtonType="Button" ShowNextPageButton="True" ShowPreviousPageButton="false" />
            </Fields>
        </asp:DataPager>--%>

        <div class="m-page">
            <asp:DataPager ID="DataPager1" runat="server" PagedControlID="rptList">
                <Fields>
                    <asp:NextPreviousPagerField ButtonType="Link" ButtonCssClass="first pageprv" ShowNextPageButton="false" ShowPreviousPageButton="True" />
                    <asp:NumericPagerField ButtonType="Link" ButtonCount="10" CurrentPageLabelCssClass="z-crt" />
                    <asp:NextPreviousPagerField ButtonType="Link" ButtonCssClass="last pagenxt" ShowNextPageButton="True" ShowPreviousPageButton="false" />
                </Fields>
            </asp:DataPager>
        </div>
    </div>
    <div class="m-layer m-layer-show" id="delete"  runat="server" >
    <div class="lymask"></div>
    <table class="lytable"><tbody><tr><td class="lytd">
    <div class="lywrap">
	    <div class="lytt"><h2 class="u-tt">清空日志</h2><span class="lyclose" runat="server" >×</span></div>
	    <div class="lyct">
	        <p>确认要清空日志吗？</p>	       
	    </div>
	    <div class="lybt">
	       
	        <div class="lybtns">
                <button type="button" class="u-btn" runat="server" id="queren" onserverclick="qingkong">确定</button>
	            <button type="button" class="u-btn" runat="server" onserverclick="xiaoshi">取消</button>	           
	        </div>
	    </div>
    </div></td></tr></tbody></table>
</div>
</asp:Content>

