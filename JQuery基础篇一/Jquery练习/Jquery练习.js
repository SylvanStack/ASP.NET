/**
 * Created by Administrator on 2017/7/21.
 */
$(document).ready(function () {
   // alert("123");
    $("li").toggle(
        function () {
            alert("123");
            $(this).css({"list-style-type":"disc", "color":"blue"});
        },
        function () {
            $(this).css({"list-style-type":"disc", "color":"red"});
        },
        function () {
            $(this).css({"list-style-type":"", "color":""});
        }
    );
    $(".pc").click(function () {
        $(this).hide(1000);
    });
    $("#btnid").click(function () {
        $(".pc").toggle(1000);
    });
    $("#target").toggle(function() {
        alert('First handler for .toggle() called.');
    }, function() {
        alert('Second handler for .toggle() called.');
    });
    /*$(".pc").toggle(function () {
        alert("点击标签1");
    },function () {
        alert("点击标签2");
       });*/
    $("#btnid1").click(function () {
        $(".img").fadeToggle(2000);
    });
    $("#btnid2").click(function () {
        $(".img").fadeTo(1000,0.5);
    });
    $("#btnid3").click(function () {
        $(".img").slideToggle(3000);
    });

});