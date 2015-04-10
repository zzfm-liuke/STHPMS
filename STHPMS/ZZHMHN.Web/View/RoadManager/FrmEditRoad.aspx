<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmEditRoad.aspx.cs" Inherits="ZZHMHN.Web.View.RoadManager.FrmEditRoad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>编辑道路</title>
    <link href="../../Css/default.css" rel="stylesheet" />
</head>


<body>
    <form id="form1" runat="server">
        <div>
            <table cellspacing="0" cellpadding="0" style="margin: 0px auto; margin-top: 30px; width:600px;">
                <tr>
                    <td rowspan="2">设施<br />
                        <asp:ListBox ID="lst_Facility" runat="server" Height="100px" Width="100px"></asp:ListBox>
                    </td>
                    <td>开始时间<br />
                        <asp:TextBox ID="txt_BeginTime" runat="server" class="EditBox"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>主要方向<br />
                        <asp:DropDownList ID="ddl_PriDir" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>道路名称<br />
                        <asp:DropDownList ID="ddl_RoadName"  CssClass="DropDownList" runat="server"></asp:DropDownList>
                    </td>
                    <td>次要方向<br />
                        <asp:DropDownList ID="ddl_SecDir" CssClass="DropDownList" runat="server"></asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td colspan="2">描述<br />
                        <asp:TextBox ID="txt_Comment" runat="server" CssClass="MultiEditBox" TextMode="MultiLine"></asp:TextBox>
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


            <!---->

        </div>
    </form>
</body>
</html>
