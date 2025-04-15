<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductSessionExample.aspx.cs" Inherits="WebApplication31.ProductSessionExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <h2>Product Entry (Session & Application State)</h2>

<table>
    <tr>
        <td>Product ID:</td>
        <td><asp:TextBox ID="txtProductId" runat="server" /></td>
    </tr>
    <tr>
        <td>Product Name:</td>
        <td><asp:TextBox ID="txtProductName" runat="server" /></td>
    </tr>
    <tr>
        <td>Unit Price:</td>
        <td><asp:TextBox ID="txtUnitPrice" runat="server" /></td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Button ID="btnAdd" runat="server" Text="Add Product" OnClick="btnAdd_Click" />
        </td>
    </tr>
</table>

<hr />

<h3>My Product List</h3>
<asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="true" />

<hr />

<asp:Label ID="lblProductCount" runat="server" ForeColor="Blue" Font-Bold="true" />

    </form>
</body>
</html>
