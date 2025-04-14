<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationsDemo.aspx.cs" Inherits="WebApplication30.ValidationsDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <h3>Working with Validations Controls in ASP.NET</h3>
    <hr />

     <form id="form1" runat="server">
      <div>

          <table>
              <tr>
                  <td>Product Id  : </td>
                  <td>
                      <asp:TextBox ID="txtProductId" runat="server"></asp:TextBox>

                      <asp:RequiredFieldValidator 
                          ID="RequiredFieldValidator1" 
                          runat="server" 
                          ControlToValidate="txtProductId"
                          ErrorMessage="Product Id is required" 
                          ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                  </td>
              </tr>

              <tr>
                  <td>Product Name  : </td>
                  <td>
                      <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                          ControlToValidate="txtProductName"
                        ErrorMessage="Product Name is requied" Display="None" ForeColor="Red"></asp:RequiredFieldValidator>
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
                      <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Quantity should be between 1 to 10" 
                    ControlToValidate="txtQuantity"
                   ForeColor="Red"
                    MinimumValue="1" MaximumValue="10" 
                          Display="None"
                          Type="Integer"></asp:RangeValidator>
                  </td>
              </tr>

              <tr>
                  <td></td>
                  <td>
                      <asp:Button ID="btnAddProduct" runat="server" OnClick="btnAddProduct_Click" Text="Add Product" />
                  </td>
              </tr>

              <tr>
                  <td colspan="2">
                      <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                  </td>
              </tr>

          </table>

          <hr />

          <asp:Label ID="lblStatus" runat="server"></asp:Label>

          <hr />

       


      </div>
  </form>
</body>
</html>
