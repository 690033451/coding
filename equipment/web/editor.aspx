<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="editor.aspx.cs" Inherits="detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        $(function () {
            listtab('zj');
            $(".lyclose").click(function () { $(".m-layer").hide(); });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="qianhead">
        <div class="link">
            <a href="List_equipment.aspx">设备管理</a>
        </div>

        <div class="link on">
            <a href="#>'">修改设备信息</a>
        </div>
    </div>
    <div class="tip">修改设备信息</div>
     <table class="table nohover" border="1">
        <tr>
            <td style="width: 10%; text-align: center;">机器编号</td>
            <td style="width: 80%;">&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxdefineId" runat="server" Width="80%"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 10%; text-align: center;">型号</td>
            <td style="width: 80%;">&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxversion" runat="server" Width="80%"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 10%; text-align: center;">部门</td>
            <td style="width: 80%; ">&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownListdepartment" runat="server" Width="80.4%"></asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 10%; text-align: center;">房间号</td>
            <td style="width: 80%;">&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxroom" runat="server" Width="80%"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 10%; text-align: center;">使用人</td>
            <td style="width: 80%; ">&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxuser" runat="server" Width="80%"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 15%; text-align: center;">品牌</td>
            <td style="width: 80%;">&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxbrand" runat="server" Width="80%"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 10%; text-align: center;">网络</td>
            <td style="width: 80%;">&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownListnet" runat="server" Width="80.4%"></asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 10%; text-align: center;">显示器信息</td>
            <td style="width: 80%; ">&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxsInfo" runat="server" Width="80%"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 10%; text-align: center;">使用情况</td>
            <td style="width: 80%; ">&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownListflag" runat="server" Width="80.4%"></asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 10%; text-align: center;">类型</td>
            <td style="width: 80%; ">&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownListtype" runat="server" Width="80.4%"></asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 10%; text-align: center;">内网IP</td>
            <td style="width: 80%;">&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxiIP" runat="server" Width="80%"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 10%; text-align: center;">外网IP</td>
            <td style="width: 80%;">&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxoIP" runat="server" Width="80%"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 10%; text-align: center;">购买日期</td>
            <td style="width: 80%;">&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Width="80%"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 10%; text-align: center;">分发日期</td>
            <td style="width: 80%;">&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" Width="80%"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 10%; text-align: center;">mac地址</td>
            <td style="width: 80%;">&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxMac" runat="server" Width="80%"></asp:TextBox></td>
        </tr>

        <tr>
            <td style="width: 10%; text-align: center;">打印机信息</td>
            <td style="width: 80%;">&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxpInfo" runat="server" Width="80%"></asp:TextBox></td>
        </tr>

        <tr>
            <td style="width: 10%; text-align: center;">扫描仪信息</td>
            <td style="width: 80%;">&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxscInfo" runat="server" Width="80%"></asp:TextBox></td>
        </tr>


        <tr>
            <td style="width: 10%; text-align: center;">备注</td>
            <td style="width: 80%;">&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxdescri" runat="server" Width="80%" ></asp:TextBox></td>
        </tr>




    </table>
    <div style="margin-top: 10px; text-align: center;">
        <asp:Button ID="ImageButtonsave" runat="server" Text="保存" OnClick="ImageButtonsave_Click" />
    </div>

</asp:Content>

