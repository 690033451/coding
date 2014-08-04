<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="detail_abandon.aspx.cs" Inherits="detail_abandon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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
            <a href="#">报废详情</a>
        </div>
    </div>

                <div class="tip">报废详情</div>
    <table class="table nohover" border="1">
        <asp:Repeater runat="server" ID="rptdetail">
            <ItemTemplate>

                <tr>
                    <td style="width: 15%; text-align: center;">机器编号</td>
                    <td style="width: 85%;">&nbsp;&nbsp;<%# Eval("id") %></td>
                </tr>
                <tr>
                    <td style="width: 15%; text-align: center;">类型</td>
                    <td>&nbsp;&nbsp;<%# Eval("type") %></td>
                </tr>
                 <tr>
                    <td style="width: 15%; text-align: center;">使用情况</td>
                    <td>&nbsp;&nbsp;<%#Enum.GetName(typeof(DLL.BaseCode.BaseCode.state), int.Parse(Eval("flag").ToString()))%></td>
                </tr>
                  <tr>
                    <td style="width: 15%; text-align: center;">部门</td>
                    <td>&nbsp;&nbsp;<%# Eval("department") %></td>
                </tr>
                <tr>
                    <td style="width: 15%; text-align: center;">房间号</td>
                    <td>&nbsp;&nbsp;<%# Eval("roomnum") %></td>
                </tr>
                <tr>
                    <td style="width: 15%; text-align: center;">使用人</td>
                    <td>&nbsp;&nbsp;<%# Eval("username") %></td>
                </tr>
                
                <tr>
                    <td style="width: 15%; text-align: center;">网络</td>
                    <td>&nbsp;&nbsp;<%# Eval("nettype") %></td>
                </tr>
                <tr>
                    <td style="width: 15%; text-align: center;">内网IP</td>
                    <td>&nbsp;&nbsp;<%# Eval("innerIP") %></td>
                </tr>
                <tr>
                    <td style="width: 15%; text-align: center;">外网IP</td>
                    <td>&nbsp;&nbsp;<%# Eval("outerIP") %></td>
                </tr>
                <tr>
                    <td style="width: 15%; text-align: center;">显示器信息</td>
                    <td>&nbsp;&nbsp;<%# Eval("screenInfo") %></td>
                </tr>
                <tr>
                    <td style="width: 15%; text-align: center;">打印机信息</td>
                    <td>&nbsp;&nbsp;<%# Eval("printerInfo") %></td>
                </tr>
                <tr>
                    <td style="width: 15%; text-align: center;">扫描仪信息</td>
                    <td>&nbsp;&nbsp;<%# Eval("scannerInfo") %></td>
                </tr>
              
                <tr>
                    <td style="width: 15%; text-align: center;">品牌</td>
                    <td>&nbsp;&nbsp;<%# Eval("brand") %></td>
                </tr>
                <tr>
                    <td style="width: 15%; text-align: center;">型号</td>
                    <td>&nbsp;&nbsp;<%# Eval("version") %></td>
                </tr>
                <tr>
                    <td style="width: 15%; text-align: center;">网卡</td>
                    <td>&nbsp;&nbsp;<%# Eval("mac") %></td>
                </tr>
                <tr>
                    <td style="width: 15%; text-align: center;">备注</td>
                    <td>&nbsp;&nbsp;<%# Eval("description") %></td>
                </tr>

            </ItemTemplate>
        </asp:Repeater>
        <tr>
            <td style="width: 15%; text-align: center;">维修次数</td>
            <td>&nbsp;&nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CssClass="linkbutton" OnClick="LinkButton2_Click"></asp:LinkButton></td>
        </tr>
    </table>
    <div style="margin-top:10px;text-align:center">
        <asp:Button ID="Buttoneditor" runat="server" Text="更改" OnClick="Buttoneditor_Click"  />
    </div>
</asp:Content>

