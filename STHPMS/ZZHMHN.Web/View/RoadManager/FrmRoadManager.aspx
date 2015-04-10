<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="FrmRoadManager.aspx.cs" Inherits="ZZHMHN.Web.View.RoadManager.FrmRoadManager" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>道路列表</title>
    <link href="../../Css/default.css" rel="stylesheet" />
    <script>
        $(function () {
            //分页初始化
            $('#add').unbind().bind('click', function () {
                //打开新增的模式窗口
                var openUrl = "FrmEditRoad.aspx";//弹出窗口的url
                var iWidth = 800; //弹出窗口的宽度;
                var iHeight = 600; //弹出窗口的高度;
                var iTop = (window.screen.availHeight - 30 - iHeight) / 2; //获得窗口的垂直位置;
                var iLeft = (window.screen.availWidth - 10 - iWidth) / 2; //获得窗口的水平位置;
                window.open(openUrl, "", "height=" + iHeight + ", width=" + iWidth + ", top=" + iTop + ", left=" + iLeft);
             
            });

        });
    </script>
    <script type="text/javascript" src='<%=ResolveUrl("~/Scripts/jquery.blockUI.js")%>'></script>
    <script type="text/javascript">
        function BlockUI(elementID) {
            var prm = Sys.WebForms.PageRequestManager.getInstance();
            prm.add_beginRequest(function () {
                var imgUrl = '<%= ResolveUrl("~/images/loadingAnim.gif")%>';
                    $("#" + elementID).block({
                        message: '<table align = "center"><tr><td><img src= "' + imgUrl + '"/></td></tr></table>',
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
    <div id="dvGrid" style="padding: 10px; width: 550px">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
 <div><a id="add" href="#">新增</a></div>
                <asp:GridView ID="dgv_Man" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="dgv_Man_RowCancelingEdit"
                    OnRowEditing="dgv_Man_RowEditing" OnRowDataBound="dgv_Man_RowDataBound" DataKeyNames="RDWAYID"
                    OnRowCommand="dgv_Man_RowCommand" Width="600px">

                    <Columns>
                        <asp:TemplateField HeaderText="编号">
                            <EditItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("RDWAYID") %>'></asp:Label>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("RDWAYID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="道路名称">
                            <EditItemTemplate>
                                <asp:DropDownList ID="ddl_Road" runat="server">
                                </asp:DropDownList>
                                <asp:HiddenField ID="hd_Road" runat="server" Value='<%# Bind("ROAD_INFO") %>' />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lbl_Road" runat="server" Text='<%# Bind("ROAD_INFO") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="设施名称">
                            <EditItemTemplate>
                                <asp:DropDownList ID="ddl_FACILITY" runat="server">
                                </asp:DropDownList>
                                <asp:HiddenField ID="hd_FACILITY" runat="server" Value='<%# Bind("FACILITY_INFO") %>' />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lbl_FACILITY" runat="server" Text='<%# Bind("FACILITY_INFO") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="开始时间">
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_Time" runat="server" Text='<%# Bind("BEGINDATE") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lbl_Time" runat="server" Text='<%# Bind("BEGINDATE") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="主要方向">
                            <EditItemTemplate>
                                <asp:DropDownList ID="ddl_PRIMARYDIR" runat="server">
                                </asp:DropDownList>
                                <asp:HiddenField ID="hd_PRIMARYDIR" runat="server" Value='<%# Bind("PRIMARYDIR_INFO") %>' />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lbl_PRIMARYDIR" runat="server" Text='<%# Bind("PRIMARYDIR_INFO") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="次要方向">
                            <EditItemTemplate>
                                <asp:DropDownList ID="ddl_SECONDDIR" runat="server">
                                </asp:DropDownList>
                                <asp:HiddenField ID="hd_SECONDDIR" runat="server" Value='<%# Bind("SECONDDIR_INFO") %>' />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lbl_SECONDDIR" runat="server" Text='<%# Bind("SECONDDIR_INFO") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="描述">
                            <EditItemTemplate>
                                <asp:TextBox ID="txt_COMMENTS" runat="server" Text='<%# Bind("COMMENTS") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lbl_COMMENTS" runat="server" Text='<%# Bind("COMMENTS") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="操作">
                            <EditItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="xg" Text="更新"></asp:LinkButton>
                                &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消"></asp:LinkButton>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="编辑"></asp:LinkButton>
                                <asp:LinkButton ID="Button2" runat="server" OnClientClick="javascript:return confirm('您确定删除此行吗?');"
                                    Text="删除" CommandName="del" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <RowStyle HorizontalAlign="Center" />

                </asp:GridView>


                <webdiyer:AspNetPager ID="AspNetPager1" runat="server" OnPageChanging="AspNetPager1_PageChanging" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页"></webdiyer:AspNetPager>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="dgv_Man" />
            </Triggers>
        </asp:UpdatePanel>
    </div>

</asp:Content>
