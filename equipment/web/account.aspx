<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="account.aspx.cs" Inherits="account" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        $(function () {
            listtab('tj');
        });
       
    </script>
    <style>
        .table td {
            text-align: center;
            width: 10%;
        }

        .table td {
            cursor: pointer;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="qianhead">

        <div class="link on">
            <a href="#">维修统计</a>
        </div>
    </div>

    <div class="tip">
        维修统计
    </div>
    <table class="table" style="color: #008000">
        <thead>
            <tr>
                <td>电脑编号</td>
                <td>维修次数</td>
            </tr>
        </thead>
        <tbody>
            <asp:ListView runat="server" ID="rptList" OnPagePropertiesChanging="rptList_PagePropertiesChanging">

                <ItemTemplate>
                    
                        <tr>
                            <td onclick="location.href='detail.aspx?parameter=<%# new DLL.BLL.computer().GetId(Convert.ToString(Eval("defineId")))%>'"><%# Eval("defineId") %></td>
                            <td onclick="location.href='detail.aspx?parameter=<%# new DLL.BLL.computer().GetId(Convert.ToString(Eval("defineId")))%>'"><%# Eval("数量") %></td>
                        </tr>
                    
                </ItemTemplate>
            </asp:ListView>
        </tbody>
    </table>
    <div style="margin-left: auto; margin-right: auto; margin-top: 10px;">
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

