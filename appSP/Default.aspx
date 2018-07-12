<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
    <div class="auto-style1">
    
        <asp:Label ID="Label1" runat="server" style="text-align: center" Text="EMPLOYEE DETAILS"></asp:Label>
        <br />
        Employee No.&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Employee Name :&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        Employee Address :
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        Employee Salary :&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" Width="250px" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Update" Width="251px" OnClick="Button2_Click" />
        <br />
        <br />
        Other options:<br />
        <asp:Button ID="Button3" runat="server" Text="Delete" Width="116px" OnClick="Button3_Click" />
&nbsp;<asp:Button ID="Button4" runat="server" Text="Display" Width="137px" OnClick="Button4_Click" />
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="192px"></asp:ListBox>
        <br />
        <br />
    
    </div>
    </form>
    
</body>
</html>
