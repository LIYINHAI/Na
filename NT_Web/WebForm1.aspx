<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="NT_Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:ListView ID="ListView1" runat="server">
           
            <ItemTemplate>
                <tr style="">
                    <td>
                        <asp:Label ID="User_IDLabel" runat="server" Text='<%# Eval("User_ID") %>' />
                    </td>
                    <td>
                        <asp:Label ID="User_NameLabel" runat="server" Text='<%# Eval("User_Name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="User_PasswordLabel" runat="server" Text='<%# Eval("User_Password") %>' />
                    </td>
                    <td>
                        <asp:Label ID="User_ImgLabel" runat="server" Text='<%# Eval("User_Img") %>' />
                    </td>
                    <td>
                        <asp:Label ID="User_EmailLabel" runat="server" Text='<%# Eval("User_Email") %>' />
                    </td>
                    <td>
                        <asp:Label ID="User_PhoneLabel" runat="server" Text='<%# Eval("User_Phone") %>' />
                    </td>
                </tr>
            </ItemTemplate>
         
        </asp:ListView>
    </div>
      
    </form>
</body>
</html>

