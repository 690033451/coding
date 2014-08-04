<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="add_repair.aspx.cs" Inherits="adds" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>添加维修信息</title>
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
            <a href="#">维修信息</a>
        </div>
    </div>
    <div class="tip">添加维修信息</div>
    <div>
        <table border="1" class="table nohover">
            <tr>
                <td style="width: 15%;">&nbsp; 计算机编号:</td>
                <td style="width: 85%;">&nbsp;<asp:TextBox ID="cidTextBox" runat="server" Width="80%" ></asp:TextBox> </td>
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
    <div style="text-align:center;margin-top:10px;"> <asp:Button ID="saveImageButton" runat="server" text="保存" OnClick="saveImageButton_Click1" /></div>
     <div class="m-layer m-layer-show" runat="server" id="queren">
    <div class="lymask"></div>
    <table class="lytable"><tbody><tr><td class="lytd">
    <div class="lywrap">
	    <div class="lytt"><h2 class="u-tt">添加错误</h2><span class="lyclose" runat="server" >×</span></div>
	    <div class="lyct">
	        <p>计算机编号不能为空</p>
	        
	    </div>
	    <div class="lybt">
	       
	        <div class="lybtns">
	            <asp:Button ID="Buttonqueren" runat="server" Text="确认" OnClick="Buttonqueren_Click" />	           
	        </div>
	    </div>
    </div></td></tr></tbody></table>
</div>
</asp:Content>

