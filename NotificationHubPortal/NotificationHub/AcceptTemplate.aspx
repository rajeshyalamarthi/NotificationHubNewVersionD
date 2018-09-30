<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AcceptTemplate.aspx.cs" Inherits="NotificationHub.AcceptTemplate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CONFIRMATION</title>
</head>
<body>
    <h2>Confirmation</h2>
    <form id="form1" runat="server">
        <div>
            <h4>Are you Sure You Want to Approve Template -<asp:Image ID="Image1" runat="server" /> ?</h4>
            <br />
            <br />
<div align="center">
 <asp:Button ID="Button1" runat="server" Text="Yes" Font-Size="Large" OnClick="Button1_Click" /> &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="Button2" runat="server" Text="No" Font-Size="Large" OnClick="Button2_Click" />
</div>

        </div>
    </form>
</body>
</html>
