<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 61%;
        }
        .style2
        {
            width: 192px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label2" runat="server" Text="Add Center"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label1" runat="server" Text="Center Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCenterName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnCenter" runat="server" onclick="btnCenter_Click" 
                    Text="Add" />
            </td>
        </tr>
    </table>
    <div>
    
    </div>
    </form>
</body>
</html>
