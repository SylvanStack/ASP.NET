$(document).ready(function () {
    $(".imageRotation").each(function () {
        // 获取有关参数
        var imageRotation = this,  // 取得 图片轮换容器
            imageBox = $(imageRotation).children(".imageBox")[0],  // 取得 图片容器
            icoBox = $(imageRotation).children(".icoBox")[0],  // 取得 图标容器
            icoArr = $(icoBox).children(),  // 取得所有图标，并保存为数组
            imageWidth = $(imageRotation).width(),  // 图片宽度
            imageNum = $(imageBox).children().size(),  // 图片数量
            imageReelWidth = imageWidth * imageNum,  // 图片容器宽度
            activeID = parseInt($($(icoBox).children(".active")[0]).attr("rel")),  // 当前图片ID
            nextID = 0,  // 下张图片ID
            setIntervalID,  // setInterval() 函数ID
            intervalTime = 4000,  // 间隔时间
            speed = 500;  // 执行速度

        // 设置 图片容器 的宽度
        $(imageBox).css({ 'width': imageReelWidth + "px" });

        // 图片轮换函数
        var rotate = function (clickID) {
            if (clickID) { nextID = clickID; }
            else { nextID = activeID <= 3 ? activeID + 1 : 1; }

            $(icoArr[activeID - 1]).removeClass("active");
            $(icoArr[nextID - 1]).addClass("active");
            $(imageBox).animate({ left: "-" + (nextID - 1) * imageWidth + "px" }, speed);

            activeID = nextID;
        }
        setIntervalID = setInterval(rotate, intervalTime);

        $(imageBox).hover(
            function () { clearInterval(setIntervalID); },
            function () { setIntervalID = setInterval(rotate, intervalTime); }
        );

        $(icoArr).click(function () {
            clearInterval(setIntervalID);
            var clickID = parseInt($(this).attr("rel"));
            rotate(clickID);
            setIntervalID = setInterval(rotate, intervalTime);
        });
    });
});