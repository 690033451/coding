<%@ Page Language="C#" AutoEventWireup="true" CodeFile="print.aspx.cs" Inherits="print" %>

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
        <asp:Repeater runat="server" ID="rptList">
            <HeaderTemplate>
                <table border="1" style="border:thin">
                <thead>
                    <tr>
                        <td style="width: 120px;">机器编号</td>
                        <td style="width: 100px;">类型</td>
                        <td style="width: 100px;">使用状况</td>
                        <td style="width: 100px;">部门</td>
                        <td style="width: 90px;">房间号</td>
                        <td style="width: 90px;">使用人</td>
                        <td style="width: 60px;">品牌</td>
                        <td style="width: 150px;">型号</td>
                        <td style="width: 150px;">网卡</td>
                        <td style="width: 80px;">网络</td>
                        <td style="width: 110px;">内网IP</td>
                        <td style="width: 110px;">外网IP</td>
                    </tr>
                    </thead>
                 </table>
            </HeaderTemplate>
                
            <ItemTemplate>
                 <table border="1" style="border:thin">
               
                    <tr>
                        <td style="width: 120px;"><%# Eval("defineId") %></td>
                        <td style="width: 100px;"><%# Eval("type") %></td>
                        <td style="width: 100px;"><%#Enum.GetName(typeof(DLL.BaseCode.BaseCode.state), int.Parse(Eval("flag").ToString()))%></td>
                        <td style="width: 100px;"><%# Eval("department") %></td>
                        <td style="width: 90px;"><%# Eval("roomnum") %></td>
                        <td style="width: 90px;"><%# Eval("username") %></td>
                        <td style="width: 60px;"><%# Eval("brand") %></td>
                        <td style="width: 150px;"><%# Eval("version") %></td>
                        <td style="width: 150px;"><%# Eval("mac") %></td>
                        <td style="width: 80px;"><%# Eval("nettype") %></td>
                        <td style="width: 110px;"><%# Eval("innerIp") %></td>
                        <td style="width: 110px;"><%# Eval("outerIp") %></td>
                    </tr>
                    
                </table>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <div style="text-align: center; margin-top: 10px; height: 18px;" runat="server">
        <form  runat="server">
            <asp:Button ID="Buttonprint" runat="server" Text="导出" OnClick="Buttonprint_Click" />
        </form>
    </div>

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
