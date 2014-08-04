<%@ Page Language="C#" AutoEventWireup="true" CodeFile="taizhang.aspx.cs" Inherits="taizhang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        .table td {
            text-align: center;
        }
    </style>
</head>
<body>
    <div style="text-align: center">
        <table border="1" style="border: solid 1px;border-collapse:collapse ">

            <tr>
                <td style="width: 70px;text-align:center;">房间</td>
                <td style="width: 70px;text-align:center;">使用人</td>
                <td style="width: 70px;text-align:center;">型号</td>
                <td style="width: 35px;text-align:center;">显</td>
                <td style="width: 35px;text-align:center;">网</td>
                <td style="width: 140px;text-align:center;">外网IP</td>
                <td style="width: 140px;text-align:center;">内网IP</td>
                <td style="width: 210px;text-align:center;">MAC地址</td>
                <td style="width: 140px;text-align:center;">外设</td>
                <td style="width: 420px;text-align:center;">备注</td>
               <%-- <td style="width: 90px;">机器编号</td>
                <td style="width: 150px;">型号</td>
                <td style="width: 140px;">部门</td>
                <td style="width: 90px;">房间号</td>
                <td style="width: 90px;">使用人</td>
                <td style="width: 60px;">品牌</td>
                <td style="width: 100px;">显示器</td>
                <td style="width: 210px;">网卡</td>
                <td style="width: 100px;">类型</td>
                <td style="width: 80px;">网络</td>
                <td style="width: 100px;">使用状态</td>--%>
                <%--<td style="width: 130px;">内网IP</td>
                <td style="width: 130px;">外网IP</td>--%>
            </tr>

            <asp:Repeater runat="server" ID="rptList">


                <ItemTemplate>


                    <tr>
                        <td><%# Eval("roomnum") %></td>
                        <td><%# Eval("username") %></td>
                        <td><%# Eval("version") %></td>
                        <td><%# Eval("screenInfo") %></td>
                        <td><%# Eval("nettype") %></td>
                        <td><%# Eval("outerIp") %></td>
                        <td><%# Eval("innerIp") %></td>
                        <td><%# Eval("mac") %></td>
                        <td><%# Eval("printerInfo") %><%# Eval("scannerInfo") %></td>
                        <td><%# Eval("description") %></td>
<%--                        <td style="width: 90px;"><%# Eval("defineId") %></td>
                        <td style="width: 150px;"><%# Eval("version") %></td>
                        <td style="width: 140px;"><%# Eval("department") %></td>
                        <td style="width: 90px;"><%# Eval("roomnum") %></td>
                        <td style="width: 90px;"><%# Eval("username") %></td>
                        <td style="width: 60px;"><%# Eval("brand") %></td>
                        <td style="width: 100px;"><%# Eval("screenInfo") %></td>
                        <td style="width: 210px;"><%# Eval("mac") %></td>
                        <td style="width: 100px;"><%# Eval("type") %></td>
                        <td style="width: 80px;"><%# Eval("nettype") %></td>
                        <td style="width: 100px;"><%#Enum.GetName(typeof(DLL.BaseCode.BaseCode.state), int.Parse(Eval("flag").ToString()))%></td>--%>
                       <%-- <td style="width: 130px;"><%# Eval("innerIp") %></td>
                        <td style="width: 130px;"><%# Eval("outerIp") %></td>--%>
                    </tr>

                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
    <%-- <div style="text-align: center; margin-top: 10px; height: 18px;" runat="server">
        <form  runat="server">
            <asp:Button ID="Buttonprint" runat="server" Text="导出" OnClick="Buttonprint_Click" />
        </form>
    </div>--%>

    <%--      <div class="m-page">
            <asp:DataPager ID="DataPager1" runat="server" PagedControlID="rptList">
                <Fields>
                    <asp:NextPreviousPagerField ButtonType="Link" ButtonCssClass="first pageprv" ShowNextPageButton="false" ShowPreviousPageButton="True" />
                    <asp:NumericPagerField ButtonType="Link" ButtonCount="10" CurrentPageLabelCssClass="z-crt" />
                    <asp:NextPreviousPagerField ButtonType="Link" ButtonCssClass="last pagenxt" ShowNextPageButton="True" ShowPreviousPageButton="false" />
                </Fields>
            </asp:DataPager>
        </div>--%>
    <%--</div>--%>
</body>
</html>

