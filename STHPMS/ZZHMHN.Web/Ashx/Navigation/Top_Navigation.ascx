<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Top_Navigation.ascx.cs" Inherits="ZZHMHN.Web.Top_Navigation" %>
<style>
    .top_Navigation {
        width: 1000px;
        height: 30px;
        line-height: 30px;
        margin: 0 auto;
    }

        .top_Navigation li a {
            color: #fff;
            text-decoration: none;
            display: block;
            float: left;
            height: 30px;
            line-height: 30px;
            padding: 0px 15px;
            font-size: 12px;
            background: #636871;
           
        }

            .top_Navigation li a:hover {
                background: #4b505a;
            }

        .top_Navigation li {
            float: left;
            position: relative;
            height: 30px;
            line-height: 30px; 
            list-style-type:none;
        }

            .top_Navigation li .second {
                position: absolute;
                left: 0;
                display: none;
            }
</style>

<script>
    $(document).ready(function () {
        $.ajax({
            type: 'POST',
            url: 'common/Navigation/Handler_Navigation.ashx',
            dataType: 'JSON',
            success: function (msg) {
                var s = "<div class='top_Navigation'>"
                $.each(eval(msg), function (i, item) {
                    s += "<li><a href='"+ item.url +"'>"+ item.title +"</a>";
                    if (item.child.length) {
                        s += "<div class='second'>"
                        $.each(item.child, function (j, n) {
                            s += "<a href='" + n.url + "' target='_blank'>" + n.title + "</a>";
                        });
                        s += "</div>"
                    }
                    s += "</li>"
                });
                s += "</div>";
                $("#top").html(s);
                Animation();
            },
            error: function (errorMsg) {
                alert(errorMsg)
            }
        });
    })

    function Animation() {
        $('.top_Navigation li').hover(function () {
            $('.second', this).css('top', '30px').show();
        }, function () {
            $('.second', this).hide();
        });
    }
    </script>

    <div id="top"></div>
