<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="repair.aspx.cs" Inherits="repair" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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

        .sz {
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
            <a href="repair.aspx">维修信息</a>
        </div>
    </div>
    <div class="toolhead">
        <div class="toolheadleft">
        </div>
        <div class="toolheadmid">
            <ul id="nav">
                <li><a href="add_repair.aspx" class="wh">添加</a></li>
            </ul>
        </div>
        <div class="toolheadright">
        </div>
    </div>

    <div class="tip">
        维修信息
    </div>
    <table class="table" style="color: #008000">
        <thead>
            <tr>
                <td style="text-align: center; width: 10%">序号</td>
                <td>机器编号</td>
                <td>维护人</td>
                <td>保修类型</td>
                <td>维修结果</td>
                <td>添加时间</td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
            </tr>
        </thead>
        <tbody>
            <asp:ListView ID="rptrepair" runat="server" OnPagePropertiesChanging="rptList_PagePropertiesChanging">
                <ItemTemplate>
                    <table class="table">
                        <tr>
                            <td><%# (Container.DataItemIndex+1) %></td>
                            <td><%# Eval("defineId") %></td>
                            <td><%# Eval("adminname") %></td>
                            <td><%# Eval("ftype") %></td>
                            <td><%# Eval("result") %></td>
                            <td><%# Eval("addTime","{0:yyyy-MM-dd}") %></td>
                            <td  class="sz" onclick="location.href='repair_editor.aspx?parameter=<%# Eval("id") %>'">修改</td>
                        </tr>
                </ItemTemplate>
            </asp:ListView>
        </tbody>
    </table>
    <div style="text-align: center; margin-top: 10px;">
        <%--<asp:DataPager ID="DataPager1" runat="server" PagedControlID="rptrepair">
            <Fields>
                <asp:NextPreviousPagerField ButtonType="Button" ShowNextPageButton="false" ShowPreviousPageButton="True" />
                <asp:NumericPagerField ButtonType="Button" ButtonCount="10" />
                <asp:NextPreviousPagerField ButtonType="Button" ShowNextPageButton="True" ShowPreviousPageButton="false" />
            </Fields>
        </asp:DataPager>--%>
         <div class="m-page">
            <asp:DataPager ID="DataPager1" runat="server" PagedControlID="rptrepair">
                <Fields>
                    <asp:NextPreviousPagerField ButtonType="Link" ButtonCssClass="first pageprv" ShowNextPageButton="false" ShowPreviousPageButton="True" />
                    <asp:NumericPagerField ButtonType="Link" ButtonCount="10" CurrentPageLabelCssClass="z-crt" />
                    <asp:NextPreviousPagerField ButtonType="Link" ButtonCssClass="last pagenxt" ShowNextPageButton="True" ShowPreviousPageButton="false" />
                </Fields>
            </asp:DataPager>
        </div>
    </div>
</asp:Content>

