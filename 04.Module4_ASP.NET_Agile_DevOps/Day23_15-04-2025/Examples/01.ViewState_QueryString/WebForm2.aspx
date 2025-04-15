<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication31.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <h3>State Management in ASP.NET</h3>
    <hr />

    <form id="form1" runat="server">
        <div>
            User Name :  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Send Data" OnClick="Button1_Click" />

            <hr />

            <asp:Button ID="Button2" runat="server" Text="Get Count" OnClick="Button2_Click" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        </div>
    </form>
</body>
</html>
