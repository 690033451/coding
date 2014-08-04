<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Detail.aspx.cs" Inherits="Detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        $(function () {
            listtab('zj');
            $(".lyclose").click(function () { $(".m-layer").hide(); });
        });
    </script>
    <style>
        .linkbutton:link {
            color: black;
        }

        .linkbutton:hover {
            color: black;
        }

        .linkbutton:visited {
            color: black;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="qianhead">
        <div class="link">
            <a href="List_equipment.aspx">设备管理</a>
        </div>
        <div class="link on">
            <a href="#">设备详情</a>
        </div>
        <div class="link">
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">维修详情</asp:LinkButton>
        </div>
    </div>

   <%-- <div class="toolhead">
        <div class="toolheadleft">
        </div>
        <div class="toolheadmid">
            <ul id="nav">
                <li>
                    <asp:LinkButton ID="LinkButtonadd" runat="server" CssClass="wh" OnClick="LinkButtonadd_Click" Text="添加维修"></asp:LinkButton></li>
            </ul>
        </div>
    </div>--%>
    <div>
        <div class="tip">设备详情</div>
        <table class="table nohover" border="1" >
            <asp:Repeater runat="server" ID="rptdetail">
                <ItemTemplate>
                    <tr>
                        <td style="width: 10%; text-align: center;">机器编号</td>
                        <td >&nbsp;&nbsp;<%# Eval("defineId") %></td>
                         </tr>
                    <tr>
                        <td style="width: 10%; text-align: center;">型号</td>
                        <td >&nbsp;&nbsp;<%# Eval("version") %></td>
                    </tr>
                    <tr>
                        <td style="width: 10%; text-align: center;">部门</td>
                        <td>&nbsp;&nbsp;<%# Eval("department") %></td>
                         </tr>
                    <tr>
                        <td style="width: 10%; text-align: center;">房间号</td>
                        <td>&nbsp;&nbsp;<%# Eval("roomnum") %></td>
                    </tr>
                    <tr>
                        <td style="width: 10%; text-align: center;">使用人</td>
                        <td>&nbsp;&nbsp;<%# Eval("username") %></td>
                         </tr>
                    <tr>
                        <td style="width: 10%; text-align: center;">品牌</td>
                        <td >&nbsp;&nbsp;<%# Eval("brand") %></td>
                    </tr>
                    <tr>
                        <td style="width: 10%; text-align: center;">网络</td>
                        <td>&nbsp;&nbsp;<%# Eval("nettype") %></td>
                         </tr>
                    <tr>
                        <td style="width: 10%; text-align: center;">显示器信息</td>
                        <td >&nbsp;&nbsp;<%# Eval("screenInfo") %></td>
                    </tr>
                    <tr>
                        <td style="width: 10%; text-align: center;">内网IP</td>
                        <td >&nbsp;&nbsp;<%# Eval("innerIP") %></td>
                         </tr>
                    <tr>
                        <td style="width: 10%; text-align: center;">外网IP</td>
                        <td>&nbsp;&nbsp;<%# Eval("outerIP") %></td>
                    </tr>
                    <tr>
                        <td style="width: 10%; text-align: center;">使用情况</td>
                        <td >&nbsp;&nbsp;<%#Enum.GetName(typeof(DLL.BaseCode.BaseCode.state), int.Parse(Eval("flag").ToString()))%></td>
                         </tr>
                    <tr>
                        <td style="width: 10%; text-align: center;">类型</td>
                        <td >&nbsp;&nbsp;<%# Eval("type") %></td>
                    </tr>
                     <tr>
                        <td style="width: 10%; text-align: center;">购买时间</td>
                        <td >&nbsp;&nbsp;<%# Eval("buyTIme","{0:yyyy/MM/dd}") %></td>
                         </tr>
                    <tr>
                         <td style="width: 10%; text-align: center;">分发时间</td>
                        <td >&nbsp;&nbsp;<%# Eval("giveTime","{0:yyyy/MM/dd}") %></td>
                    </tr>
                   
                    <tr>
                        <td style="width: 10%; text-align: center;"> mac地址</td>
                 
                        <td>&nbsp;&nbsp;<%# Eval("mac") %></td>
                    </tr>
                    
                    <tr>
                        <td style="width: 10%; text-align: center;">打印机信息</td>
                        <td >&nbsp;&nbsp;<%# Eval("printerInfo") %></td>
                    </tr>
                    <tr>
                        <td style="width: 10%; text-align: center;">扫描仪信息</td>                    
                        <td>&nbsp;&nbsp;<%# Eval("scannerInfo") %></td>
                    </tr>
                    <tr>
                        <td style="width: 10%; text-align: center;">备注</td>                   
                        <td >&nbsp;&nbsp;<%# Eval("description") %></td>
                    </tr>

                </ItemTemplate>
            </asp:Repeater>
           <%-- <tr>
                <td colspan="4" style="text-align: center;">维修次数</td>
            </tr>
            <tr>
                <td colspan="4" style="text-align: center;">&nbsp;&nbsp;<asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" CssClass="linkbutton"></asp:LinkButton></td>
            </tr>--%>
        </table>
    </div>
    <div style="position: absolute; top: 678px; left: 315px"></div>
    <div style="text-align: center; margin-top: 10px;">
        <asp:Button ID="Buttoneditor" runat="server" Text="更改" OnClick="Buttoneditor_Click" />&nbsp;
        <asp:Button ID="Buttonabandon" runat="server" Text="报废" OnClick="Buttonabandon_Click1" />
    </div>
    <div class="m-layer m-layer-show" runat="server" id="queren">
        <div class="lymask"></div>
        <table class="lytable">
            <tbody>
                <tr>
                    <td class="lytd">
                        <div class="lywrap">
                            <div class="lytt">
                                <h2 class="u-tt">报废机器</h2>
                                <span class="lyclose" runat="server">×</span></div>
                            <div class="lyct">
                                <p>确认要报废该机器吗？</p>

                            </div>
                            <div class="lybt">

                                <div class="lybtns">
                                    <asp:Button ID="Buttonqueren" runat="server" Text="确认" OnClick="Buttonabandon_Click" />
                                    <asp:Button ID="Buttonquxiao" runat="server" Text="取消" OnClick="Buttonquxiao_Click" />
                                </div>
                            </div>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>


</asp:Content>

