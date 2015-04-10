<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Left_Navigation.ascx.cs" Inherits="ZZHMHN.Web.Left_Navigation" %>
 <style>
        body {
            font-family: 'Verdana','宋体';
            font-size: 16px;
        }

        dl {
            width: 300px;
        }

        dl, dd {
            margin: 0;
        }

        dt {
            background: #F39;
            font-size: 18px;
            padding: 5px;
            margin: 2px;
        }

            dt a {
                color: #FFF;
            }

        dd a {
            color: #000;
        }

        ul {
            list-style: none;
            padding: 5px;
        }
    </style>
    <script>
        $(document).ready(function () {
            $.ajax({
                type: 'POST',
                url: 'common/Navigation/Handler_Navigation.ashx',
                dataType: 'JSON',
                success: function (msg) {
                    var s = "<dl>"
                    $.each(eval(msg), function (i, item) {
                        s += "<dt><a href='" + item.url + "'>" + item.title + "</a></dt>";
                        if (item.child.length) {
                            s += "<dd><ul>"
                            $.each(item.child, function (j, n) {
                                s += "<li><a href='" + n.url + "' target='_blank'>" + n.title + "</a></li>";
                            });
                            s += "</ul></dd>"
                        }
                    });
                    s += "</dl>";
                    $("#left_Navigation").html(s);

                    Animation();
                },
                error: function (errorMsg) {
                    //alert(errorMsg)
                }
            });
        })

        function Animation() {
            $("dd:not(:first)").hide();
            $("dt a").click(function () {
                $("dd:visible").slideUp("slow");
                $(this).parent().next().slideDown("slow");
                return false;
            });
        }
    </script>
<div id="left_Navigation"></div>