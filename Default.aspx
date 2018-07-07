<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-size: x-large;
            font-weight: 700;
        }
        .auto-style3 {
            font-size: x-large;
        }
        .auto-style4 {
            font-size: x-large;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <center>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Large" Text="EMPLOYEE DETAILS" style="font-size: x-large" BorderStyle="Dotted"></asp:Label>
        <br />
        <br />
        <br />
    
        <strong>
    
        <asp:Label ID="Label1" runat="server" Text="Emp no" CssClass="auto-style3"></asp:Label>
        </strong><span class="auto-style3"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></span><strong>
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter Employee id" CssClass="auto-style4"></asp:TextBox>
        <br class="auto-style3" />
        <br class="auto-style3" />
        <asp:Label ID="Label2" runat="server" Text="Emp name" CssClass="auto-style3"></asp:Label>
        </strong><span class="auto-style3"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </strong></span><strong>
        <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter Employee name" CssClass="auto-style4"></asp:TextBox>
        <br class="auto-style3" />
        <br class="auto-style3" />
        <asp:Label ID="Label3" runat="server" Text="Emp address" CssClass="auto-style3"></asp:Label>
        </strong><span class="auto-style3"><strong>&nbsp;&nbsp;&nbsp;
        </strong></span><strong>
        <asp:TextBox ID="TextBox3" runat="server" placeholder="Enter Employee address" CssClass="auto-style4"></asp:TextBox>
        <br class="auto-style3" />
        <br class="auto-style3" />
        <asp:Label ID="Label4" runat="server" Text="Emp sal" CssClass="auto-style3"></asp:Label>
        </strong><span class="auto-style3"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </strong></span><strong>
        <asp:TextBox ID="TextBox4" runat="server" placeholder="Enter Employee salary" CssClass="auto-style4"></asp:TextBox>
        </strong>
        <br class="auto-style2" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Save" Width="91px" CssClass="auto-style3" OnClick="Button1_Click1" />
        <span class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </span>
        <asp:Button ID="Button2" runat="server" Text="Update" Width="113px" CssClass="auto-style3" OnClick="Button2_Click1" />
        <span class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </span>
        <asp:Button ID="Button3" runat="server" Text="Delete" Width="92px" CssClass="auto-style3" OnClick="Button3_Click" />
        <span class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </span>
        <asp:Button ID="Button4" runat="server" Text="Display" Width="114px" CssClass="auto-style3" OnClick="Button4_Click" />
    
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="293px"></asp:ListBox>
    
        <br />
    
    </div>
    </form>
        </center>
    <p>
        &nbsp;</p>
</body>
</html>
