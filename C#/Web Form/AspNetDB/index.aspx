<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="AspNetDB.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCate" runat="server" Text="CatogoryName"></asp:Label>
            <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:GridView ID="gvProduct" runat="server" AutoGenerateColumns="False" EnableModelValidation="True">
                <Columns>
                    <asp:BoundField DataField="ProductID" HeaderText="ProductID" />
                    <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                    <asp:BoundField DataField="UnitPrice" HeaderText="Price" />
                    <asp:HyperLinkField DataNavigateUrlFields="ProductID" DataNavigateUrlFormatString="Edit.aspx?pid={0}" HeaderText="Update" Text="Edit" />
                    <asp:HyperLinkField DataNavigateUrlFields="ProductID" DataNavigateUrlFormatString="Delete.aspx?pid={0}" HeaderText="Xóa" Text="delete" />
                </Columns>
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
