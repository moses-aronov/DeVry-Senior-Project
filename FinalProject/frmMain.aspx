<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMain.aspx.cs" Inherits="FinalProject.frmMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 890px">
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="136px" ImageUrl="~/Pictures/banner.jpg" Width="100%" />
    
    </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Image ID="imgbtnManage" runat="server" Height="59px" ImageUrl="~/Pictures/manage.jpg" Width="64px" />
&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButtonManage" runat="server" PostBackUrl="~/frmManageUsers.aspx">Manage Users</asp:LinkButton>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Image ID="imbtnStaff" runat="server" Height="46px" ImageUrl="~/Pictures/Employee.jpg" Width="53px" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButtonStaff" runat="server" PostBackUrl="~/frmCreateStaff.aspx">Enter Staff Request</asp:LinkButton>
    </form>
</body>
</html>
