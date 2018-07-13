<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style2">
    
        <span class="auto-style1"><strong>EMPLOYEE DETAIL</strong><br />
        </span>
        <br />
        <span class="auto-style3">EMPLOYEE NO:</span><asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3"></asp:TextBox>
        <br />
        <br class="auto-style3" />
        <span class="auto-style3">EMPLOYEE NAME:</span><asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style3"></asp:TextBox>
        <br />
        <br class="auto-style3" />
        <span class="auto-style3">EMPLOYEE ADDRESS:</span><asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style3"></asp:TextBox>
        <br />
        <br class="auto-style3" />
        <span class="auto-style3">EMPLOYEE SALARY:</span><asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style3"></asp:TextBox>
        <br />
        <br class="auto-style3" />
        <asp:Button ID="Button1" runat="server" CssClass="auto-style3" OnClick="Button1_Click" Text="Save" />
        <span class="auto-style3">&nbsp;
        <asp:Button ID="Button3" runat="server" CssClass="auto-style3" Text="Update" OnClick="Button3_Click" />
&nbsp; </span>
        <asp:Button ID="Button2" runat="server" CssClass="auto-style3" Text="Delete" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1" DataTextField="Empname" DataValueField="Empno" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="125px"></asp:ListBox>
        <br />
        <br class="auto-style3" />
        <span class="auto-style3">
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" style="font-size: x-large" Text="Cancel" />
&nbsp;</span><span class="auto-style3">&nbsp;
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="disp_rec" TypeName="nsemployee.clsemp"></asp:ObjectDataSource>
        <br />
        </span>
    
    </div>
    </form>
</body>
</html>
