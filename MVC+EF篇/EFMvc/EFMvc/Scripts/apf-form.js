$.SaveForm = function (options) {
	var IsClose;
	if (window.name == "") {
		IsClose = false;
	} else {
		var index = top.layer.getFrameIndex(window.name); //先得到当前iframe层的索引
		var $IsdialogClose = top.$("#layui-layer" + index).find('.layui-layer-btn').find("#IsdialogClose");
		IsClose = $IsdialogClose.is(":checked");//默认关闭弹出的layer窗口
		if ($IsdialogClose.length == 0) {
			IsClose = true;
		}
	}
	var defaults = {
        loading: "正在保存…",//如果不显示，则传入布尔类型，不论true或false都不会显示，否则传入非布尔的任何值都将进行显示
        close: IsClose,//在aJax调用成功且返回结果类型为成功时，是否关闭调用页面
        success: null,
    };
    options = $.extend(defaults, options);
    var success = options.success;
    options.success = function (data) {
        if (success != null) success(data);//调用者传入了执行成功的回调事件
        if (!!options.loading) { //判断loading参数存在，且不为逻辑false，则关闭提示消息
            Loading(false);
        }
        if (options.close) {//aJax调用成功且返回结果的也是成功类型时，根据调用者传入的close参数决定是否关闭当前页面
            dialogClose();
        }
    };
    $.AjaxRun(options);
};
$.AjaxRun = function (options) {
    var defaults = {
        loading: "正在执行操作…",
        url: "",
        param: {},
        type: "post",
        contentType: "application/x-www-form-urlencoded; charset=UTF-8",
        dataType: "json",
        successMessage: true,//执行成功后，是否执行统一成功提示
        async: true,
        success: null,
        failed: null,
        error: null,
    };
    var options = $.extend(defaults, options);
    if (!!options.loading) {	//判断loading参数存在，且不为逻辑false
        if (typeof options.loading === "string") { //调用者传入的loading参数是字符串则将制定的提示信息显示出来
            Loading(true, options.loading);
        } else {
            Loading(true);
        }
    }
    //window.setTimeout(function () {
    var postdata = options.param;
    if ($('[name=__RequestVerificationToken]').length > 0) {
        postdata["__RequestVerificationToken"] = $('[name=__RequestVerificationToken]').val();
    }
    var ajaxOptions = $.CopyObject(options, ["loading", "param", "successMessage"], {
        data: options.param,
        success: function (retData) {
            var data = {
                type: null,
                successMessage: null,
            };
            data = $.extend(data, retData);
            if (data.type != null && parseInt(data.type) != 1) {//返回值中包含值类型，且为非正确类型
                if (options.failed != null) {
                	options.failed(data);
                } else {
                	dialogAlert(data.message, data.type);
                }
            } else {//不包含返回值类型，或返回值类型不是正确类型
                if (options.success != null) {
                    options.success(retData);
                }
                if (data.type != null && options.successMessage) {//返回值类型为正确类型且调用者允许显示成功消息
                    dialogMsg(data.message, 1);
                }
            }
            if (!!options.loading) { //判断loading参数存在，且不为逻辑false
                Loading(false);
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            if (!!options.loading) { //判断loading参数存在，且不为逻辑false
                Loading(false);
            }
            if (options.error != null) {
                options.error(XMLHttpRequest, textStatus, errorThrown);
            } else {
            	dialogAlert("操作失败", -1);
            }
        },
        complete: function () {
            if (!!options.loading) { //判断loading参数存在，且不为逻辑false
                Loading(false);
            }
        }
    });

    if (options.contentType != null) {
        options = $.extend(options, {
            contentType: options.contentType,
        });
    }
    $.ajax(ajaxOptions);
    //}, 500);
};
$.SetForm = function (options) {
    var defaults = {
        loading: "正在拼了命为您加载…",
        type: "get",
    };
    var options = $.extend(defaults, options);
    $.AjaxRun(options);
};
$.ConfirmAjax = function (options) {
    var defaults = {
        msg: "您确认要执行此操作吗？",
        loading: "正在执行操作…",
    };
    var options = $.extend(defaults, options);
    dialogConfirm(options.msg, function (r) {
        if (r) {
            $.AjaxRun(options);
        }
    });
};
$.RemoveForm = function (options) {
    var defaults = {
        msg: "您确定要删除吗？该操作将无法恢复！",
        loading: "正在删除数据…",
    };
    var options = $.extend(defaults, options);
    $.ConfirmAjax(options);
};
$.ExistField = function (controlId, url, param) {
    var $control = $("#" + controlId);
    if (!$control.val()) {
        return false;
    }
    var data = {
        keyValue: request('keyValue')
    };

    if (keyValue != "") {
        return false;
    }
    data[controlId] = $control.val();
    var options = $.extend(data, param);
    $.ajax({
        url: url,
        data: options,
        type: "get",
        dataType: "text",
        async: false,
        success: function (data) {
            if (data.toLocaleLowerCase() == 'false') {
                ValidationMessage($control, '已存在,请重新输入');
                $control.attr('fieldexist', 'yes');
            } else {
                $control.attr('fieldexist', 'no');
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            dialogMsg(errorThrown, -1);
        }
    });
};
$.fn.AjaxUpload = function (options) {
    var defaults = {
        timeout: 30000,
        url: "",
        param: {},
        success: null,
        error: null,
        failed: null,
        successMessage: true,
        uploadProgress: true,
    };
    options = $.extend(defaults, options);

    if (typeof options.uploadProgress === "boolean" && options.uploadProgress) {
        Loading(true, "正在上传...");
    }

    var pic = $(this).get(0).files[0];
    var formData = new FormData();
    var key = this.attr("name");
    if (key == null) {
        key = this.attr("id");
    }
    if (key == null) {
        key = "file";
    }
    formData.append(key, pic);

    param = options.param;
    if (typeof param == "string") {
        var items = param.split('&');
        for (var i in items) {
            var value = items[i].split('=');
            formData.append(value[0], unescape(value[1]));
        }
    } else {
        for (var key in param) {
            formData.append(key, param[key]);
        }
    }
    var uploadProgress = function (event) {
        var position = event.loaded;
        var total = event.total;
        var percentComplete = Math.floor(100 * position / total);
        if (typeof options.uploadProgress === "boolean" && options.uploadProgress) {
            Loading(true, "<div style='border: 1px solid #ccc; width: 300px; height: 25px; display: inline-block; position: relative;'><div style='position: absolute; left: 0; top: 0; width: 100%; height: 100%; text-align: center; line-height: 23px;'>" + percentComplete + "%</div><div style='position: absolute; left: 0; top: 0; width: " + percentComplete + "%; height: 100%; background: blue; overflow: hidden;'><div style='width: 300px; text-align: center; color: white; line-height: 23px;'>" + percentComplete + "%</div></div></div>");
        } else {
            options.uploadProgress(event, position, total, percentComplete);
        }
    };
    $.ajax({
        url: options.url,
        timeout: options.timeout,
        dataType: 'json',
        data: formData,
        contentType: false,
        processData: false,
        type: 'post',
        async: true,
        cache: false,
        xhr: function () {
            var xhr = $.ajaxSettings.xhr();
            xhr.upload.addEventListener("progress", uploadProgress, false);
            return xhr;
        },
        success: function (retData) {
            var data = {
                type: null,
                successMessage: null,
            };
            data = $.extend(data, retData);
            if (data.type != null && data.type != "1") {
                dialogAlert(data.message, data.type);
                if (options.failed != null) options.failed(data);
            } else {
                if (options.success != null) {
                    options.success(data);
                }
                if (data.type != null && options.successMessage != null) {
                    dialogMsg(data.message, 1);
                }
            }
            Loading(false);
        },
        error: function (XmlHttpRequest, textStatus, errorThrown) {
            Loading(false);
            dialogMsg(errorThrown, -1);
            if (options.error != null) {
                options.error(XMLHttpRequest, textStatus, errorThrown);
            }
        }
    });
}