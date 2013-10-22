<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GiaodienAdmin.aspx.cs" Inherits="UI.GiaodienAdmin" %>

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
            width: 154px;
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td colspan="2">
                    <img alt="" src="Image/BannerDep.jpg" style="width: 879px; height: 427px" /><br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" 
                        DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" 
                        ForeColor="#284E98" StaticSubMenuIndent="10px">
                        <StaticSelectedStyle BackColor="#507CD1" />
                        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                        <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
                        <DynamicMenuStyle BackColor="#B5C7DE" />
                        <DynamicSelectedStyle BackColor="#507CD1" />
                        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                        <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
                        <Items>
                            <asp:MenuItem Text="Center Management" Value="Center Management"></asp:MenuItem>
                            <asp:MenuItem Text="Shop Management" Value="Shop Management"></asp:MenuItem>
                        </Items>
                    </asp:Menu>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
