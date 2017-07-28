/**
 * Created by Administrator on 2017/7/20.
 */

$(document).ready(function () {
        imgl();//调用图片处理方法
        var dataimg={"data":[{"src":"18.jpg"},{"src":"17.jpg"},{"src":"16.jpg"},{"src":"15.jpg"},{"src":"14.jpg"},{"src":"13.jpg"},{"src":"12.jpg"},
            {"src":"11.jpg"},{"src":"10.jpg"},{"src":"7.jpg"},{"src":"6.jpg"},{"src":"5.jpg"},{"src":"4.jpg"},{"src":"3.jpg"},{"src":"2.jpg"},{"src":"1.jpg"}]};
        window.onscroll=function () {
            //var scroHeight=document.documentElement.scrollTop||document.body.scrollTop;
            if (scroll1()) {
                $.each(dataimg.data,function (index,value) {
                    var box = $("<div>").addClass("imgbox").appendTo("#content");
                    var con = $("<div>").addClass("img").appendTo(box);
                    console.log("./image/"+$(value).attr("src"));
                    $("<img>").attr('src', 'image/' + $(value).attr("src")).appendTo(con);
                });
                imgl();
            }
        };


});
//鼠标滚动事件
function scroll1() {
    var box = $(".imgbox");
    var lastboxheight =box.last().get(0).offsetTop+Math.floor(box.last().height()/2);
    console.log("距低高"+lastboxheight);
    var documentheight =$(document).width();
   // var documentheight =$(document).height();
    console.log("页高"+documentheight);
    var scrollheight = document.documentElement.scrollTop||document.body.scrollTop;// $(window).scrollTop;
    console.log("滑动高"+scrollheight);
    return ( lastboxheight<=documentheight+scrollheight)?true:false;


}

//图片处理方法
function imgl() {
    var box = $(".imgbox");//获取class=imgbox的标签  获取储存图片外部的div 便于索引所有的图片
    var boxwidth=  box.eq(0).width();//得到box第一个图片的宽度
    var num = Math.floor($(window).width()/boxwidth);//页宽 一行可以有几张图片
    var boxArr=[]; //定义一个数组
    box.each(function (index,value) {   //遍历数组
        var boxh=box.eq(index).height(); //得到每个数组的高度
        if(index<num){
            boxArr[index]=boxh; //将第一行的值存入数组
        }
        else {
            var minboxh=Math.min.apply(null,boxArr);  //得到最小值
            var minboxindex=$.inArray(minboxh,boxArr);  //得到最小值的索引
            $(value).css({  //得到标签
               "position":"absolute",
                "top":minboxh,  //在第一行的最后一个排列
                "left":box.eq(minboxindex).position().left, //向左移动到最小值
            });
        }
        boxArr[minboxindex]+=box.eq(index).height();//将最小的长度加上新追加图片的长度
    });

}