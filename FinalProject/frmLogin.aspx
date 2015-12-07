<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="FinalProject.frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 428px;
        }
        .auto-style2 {
            height: 144px;
        }
    </style>
</head>
<body style="height: 562px">
    <form id="form1" runat="server" class="auto-style1">
    <div class="auto-style2">
    
            <asp:Image ID="Image1" runat="server" Height="136px" ImageUrl="~/Pictures/banner.jpg" Width="100%" />
        <br />
        <br />
        <br />
        <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/frmMain.aspx" OnAuthenticate="Login1_Authenticate" style="text-align: center" TitleText="Please enter your UserName and Password in order to log in to the system.">
        </asp:Login>
        <br />
    
    </div>
    </form>
</body>
</html>
