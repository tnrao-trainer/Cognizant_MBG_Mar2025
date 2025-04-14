<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationPage.aspx.cs" Inherits="WebApplication30.RegistrationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <h2>Registration Form</h2>
    <hr />
    
    <form id="form1" runat="server">
 



<table>
    <tr>
        <td>Name:</td>
        <td>
            <asp:TextBox ID="txtName" runat="server" />
            <asp:RequiredFieldValidator ID="rfvName" runat="server" 
                ControlToValidate="txtName" 
                ErrorMessage="Name is required" 
                Display="None" ForeColor="Red" />
        </td>
    </tr>

    <tr>
        <td>Email:</td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server" />
            <asp:RegularExpressionValidator ID="revEmail" runat="server" 
                ControlToValidate="txtEmail" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                ErrorMessage="Invalid email format" 
                Display="None" ForeColor="Red" />
        </td>
    </tr>

    <tr>
        <td>Age:</td>
        <td>
            <asp:TextBox ID="txtAge" runat="server" />
            <asp:RangeValidator ID="rvAge" runat="server" 
                ControlToValidate="txtAge" 
                MinimumValue="18" MaximumValue="60" Type="Integer" 
                ErrorMessage="Age must be between 18 and 60" 
                Display="None" ForeColor="Red" />
        </td>
    </tr>

    <tr>
        <td>Password:</td>
        <td>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" 
                ControlToValidate="txtPassword" 
                ErrorMessage="Password is required" 
                Display="None" ForeColor="Red" />
        </td>
    </tr>

    <tr>
        <td>Confirm Password:</td>
        <td>
            <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" />
            <asp:CompareValidator ID="cvPasswords" runat="server" 
                ControlToValidate="txtConfirmPassword" 
                ControlToCompare="txtPassword" 
                ErrorMessage="Passwords do not match" 
                Display="None" ForeColor="Red" />
        </td>
    </tr>

    <tr>
        <td>Custom Code:</td>
        <td>
            <asp:TextBox ID="txtCustomCode" runat="server" />
            <asp:CustomValidator ID="cvCode" runat="server" 
                ControlToValidate="txtCustomCode" 
                ErrorMessage="Code must be 'XYZ123'" 
                OnServerValidate="cvCode_ServerValidate" 
                Display="None" ForeColor="Red" />
        </td>
    </tr>

    <tr>
        <td colspan="2" align="center">
            <asp:Button ID="btnSubmit" runat="server" Text="Register" OnClick="btnSubmit_Click"
                OnClientClick="return checkValidation();" />
        </td>
    </tr>
    <tr>
    <td colspan="2" >
       <asp:ValidationSummary ID="vsSummary" runat="server" 
    ShowMessageBox="false" ShowSummary="true" ForeColor="Red" />
    </td>
</tr>
    <tr>
        <td colspan="2" align="center">
            <asp:Label ID="lblMessage" runat="server" ForeColor="Green" />
        </td>
    </tr>
</table>

<script type="text/javascript">
    function checkValidation() {
        var isValid = Page_ClientValidate();
        if (!isValid) {
            document.getElementById('<%= lblMessage.ClientID %>').innerText = '';
        }
        return isValid;
    }
</script>

 
    </form>
</body>
</html>
