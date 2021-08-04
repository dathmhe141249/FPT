<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Q3.aspx.cs" Inherits="Q3.Q3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Detail<br />
            Name:
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            Master:<asp:DropDownList ID="ddlMaster" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Button ID="btnFilter" runat="server" OnClick="btnFilter_Click" Text="Filter" />
            <asp:GridView ID="gvMaster" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
