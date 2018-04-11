<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="NT_Web.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div class="form">
					<h2>Login to your account</h2>
					
                        <asp:TextBox ID="UserName" runat="server" placeholder="用户名"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName" ErrorMessage=""></asp:RequiredFieldValidator>
                        <asp:TextBox ID="Password" runat="server" placeholder="密码" TextMode="Password"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Password" ErrorMessage=""></asp:RequiredFieldValidator>
                        <asp:Button ID="Button1" runat="server" Text="登录" OnClick="Button1_Click" />	<br />
                      <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>  
				  </div>	
    </form>
</body>
</html>
