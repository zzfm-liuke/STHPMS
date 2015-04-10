<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="ZZHMHN.Web.Test" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="Scripts/jquery-2.1.3.min.js"></script>
   
    <style type="text/css">
        #Container {
            width: 1024px;
            margin: 0 auto; /*设置整个容器在浏览器中水平居中*/
           
        }

        #Header {
            height: 100px;
            background: #093;
            
        }

        #Content {
            height: 600px;
            /*此处对容器设置了高度，一般不建议对容器设置高度，一般使用overflow:auto;属性设置容器根据内容自适应高度，如果不指定高度或不设置自适应高度，容器将默认为1个字符高度，容器下方的布局元素（footer）设置margin-top:属性将无效*/
            margin-top: 5px; /*此处讲解margin的用法，设置content与上面header元素之间的距离*/
        }

        #Content-Left {
            height: 100%;
            width: 200px;
            margin-right: 10px; /*设置元素跟其他元素的距离为20像素*/
            float: left; /*设置浮动，实现多列效果，div+Css布局中很重要的*/
            background: #90C;
        }

        #Content-Main {
            height: 100%;
            width: 814px;
            float: left; /*设置浮动，实现多列效果，div+Css布局中很重要的*/
            background: #90C;
        }
        /*注：Content-Left和Content-Main元素是Content元素的子元素，两个元素使用了float:left;设置成两列，这个两个元素的宽度和这个两个元素设置的padding、margin的和一定不能大于父层Content元素的宽度，否则设置列将失败*/
        #Footer {
            height: 80px;
            background: #90C;
            margin-top: 5px;
            clear: both;
            
        }

        .Clear {
        }
    </style>
    <script>

        $(document).ready(function () {
            $.ajax({
                type: 'POST',
                url: 'common/Navigation/Handler_Navigation.ashx',
                dataType: 'JSON',
                success: function (msg) {
                    var top = ""
                    var left = ""
                    //一级菜单
                    $.each(eval(msg), function (i, item) {
                        top += '<div style="border:1px solid red;cursor:pointer; margin-left:10px;text-align:center; height:30px; width:100px;  line-height:30px; float:left" onclick="change(this)">' + item.title + '</div>';
                        //二级菜单
                        if (item.child.length) {
                            left += "<div>"
                            $.each(item.child, function (j, n) {
                                left += "<div style='border: 1px solid red;cursor:pointer;text-align:center; margin-top: 5px; height: 30px; line-height: 30px;'><a href='" + n.url + "' target='_blank'>" + n.title + "</a></div>";
                            });
                            left += "</div>"
                        }
                    });
                    $("#top_Navigation").html(top);
                    $("#Content-Left").html(left);
                    Init();
                },
                error: function (errorMsg) {
                    alert(errorMsg)
                }
            });
        })

        //初始化只显示第一个菜单的项目
        function Init() {
            $("#Content-Left").children(":first").nextAll().css('display', 'none');
            $("#top_Navigation").children(":first").css('background', '#90C');
        }

        function change(obj)
        {
            $(obj).siblings().css('background', '#093');
            $(obj).css('background', '#90C');

            //显示子项，隐藏其他子项
            var index = $(obj).index();
            var child = $("#Content-Left").children().eq(index);
            child.css('display', 'block');
            child.siblings().css('display', 'none');
        }

    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div id="Container">
            <div id="Header">
                基于时空的路面科学养护系统
               
            </div>

            <div style="height: 30px;" id="top_Navigation">
                <!--选项卡-->

            </div>
            <div id="Content">
                <div id="Content-Left">
                    
                    <!--子选项卡-->
           
                </div>
                <div id="Content-Main">
                  
                </div>
            </div>

            <div id="Footer">Footer</div>
        </div>


    </form>
</body>
</html>
