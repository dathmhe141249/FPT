<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="master.aspx.cs" Inherits="ExA.master" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Detail"></asp:Label>
            <br />
            Name:<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            Master:<asp:DropDownList ID="ddlmaster" runat="server">
            </asp:DropDownList>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Filter" />
        <br />
        <asp:GridView ID="gvmaster" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
