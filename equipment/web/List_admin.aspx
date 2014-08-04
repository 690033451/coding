<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="List_admin.aspx.cs" Inherits="List_admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>用户列表</title>
    <script type="text/javascript">
        $(function () {
            listtab('yg');
        });
    </script>
     <style>
      
        .table td{
             
             text-align:center;
             cursor:pointer;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="qianhead">
        <div class="link on">
            <a href="#">用户列表</a>
        </div>
    </div>
            <div class="toolhead">
        <div class="toolheadleft">
        </div>
        <div class="toolheadmid">
            <ul id="nav">
                <li><a href="add_admin.aspx" class="wh">添加用户</a></li>
            </ul>
        </div>
        <div class="toolheadright">
        </div>
                </div>
    <div class="tip">用户列表</div>
    <table class="table" style="color: #008000">
        <thead>
                <tr>
                    <td style=" width: 5%">序号</td>
                    <td style=" width: 10%">用户姓名</td>
                    <td style=" width: 10%">登录名</td>                   
                    <td style=" width: 10%">联系电话</td>
                </tr>
         </thead>
        <tbody>
    <asp:listview runat="server" ID="rptList" OnPagePropertiesChanging="rptList_PagePropertiesChanging">
        <ItemTemplate>
            
                <tr>
                    <td style=" width: 5%" onclick="location.href='Detail_admin.aspx?parameter=<%# Eval("id") %>'"><%# (Container.DataItemIndex+1) %></td>
                    <td style=" width: 10%" onclick="location.href='Detail_admin.aspx?parameter=<%# Eval("id") %>'"><%# Eval("username") %></td>
                    <td style=" width: 10%" onclick="location.href='Detail_admin.aspx?parameter=<%# Eval("id") %>'"><%# Eval("userId") %></td>                    
                    <td style=" width: 10%" onclick="location.href='Detail_admin.aspx?parameter=<%# Eval("id") %>'"><%# Eval("tel") %></td>
                </tr>
            
        </ItemTemplate>
    </asp:listview>
        </tbody>
       
        </table>
    <div style="text-align:center;margin-top:10px;">
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
</asp:Content>

