<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="abandon.aspx.cs" Inherits="abandon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>报废列表</title>
    <script type="text/javascript">
        $(function () {
            listtab('zj');
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
        <div class="link">
            <a href="List_equipment.aspx">设备管理</a>
        </div>

        <div class="link on">
            <a href="#">报废设备信息</a>
        </div>
    </div>
    <div class="tip">
        报废设备信息
    </div>
    <table class="table" style="color: #008000">
        <thead>
            <tr>
            <td style="text-align: center; width: 10%">序号</td>
            <td style="text-align: center; width: 10%">类型</td>
            <td style="text-align: center; width: 10%">品牌</td>
            <td style="text-align: center; width: 10%">型号</td>
            <td style="text-align: center; width: 10%">网卡编号</td>
            <td style="text-align: center; width: 10%">备注</td>
            </tr>
        </thead>
        <tbody>
            
                <asp:ListView runat="server" ID="rptabandon" OnPagePropertiesChanging="rptList_PagePropertiesChanging">
                    <ItemTemplate>

                        <tr>
                            <td style="text-align: center; width: 10%" onclick="location.href='detail_abandon.aspx?parameter=<%# Eval("id") %>'"><%# (Container.DataItemIndex+1) %></td>
                            <td style="text-align: center; width: 10%" onclick="location.href='detail_abandon.aspx?parameter=<%# Eval("id") %>'"><%# Eval("type") %></td>
                            <td style="text-align: center; width: 10%" onclick="location.href='detail_abandon.aspx?parameter=<%# Eval("id") %>'"><%# Eval("brand") %></td>
                            <td style="text-align: center; width: 10%" onclick="location.href='detail_abandon.aspx?parameter=<%# Eval("id") %>'"><%# Eval("version") %></td>
                            <td style="text-align: center; width: 10%" onclick="location.href='detail_abandon.aspx?parameter=<%# Eval("id") %>'"><%# Eval("mac") %></td>
                            <td style="text-align: center; width: 10%" onclick="location.href='detail_abandon.aspx?parameter=<%# Eval("id") %>'"><%# Eval("description") %></td>
                        </tr>


                    </ItemTemplate>

                </asp:ListView>
        </tbody>
    </table>
    <div style="text-align: center; margin-top: 10px;">
        <%--<asp:DataPager ID="DataPager1" runat="server" PagedControlID="rptabandon">
            <Fields>
                <asp:NextPreviousPagerField ButtonType="Button" ShowNextPageButton="false" ShowPreviousPageButton="True" />
                <asp:NumericPagerField ButtonType="Button" ButtonCount="10" />
                <asp:NextPreviousPagerField ButtonType="Button" ShowNextPageButton="True" ShowPreviousPageButton="false" />
            </Fields>
        </asp:DataPager>--%>
        <div class="m-page">
            <asp:DataPager ID="DataPager1" runat="server" PagedControlID="rptabandon">
                <Fields>
                    <asp:NextPreviousPagerField ButtonType="Link" ButtonCssClass="first pageprv" ShowNextPageButton="false" ShowPreviousPageButton="True" />
                    <asp:NumericPagerField ButtonType="Link" ButtonCount="10" CurrentPageLabelCssClass="z-crt" />
                    <asp:NextPreviousPagerField ButtonType="Link" ButtonCssClass="last pagenxt" ShowNextPageButton="True" ShowPreviousPageButton="false" />
                </Fields>
            </asp:DataPager>
        </div>

    </div>
</asp:Content>

