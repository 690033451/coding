<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Detail_admin.aspx.cs" Inherits="Detail_admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>用户信息</title>
    <script type="text/javascript">
        $(function () {
            listtab('yg');
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="qianhead">
        <div class="link">
            <a href="List_admin.aspx">用户管理</a>
        </div>
        <div class="link on">
            <a href="#">用户详情</a>
        </div>
    </div>
    <%-- <div class="toolhead">
                <div class="toolheadleft">
                </div>
                <div class="toolheadmid">
                    <ul id="nav">
                        <li><a href="thisrepair.aspx?parameter=<%# Eval("id")%>" class="wh">维修信息</a></li>
                    </ul>
                </div>
                <div class="toolheadright">
                </div>
            </div>--%>
    <div class="tip">用户详情</div>
    <asp:Repeater runat="server" ID="rptdetail">
        <ItemTemplate>

            <table class="table nohover" border="1">
                <tr>
                    <td style="width: 15%; text-align: center;">管理员编号</td>
                    <td style="width: 85%;">&nbsp;&nbsp;<%# Eval("id") %></td>
                </tr>
                <tr>
                    <td style="width: 15%; text-align: center;">用户名</td>
                    <td>&nbsp;&nbsp;<%# Eval("username") %></td>
                </tr>
                <tr>
                    <td style="width: 15%; text-align: center;">电话</td>
                    <td>&nbsp;&nbsp;<%# Eval("tel") %></td>
                </tr>
                <tr>
                    <td style="width: 15%; text-align: center;">登录名</td>
                    <td>&nbsp;&nbsp;<%# Eval("userId") %></td>
                </tr>

            </table>

        </ItemTemplate>
    </asp:Repeater>
    <div style="text-align: center; margin-top: 10px;">
        <asp:Button ID="Buttoneditor" runat="server" Text="更改" OnClick="Buttoneditor_Click"/>
        <asp:Button ID="Buttonabandon" runat="server" Text="删除" OnClick="Buttonabandon_Click" />
    </div>
</asp:Content>

