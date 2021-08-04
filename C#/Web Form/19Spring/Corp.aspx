<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Corp.aspx.cs" Inherits="_19Spring.Corp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Region:<asp:DropDownList ID="ddlregion" runat="server" OnSelectedIndexChanged="ddlregion_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        Corporation:<asp:DropDownList ID="ddlCorp" runat="server">
        </asp:DropDownList>
        <br />
        First Name:<asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
        <br />
        LastName:<asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add Member" />
    </form>
</body>
</html>
