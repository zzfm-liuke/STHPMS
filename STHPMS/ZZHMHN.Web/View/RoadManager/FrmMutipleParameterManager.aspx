<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="FrmMutipleParameterManager.aspx.cs" Inherits="ZZHMHN.Web.View.RoadManager.FrmMutipleParameterManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>添加指标</title>
    <link href="../../Css/default.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
                            <asp:DropDownList ID="ddl_begin"  CssClass="DropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_begin_SelectedIndexChanged"></asp:DropDownList>
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
                <input id="btn_Layer" type="button" value="添加结构层" />
                <input id="btn_Mill_Surface" type="button" value="Mill_Surface" />
                <input id="btn_ZB" type="button" value="编辑指标" />
            </td>
            
        </tr>
        
        </table>
</asp:Content>
