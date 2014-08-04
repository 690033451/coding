<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="editor_admin.aspx.cs" Inherits="editor_admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>修改用户信息</title>
    <script type="text/javascript">
        $(function () {
            listtab('yg');
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="qianhead">
        <div class="link">
            <a href="List_admin.aspx">用户管理</a>
        </div>
        <div class="link on">
            <a href="add_admin.aspx">修改用户信息</a>
        </div>
    </div>
    <div class="tip">修改用户信息</div>
    <div>
        <table border="1" class="table nohover">
            <tr>
                <td style="width: 15%;">&nbsp; 登录名:</td>
                <td style="width: 85%;">&nbsp;<asp:TextBox ID="loginTextBox" runat="server" Width="80%" ></asp:TextBox> </td>
            </tr>
            <tr>
                <td style="width: 15%;">&nbsp; 密码:</td>
                <td style="width: 85%;">&nbsp;<asp:TextBox ID="psyTextBox" runat="server" TextMode="Password" Width="80%" ></asp:TextBox> </td>
            </tr>
            <tr>
                <td style="width: 15%;">&nbsp; 用户名:</td>
                <td style="width: 85%;">&nbsp;<asp:TextBox ID="userTextBox" runat="server" Width="80%" ></asp:TextBox> </td>
            </tr>
            <tr>
                <td style="width: 15%;">&nbsp; 电话:</td>
                <td style="width: 85%;">&nbsp;<asp:TextBox ID="telTextBox" runat="server" Width="80%" ></asp:TextBox> </td>
            </tr>
        </table>
    </div>
    <div style="margin-top:10px;text-align:center;"> <asp:Button ID="saveImageButton" runat="server" text="保存" OnClick="saveImageButton_Click"  /></div>
</asp:Content>

