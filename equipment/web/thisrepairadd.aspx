<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="thisrepairadd.aspx.cs" Inherits="thisrepairadd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">
        $(function () {
            listtab('zj');
            $(".lyclose").click(function () { $(".m-layer").hide(); });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="qianhead">
        <div class="link">
            <a href="List_equipment.aspx">设备管理</a>
        </div>
         <div class="link">
            <asp:LinkButton ID="LinkButtondetail" runat="server" OnClick="LinkButtondetail_Click">设备详情</asp:LinkButton>
        </div>
        <div class="link on">
            <a href="#">添加维修</a>
        </div>
    </div>
    <div class="tip">添加维修信息</div>
    <div>
        <table border="1" class="table nohover">
            <tr>
                <td style="width: 15%;">&nbsp; 计算机编号:</td>
                <td style="width: 85%;">&nbsp; <asp:Label ID="LabeldefineId" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 15%;">&nbsp; 维修类型:</td>
                <td style="width: 85%;">&nbsp;<asp:TextBox ID="ftypeTextBox" runat="server" Width="80%" ></asp:TextBox> </td>
            </tr>
            <tr>
                <td style="width: 15%;">&nbsp; 维修结果:</td>
                <td style="width: 85%;">&nbsp;<asp:TextBox ID="resultTextBox" runat="server" Width="80%" ></asp:TextBox> </td>
            </tr>
           
        </table>
    </div>
    <div style="text-align:center;margin-top:10px;"> <asp:Button ID="saveImageButton" runat="server" text="保存" OnClick="saveImageButton_Click"  /></div>
</asp:Content>

