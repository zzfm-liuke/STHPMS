<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmAddLayer.aspx.cs" Inherits="ZZHMHN.Web.View.RoadManager.FrmAddLayer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../Css/default.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table cellspacing="0" cellpadding="0" style="margin: 0px auto; margin-top: 30px; width: 600px;">
                <tr>
                    <th colspan="2" style="height: 20px">添加结构层组合
                    </th>
                </tr>
                <tr>
                    <td style="width: 30%;" align="right">结构层类型:
                        
                    </td>
                    <td>
                        <asp:DropDownList  ID="cmbType" CssClass="DropDownList" runat="server" AutoPostBack="True"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td style="width: 30%;" align="right">材料类型:
                        
                    </td>
                    <td>
                        <asp:DropDownList ID="cmbMatl" CssClass="DropDownList" runat="server" AutoPostBack="True" ></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right">结构层厚度:
                        
                    </td>
                    <td>
                        <asp:TextBox ID="txtThickness" CssClass="EditBox" Text="2" runat="server"></asp:TextBox>英寸
                    </td>
                </tr>
                <tr>
                    <td style="width: 30%;" align="right">强度类型:
                        
                    </td>
                    <td>
                        <asp:DropDownList ID="cmbStrength" CssClass="DropDownList" runat="server" AutoPostBack="True" ></asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td align="right">强度值:
                        
                    </td>
                    <td>
                        <asp:TextBox ID="txtStrength" runat="server" CssClass="EditBox"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">强度年限:
                        
                    </td>
                    <td>
                        <asp:TextBox ID="txtStrYear" runat="server" CssClass="EditBox"></asp:TextBox>年
                    </td>
                </tr>
                <tr>
                    <td style="width: 30%;" align="right">添加类型:
                        
                    </td>
                    <td>
                        <asp:DropDownList ID="cmbAsphalt" CssClass="DropDownList" runat="server" AutoPostBack="True" ></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right">排水系数:
                        
                    </td>
                    <td>
                        <asp:TextBox ID="txtDrainage" runat="server" CssClass="EditBox"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">施工年限:
                        
                    </td>
                    <td>
                        <asp:TextBox ID="txtConstYear" runat="server" CssClass="EditBox"></asp:TextBox>年
                    </td>
                </tr>
                <tr>
                    <td align="right">说明:
                        
                    </td>
                    <td>
                        <asp:TextBox ID="txtComments" TextMode="MultiLine" runat="server" CssClass="MultiEditBox"></asp:TextBox>
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
