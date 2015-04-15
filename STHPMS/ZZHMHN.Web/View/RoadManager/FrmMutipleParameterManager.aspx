<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="FrmMutipleParameterManager.aspx.cs" Inherits="ZZHMHN.Web.View.RoadManager.FrmMutipleParameterManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>添加指标</title>
    <link href="../../Css/default.css" rel="stylesheet" />
    <script>
        $(function () {
            //分页初始化
            //$('#btn_ZB').unbind().bind('click', function () {
            //    //打开新增的模式窗口
            //    var openUrl = "FrmUpdateParm.aspx?Road_ID=" + $("#hd_road_id").val();//弹出窗口的url
            //    var iWidth = 800; //弹出窗口的宽度;
            //    var iHeight = 600; //弹出窗口的高度;
            //    var iTop = (window.screen.availHeight - 30 - iHeight) / 2; //获得窗口的垂直位置;
            //    var iLeft = (window.screen.availWidth - 10 - iWidth) / 2; //获得窗口的水平位置;
            //    window.open(openUrl, "", "height=" + iHeight + ", width=" + iWidth + ", top=" + iTop + ", left=" + iLeft);

            //});

        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <input id="hd_road_id" type="hidden" value="<%=Road_ID %>" />
    <table cellspacing="0" cellpadding="0" style="margin: 0px auto; margin-top: 30px;">

        <tr>
            <td>道路名称</td>
            <td>

                 <asp:DropDownList ID="ddl_RoadName"  AutoPostBack="true"  CssClass="DropDownList" runat="server" OnSelectedIndexChanged="ddl_RoadName_SelectedIndexChanged"></asp:DropDownList>

            </td>
        </tr>
         <tr>
            <td colspan="2">
                <table border="0">
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="rdList" runat="server" OnSelectedIndexChanged="rdList_SelectedIndexChanged" AutoPostBack="True">
                                <asp:ListItem Selected="True">站</asp:ListItem>
                                <asp:ListItem>位置</asp:ListItem>
                            </asp:RadioButtonList>

                        </td>
                        <td>
 <asp:Label ID="lblBegin" runat="server" Text="开始站:"></asp:Label>
                            <asp:DropDownList ID="ddl_begin"  CssClass="DropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_begin_SelectedIndexChanged" ></asp:DropDownList>
                            <br />
                            <asp:Label ID="lblEnd" runat="server" Text="结束站:"></asp:Label>
                             <asp:DropDownList ID="ddl_end"  CssClass="DropDownList" runat="server"></asp:DropDownList>

                        </td>
                    </tr>

                   
                </table>

            </td>
            
        </tr>
         <tr>
            <td colspan="2">
                <asp:Button ID="btn_Layer" runat="server" Text="添加结构层" OnClick="btn_Layer_Click"  />
                 <asp:Button ID="btn_Mill" runat="server" Text="Mill_Surface" OnClick="Button1_Click"  />
                <asp:Button ID="btn_ZB" runat="server" Text="编辑指标" OnClick="btn_ZB_Click" />
            </td>
            
        </tr>
        
        </table>
</asp:Content>
