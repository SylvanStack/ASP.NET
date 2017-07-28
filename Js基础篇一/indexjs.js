/**
 * Created by Administrator on 2017/7/19.
 */



//相乘
function  Add() {
      i = document.getElementById("oneid").value;
      j = document.getElementById("twoid").value;
    isnull(i,j);
    sw(xc);

}
function xunhuan() {
    var i=5;
    for(var k =1;k<=i;k++)
    {
        alert(k);
    }
}
function usre() {
    person=new Object();
    person.firstname="孙悟空";
    person.lastname="Gates";
    person.age=56;
    person.eyecolor="blue";
   document.getElementById("puser").innerHTML="运算符区:<br/>"+"测试人:"+person.firstname;
}
//判断是否为空
function isnull(i,j) {
    if(i=="")
    {
        var k= document.getElementById("result").innerHTML="输入第一个数";
        k.focus();
    }
    else if(j=="")
    {
        var k= document.getElementById("result").innerHTML="输入第二个数";
        k.focus();
    }
}
//判断
function sw(btnid) {

    switch (btnid)
    {
        case ljzfc:
           var p=i+j
            if (isString(p)) {

                document.getElementById("result").innerHTML = "输出结果：" + p;
            }
            break;
        case xj :
            var s = parseInt(i) + parseInt(j);
            if(isNumber(s)) {

                document.getElementById("result").innerHTML = "输出结果：" + s;
            }
            break;
        case xc:
            var c = parseInt(i) * parseInt(j);
            if (isNumber(c)) {

                document.getElementById("result").innerHTML = "输出结果：" + c;
            }
            break;
        case xjian:
            var c = parseInt(i) - parseInt(j);
            if (isNumber(c)) {

                document.getElementById("result").innerHTML = "输出结果：" + c;
            }
            break;
        case bj:
             //q =  parseInt(i) > parseInt(j) ? true : false;

            if(parseInt(i)>parseInt(j))
            {
                document.getElementById("result").innerHTML = "输出结果：" + "第一个数大";
            }
            else
            {
                document.getElementById("result").innerHTML = "输出结果：" + "第二个数大";
            }
            /*while (isNumber(c))
            {
                if (q==false)
                {
                    document.getElementById("result").innerHTML = "输出结果：" + "第二个数大";
                    break;
                }
                else
                {
                    document.getElementById("result").innerHTML = "输出结果：" + "第一个数大";
                    break;
                }
            }*/
            break;



    }
}

//是否为字符串
function isString(str){
    return (typeof str=='string')&&str.constructor==String;
}
//是否为整形
function isNumber(obj){
    return (typeof obj=='number')&&obj.constructor==Number;
}
//改变p标签
function ChangeP() {
    document.getElementById("demo").innerHTML="我的第一段 JavaScript";
}

//连接字符串
function  AddString() {
      i = document.getElementById("oneid").value;
     j = document.getElementById("twoid").value;
    isnull(i,j);
    sw(ljzfc);
}
//相加
function  Addint() {
     i = document.getElementById("oneid").value;
     j = document.getElementById("twoid").value;
    isnull(i,j);
    sw(xj);
    xunhuan();
}
function  xjian() {
    i = document.getElementById("oneid").value;
    j = document.getElementById("twoid").value;
    isnull(i,j);
    sw(xjian);
}
function bj() {
    i = document.getElementById("oneid").value;
    j = document.getElementById("twoid").value;
    isnull(i,j);
    sw(bj);
}
