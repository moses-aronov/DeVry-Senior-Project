<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmManageUsers.aspx.cs" Inherits="FinalProject.frmManageUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 157px;
        }
    </style>
</head>
<body style="height: 750px">
    <form id="form1" runat="server" class="auto-style1">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="136px" ImageUrl="~/Pictures/banner.jpg" Width="100%" />
        <br />
        <br />
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="427px">
            <asp:Label ID="lblManageUsers" runat="server" Text="Manage Users:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <asp:Label ID="lblUserName" runat="server" Text="Username:"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtUserName" runat="server" OnTextChanged="txtUserName_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtPassword" runat="server" OnTextChanged="txtPassword_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblSecurityLevel" runat="server" Text="Security Level:"></asp:Label>
            &nbsp;
            <asp:DropDownList ID="ddlSecurityLevel" runat="server">
                <asp:ListItem>A</asp:ListItem>
                <asp:ListItem>U</asp:ListItem>
                <asp:ListItem>S</asp:ListItem>
                <asp:ListItem>M</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [tblUserLogin] WHERE [UserID] = ?" InsertCommand="INSERT INTO [tblUserLogin] ([UserID], [UserName], [UserPassword], [SecurityLevel]) VALUES (?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [tblUserLogin]" UpdateCommand="UPDATE [tblUserLogin] SET [UserName] = ?, [UserPassword] = ?, [SecurityLevel] = ? WHERE [UserID] = ?">
                <DeleteParameters>
                    <asp:Parameter Name="UserID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="UserID" Type="Int32" />
                    <asp:Parameter Name="UserName" Type="String" />
                    <asp:Parameter Name="UserPassword" Type="String" />
                    <asp:Parameter Name="SecurityLevel" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="UserName" Type="String" />
                    <asp:Parameter Name="UserPassword" Type="String" />
                    <asp:Parameter Name="SecurityLevel" Type="String" />
                    <asp:Parameter Name="UserID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            <asp:Button ID="btnAddUser" runat="server" Text="Add User" OnClick="btnAddUser_Click" />
            <br />
            <br />
            <asp:Label ID="lblDisplay" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblCurrentUsers" runat="server" Text="Current Users:"></asp:Label>
            <br />
            <asp:GridView ID="grdVUsers" runat="server" AutoGenerateColumns="False" DataKeyNames="UserID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="UserID" HeaderText="UserID" InsertVisible="False" ReadOnly="True" SortExpression="UserID" />
                    <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                    <asp:BoundField DataField="UserPassword" HeaderText="UserPassword" SortExpression="UserPassword" />
                    <asp:BoundField DataField="SecurityLevel" HeaderText="SecurityLevel" SortExpression="SecurityLevel" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" DeleteCommand="DELETE FROM [tblUserLogin] WHERE [UserID] = ?" InsertCommand="INSERT INTO [tblUserLogin] ([UserID], [UserName], [UserPassword], [SecurityLevel]) VALUES (?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT * FROM [tblUserLogin]" UpdateCommand="UPDATE [tblUserLogin] SET [UserName] = ?, [UserPassword] = ?, [SecurityLevel] = ? WHERE [UserID] = ?">
                <DeleteParameters>
                    <asp:Parameter Name="UserID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="UserID" Type="Int32" />
                    <asp:Parameter Name="UserName" Type="String" />
                    <asp:Parameter Name="UserPassword" Type="String" />
                    <asp:Parameter Name="SecurityLevel" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="UserName" Type="String" />
                    <asp:Parameter Name="UserPassword" Type="String" />
                    <asp:Parameter Name="SecurityLevel" Type="String" />
                    <asp:Parameter Name="UserID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </asp:Panel>
    </form>
</body>
</html>
