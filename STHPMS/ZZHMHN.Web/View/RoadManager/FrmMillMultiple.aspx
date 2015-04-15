<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMillMultiple.aspx.cs" Inherits="ZZHMHN.Web.View.RoadManager.FrmMillMultiple" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../../Css/default.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div>
            <table cellspacing="0" cellpadding="0" style="margin: 0px auto; margin-top: 30px; width: 600px;">
                <tr>
                    <th colspan="2" style="height:20px">Milling Multiple Segments
                    </th>
                </tr>
               
                <tr align="center">
                    
                    <td>
                        路面拆除厚度:
                        <asp:TextBox ID="txtInRemoved"  runat="server"></asp:TextBox>
                        英寸(最小值:<asp:Label ID="lblMin" runat="server" Text=""></asp:Label>)
                    </td>
                </tr>

                <tr align="center">
                    <td >
                        <asp:Button ID="btn_OK" runat="server" Text="确定" CssClass="ButtonCSS" OnClick="btn_OK_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                    <input id="btn_Cancel" type="button" value="取消" class="ButtonCSS" onclick="return window.close();" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>
</body>
</html>
