<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="thisrepair.aspx.cs" Inherits="thisrepair" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        $(function () {
            listtab('zj');
            $(".lyclose").click(function () { $(".m-layer").hide(); });
        });
    </script>
    <style>
        .sz {
            text-align: center;
            cursor: pointer;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="qianhead">
        <div class="link">
            <a href="List_equipment.aspx">设备管理</a>
        </div>
        <div class="link ">
            <asp:LinkButton ID="LinkButtondetail" runat="server" OnClick="LinkButtondetail_Click">设备详情</asp:LinkButton>
        </div>
        <div class="link on">
            <a href="#">维修详情</a>
        </div>
    </div>
     <div class="toolhead">
        <div class="toolheadleft">
        </div>
    <div class="toolheadmid">
            <ul id="nav">                
                <li><asp:LinkButton ID="LinkButton1" runat="server" CssClass="wh" OnClick="LinkButton1_Click" >添加维修</asp:LinkButton></li>
            </ul>
        </div>
         </div>
    <div class="tip">
        本机维修信息
    </div>
    <table class="table" style="color: #008000">
        <thead>
        <tr>
            <td style="text-align: center; width: 10%">序号</td>
<%--            <td style="text-align: center; width: 10%">机器编号</td>--%>
            <td style="text-align: center; width: 10%">维护人</td>
            <td style="text-align: center; width: 10%">保修类型</td>
            <td style="text-align: center; width: 10%">维修结果</td>
            <td style="text-align: center; width: 10%">添加时间</td>
            <td style="text-align: center; width: 10%">&nbsp;&nbsp;&nbsp;&nbsp;</td>
        
        </tr>
            </thead>
   <tbody>
    <asp:ListView ID="rptrepair" runat="server" OnPagePropertiesChanging="rptList_PagePropertiesChanging">

        <ItemTemplate>
           
                <tr>
                    <td style="text-align: center; width: 10%"><%# (Container.DataItemIndex+1) %></td>
<%--                <td style="text-align: center; width: 10%" onclick="location.href='repair_editor.aspx?parameter=<%# Eval("id") %>'"><%# Eval("defineId") %></td>--%>
                    <td style="text-align: center; width: 10%"><%# Eval("adminname") %></td>
                    <td style="text-align: center; width: 10%"><%# Eval("ftype") %></td>
                    <td style="text-align: center; width: 10%"><%# Eval("result") %></td>
                    <td style="text-align: center; width: 10%"><%# Eval("addTime","{0:yyyy-MM-dd}") %></td>
                    <td class="sz" style="text-align: center; width: 10%" onclick="location.href='repair_editor.aspx?parameter=<%# Eval("id") %>'">修改</td>
                </tr>
           
        </ItemTemplate>
    </asp:ListView>
       </tbody>
         </table>
    <div style="text-align:center;margin-top: 10px;">
        <%-- <asp:DataPager ID="DataPager1" runat="server" PagedControlID="rptrepair">
            <Fields>
                <asp:NextPreviousPagerField ButtonType="Button" ShowNextPageButton="false" ShowPreviousPageButton="True" />
                <asp:NumericPagerField ButtonType="Button" ButtonCount="10" />
                <asp:NextPreviousPagerField ButtonType="Button" ShowNextPageButton="True" ShowPreviousPageButton="false" />
            </Fields>
        </asp:DataPager>--%>
         <div class="m-page">
            <asp:DataPager ID="DataPager1" runat="server" PagedControlID="rptrepair">
                <Fields>
                    <asp:NextPreviousPagerField ButtonType="Link" ButtonCssClass="first pageprv" ShowNextPageButton="false" ShowPreviousPageButton="True" />
                    <asp:NumericPagerField ButtonType="Link" ButtonCount="10" CurrentPageLabelCssClass="z-crt" />
                    <asp:NextPreviousPagerField ButtonType="Link" ButtonCssClass="last pagenxt" ShowNextPageButton="True" ShowPreviousPageButton="false" />
                </Fields>
            </asp:DataPager>
        </div>
    </div>
    <div style="text-align:center;margin-top: 10px;">
    <asp:Button ID="buttonredetail" runat="server" Text="返回" OnClick="buttonredetail_Click"  />
        </div>
</asp:Content>

