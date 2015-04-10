<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="ZZHMHN.Web.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <style type="text/css">
        .style1
        {
            width: 74px;
        }
        .style2
        {
            width: 79px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
   <div align="center">
        <table style="height: 85px; width: 657px;">
            <tr>
                <td>
                    <img alt="system error" src="Images/errorpage.jpg" />
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="lblMessage1" runat="server" Font-Names="微软雅黑" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="lblMessage2" runat="server" Font-Names="微软雅黑" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="lblMessage3" runat="server" Font-Names="微软雅黑" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
