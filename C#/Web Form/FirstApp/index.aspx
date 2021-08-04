<!--Directive-->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="FirstApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </div>
        <hr />
        <p>
            <asp:Button ID="btnClick" runat="server" OnClick="btnClick_Click" Text="Click me" />
        </p>
    </form>
</body>
</html>
