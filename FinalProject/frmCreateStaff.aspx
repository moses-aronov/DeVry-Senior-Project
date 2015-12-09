<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCreateStaff.aspx.cs" Inherits="FinalProject.frmCreateStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            height: 23px;
            text-align: left;
        }
        .auto-style4 {
            height: 23px;
            width: 460px;
            text-align: right;
        }
        .auto-style5 {
            width: 460px;
            text-align: right;
        }
        .auto-style6 {
            text-align: left;
        }
    </style>
</head>
<body style="height: 641px">
    <form id="form1" runat="server">
        <p>
            <asp:Image ID="Image1" runat="server" Height="136px" ImageUrl="~/Pictures/banner.jpg" Width="100%" />
        </p>
    <div class="auto-style1">
    
        <br />
    
        <br />
        <table class="auto-style2">
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="First Name: "></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtFirstName" runat="server" Width="225px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label6" runat="server" Text="Last Name: "></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtLastName" runat="server" Width="227px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label2" runat="server" Text="Address: "></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label3" runat="server" Text="City: "></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label4" runat="server" Text="State:"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:DropDownList ID="ddlLocation" runat="server">
                        <asp:ListItem>AL</asp:ListItem>
                        <asp:ListItem>AK</asp:ListItem>
                        <asp:ListItem>AZ</asp:ListItem>
                        <asp:ListItem>AR</asp:ListItem>
                        <asp:ListItem>CA</asp:ListItem>
                        <asp:ListItem>CO</asp:ListItem>
                        <asp:ListItem>CT</asp:ListItem>
                        <asp:ListItem>DE</asp:ListItem>
                        <asp:ListItem>DC</asp:ListItem>
                        <asp:ListItem>FL</asp:ListItem>
                        <asp:ListItem>GA</asp:ListItem>
                        <asp:ListItem>HI</asp:ListItem>
                        <asp:ListItem>ID</asp:ListItem>
                        <asp:ListItem>IL</asp:ListItem>
                        <asp:ListItem>IN</asp:ListItem>
                        <asp:ListItem>IA</asp:ListItem>
                        <asp:ListItem>KS</asp:ListItem>
                        <asp:ListItem>KY</asp:ListItem>
                        <asp:ListItem>LA</asp:ListItem>
                        <asp:ListItem>ME</asp:ListItem>
                        <asp:ListItem>MD</asp:ListItem>
                        <asp:ListItem>MA</asp:ListItem>
                        <asp:ListItem>MI</asp:ListItem>
                        <asp:ListItem>MN</asp:ListItem>
                        <asp:ListItem>MS</asp:ListItem>
                        <asp:ListItem>MO</asp:ListItem>
                        <asp:ListItem>MT</asp:ListItem>
                        <asp:ListItem>NE</asp:ListItem>
                        <asp:ListItem>NH</asp:ListItem>
                        <asp:ListItem>NJ</asp:ListItem>
                        <asp:ListItem>NM</asp:ListItem>
                        <asp:ListItem>NY</asp:ListItem>
                        <asp:ListItem>NC</asp:ListItem>
                        <asp:ListItem>ND</asp:ListItem>
                        <asp:ListItem>OH</asp:ListItem>
                        <asp:ListItem>OK</asp:ListItem>
                        <asp:ListItem>OR</asp:ListItem>
                        <asp:ListItem>PA</asp:ListItem>
                        <asp:ListItem>SC</asp:ListItem>
                        <asp:ListItem>RI</asp:ListItem>
                        <asp:ListItem>TN</asp:ListItem>
                        <asp:ListItem>SD</asp:ListItem>
                        <asp:ListItem>UT</asp:ListItem>
                        <asp:ListItem Selected="True">TX</asp:ListItem>
                        <asp:ListItem>VA</asp:ListItem>
                        <asp:ListItem>VT</asp:ListItem>
                        <asp:ListItem>WV</asp:ListItem>
                        <asp:ListItem>WA</asp:ListItem>
                        <asp:ListItem>WY</asp:ListItem>
                        <asp:ListItem>WI</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label5" runat="server" Text="Zip Code:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtZip" runat="server" Width="82px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label7" runat="server" Text="Phone:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label8" runat="server" Text="E-Mail:"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtEMail" runat="server" OnTextChanged="txtEMail_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label22" runat="server" Text="Upload Photo:"></asp:Label>
                </td>
                <td class="auto-style6">
                    <input id="fuPicture" name="fuPicture" style="height: 22px" type="file" /></td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label23" runat="server" Text="Upload Resume:"></asp:Label>
                </td>
                <td class="auto-style6">
                    <input id="fuResume" name="fuResume" style="height: 22px" type="file" /></td>
            </tr>
        </table>
        <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" style="height: 26px" Text="Submit " />
&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
