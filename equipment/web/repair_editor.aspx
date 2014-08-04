<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="repair_editor.aspx.cs" Inherits="repair_editor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="qianhead">
        <div class="link">
            <a href="List_equipment.aspx">设备管理</a>
        </div>
         <div class="link">
            <a href="repair.aspx">维修信息</a>
        </div>
        <div class="link on">
            <a href="#">修改维修信息</a>
        </div>
    </div>
    <div class="tip">
        修改维修信息
    </div>

            <table class="table nohover" border="1" onmouseover=" background-color:none;">
    <asp:Repeater ID="rpteditor" runat="server">
        <ItemTemplate>               
                <tr>
                    <td style="width: 15%; text-align: center;">机器编号</td>
                    <td style="width: 85%;">&nbsp;&nbsp;
                        <asp:Label ID="Labelcid" runat="server" Text=""><%# Eval("defineId") %></asp:Label></td>
                </tr>
                <tr>
                    <td style="width: 15%; text-align: center;">维护人</td>
                    <td style="width: 85%;">&nbsp;&nbsp;
                        <asp:Label ID="Labelaid" runat="server" Text=""><%# Eval("adminname") %></asp:Label></td>
                </tr>
                <tr>
                    <td style="width: 15%; text-align: center;">添加时间</td>
                    <td style="width: 85%;">&nbsp;&nbsp;
                        <asp:Label ID="Labeltime" runat="server" Text=""><%# Eval("addTIme") %></asp:Label></td>
                </tr>

            
        </ItemTemplate>
    </asp:Repeater>
    
        <tr>
            <td style="width: 15%; text-align: center;">维修类型</td>
            <td>&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxftype" runat="server" Width="80%" TextMode="SingleLine"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 15%; text-align: center;">维修结果</td>
            <td>&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxresult" runat="server" Width="80%" TextMode="SingleLine"></asp:TextBox></td>
        </tr>
    </table>
    <div style="margin-top: 5px; margin-left: 5px; padding-left: 45%;">
        <asp:Button ID="ImageButtonsave" runat="server" text="保存" OnClick="ImageButtonsave_Click"  />
    </div>
</asp:Content>

