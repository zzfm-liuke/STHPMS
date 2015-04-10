<%@ Page Title="路网管理" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="FrmDataBaseManager.aspx.cs" Inherits="ZZHMHN.Web.View.RoadManager.FrmDataBaseManager" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">    
    <script type="text/javascript" src='<%=ResolveUrl("~/Scripts/jquery.blockUI.js")%>'></script>
        <script type = "text/javascript">
            function BlockUI(elementID) {
                var prm = Sys.WebForms.PageRequestManager.getInstance();
                prm.add_beginRequest(function () {
                    var imgUrl='<%= ResolveUrl("~/images/loadingAnim.gif")%>';
                    $("#" + elementID).block({
                        message: '<table align = "center"><tr><td><img src= "'+imgUrl+'"/></td></tr></table>',
                        css: {},
                        overlayCSS: {
                            backgroundColor: '#000000', opacity: 0.6, border: '3px solid #63B2EB'
                        }
                    });
                });
                prm.add_endRequest(function () {
                    $("#" + elementID).unblock();
                });
            }
            $(document).ready(function () {

                BlockUI("dvGrid");
                $.blockUI.defaults.css = {};
            });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>--%>
    <div id = "dvGrid" style ="padding:10px;width:550px">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
       <asp:GridView ID="GridView1" runat="server"  Width = "550px"
        AutoGenerateColumns = "False" Font-Names = "Arial" 
        Font-Size = "11pt" AlternatingRowStyle-BackColor = "#C2D69B"  
        HeaderStyle-BackColor = "green"  ShowFooter = "True"  DataKeyNames="id"
        onrowediting="EditAction" onrowupdating="UpdateAction"  onrowcancelingedit="CancelEdit" >
       <Columns>
        <asp:TemplateField ItemStyle-Width = "30px"  HeaderText = "id"  Visible="False">
            <ItemTemplate>
                <asp:Label ID="lblId" runat="server" Text='<%# Eval("id")%>'></asp:Label>
            </ItemTemplate> 
            <EditItemTemplate>
                <asp:TextBox ID="txtId" Width = "40px" MaxLength = "100"  Text='<%# Eval("id")%>' runat="server"></asp:TextBox>
            </EditItemTemplate>  
            <FooterTemplate>
                <asp:TextBox ID="txtId" Width = "40px"  runat="server"></asp:TextBox>
            </FooterTemplate> 
            <ItemStyle Width="30px" />
        </asp:TemplateField> 
        <asp:TemplateField ItemStyle-Width = "100px"  HeaderText = "路网名称">
            <ItemTemplate>
                <asp:Label ID="lblName" runat="server"  Text='<%# Eval("name")%>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txtName" runat="server" MaxLength = "1000" Text='<%# Eval("name")%>'  ></asp:TextBox>
            </EditItemTemplate>  
            <FooterTemplate>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </FooterTemplate> 
            <ItemStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField ItemStyle-Width = "150px"  HeaderText = "路网描述" Visible="False">
            <ItemTemplate>
                <asp:Label ID="lblComment" runat="server" Text='<%# Eval("comment")%>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txtComment" runat="server" MaxLength = "100"  Text='<%# Eval("comment")%>'></asp:TextBox>
            </EditItemTemplate>  
            <FooterTemplate>
                <asp:TextBox ID="txtComment" runat="server"></asp:TextBox>
            </FooterTemplate> 
            <ItemStyle Width="150px" />
        </asp:TemplateField>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID="lnkOpen" runat="server" CommandArgument = '<%# Container.DataItemIndex %>' 
                Text = "打 开" OnClick = "OpenAction"></asp:LinkButton>
            </ItemTemplate>
             <FooterTemplate>
                <asp:Button ID="btnAdd" runat="server" Text="添加" OnClick = "AddNewAction" />
            </FooterTemplate> 
        </asp:TemplateField> 
        <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID="lnkRemove" runat="server" CommandArgument = '<%# Eval("id")%>' 
                 OnClientClick = "return confirm('你确定要删除?')"
                Text = "删 除" OnClick = "DeleteAction"></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField> 
        <asp:CommandField  ShowEditButton="True" CancelText="取 消" DeleteText="删 除" EditText="编 辑" InsertText="插 入" NewText="新 建" UpdateText="更 新" /> 

       </Columns> 
       <AlternatingRowStyle BackColor="#C2D69B"  />
       <HeaderStyle BackColor="Green" />
        <PagerTemplate>
        </PagerTemplate>
    </asp:GridView>             
            
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" OnPageChanging="AspNetPager1_PageChanging"  
            FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页"></webdiyer:AspNetPager>
        </ContentTemplate> 
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID = "GridView1" /> 
    </Triggers> 
    </asp:UpdatePanel> 
    </div>
</asp:Content>
