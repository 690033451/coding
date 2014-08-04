<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="search.aspx.cs" Inherits="search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>设备检索</title>
    <script type="text/javascript">
        $(function () {
            listtab('tj');
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="qianhead">
        <div class="link">
            <a href="List_equipment.aspx">统计查询</a>
        </div>
        <div class="link on">
            <a href="#">设备检索</a>
        </div>
    </div>
    <div class="tip">
        设备检索
    </div>
    <div>
        <table class="table" style="color: #008000; border: solid 1px;">
            <tr>
                <td>编号：</td>
                <td>
                    <asp:TextBox ID="TextBoxdefine" runat="server"></asp:TextBox></td>
                <td>类型：</td>
                <td>
                    <asp:DropDownList ID="DropDownListtype" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>品牌：</td>
                <td>
                    <asp:TextBox ID="TextBoxbrand" runat="server"></asp:TextBox></td>
                <td>型号：</td>
                <td>
                    <asp:TextBox ID="TextBoxversion" runat="server"></asp:TextBox></td>
            </tr>
            <tr>

                <td>网络：</td>
                <td>
                    <asp:TextBox ID="TextBoxnet" runat="server"></asp:TextBox></td>
                <td>部门：</td>
                <td>
                    <asp:TextBox ID="TextBoxdepart" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>房间号：</td>
                <td>
                    <asp:TextBox ID="TextBoxroom" runat="server"></asp:TextBox></td>
                <td>使用人：</td>
                <td>
                    <asp:TextBox ID="TextBoxuser" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td colspan="4" style="text-align: center">
                    <asp:Button ID="Button1" runat="server" Text="检索" OnClick="Button1_Click" /></td>

            </tr>
        </table>
    </div>
</asp:Content>

