<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FloorUI.aspx.cs" Inherits="UI.FloorUI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 55%;
        }
        .style2
        {
            height: 24px;
        }
        .style3
        {
            height: 32px;
        }
        .style4
        {
            height: 24px;
            width: 162px;
        }
        .style5
        {
            width: 162px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td align="center" colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="Shop Management"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label2" runat="server" Text="Floor ID:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtFloorID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="Label3" runat="server" Text="Floor Name:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFloorName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="Label4" runat="server" Text="Center ID:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlCenterID" runat="server" BackColor="#0066FF" 
                        DataSourceID="SqlDataSource1" DataTextField="centerName" 
                        DataValueField="centerID" ForeColor="Black" Height="37px" Width="128px">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:MallManagementConnectionString %>" 
                        SelectCommand="SELECT [centerID], [centerName] FROM [center]">
                    </asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td align="center" class="style3" colspan="2">
                    <asp:Button ID="btnAdd" runat="server" onclick="btnAdd_Click" Text="Add" />
                    <asp:Button ID="btnUpdate" runat="server" onclick="btnUpdate_Click" 
                        Text="Update" />
                    <asp:Button ID="btnDelete" runat="server" onclick="btnDelete_Click" 
                        Text="Delete" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="grvFloor" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" ForeColor="#333333" GridLines="None" Width="431px">
            <RowStyle BackColor="#E3EAEB" />
            <Columns>
                <asp:BoundField DataField="floorID" HeaderText="Floor ID" />
                <asp:BoundField DataField="floorName" HeaderText="Floor Name" />
                <asp:BoundField DataField="centerID" HeaderText="Center ID" />
            </Columns>
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
