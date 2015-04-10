<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="FrmRoadList.aspx.cs" Inherits="ZZHMHN.Web.View.LoadManager.FrmRoadList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Css/pagination.css" rel="stylesheet" />
    <script src="../../Scripts/jquery.pagination.js"></script>
    <style type="text/css">
        .table-tr-title {
            height: 26px;
            font-size: 12px;
            text-align: center;
        }

        .table-tr-content {
            height: 18px;
            background: #FFFFFF;
            text-align: center;
            font-size: 12px;
        }

        .normalEvenTD {
            background: #DFD8D8;
        }

        .normalOddTD {
            background: #FFFFFF;
        }

        .hoverTD {
            background-color: #eafcd5;
            height: 18px;
            text-align: center;
            font-size: 12px;
        }

        .trSelected {
            background-color: #51b2f6;
            height: 18px;
            text-align: center;
            font-size: 12px;
        }
    </style>

    <script type="text/javascript">
        var pageIndex = 0;
        var pageSize = 10;
        var pageCount;

        $(function () {
            //分页初始化
            InitTable(<%=pageIndex%>);
            //初始化或跳转回来保存分页索引
            $("#curPage").val(<%=pageIndex%>)
        });

        //翻页调用  
        function PageCallback(index, jq) {
            //分页时候保存当前的index到hidden
            $("#curPage").val(index)

            InitTable(index);

        }

        //请求数据  
        function InitTable(pageIndex) {
            $.ajax({
                type: "POST",
                dataType: "text",
                url: 'ashx/RoadService.ashx',
                data: "pageIndex=" + (pageIndex + 1) + "&pageSize=" + pageSize,
                success: function (data) {
                    var r = eval('(' + data + ')');
                    //pageCount
                    pageCount = r.total;

                    $("#Result tr:gt(0)").remove();
                    $(r.rows).each(function (i, item) {
                        //alert(item.Title)

                        $("#Result").append("<tr class='table-tr-content' align='center'>"
        + "<td>" + item.ID + "</td>"
                                + "<td>" + item.Title + "</td>"
                                + "<td>" + item.Time + "</td>"
                            + "</tr>");
                    });

                    changColor();//颜色交替

                    //设置分页                   
                    $("#Pagination").pagination(pageCount, {
                        callback: PageCallback,
                        prev_text: '上一页',
                        next_text: '下一页',
                        items_per_page: pageSize,
                        num_display_entries: 6,//连续分页主体部分分页条目数  
                        current_page: pageIndex,//当前页索引  
                        num_edge_entries: 2//两侧首尾分页条目数  
                    });
                }
            });
        }

        //行的颜色交替
        function changColor() {
            //行交替色
            $("#Result").each(function () {
                var self = this;
                $("tr:even:not(:first)", $(self)).addClass("normalEvenTD"); // 从标头行下一行开始的奇数行，行数：（1，3，5...） 
                $("tr:odd", $(self)).addClass("normalOddTD"); // 从标头行下一行开始的偶数行，行数：（2，4，6...） 

                // 鼠标经过的行变色 
                $("tr:not(:first)", $(self)).hover(
                    function () { $(this).addClass('hoverTD'); $(this).removeClass('table-td-content'); },
                    function () { $(this).removeClass('hoverTD'); $(this).addClass('table-td-content'); }
                );

                // 选择行变色 
                $("tr", $(self)).click(function () {
                    var trThis = this;
                    $(self).find(".trSelected").removeClass('trSelected');
                    if ($(trThis).get(0) == $("tr:first", $(self)).get(0)) {
                        return;
                    }
                    $(trThis).addClass('trSelected');

                    //保存该行的数据
                });
            });
            //结束
        }
    </script>

    <script>
        //修改事件
        $(function () {
            //分页初始化
            $('#edit').unbind().bind('click', function () {
                //获取当前索引
                alert($("#curPage").val())
                //window.showModalDialog('EditRoadInfo.aspx', 'obj', 'dialogWidth=352px;dialogHeight=337px');
            });

        });
    </script>


</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a id="edit" href="#">修改</a>
    <input type="hidden" id="curPage" value="0" />
    <table id="Result" width="99%" class="list" style="word-break: break-all" border="0" align="center" cellpadding="0" cellspacing="1" bgcolor="#c0de98">
        <tr class="table-tr-title">
            <th style="width: 10%">ID  
            </th>
            <th style="width: 60%">标题  
            </th>
            <th style="width: 20%">更新时间  
            </th>
        </tr>
    </table>
    <div id="Pagination" class="meneame">
    </div>

</asp:Content>
