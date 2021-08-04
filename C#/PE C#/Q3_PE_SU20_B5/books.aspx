<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="books.aspx.cs" Inherits="Q3_PE_SU20_B5.books" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="List of books:"></asp:Label>
            <br />
            <asp:GridView ID="gvBook" runat="server" AutoGenerateColumns="False" EnableModelValidation="True">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" />
                    <asp:BoundField DataField="Title" HeaderText="Title" />
                    <asp:BoundField DataField="Year" HeaderText="Year" />
                    <asp:BoundField DataField="Description" HeaderText="Description" />
                    <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="delete.aspx?id={0}" HeaderText="Action" Text="Delete" />
                </Columns>
            </asp:GridView>
        </div>
    </form>

</body>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js" integrity="sha512-894YE6QWD5I59HgZOGReFYm4dnWc1Qt5NtvYSaNcOP+u1T9qYdvdihz0PPSiiqn/+/3e7Jo4EaG7TubfWGUrMQ==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
<script>
    $("table tr td a").click(function () {
        var x = confirm("Are you sure you want to delete?");
        if (x)
            return true;
        else
            return false;
    });
</script>
</html>
