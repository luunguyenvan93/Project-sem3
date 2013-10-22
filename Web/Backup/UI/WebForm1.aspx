<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="WebForm1.aspx.cs" Inherits="UI.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
        }
        .style3
        {
            height: 25px;
        }
        .style5
        {
            width: 265px;
            height: 28px;
        }
        .style6
        {
            height: 28px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td align="center" class="style3" colspan="2">
                    Add Center</td>
            </tr>
            <tr>
                <td align="right" class="style5">
                    <asp:Label ID="Label1" runat="server" Text="Center Name:"></asp:Label>
                </td>
                <td align="center" class="style6">
                    <asp:TextBox ID="txtCenterName" runat="server" 
                        ontextchanged="txtCenterName_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" class="style2" colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
