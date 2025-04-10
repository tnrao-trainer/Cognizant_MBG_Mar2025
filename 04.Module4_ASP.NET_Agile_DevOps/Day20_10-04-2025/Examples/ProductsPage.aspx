<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductsPage.aspx.cs" Inherits="WebApplication30.ProductsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h3>Products Page</h3>
    <hr />
    <form id="form1" runat="server">
        <div>

            <table>
                <tr>
                    <td>Product Id  : </td>
                    <td>
                        <asp:TextBox ID="txtProductId" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>Product Name  : </td>
                    <td>
                        <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>Unit Price:</td>
                    <td>
                        <asp:TextBox ID="txtUnitPrice" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td>Quantity:</td>
                    <td>
                        <asp:TextBox ID="txtQuantity" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnAddProduct" runat="server" OnClick="btnAddProduct_Click" Text="Add Product" />
                    </td>
                </tr>

            </table>

            <hr />

            <asp:Label ID="lblStatus" runat="server"></asp:Label>

            <hr />

            <h3>Product List</h3>
            <asp:GridView ID="gvProducts" runat="server" 
                          AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" EmptyDataText="No products added yet.">
                <Columns>
                    <asp:BoundField DataField="ProductId" HeaderText="Product ID" />
                    <asp:BoundField DataField="ProductName" HeaderText="Name" />
                    <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" DataFormatString="{0:C}" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                </Columns>
            </asp:GridView>


        </div>
    </form>
</body>
</html>
