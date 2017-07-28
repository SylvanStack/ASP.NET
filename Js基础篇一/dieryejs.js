/**
 * Created by Administrator on 2017/7/20.
 */
function changdiv() {
   var  div = document.getElementById("divid");
    div.style.backgroundColor= "aquamarine";
}
function changimg() {
    document.getElementById("image").src="image/11.jpg";
}
function onmouseove(obj) {
    obj.innerHTML="谢谢";
}
function onmouseou(obj) {
    obj.innerHTML="鼠标移过来";
}
function mDown(obj)
{
    obj.style.backgroundColor="#1ec5e5";
    obj.innerHTML="请释放鼠标按钮"
}

function mUp(obj)
{
    obj.style.backgroundColor="green";
    obj.innerHTML="请按下鼠标按钮"
}
function ofu(obj)
{
    obj.style.backgroundColor="aquamarine";
}




