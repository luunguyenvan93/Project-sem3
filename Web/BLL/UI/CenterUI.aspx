<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CenterUI.aspx.cs" Inherits="UI._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 57%;
        }
        .style2
        {
            height: 23px;
        }
        .style3
        {
            height: 27px;
        }
        .style4
        {
            height: 30px;
        }
        #stylediv
        {
        	margin:auto;
        }
        .style5
        {
            height: 26px;
        }
        .style6
        {
            height: 26px;
            width: 146px;
        }
        .style7
        {
            height: 23px;
            width: 146px;
        }
    </style>
</head>
<body >
    <form id="form1" runat="server">
    <div>
        <table class="style1" id="stylediv">
            <tr>
                <td align="left" class="style3" colspan="2">
                    <asp:Label ID="Label3" runat="server" Text="Center Management"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    <asp:Label ID="Label1" runat="server" Text="Center ID:"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="txtCenterID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    <asp:Label ID="Label4" runat="server" Text="Center Name:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="txtCenterName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="left" class="style4" colspan="2">
                    <asp:Button ID="btnAdd" runat="server" onclick="btnAdd_Click" 
                        style="height: 26px" Text="Add" />
                    <asp:Button ID="btnUpdate" runat="server" onclick="btnUpdate_Click" 
                        Text="Update" />
                    <asp:Button ID="btnDelete" runat="server" onclick="btnDelete_Click" 
                        Text="Delete" />
                </td>
            </tr>
            <tr>
                <td align="left" class="style4" colspan="2">
        <asp:GridView ID="grvCenter" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" ForeColor="#333333" GridLines="None" 
            style="margin-bottom: 12px" Width="441px" DataKeyNames="centerID" 
            onrowdatabound="grvCenter_RowDataBound" 
            onrowdeleting="grvCenter_RowDeleting" 
            onrowcancelingedit="grvCenter_RowCancelingEdit" 
            onrowediting="grvCenter_RowEditing" onrowupdating="grvCenter_RowUpdating">
            <RowStyle BackColor="#E3EAEB" />
            <Columns>
                <asp:BoundField DataField="centerID" HeaderText="Center ID" />
                <asp:BoundField DataField="centerName" HeaderText="Center Name" />
                <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
            </Columns>
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
    
                </td>
            </tr>
        </table>
        <br />
    
    </div>
    </form>
</body>
</html>
