<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>系统登录</title>
<%--    <script src="/js/jquery-1.8.2.min.js" type="text/javascript"></script>
    <script src="/js/jquery-ui-1.10.4.custom.min.js"></script>
    <link href="/js/themes/cupertino/jquery-ui-1.10.4.custom.css" rel="stylesheet" />--%>
        <script src="/js/jquery-1.8.3.js" type="text/javascript"></script>
    <script src="/js/jquery-ui-1.9.2.custom.min.js" type="text/javascript"></script>
    <link href="/js/themes/cupertino/jquery-ui-1.9.2.custom.css" rel="stylesheet" />
    <script src="/js/JScript.js" type="text/javascript"></script>
    <link href="/js/StyleSheet.css" rel="stylesheet" type="text/css" />
    <script>
        function logerror()
        {
            $("#diverror").hide();
        }
        
    </script>
</head>
<body style="background-color: #f5facc; margin: 0">
    
    <form id="form1" runat="server">
    <div style="height: 300px; width: 500px; background: url('img/login.png'); top: 50%; left: 50%; margin-top: -157px; margin-left: -254px; position: absolute">
            <div style="margin-top: 164px; margin-left: 280px">
                <asp:TextBox ID="usernameTextBox" runat="server"  Width="150px"></asp:TextBox>
            </div>
            <div style="margin-top: 16px; margin-left: 280px;">
                <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password" Width="150px"></asp:TextBox>
            </div>
            <div style="margin-top: 24px; margin-left: 310px">
                <asp:ImageButton ID="loginImageButton" runat="server" ImageUrl="img/loginbutton.jpg" OnClick="loginImageButton_Click"/>
            </div>
        </div>
     <div class="m-layer m-layer-show" runat="server" id="diverror">
    <div class="lymask"></div>
    <table class="lytable"><tbody><tr><td class="lytd">
    <div class="lywrap">
	    <div class="lytt"><h2 class="u-tt">登录失败</h2><span class="lyclose" runat="server" onclick="logerror()">×</span></div>
	    <div class="lyct">
	        <p>用户名或密码错误！</p>
	        
	    </div>
	    <div class="lybt">
	       
	        <div class="lybtns" style="text-align:center">
	            <asp:Button ID="Buttonqueren" runat="server" Text="确认" OnClick="Buttonqueren_Click"/>	           
	        </div>
	    </div>
    </div></td></tr></tbody></table>
</div>
    </form>

</body>
</html>
