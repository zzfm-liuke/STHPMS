<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ZZHMHN.Web.WebForm1" %>

<%@ Register Src="~/Common/Navigation/Top_Navigation.ascx" TagPrefix="uc1" TagName="Top_Navigation" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="Scripts/jquery-2.1.3.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <uc1:Top_Navigation runat="server" ID="Top_Navigation" />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

        <br />
        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
    </form>
</body>
</html>
