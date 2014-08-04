<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="List_equipment.aspx.cs" Inherits="List_equipment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>设备列表</title>
    <script type="text/javascript">
        $(function () {
            listtab('zj');
        });
    </script>
    <style>
        .table td {
            text-align: center;
            cursor: pointer;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="qianhead">
        <div class="link on">
            <a href="List_equipment.aspx">设备管理</a>
        </div>
    </div>
    <div class="toolhead">
        <div class="toolheadleft">
        </div>
        <div class="toolheadmid">
            <ul id="nav">
                <li><a href="adddetail.aspx" class="wh">添加设备</a></li>
                <li>
                    <a href="taizhang.aspx" target="_blank" class="wh">显示台帐</a>
                    <%--<asp:LinkButton ID="LinkButton1" runat="server" CssClass="wh" OnClick="LinkButton1_Click">显示台帐</asp:LinkButton>--%></li>
            </ul>
        </div>
        <div class="toolheadright">
        </div>
        <div class="toolright">
            <asp:DropDownList ID="DropDownListtype" runat="server"></asp:DropDownList>
            <asp:DropDownList ID="DropDownListsearch" runat="server" OnSelectedIndexChanged="search_Click">
                <asp:ListItem Value="请选择">请选择</asp:ListItem>
                <asp:ListItem Value="roomNum">按房间号</asp:ListItem>
                <asp:ListItem Value="defineId">按电脑编号</asp:ListItem>
                <asp:ListItem Value="department">按部门</asp:ListItem>
                <%--<asp:ListItem Value="4">按类型</asp:ListItem>--%>
            </asp:DropDownList>
            <asp:TextBox ID="roomnumTextBox" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="检索" OnClick="search_Click" />

        </div>
    </div>


    <div class="tip">
        设备列表
    </div>
    <table class="table" style="color: #008000">
        <thead>
            <tr>
                <td >序号</td>
                <td>机器编号</td>
                <td>型号</td>
                <td>部门</td>
                <td>房间</td>
                <td>使用人</td>
                <td>品牌</td>
                <td>显示器</td>
                <td>mac地址</td>
                <td>网络</td>
                <td>内网IP</td>
                <td>外网IP</td>                
                <td>备注</td>
            </tr>
        </thead>
        <tbody>
            <asp:ListView runat="server" ID="rptList" OnPagePropertiesChanging="rptList_PagePropertiesChanging">
                <ItemTemplate>
                    
                        <tr>
                            <td  onclick="location.href='detail.aspx?parameter=<%# Eval("id") %>'"><%# (Container.DataItemIndex+1) %></td>
                            <td  onclick="location.href='detail.aspx?parameter=<%# Eval("id") %>'"><%# Eval("defineId") %></td>
                            <td  onclick="location.href='detail.aspx?parameter=<%# Eval("id") %>'"><%# Eval("version") %></td>
                            <td  onclick="location.href='detail.aspx?parameter=<%# Eval("id") %>'"><%# Eval("department") %></td>
                            <td  onclick="location.href='detail.aspx?parameter=<%# Eval("id") %>'"><%# Eval("roomnum") %></td>
                            <td  onclick="location.href='detail.aspx?parameter=<%# Eval("id") %>'"><%# Eval("username") %></td>
                            <td  onclick="location.href='detail.aspx?parameter=<%# Eval("id") %>'"><%# Eval("brand") %></td>
                            <td  onclick="location.href='detail.aspx?parameter=<%# Eval("id") %>'"><%# Eval("screenInfo") %></td>
                            <td  onclick="location.href='detail.aspx?parameter=<%# Eval("id") %>'"><%# Eval("mac") %></td>
                            <td  onclick="location.href='detail.aspx?parameter=<%# Eval("id") %>'"><%# Eval("nettype") %></td>
                            <td  onclick="location.href='detail.aspx?parameter=<%# Eval("id") %>'"><%# Eval("innerIP") %></td>
                            <td  onclick="location.href='detail.aspx?parameter=<%# Eval("id") %>'"><%# Eval("outerIP") %></td>
                            <td  onclick="location.href='detail.aspx?parameter=<%# Eval("id") %>'"><%# Eval("description") %></td>
                            <%--                        <td style="width: 60px;"onclick="location.href='detail.aspx?parameter=<%# Eval("id") %>'"><%#Enum.GetName(typeof(DLL.BaseCode.BaseCode.state), int.Parse(Eval("flag").ToString()))%></td>--%>
                        </tr>
                   
                </ItemTemplate>
            </asp:ListView>
        </tbody>
        <%--<tfoot>
            <tr>
                <td colspan="5" style="height: 10px"></td>
            </tr>
        </tfoot>--%>
    </table>
    <div style="text-align: center; margin-top: 10px; height: 18px;">
        <%-- <asp:DataPager class="pager" ID="DataPager1" runat="server" PagedControlID="rptList">
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
    <%--    <div style="margin-left: 45%">
    </div>--%>
</asp:Content>

