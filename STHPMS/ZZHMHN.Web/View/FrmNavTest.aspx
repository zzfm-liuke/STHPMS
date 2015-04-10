<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="FrmNavTest.aspx.cs" Inherits="ZZHMHN.Web.View.FrmNavTest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="add" />
    <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="update" />
    <asp:Button ID="btnDel" runat="server" OnClick="btnDel_Click" Text="del" />
    <asp:Button ID="btnGet" runat="server" OnClick="btnGet_Click" Text="get" />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>
