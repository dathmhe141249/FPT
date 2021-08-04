<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SchedulePage.aspx.cs" Inherits="PE_SU20_Q3_B1.SchedulePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlTeachingDate" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTeachingDate_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:PlaceHolder ID="phSchedule" runat="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
