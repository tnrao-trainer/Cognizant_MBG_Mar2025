<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication34.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <main>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    DataKeyNames="empno" OnRowEditing="GridView1_RowEditing" 
    OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" 
    OnRowDeleting="GridView1_RowDeleting">
    <Columns>
        <asp:BoundField DataField="empno" HeaderText="Emp No" ReadOnly="True" />
        <asp:BoundField DataField="ename" HeaderText="Name" />
        <asp:BoundField DataField="job" HeaderText="Job" />
        <asp:BoundField DataField="sal" HeaderText="Salary" />
        <asp:BoundField DataField="deptno" HeaderText="Dept No" />
        <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
    </Columns>
</asp:GridView>

<br />

<asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
<br />
<h4>Add New Employee</h4>
<asp:TextBox ID="txtEmpno" runat="server" Placeholder="Emp No" />
<asp:TextBox ID="txtEname" runat="server" Placeholder="Name" />
<asp:TextBox ID="txtJob" runat="server" Placeholder="Job" />
<asp:TextBox ID="txtSal" runat="server" Placeholder="Salary" />
<asp:TextBox ID="txtDeptno" runat="server" Placeholder="Dept No" />
<asp:Button ID="btnAdd" runat="server" Text="Add Employee" OnClick="btnAdd_Click" />


    </main>
</asp:Content>
