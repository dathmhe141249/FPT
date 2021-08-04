<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addrecord.aspx.cs" Inherits="Q3_Sp20_B1.addrecord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .container{
            display: flex;
        }
        .right{
            width: 30%;
            margin-left: 30px;
        }
        .left{
            width:30%;
            margin-right:30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Country"></asp:Label>
&nbsp;<asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <div class="container">
                <div class="left">
<asp:Label ID="Label2" runat="server" Text="From"></asp:Label>
 <asp:Calendar ID="Carlendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                <NextPrevStyle VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#808080" />
                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                <SelectorStyle BackColor="#CCCCCC" />
                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
                </div>
           <div class="right">
<asp:Label ID="Label3" runat="server" Text="To"></asp:Label>
               <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
            <br />
           </div>
           
            </div>
             <asp:Button ID='Button1' runat='server' Text='Add Record' OnClick="Button1_Click" />
            <br />
            <asp:PlaceHolder ID="phField" runat="server"></asp:PlaceHolder>
            <br />
            <asp:Label ID="ErrorMsg" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" />
        </div>
       
    </form>
</body>
    <script>
        var session = '<%= Session["Error"]%>';
        if (session == '') {
        } else {
            alert(session);
        }


    </script>
</html>
