/**
 * Created by Administrator on 2017/7/20.
 */
//alert(" JavaScript 时钟");
pX=400;pY=200
obs = new Array(13);
function ob () {
    for (i = 0; i < 13; i++) {
        if (document.all){
            obs[i] = new Array(eval('ob' + i).style, -100, -100) ;                //document.all是页面内所有元素的一个集合。例如：document.all(0)表示页面内第一个元素
        }
         else {
            obs[i] = new Array(eval('document.ob' + i), -100, -100);           // eval 函数：计算表达式的结果。
        }
    }
}
function cl(a,b,c){
    if (document.all) {
        if (a!=0) b+=-1
        eval('c'+a+'.style.pixelTop='+(pY+(c)))
        eval('c'+a+'.style.pixelLeft='+(pX+(b)))
    }
    else{
        if (a!=0) b+=10
        eval('document.c'+a+'.top='+(pY+(c)))
        eval('document.c'+a+'.left='+(pX+(b)))
    }
    if (document.all) c0.style.pixelLeft=26
}
function runClock() {
    for (i=0; i<13; i++) {
        obs[i][0].left=obs[i][1]+pX
        obs[i][0].top=obs[i][2]+pY
    }
}
var lastsec
function timer() {
    time = new Date ()
    sec = time.getSeconds()
    if (sec!=lastsec) {
        lastsec = sec
        sec=Math.PI*sec/30
        min=Math.PI*time.getMinutes()/30
        hr =Math.PI*((time.getHours()*60)+time.getMinutes())/360
        for (i=1;i<6;i++) {
            obs[i][1] = Math.sin(sec) * (44 - (i-1)*11)-16;
            if (document.layers)obs[i][1]+=10;
            obs[i][2] = -Math.cos(sec) * (44 - (i-1)*11)-27;
        }
        for (i=6;i<10;i++) {
            obs[i][1] = Math.sin(min) * (40 - (i-6)*10)-16;
            if (document.layers)obs[i][1]+=10;
            obs[i][2] = -Math.cos(min) * (40 - (i-6)*10)-27;
        }
        for (i=10;i<13;i++) {
            obs[i][1] = Math.sin(hr) * (37 - (i-10)*11)-16;
            if (document.layers)obs[i][1]+=10;
            obs[i][2] = -Math.cos(hr) * (37 - (i-10)*11)-27;
        } } }
function setNum(){
    cl (0,-67,-65);
    cl (1,10,-51);
    cl (2,28,-33);
    cl (3,35,-8);
    cl (4,28,17);
    cl (5,10,35);
    cl (6,-15,42);
    cl (7,-40,35);
    cl (8,-58,17);
    cl (9,-65,-8);
    cl (10,-58,-33);
    cl (11,-40,-51);
    cl (12,-16,-56);
}