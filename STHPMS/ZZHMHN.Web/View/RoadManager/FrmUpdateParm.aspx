<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmUpdateParm.aspx.cs" Inherits="ZZHMHN.Web.View.RoadManager.FrmUpdateParm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>更新参数</title>
    <link href="../../Css/default.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table cellspacing="0" cellpadding="0" style="margin: 0px auto; margin-top: 30px; width: 600px;">
                <tr>
                    <th colspan="2" style="height:20px">更新多路段参数
                    </th>
                </tr>
                <tr>
                    <td style="width:30%;" align="right">参数:
                        
                    </td>
                    <td>
                        <asp:DropDownList ID="ddl_Parm" CssClass="DropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_Parm_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right">值:
                        
                    </td>
                    <td>
                        <asp:DropDownList ID="ddl_Value" CssClass="DropDownList" runat="server"></asp:DropDownList>
                        <asp:TextBox ID="txtParamValue" Visible="false" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr align="center">
                    <td colspan="2">
                        <asp:Button ID="btn_OK" runat="server" Text="确定" CssClass="ButtonCSS" OnClick="btn_OK_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                    <input id="btn_Cancel" type="button" value="取消" class="ButtonCSS" onclick="return window.close();" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
