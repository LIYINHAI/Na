<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="NT_Web.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <div class="form">
					<h2>Register a account</h2>					
                      <asp:TextBox ID="UserName" runat="server" placeholder="用户名"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName" ErrorMessage=""></asp:RequiredFieldValidator>
                       <asp:TextBox ID="User_Img" runat="server" placeholder="头像"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="UserName" ErrorMessage=""></asp:RequiredFieldValidator>
                      <asp:TextBox ID="Password" runat="server" placeholder="密码" TextMode="Password"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Password" ErrorMessage=""></asp:RequiredFieldValidator>
                      <asp:TextBox ID="RePassword" runat="server" placeholder="确认密码" TextMode="Password"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="RePassword" ErrorMessage=""></asp:RequiredFieldValidator>
                      <asp:TextBox ID="Email" runat="server" placeholder="邮箱"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Email" ErrorMessage=""></asp:RequiredFieldValidator>
                      <asp:TextBox ID="Phone" runat="server" placeholder="电话"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Phone" ErrorMessage=""></asp:RequiredFieldValidator>
                      <asp:Button ID="Button1" runat="server" Text="注册" OnClick="Button1_Click" />
					
				  </div>				  
					
    </form>
</body>
</html>
