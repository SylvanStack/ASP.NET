$(function () {
	$(".ui-filter-text").click(function () {
		if ($(this).next('.ui-filter-list').is(":hidden")) {
			$(this).css('border-bottom-color', '#fff');
			$(".ui-filter-list").slideDown(10);
			$(this).addClass("active")
		} else {
			$(this).css('border-bottom-color', '#ccc');
			$(".ui-filter-list").slideUp(10);
			$(this).removeClass("active")
		}
	});
	$(".profile-nav li").click(function () {
		$(".profile-nav li").removeClass("active");
		$(".profile-nav li").removeClass("hover");
		$(this).addClass("active")
	}).hover(function () {
		if (!$(this).hasClass("active")) {
			$(this).addClass("hover")
		}
	}, function () {
		$(this).removeClass("hover")
	})
	Loading(false);
});
whiteCover = function (bool) {
	if (bool) {
		var cover = document.getElementById("whiteCover");
		if (!cover) {
			cover = document.createElement("div");
			cover.id = "whiteCover";
			cover.style.position = "absolute";
			cover.style.top = 0;
			cover.style.left = 0;
			cover.style.bottom = 0;
			cover.style.right = 0;
			cover.style.background = "white";
			document.body.appendChild(cover);
		}
		cover.style.display = "block";
		cover.style.opacity = 1;
	} else {
		$("#whiteCover").fadeOut("normal", function () {
			$("#whiteCover").remove();
		});
	}
}
Loading = function (bool, text, istableloading) {
	var ajaxbg = top.$("#loading_background,#loading_manage");
	if (istableloading != undefined && istableloading != null) {
		if (istableloading) {
			top.$("#loading_manage").addClass('istableloading');
		} else {
			top.$("#loading_manage").removeClass('istableloading');
		}
	}
	if (bool) {
		ajaxbg.show();
	} else {
		if (!top.$("#loading_manage").hasClass('istableloading')) {
			ajaxbg.hide();
			top.$(".ajax-loader").remove();
		}
	}
	if (!!text) {
		top.$("#loading_manage").html(text);
	} else {
		top.$("#loading_manage").html("正在拼了命为您加载…");
	}
	top.$("#loading_manage").css("margin-left", 0 - top.$("#loading_manage").outerWidth() / 2);
	top.$("#loading_manage").css("margin-top", 0 - top.$("#loading_manage").outerHeight() / 2);
};
tabiframeId = function () {
	var tabs_container = top.$(".active.J_menuTab");
	return tabs_container.attr("id");
};
$.fn.ComboBox = function (options, defferedFlag) {
	//options参数：description,height,width,allowSearch,url,param,data
	var defaults = {
		id: 'id',						// 指定 id 字段
		text: 'text',					// 指定 text 字段
		multiSelect: false,			// 是否为多选
		description: "==请选择==",	// 提示文字
		height: "200px",				// 下拉框弹出层最大高度
		width: false,					// 弹出层宽度，不指定弹出层宽度(undefined/null/false)时，弹出层宽度默认与框体相同宽度，指定后则按指定宽度显示
		popToTopWindow: true,		// 是否弹出至顶层窗口，弹出至顶层窗口可以解决当前iframe过小的问题
		valueSeparator: ',',			// 值分隔字符（仅用于多选）
		isTree: false,					// 是否模拟树结构，目前版本还在测试中，不建议立即采用
		selectable: false,			// 指定标识当前节点时否可选择字段，当指定为false或不指定（取默认值false）时则表示任何节点都可（仅用于树结构）
		includeParentText: true,	// 是否包含父级文字（仅用于树结构）
		textSeparator: ' ',			// 父级文字与子级文字分隔符（仅用于树结构）
		parentTextMaxLevel: 1,		// 父级文字最大向上查找多少级（指定一个小于或等于0的值代表无限制）
	};
	options = $.extend(defaults, options);
	var $select = this;
	var id = $select.attr('id');
	$select.attr("type", "select");
	$select.attr("data-multiSelect", options.multiSelect);
	if (options.multiSelect) {
		$select.addClass("multiSelect");
	}
	if (id == undefined || id == "") {
		return false;
	}
	var $text, $option, $optContent;
	if (!!options) {
		if ($select.find('.ui-select-text').length == 0) {
			var thisHTML = $select.html().trim();
			$select.empty();
			$text = $('<div class="ui-select-text"></div>');
			$select.append($text);
		} else {
			$text = $select.find('.ui-select-text');
		}
		$("#" + id + "-option").remove();
		$option = $('<div id="' + id + '-option" class="ui-select-option"></div>');
		$optContent = $('<div class="ui-select-option-content" style="overflow:auto;"></div>');
		$optContent.css({ maxHeight: options.height });
		$optContent.html("");
		if (!!thisHTML && thisHTML.length > 0) {
			var $thisHTML = $(thisHTML);
			var li = $thisHTML.find("li");
			if (options.data == undefined) {
				options.data = [];
			}
			for (var i = 0; i < li.length; i++) {
				var item;
				eval('item = { "' + options.id + '" : li.eq(i).attr("data-value"), "' + options.text + '": li.eq(i).html() };');
				options.data.push(item);
			}
		}

		$option.append($optContent);
		if (options.allowSearch) {
			$option.append("<div class=\"ui-select-option-search\"><input type=\"text\" class=\"form-control\" placeholder=\"搜索关键字\" /><span class=\"input-query\" title=\"Search\"><i class=\"fa fa-search\"></i></span></div>");
		}
		$text.html('<div class="text-item description">' + options.description + '</div>');
		if (options.multiSelect) {
			$option.addClass("multiSelect");
		}
		$option.prependTo(document.body);

		function join(arrayObj, property, separator) {
			if (!separator) separator = options.valueSeparator;
			var array = [];
			for (var i = 0; i < arrayObj.length; i++) {
				array.push(arrayObj[i][property]);
			}
			return array.join(separator);
		}

		$option.off("click").on("click", ".ui-select-option-content [data-selectable='true']", function (e) {
			var $this = $(this);
			var values = $select.data("data") || [];
			if ($this.hasClass("description")) {
				$this.find(".active").removeClass("active");
				values = [];
			} else {
				var item = {
					text: $this.text(),
					value: $this.attr("data-value"),
					html: $this.html(),
				};
				if (options.isTree && options.includeParentText) {
					var $parent = $this.parent().parent();
					var level = 0;
					while ($parent.is(".ui-treeview-subnodes") && (options.parentTextMaxLevel <= 0 || level++ < options.parentTextMaxLevel)) {
						var $obj = $parent.parent().children("div");
						item.text = $obj.text() + options.textSeparator + item.text;
						$parent = $parent.parent().parent();
					}
					item.html = item.text;
				}
				var model = values.filter(function (obj) { return obj.value == item.value });
				var index = -1;
				if (model.length > 0) {
					var index = values.indexOf(model[0]);
				}
				if ($this.hasClass("active") && options.multiSelect) {
					$this.removeClass("active");
					if (index >= 0) {
						values.splice(index, 1);
					}
				} else {
					if (!options.multiSelect) {
						$option.find(".active").removeClass("active");
						values = [];
					}
					$this.addClass("active");
					if (index < 0) {
						values.push(item);
					}
				}
			}
			$text.find(".text-item.text").remove();
			$select.removeAttr("data-value").removeAttr("data-text");
			if (values.length > 0) {
				$select.attr("data-value", join(values, "value"));
				$select.attr("data-text", join(values, "text"));
				$text.append('<div class="text-item text">' + join(values, 'html') + '</div>');
			}
			$select.data("data", values);
			$select.trigger("change");
			if (!options.multiSelect) {
				$option.slideUp(150, function () { $option.prependTo(document.body); });
			}
			e.stopPropagation();
		});

		if (!!options.url) {
			$.SetForm({
				url: options.url,
				param: options.param,
				type: "get",
				dataType: "json",
				successMessage: false,
				success: function (data) {
					options.data = data;
					loadComboBoxView(data);
					if (data.length > 0) {
						if ($select.attr("data-text") != undefined) {	//如果指定了初值，则选中初值
							$select.ComboBoxSetIndexByText($select.attr("data-text"));
						} else if ($select.attr("data-value") != undefined) {	//如果指定了初值，则选中初值
							$select.ComboBoxSetValue($select.attr("data-value"));
						}
					}
					if (defferedFlag != null) {
						defferedFlag.resolve();
					}
				},
				error: function (req, status, err) {
					if (defferedFlag != null) {
						defferedFlag.reject();
					}
				}
			})
		} else if (options.data != undefined) {
			loadComboBoxView(options.data);
		}
	}

	function loadTreeView(data, level) {
		function create_node(row) {
			var $node = $('<li class="ui-treeview-node"></li>');
			var $div = $('<div></div>');
			$div.attr("data-value", row[options.id]);
			$node.append($div);
			var $text = $('<span class="ui-treeview-node-text">' + row[options.text] + '</span>');
			$div.append($text);
			if (row[options.image]) {
				$text.prepend('<i class="' + row[options.image] + '"></i>')
			} else {
				$text.prepend('<i class="ui-treeview-node-icon"></i>')
			}
			if (options.multiSelect && row[options.selectable]) {
				$text.prepend('<i class="selecticon"></i>');
			}
			$div.attr('data-selectable', options.selectable ? row[options.selectable] : true);
			var title = row[options.title];
			if (title == undefined) {
				title = row[options.text];
				if (title == undefined) {
					title = "";
				}
			}
			$node.attr("title", title);
			var $el;
			if (data[i].ChildNodes != undefined && data[i].ChildNodes.length > 0) {
				if (data[i].isexpand) {
					$node.addClass("ui-treeview-node-expanded");
				}
				$el = $('<span class="ui-treeview-node-el"></span>');
				$el.on("click", function (e) {
					$node.toggleClass('ui-treeview-node-expanded');
					e.stopPropagation();
				});
				$div.on("dbclick", function (e) {
					$el.trigger("click");
					e.stopPropagation();
				});
				if (!row[options.selectable]) {
					$div.on("click", function (e) {
						e.stopPropagation();
					});
				}
				$node.append(loadTreeView(data[i].ChildNodes, level + 1));
			} else {
				$el = $('<span class="ui-treeview-node-el" style="visibility: hidden;"></span>');
				$node.addClass("ui-treeview-node-leaf");
			}
			$div.prepend($el);
			for (var l = 0; l < level; l++) {
				$div.prepend('<span class="ui-treeview-node-indent"></span>');
			}
			return $node;
		}
		if (!level) level = 0;
		var container = $("<ul></ul>");
		for (var i = 0; i < data.length; i++) {
			container.append(create_node(data[i]));
		}
		container.addClass((level == 0 ? "ui-treeview" : "ui-treeview-subnodes"));
		return container;
	}

	function loadComboBoxView(data, search, m) {
		if (data.length > 0) {
			$("ul", $optContent).remove();
			var ul = $('<ul></ul>');
			var li = $('<li class="ui-select-option-item description"' + (options.multiSelect ? ' style="display: none;"' : '') + ' data-selectable="true">' + (options.multiSelect ? '<i class="fa selecticon"></i>' : '') + options.description + '</li>');
			ul.append(li);
			if (options.isTree) {
				var li = $("<li></li>");
				li.append(loadTreeView(data));
				ul.append(li);
			} else {
				for (var i = 0; i < data.length; i++) {
					var row = data[i];
					if (search == undefined || search.length == 0 || row[m.text].indexOf(search) > -1) {
						var li = $('<li class="ui-select-option-item"' + (row[options.id] ? ' data-value="' + row[options.id] + '"' : '') + ' data-selectable="true">' + (options.multiSelect ? '<i class="fa selecticon"></i>' : '') + row[options.text] + '</li>');
						var title = row[options.title];
						if (title == undefined) {
							title = row[options.text];
							if (title == undefined) {
								title = "";
							}
						}
						li.attr("title", title);
						ul.append(li);
					}
				}
			}
			$optContent.append(ul);
		}
	}
	if (options.allowSearch) {
		$option.find('.ui-select-option-search').find('input').on("keypress", function (e) {
			if (e.keyCode == "13") {
				var value = $(this).val();
				loadComboBoxView($(this)[0].options.data, value, $(this)[0].options);
			}
		}).focus(function () {
			$(this).select();
		})[0]["options"] = options;
	}
	$select.off("click").on("click", function (e) {
		if ($select.attr("readonly") == "readonly" || $select.attr("disabled") == "disabled") {
			return false;
		}
		if ($option.is(":hidden")) {
			$(document).trigger("click");
			var x = $select.offset().left;
			var y = $select.offset().top + $select.outerHeight() - 1;
			if (options.popToTopWindow) {
				var win = window;
				while (win != undefined && win != top) {
					x += win.parent.$("iframe[id='" + win.name + "'],iframe[name='" + win.name + "']").offset().left;
					y += win.parent.$("iframe[id='" + win.name + "'],iframe[name='" + win.name + "']").offset().top;
					win = win.parent;
				};
				if (window != top) {
					var win = window;
					while (win.parent != top) {
						win = win.parent;
					}
					var thisIframe = top.$("#" + win.name + ",[name='" + win.name + "']");
					var zIndex = 1;
					while (thisIframe[0] != top.document.body) {
						var z = thisIframe.css("z-index");
						if (thisIframe.css("z-index") != undefined && thisIframe.css("z-index") != "auto") {
							zIndex = parseInt(thisIframe.css("z-index"));
							break;
						}
						thisIframe = thisIframe.parent();
					}
					$option.css({ zIndex: zIndex });
				} else {
					$option.css({ zIndex: 99 });
				}
				$option.appendTo(top.document.body).focus();
			} else {
				$option.css({ zIndex: 99 });
			}
			var width = $select.outerWidth();
			if (options.width) {
				width = options.width;
			}
			$option.find("li").removeClass("active");
			var selected_data = $select.attr("data-value");
			if (selected_data != undefined) {
				if (options.multiSelect) {
					selected_data = selected_data.split(',');
					for (var i = 0; i < selected_data.length; i++) {
						$option.find("[data-value='" + selected_data[i] + "']").addClass("active");
					}
				} else {
					var $li = $option.find("[data-value='" + selected_data + "']");
					$li.addClass("active");
				}
			}
			$option.find(".ui-select-option-search").find("input").select();
			$option.css({ position: 'absolute', top: y, left: x, width: width });
			$option.slideDown(150);
			$select.addClass("ui-select-focus");
		} else {
			$(document).trigger("click");
		}
		e.stopPropagation();
	})
	function documentClick(e) {
		var e = e ? e : window.event;
		var tar = e.srcElement || e.target;
		$option.slideUp(50, function () { $option.prependTo(document.body); });
		$select.removeClass('ui-select-focus');
		e.stopPropagation();
	}
	$(document).on("click", documentClick);
	var _top = top;
	if (options.popToTopWindow) {
		window.onunload = window.onbeforeunload = function () {
			top.$(".ui-select-option").remove();
		};
		$select.on("blur", documentClick);
		$(top.document).on("click", documentClick);
		$(top.document).find(".layui-layer-title").on("mousedown", documentClick);
		_top = window.parent;
	}
	var $obj = $select;
	var win = window;
	while (win != undefined && win != top) {
		var parent = $obj.parent();
		while (parent.length > 0 && parent[0] != document.body) {
			try {
				if (parent.css("overflow") == "scroll" || parent.css("overflow") == "auto" || parent.css("overflow-x") == "scroll" || parent.css("overflow-x") == "auto" || parent.css("overflow-y") == "scroll" || parent.css("overflow-y") == "auto") {
					parent.on("scroll", function (e) {
						//if ($option.is(":hidden")) {
						//	return;
						//}
						//var e = e ? e : window.event;
						//if ($select.offset().top <= 0 || $select.offset().top + $select.outerHeight() > this.clientHeight) {
						//	$option.hide();
						//	$option.prependTo(document.body);
						//	$select.removeClass('ui-select-focus');
						//} else {
						//	var x = $select.offset().left;
						//	var y = $select.offset().top + $select.outerHeight() - 1;
						//	var win = window;
						//	while (win != undefined && win != top) {
						//		x += win.parent.$("iframe[id='" + win.name + "'],iframe[name='" + win.name + "']").offset().left;
						//		y += win.parent.$("iframe[id='" + win.name + "'],iframe[name='" + win.name + "']").offset().top;
						//		win = win.parent;
						//	};
						//	var width = $select.outerWidth();
						//	if (options.width) {
						//		width = options.width;
						//	}
						//	$option.css({ top: y, left: x });
						//}
						$(document).trigger("click");
						e.stopPropagation();
					});
				}
			} catch (e) { }
			parent = parent.parent();
		}
		$obj = win.parent.$("#" + win.name + ",[name='" + win.name + "']");
		win = win.parent;
	}
	return $select;
};
$.fn.ComboBoxSetValue = function (value) {
	if ($.isNullOrEmpty(value)) {
		return;
	}
	var $select = $(this);
	var $option = $("#" + $select.attr('id') + "-option");
	$option.find('.description').trigger("click");
	$select.attr("data-value", value);
	var val = String(value).split(',');
	var selector = "";
	for (var i = 0; i < val.length; i++) {
		if (selector.length > 0) {
			selector += ",";
		}
		selector += '[data-value="' + val[i] + '"]';
	}
	var option = $option.find(selector).trigger("click");
	return $select;
};
$.fn.ComboBoxSetIndexByText = function (value) {
	if ($.isNullOrEmpty(value)) {
		return;
	}
	var $select = $(this);
	var multiSelect = $select.attr("data-multiSelect");
	var $option = $("#" + $select.attr('id') + "-option");
	$option.find('.description').trigger("click");
	$select.attr('data-text', value);
	var data_value = "";
	if ($option.find('[data-selectable="true"]:not(.description)').length > 0) {
		var allLiText = $option.find("[data-selectable='true']:not(.description)");
		var selector = "";
		var val = value.split(',');
		for (var v = 0; v < val.length; v++) {
			for (var i = 0; i < allLiText.length; i++) {
				var itemText = allLiText[i].innerText;
				var itemHtml = allLiText[i].innerHTML;
				if (allLiText[i].innerHTML == val[v] || allLiText[i].innerText == val[v]) {
					$(allLiText[i]).trigger("click");
				}
			}
		}
	}
	return $select;
};
$.fn.ComboBoxTree = function (options) {
	//options参数：description,height,allowSearch,appendTo,click,url,param,method,icon
	var defaults = {
		height: "300px",
		description: "==请选择==",
		width: false,					// 弹出层宽度，不指定弹出层宽度(undefined/null/false)时，弹出层宽度默认与框体相同宽度，指定后则按指定宽度显示
		popToTopWindow: true,		// 是否弹出至顶层窗口，弹出至顶层窗口可以解决当前iframe过小的问题
		includeParentText: true,	// 选中后文字是否包含父级文字，为了避免仅显示当前项文字可能引起意义不明的问题
		separator: " ",				// 父级文字与当前项文字之间的分隔字符
	}
	options = $.extend(defaults, options);
	var $select = $(this);
	if (!$select.attr('id')) {
		return false;
	}
	$select.attr("type", "selectTree");
	$select.find('.ui-select-text').remove()
	var $select_html = "";
	$select_html += "<div class=\"ui-select-text\"  style='color:#999;'>" + options.description + "</div>";
	$select_html += "<div class=\"ui-select-option tree-option\">";
	$select_html += "<div class=\"ui-select-option-content\" style=\"max-height: " + options.height + "\"></div>";
	if (options.allowSearch) {
		$select_html += "<div class=\"ui-select-option-search\"><input type=\"text\" class=\"form-control\" placeholder=\"搜索关键字\" /><span class=\"input-query\" title=\"Search\"><i class=\"fa fa-search\" title=\"按回车查询\"></i></span></div>";
	}
	$select_html += "</div>";
	$select.append($select_html);
	var $text = $select.find('.ui-select-text');
	var $option_html = $($("<p>").append($select.find('.ui-select-option').clone()).html());
	$option_html.attr('id', $select.attr('id') + '-option');
	$select.find('.ui-select-option').remove();
	if (options.appendTo) {
		$(options.appendTo).prepend($option_html);
	} else {
		$('body').prepend($option_html);
	}
	var $option = $("#" + $select.attr('id') + "-option");
	var $option_content = $("#" + $select.attr('id') + "-option").find('.ui-select-option-content');
	if (!!options.url) {
		$.SetForm({
			url: options.url,
			param: options.param,
			type: "get",
			dataType: "json",
			success: function (data) {
				options.data = data;
				loadtreeview(data);
				if (data.length == 0 || !$select.attr("data-value")) {	//如果数据长度为空或者未指定初值，则显示默认提示文字，并移除选中
					$text.html(!!options.description ? options.description : '');
					$select.removeAttr("data-value");
				} else if (!!$select.attr("data-value")) {	//如果指定了初值，则选中初值
					$select.ComboBoxTreeSetValue($select.attr("data-value"));
				}
			},
			error: function (req, status, err) {
				dialogMsg(err, -1);
			}
		})
	} else if (!!options.data) {
		loadtreeview(options.data);
	}
	function loadtreeview(data) {
		$option_content.empty();
		$option_content.treeview({
			onnodeclick: function (item) {
				$select.attr("data-value", item.id).attr("data-text", item.text);
				var text = item.text;
				if (options.includeParentText) {
					text = item.parent.text + options.separator + text;
				}
				$select.find('.ui-select-text').html(text).css('color', '#000');
				$option.slideUp(150, function () {
					$option.prependTo(document.body);
					$select.trigger("change");
					if (options.click) {
						options.click(item);
					}
				});
			},
			height: options.height,
			data: data,
			method: options.method,
			description: options.description
		});
	}
	if (options.data == null && options.allowSearch) {
		$option.find('.ui-select-option-search').find('input').attr('data-url', options.url);
		$option.find('.ui-select-option-search').find('input').bind("keypress", function (e) {
			if (e.keyCode == "13") {
				var value = $(this).val();
				//var url = changeUrlParam($option.find('.ui-select-option-search').find('input').attr('data-url'), "keyword", escape(value));
				var url = $option.find('.ui-select-option-search').find('input').attr('data-url');
				$.SetForm({
					url: options.url,
					param: { keyword: value },
					type: "get",
					dataType: "json",
					success: function (data) {
						options.data = data;
						loadtreeview(data);
						if (data.length == 0 || !$select.attr("data-value")) {	//如果数据长度为空或者未指定初值，则显示默认提示文字，并移除选中
							$text.html(!!options.description ? options.description : '');
							$select.removeAttr("data-value");
						} else if (!!$select.attr("data-value")) {	//如果指定了初值，则选中初值
							$select.ComboBoxTreeSetValue($select.attr("data-value"));
						}
					},
					error: function (req, status, err) {
						dialogMsg(err, -1);
					}
				})
			}
		}).focus(function () {
			$(this).select();
		});
	}
	if (options.icon) {
		$option.find('i').remove();
		$option.find('img').remove();
	}
	$select.off('click').bind("click", function (e) {
		if ($select.attr('readonly') == 'readonly' || $select.attr('disabled') == 'disabled') {
			return false;
		}
		$(this).parent().addClass('ui-select-focus');
		if ($option.is(":hidden")) {
			$(document).trigger("click");
			var x = $select.offset().left;
			var y = $select.offset().top + $select.outerHeight() - 1;
			if (options.popToTopWindow) {
				var win = window;
				while (win != undefined && win != top) {
					x += win.parent.$("iframe[id='" + win.name + "'],iframe[name='" + win.name + "']").offset().left;
					y += win.parent.$("iframe[id='" + win.name + "'],iframe[name='" + win.name + "']").offset().top;
					win = win.parent;
				};
				if (window != top) {
					var win = window;
					while (win.parent != top) {
						win = win.parent;
					}
					var thisIframe = top.$("#" + win.name + ",[name='" + win.name + "']");
					var zIndex = 1;
					while (thisIframe[0] != top.document.body) {
						var z = thisIframe.css("z-index");
						if (thisIframe.css("z-index") != undefined && thisIframe.css("z-index") != "auto") {
							zIndex = parseInt(thisIframe.css("z-index"));
							break;
						}
						thisIframe = thisIframe.parent();
					}
					$option.css({ zIndex: zIndex });
				} else {
					$option.css({ zIndex: 99 });
				}
				$option.appendTo(top.document.body).focus();
			} else {
				$option.css({ zIndex: 99 });
			}
			var width = $select.outerWidth();
			if (options.width) {
				width = options.width;
			}
			$option.css({ position: 'absolute', top: y, left: x, width: width, zIndex: 99999999 });
			$option.slideDown(150);
			$option.find('.ui-select-option-search').find('input').select();
		} else {
			$option.slideUp(150, function () { $option.prependTo(document.body); });
		}
		e.stopPropagation();
	});
	if ($option.height() > (options.height ? parseFloat(options.height.substring(0, options.height.indexOf('px'))) : 100)) {
		$select.find(".ui-select-option-content").css({ "max-height": options.height, "overflow-y": "scroll" });
	}
	$option.on("click", 'li div', function (e) {
		var e = e ? e : window.event;
		var tar = e.srcElement || e.target;
		if (!$(tar).hasClass('bbit-tree-ec-icon')) {
			e.stopPropagation();
		}
	});
	function documentClick(e) {
		var e = e ? e : window.event;
		var tar = e.srcElement || e.target;
		if (!$(tar).hasClass('bbit-tree-ec-icon') && !$(tar).hasClass('form-control')) {
			$option.slideUp(150, function () { $option.prependTo(document.body); });
			$select.removeClass('ui-select-focus');
			e.stopPropagation();
		}
	}
	$(document).on("click", documentClick);
	var _top = top;
	if (options.popToTopWindow) {
		window.onunload = window.onbeforeunload = function () {
			top.$(".ui-select-option").remove();
		};
		$select.on("blur", documentClick);
		$(top.document).on("click", documentClick);
		$(top.document).find(".layui-layer-title").on("mousedown", documentClick);
		var $obj = $select;
		_top = window.parent;
	}
	var win = window;
	while (win != undefined && win != _top) {
		var parent = $obj.parent();
		while (parent.length > 0 && parent[0] != document.body) {
			try {
				if (parent.css("overflow") == "scroll" || parent.css("overflow") == "auto" || parent.css("overflow-x") == "scroll" || parent.css("overflow-x") == "auto" || parent.css("overflow-y") == "scroll" || parent.css("overflow-y") == "auto") {
					parent.on("scroll", function (e) {
						$(document).trigger("click");
						e.stopPropagation();
					});
				}
			} catch (e) { }
			parent = parent.parent();
		}
		$obj = win.parent.$("#" + win.name + ",[name='" + win.name + "']");
		win = window.parent;
	}
	return $select;
};
$.fn.ComboBoxTreeSetValue = function (value) {
	if (value == "") {
		return;
	}
	var $select = $(this);
	var $option = $("#" + $select.attr('id') + "-option");
	$select.attr('data-value', value);
	$option.find('ul').find('[data-value="' + value + '"]').trigger("click");
	return $select;
};
$.fn.ComboBoxTreeCheckBox = function (options) {
	//options参数：description,height,allowSearch,appendTo,click,url,param,method,icon
	var defaults = {
		height: "300px",
		description: "==请选择==",
		width: false,					// 弹出层宽度，不指定弹出层宽度(undefined/null/false)时，弹出层宽度默认与框体相同宽度，指定后则按指定宽度显示
		popToTopWindow: true,		// 是否弹出至顶层窗口，弹出至顶层窗口可以解决当前iframe过小的问题
		includeParentText: true,	// 选中后文字是否包含父级文字，为了避免仅显示当前项文字可能引起意义不明的问题
		separator: " ",				// 父级文字与当前项文字之间的分隔字符
	}
	options = $.extend(defaults, options);
	var $select = $(this);
	if (!$select.attr('id')) {
		return false;
	}
	$select.attr("type", "selectTreeBox");
	$select.find('.ui-select-text').remove();
	var $select_html = "";
	$select_html += "<div class=\"ui-select-text\"  style='color:#999;'>" + options.description + "</div>";
	$select_html += "<div class=\"ui-select-option tree-option\">";
	$select_html += "<div id=\"select_tree_box\" class=\"ui-select-option-content\" style=\"max-height: " + options.height + "\"></div>";
	if (options.allowSearch) {
		$select_html += "<div class=\"ui-select-option-search\"><input type=\"text\" class=\"form-control\" placeholder=\"搜索关键字\" /><span class=\"input-query\" title=\"Search\"><i class=\"fa fa-search\" title=\"按回车查询\"></i></span></div>";
	}
	$select_html += "</div>";
	$select.append($select_html);
	var $text = $select.find('.ui-select-text');
	var $option_html = $($("<p>").append($select.find('.ui-select-option').clone()).html());
	$option_html.attr('id', $select.attr('id') + '-option');
	$select.find('.ui-select-option').remove();
	if (options.appendTo) {
		$(options.appendTo).prepend($option_html);
	} else {
		$('body').prepend($option_html);
	}
	var $option = $("#" + $select.attr('id') + "-option");
	var $option_content = $("#" + $select.attr('id') + "-option").find('.ui-select-option-content');
	if (!!options.url) {
		$.SetForm({
			url: options.url,
			param: options.param,
			type: "get",
			dataType: "json",
			success: function (data) {
				options.data = data;
				$text.html(!!options.description ? options.description : '');
				loadtreeview(data);
				$select.data("value", []);
				//if (data.length == 0 || !$select.data("value")) {	//如果数据长度为空或者未指定初值，则显示默认提示文字，并移除选中
				//    $text.html(!!options.description ? options.description : '');
				//    $select.data("value",[]);
				//} else if (!!$select.data("value")) {	//如果指定了初值，则选中初值
				//    $select.ComboBoxTreeCheckBoxSetValue($select.data("value"));
				//}
			},
			error: function (req, status, err) {
				dialogMsg(err, -1);
			}
		})
	} else if (!!options.data) {
		loadtreeview(options.data);
	}
	function loadtreeview(data) {
		$select.data("json", data);
		$option_content.empty();
		var treeview = $option_content.treeview({
			onnodeclick: function (tree, item) {
				$option.find("#select_tree_box_" + tree.id + "_cb").trigger("click");
				$option.find("#select_tree_box_" + tree.id).removeClass("bbit-tree-selected");
			},
			oncheckboxclick: function (tree, item, status) {
				var data = $select.data("value");
				console.log({ tree: tree, item: item, status: status });
				if (item == 1) {
					if (data == null) {
						data = [];
					}
					var model = data.filter(function (obj) { return obj.id == tree.id });
					var text = tree.text;
					if (options.includeParentText) {
						var pitem = tree;
						var nodeText = [];
						do {
							nodeText.unshift(pitem.text);
							if (pitem != tree && pitem.showcheck) {
								var icon = $option.find("#select_tree_box_" + pitem.id + "_cb");
								icon.attr("src", icon.attr("src").replace("checkbox_0", "checkbox_2"));
							}
							if (!pitem.showcheck) {
								break;
							}
							pitem = pitem.parent;
						} while (pitem != undefined);
						text = nodeText.join(options.separator);
					}
					if (model.length == 0) {
						data.push({ "id": tree.id, "text": text, "value": tree.value });
					}
				}
				else {
					var model = data.filter(function (obj) { return obj.id == tree.id });
					if (model.length > 0) {
						var index = $.inArray(model[0], data);
						if (index > -1) {
							data.splice(index, 1);
						}
					}
				}
				$select.data("value", data);
				$("#" + $select.attr("id").replace("_Temp", "")).val($select.ComboBoxTreeCheckBoxGetValue());
				$select.find('.ui-select-text').html($.map(data, function (value) { return value.text; }).join(",")).css('color', '#000');
				//debugger;
			},
			height: options.height,
			data: data,
			method: options.method,
			description: options.description,
			showcheck: true
		});
		var dataValue = $select.data("ivalue");
		if (dataValue != null) {
			$select.ComboBoxTreeCheckBoxSetValue(dataValue);
			$select.data("ivalue", null);
		}
	}
	if (options.data == null && options.allowSearch) {
		$option.find('.ui-select-option-search').find('input').attr('data-url', options.url);
		$option.find('.ui-select-option-search').find('input').bind("keypress", function (e) {
			if (e.keyCode == "13") {
				var value = $(this).val();
				//var url = changeUrlParam($option.find('.ui-select-option-search').find('input').attr('data-url'), "keyword", escape(value));
				var url = $option.find('.ui-select-option-search').find('input').attr('data-url');
				$.SetForm({
					url: options.url,
					param: { keyword: value },
					type: "get",
					dataType: "json",
					success: function (data) {
						options.data = data;
						loadtreeview(data);
						$text.html(!!options.description ? options.description : '');
						$select.data("value", []);
						//if (data.length == 0 || !$select.data("value")) {	//如果数据长度为空或者未指定初值，则显示默认提示文字，并移除选中
						//    $text.html(!!options.description ? options.description : '');
						//    $select.data("value", []);
						//} else if (!!$select.data("value")) {	//如果指定了初值，则选中初值
						//    var d = $.map($select.data("value"), function (item) { return item.value; }).join(",");
						//    $select.ComboBoxTreeCheckBoxSetValue(d);
						//}
					},
					error: function (req, status, err) {
						dialogMsg(err, -1);
					}
				});
			}
		}).focus(function () {
			$(this).select();
		});
	}
	if (options.icon) {
		$option.find('i').remove();
		$option.find('img').remove();
	}
	$select.off('click').bind("click", function (e) {
		if ($select.attr('readonly') == 'readonly' || $select.attr('disabled') == 'disabled') {
			return false;
		}
		$(this).parent().addClass('ui-select-focus');
		if ($option.is(":hidden")) {
			$(document).trigger("click");
			var x = $select.offset().left;
			var y = $select.offset().top + $select.outerHeight();
			if (options.popToTopWindow) {
				var win = window;
				while (win != undefined && win != top) {
					x += win.parent.$("iframe[id='" + win.name + "'],iframe[name='" + win.name + "']").offset().left;
					y += win.parent.$("iframe[id='" + win.name + "'],iframe[name='" + win.name + "']").offset().top;
					win = win.parent;
				};
				if (window != top) {
					var win = window;
					while (win.parent != top) {
						win = win.parent;
					}
					var thisIframe = top.$("#" + win.name + ",[name='" + win.name + "']");
					var zIndex = 1;
					while (thisIframe[0] != top.document.body) {
						var z = thisIframe.css("z-index");
						if (thisIframe.css("z-index") != undefined && thisIframe.css("z-index") != "auto") {
							zIndex = parseInt(thisIframe.css("z-index"));
							break;
						}
						thisIframe = thisIframe.parent();
					}
					$option.css({ zIndex: zIndex });
				} else {
					$option.css({ zIndex: 99 });
				}
				$option.appendTo(top.document.body).focus();
			} else {
				$option.css({ zIndex: 99 });
			}
			var width = $select.outerWidth();
			if (options.width) {
				width = options.width;
			}
			$option.css({ position: 'absolute', top: y, left: x, width: width, zIndex: 99999999 });
			$option.slideDown(150);
			$option.find('.ui-select-option-search').find('input').select();
		} else {
			$option.slideUp(150, function () { $option.prependTo(document.body); });
		}
		e.stopPropagation();
	});
	if ($option.height() > (options.height ? parseFloat(options.height.substring(0, options.height.indexOf('px'))) : 100)) {
		$select.find(".ui-select-option-content").css({ "max-height": (options.height || "100px"), "overflow-y": "scroll" });
	}
	$option.on("click", 'li div', function (e) {
		var e = e ? e : window.event;
		var tar = e.srcElement || e.target;
		if (!$(tar).hasClass('bbit-tree-ec-icon')) {
			e.stopPropagation();
		}
	});
	function documentClick(e) {
		var e = e ? e : window.event;
		var tar = e.srcElement || e.target;
		if (!$(tar).hasClass('bbit-tree-ec-icon') && !$(tar).hasClass('form-control')) {
			$option.slideUp(50, function () { $option.prependTo(document.body); });
			$select.removeClass('ui-select-focus');
			e.stopPropagation();
		}
	}
	$(document).on("click", documentClick);
	var _top = top;
	if (options.popToTopWindow) {
		window.onunload = window.onbeforeunload = function () {
			top.$(".ui-select-option").remove();
		};
		$select.on("blur", documentClick);
		$(top.document).on("click", documentClick);
		$(top.document).find(".layui-layer-title").on("mousedown", documentClick);
		_top = window.parent;
	}
	var win = window;
	while (win != undefined && win != _top) {
		var parent = $obj.parent();
		while (parent.length > 0 && parent[0] != document.body) {
			try {
				if (parent.css("overflow") == "scroll" || parent.css("overflow") == "auto" || parent.css("overflow-x") == "scroll" || parent.css("overflow-x") == "auto" || parent.css("overflow-y") == "scroll" || parent.css("overflow-y") == "auto") {
					parent.on("scroll", function (e) {
						$(document).trigger("click");
						e.stopPropagation();
					});
				}
			} catch (e) { }
			parent = parent.parent();
		}
		$obj = win.parent.$("#" + win.name + ",[name='" + win.name + "']");
		win = window.parent;
	}
	return $select;
};
$.fn.ComboBoxTreeCheckBoxSetValue = function (value) {
	if (value == "") {
		return;
	}
	var $select = $(this);
	var json = $select.data("json");
	if (json == null) {
		$select.data("ivalue", value);
		return;
	}
	else {
		json = json[0];
	}
	var values = value.split(",");
	for (var i = 0; i < values.length; i++) {
		var id = GetCheckBoxIdByValue(json, values[i]);
		$("#select_tree_box_" + id + "_cb").trigger("click");
	}
	return $select;
};
function GetCheckBoxIdByValue(data, value) {
	if (data.value == value) {
		return data.id;
	}
	for (var i = 0; i < data.ChildNodes.length; i++) {
		var id = GetCheckBoxIdByValue(data.ChildNodes[i], value);
		if (id != null) {
			return id;
		}
	}
}
$.fn.ComboBoxTreeCheckBoxGetValue = function () {
	var $select = $(this);
	var value = $select.data("value");
	value = $.map(value, function (value) { return value.value; }).join(",");
	return value;
};
$.fn.GetWebControls = function (keyValue) {
	var $id = $(this);
	var reVal = "";
	$id.find('input,select,textarea,.ui-select,.data-list').each(function (r) {
		var id = $(this).attr('id');
		var type = $(this).attr('type');
		if ($(this).hasClass("data-list")) {
			type = "dataList";
		}
		if (id == null || document.getElementById(id).style.display == "none") {
			return true;
		}
		switch (type) {
			case "checkbox":
				if ($("#" + id).is(":checked")) {
					reVal += '"' + id + '"' + ':' + '"Y",'
				} else {
					reVal += '"' + id + '"' + ':' + '"N",'
				}
				break;
			case "select":
				var value = $("#" + id).attr('data-value');
				if (value == "") {
					value = "&nbsp;";
				}
				reVal += '"' + id + '"' + ':' + '"' + $.trim(value) + '",'
				break;
			case "selectTree":
				var value = $("#" + id).attr('data-value');
				if (value == "") {
					value = "&nbsp;";
				}
				reVal += '"' + id + '"' + ':' + '"' + $.trim(value) + '",'
				break;
			case "selectTreeBox":
				var value = $("#" + id).ComboBoxTreeCheckBoxGetValue();
				if (value == "") {
					value = "&nbsp;";
				}
				reVal += '"' + id + '"' + ':' + '"' + $.trim(value) + '",'
				break;
			case "dataList":
				var value = $("#" + id).getDataListValue();
				reVal += '"' + id + '"' + ':' + '"' + $.trim(value) + '",';
				break;
			default:
				var value = $("#" + id).val();
				if (value == "") {
					value = "&nbsp;";
				}
				reVal += '"' + id + '"' + ':' + '"' + $.trim(value) + '",'
				break;
		}
	});
	reVal = reVal.substr(0, reVal.length - 1);
	//if (!keyValue) {
	reVal = reVal.replace(/&nbsp;/g, '');
	//}
	reVal = reVal.replace(/\\/g, '\\\\');
	reVal = reVal.replace(/\n/g, '\\n');
	var postdata = jQuery.parseJSON('{' + reVal + '}');
	//阻止伪造请求
	//if ($('[name=__RequestVerificationToken]').length > 0) {
	//    postdata["__RequestVerificationToken"] = $('[name=__RequestVerificationToken]').val();
	//}
	return postdata;
};
$.fn.SetWebControls = function (data) {
	var $id = $(this)
	for (var key in data) {
		var id = $id.find('#' + key);
		if (id.attr('id')) {
			var type = id.attr('type');
			if (id.hasClass("input-datepicker")) {
				type = "datepicker";
			}
			if (id[0].nodeName.toLowerCase() == "iframe") {
				type = "iframe";
			}
			if (id.hasClass("data-list")) {
				type = "dataList";
			}
			if (id[0].nodeName.toLowerCase() == "script") {
				type = "skip";
			}
			var value = $.trim(data[key]).replace(/&nbsp;/g, '');
			switch (type) {
				case "skip":
					break;
				case "checkbox":
					if (value == "Y") {
						id.attr("checked", 'checked');
					} else {
						id.removeAttr("checked");
					}
					break;
				case "select":
					id.ComboBoxSetValue(value);
					break;
				case "selectTree":
					id.ComboBoxTreeSetValue(value);
					break;
				case "selectTreeBox":
					id.ComboBoxTreeCheckBoxSetValue(value);
					break;
				case "datepicker":
					id.val(formatDate(value, 'yyyy-MM-dd'));
					break;
				case "dataList":
					id.loadDataListItems(value);
					break;
				case "iframe":
					$.SetIframeContent(key, value);
					break;
				default:
					if (id[0].nodeName.toLowerCase() == "input"
|| id[0].nodeName.toLowerCase() == "textarea"
|| id[0].nodeName.toLowerCase() == "select") {
						id.val(value);
					} else {
						id.html(value);
					}
					break;
			}
		}
	}
};
$.fn.Contextmenu = function () {
	var element = $(this);
	var oMenu = $('.contextmenu');
	$(document).click(function () {
		oMenu.hide();
	});
	$(document).mousedown(function (e) {
		if (3 == e.which) {
			oMenu.hide();
		}
	});
	var aUl = oMenu.find("ul");
	var aLi = oMenu.find("li");
	var showTimer = hideTimer = null;
	var i = 0;
	var maxWidth = maxHeight = 0;
	var aDoc = [document.documentElement.offsetWidth, document.documentElement.offsetHeight];
	oMenu.hide();
	for (i = 0; i < aLi.length; i++) {
		//为含有子菜单的li加上箭头
		aLi[i].getElementsByTagName("ul")[0] && (aLi[i].className = "sub");
		//鼠标移入
		aLi[i].onmouseover = function () {
			var oThis = this;
			var oUl = oThis.getElementsByTagName("ul");
			//鼠标移入样式
			oThis.className += " active";
			//显示子菜单
			if (oUl[0]) {
				clearTimeout(hideTimer);
				showTimer = setTimeout(function () {
					for (i = 0; i < oThis.parentNode.children.length; i++) {
						oThis.parentNode.children[i].getElementsByTagName("ul")[0] &&
(oThis.parentNode.children[i].getElementsByTagName("ul")[0].style.display = "none");
					}
					oUl[0].style.display = "block";
					oUl[0].style.top = oThis.offsetTop + "px";
					oUl[0].style.left = oThis.offsetWidth + "px";

					//最大显示范围					
					maxWidth = aDoc[0] - oUl[0].offsetWidth;
					maxHeight = aDoc[1] - oUl[0].offsetHeight;

					//防止溢出
					maxWidth < getOffset.left(oUl[0]) && (oUl[0].style.left = -oUl[0].clientWidth + "px");
					maxHeight < getOffset.top(oUl[0]) && (oUl[0].style.top = -oUl[0].clientHeight + oThis.offsetTop + oThis.clientHeight + "px")
				}, 300);
			}
		};
		//鼠标移出	
		aLi[i].onmouseout = function () {
			var oThis = this;
			var oUl = oThis.getElementsByTagName("ul");
			//鼠标移出样式
			oThis.className = oThis.className.replace(/\s?active/, "");

			clearTimeout(showTimer);
			hideTimer = setTimeout(function () {
				for (i = 0; i < oThis.parentNode.children.length; i++) {
					oThis.parentNode.children[i].getElementsByTagName("ul")[0] &&
(oThis.parentNode.children[i].getElementsByTagName("ul")[0].style.display = "none");
				}
			}, 300);
		};
	}
	//自定义右键菜单
	$(element).bind("contextmenu", function () {
		var event = event || window.event;
		oMenu.show();
		oMenu.css('top', event.clientY + "px");
		oMenu.css('left', event.clientX + "px");
		//最大显示范围
		maxWidth = aDoc[0] - oMenu.width();
		maxHeight = aDoc[1] - oMenu.height();
		//防止菜单溢出
		if (oMenu.offset().top > maxHeight) {
			oMenu.css('top', maxHeight + "px");
		}
		if (oMenu.offset().left > maxWidth) {
			oMenu.css('left', maxWidth + "px");
		}
		return false;
	}).bind("click", function () {
		oMenu.hide();
	});
};
$.fn.panginationEx = function (options) {
	var $pager = $(this);
	if (!$pager.attr('id')) {
		return false;
	}
	var defaults = {
		firstBtnText: '首页',
		lastBtnText: '尾页',
		prevBtnText: '上一页',
		nextBtnText: '下一页',
		showInfo: true,
		showJump: true,
		jumpBtnText: '跳转',
		showPageSizes: true,
		infoFormat: '{start} ~ {end}条，共{total}条',
		sortname: '',
		url: "",
		success: null,
		beforeSend: null,
		complete: null
	};
	var options = $.extend(defaults, options);
	var params = $.extend({ sidx: options.sortname, sord: "asc" }, options.params);
	options.remote = {
		url: options.url,  //请求地址
		params: params,       //自定义请求参数
		beforeSend: function (XMLHttpRequest) {
			if (options.beforeSend != null) {
				options.beforeSend(XMLHttpRequest);
			}
		},
		success: function (result, pageIndex) {
			//回调函数
			//result 为 请求返回的数据，呈现数据
			if (options.success != null) {
				options.success(result.rows, pageIndex);
			}
		},
		complete: function (XMLHttpRequest, textStatu) {
			if (options.complete != null) {
				options.complete(XMLHttpRequest, textStatu);
			}
			//...
		},
		pageIndexName: 'page',     //请求参数，当前页数，索引从0开始
		pageSizeName: 'rows',       //请求参数，每页数量
		totalName: 'records'              //指定返回数据的总数据量的字段名
	}
	$pager.page(options);
};
$.fn.LeftListShowOfemail = function (options) {
	var $list = $(this);
	if (!$list.attr('id')) {
		return false;
	}
	$list.append('<ul  style="padding-top: 10px;"></ul>');
	var defaults = {
		id: "id",
		name: "text",
		img: "fa fa-file-o",

	};
	var options = $.extend(defaults, options);
	$list.height(options.height);
	$.ajax({
		url: options.url,
		data: options.param,
		type: "GET",
		dataType: "json",
		async: false,
		success: function (data) {
			$.each(data, function (i, item) {
				var $_li = $('<li class="" data-value="' + item[options.id] + '"  data-text="' + item[options.name] + '" ><i class="' + options.img + '" style="vertical-align: middle; margin-top: -2px; margin-right: 8px; font-size: 14px; color: #666666; opacity: 0.9;"></i>' + item[options.name] + '</li>');
				if (i == 0) {
					$_li.addClass("active");
				}
				$list.find('ul').append($_li);
			});
			$list.find('li').click(function () {
				var key = $(this).attr('data-value');
				var value = $(this).attr('data-text');
				$list.find('li').removeClass('active');
				$(this).addClass('active');
				options.onnodeclick({ id: key, name: value });
			});
		},
		error: function (XMLHttpRequest, textStatus, errorThrown) {
			dialogMsg(errorThrown, -1);
		}
	});
};
$.fn.authorizeButton = function () {
	var $element = $(this);
	$element.find('a.btn').attr('authorize', 'no')
	$element.find('ul.dropdown-menu').find('li').attr('authorize', 'no')
	var moduleId = tabiframeId();
	var data = top.authorizeButtonData[moduleId];
	if (data != undefined) {
		$.each(data, function (i) {
			$element.find("#" + data[i].EN_CODE).attr('authorize', 'yes');
		});
	}
	$element.find('[authorize=no]').remove();
};
$.fn.authorizeColModel = function () {
	var $element = $(this);
	var columns = $element.bootstrapTable('getOptions').columns;
	if (columns != null) {
		columns = columns[0];
		for (var i = 0; i < columns.length; i++) {
			var columnArray = columns[i];
			if (!columnArray.checkbox) {
				$element.bootstrapTable('hideColumn', columnArray.field);
			}
		}
		var moduleId = tabiframeId();
		var data = top.authorizeColumnData[moduleId];
		if (data != undefined) {
			$.each(data, function (i) {
				$element.bootstrapTable('showColumn', data[i].EN_CODE);
			});
		}
	}
};//


$.fn.jqGridEx = function (options) {
	var $jqGrid = $(this);
	var _selectedRowIndex;
	if (!$jqGrid.attr('id')) {
		return false;
	}
	var defaults = {
		url: "",
		datatype: "json",
		height: $(window).height() - 139.5,
		autowidth: true,
		colModel: [],
		viewrecords: true,
		rowNum: 30,
		rowList: [30, 50, 100],
		pager: "#gridPager",
		sortname: 'CreateDate desc',
		rownumbers: true,
		shrinkToFit: false,
		gridview: true,
		onSelectRow: function () {
			_selectedRowIndex = $("#" + this.id).getGridParam('selrow');
		},
		gridComplete: function () {
			$("#" + this.id).setSelection(_selectedRowIndex, false);
		}
	};
	var options = $.extend(defaults, options);
	$jqGrid.jqGrid(options);
};
$.fn.jqGridRowValue = function (code) {
	var $jgrid = $(this);
	var json = [];
	var selectedRowIds = $jgrid.jqGrid("getGridParam", "selarrrow");
	if (selectedRowIds != undefined && selectedRowIds != "") {
		var len = selectedRowIds.length;
		for (var i = 0; i < len ; i++) {
			var rowData = $jgrid.jqGrid('getRowData', selectedRowIds[i]);
			json.push(rowData[code]);
		}
	} else {
		var rowData = $jgrid.jqGrid('getRowData', $jgrid.jqGrid('getGridParam', 'selrow'));
		json.push(rowData[code]);
	}
	return String(json);
};
$.fn.jqGridRow = function () {
	var $jgrid = $(this);
	var json = [];
	var selectedRowIds = $jgrid.jqGrid("getGridParam", "selarrrow");
	if (selectedRowIds != "") {
		var len = selectedRowIds.length;
		for (var i = 0; i < len ; i++) {
			var rowData = $jgrid.jqGrid('getRowData', selectedRowIds[i]);
			json.push(rowData);
		}
	} else {
		var rowData = $jgrid.jqGrid('getRowData', $jgrid.jqGrid('getGridParam', 'selrow'));
		json.push(rowData);
	}
	return json;
};

dialogTop = function (content, type) {
	$(".tip_container").remove();
	var bid = parseInt(Math.random() * 100000);
	$("body").prepend('<div id="tip_container' + bid + '" class="container tip_container"><div id="tip' + bid + '" class="mtip"><i class="micon"></i><span id="tsc' + bid + '"></span><i id="mclose' + bid + '" class="mclose"></i></div></div>');
	var $this = $(this);
	var $tip_container = $("#tip_container" + bid);
	var $tip = $("#tip" + bid);
	var $tipSpan = $("#tsc" + bid);
	//先清楚定时器
	clearTimeout(window.timer);
	//主体元素绑定事件
	$tip.attr("class", type).addClass("mtip");
	$tipSpan.html(content);
	$tip_container.slideDown(300);
	//提示层隐藏定时器
	window.timer = setTimeout(function () {
		$tip_container.slideUp(300);
		$(".tip_container").remove();
	}, 4000);
	$("#tip_container" + bid).css("left", ($(window).width() - $("#tip_container" + bid).width()) / 2);
};

dialogOpenparent = function (options) {
	Loading(true);
	var defaults = {
		id: null,
		title: '系统窗口',
		width: "100px",
		height: "100px",
		url: '',
		shade: 0.3,
		btn: ['确认', '关闭'],
		callBack: null
	};
	var options = $.extend(defaults, options);
	var _url = options.url;
	if (!(typeof options.width === "string")) {
		options.width = String(options.width);
	}
	if (!(typeof options.height === "string")) {
		options.height = String(options.height);
	}
	var _width = top.$.windowWidth() > parseInt(options.width.replace('px', '')) ? options.width : top.$.windowWidth() + 'px';
	var _height = top.$.windowHeight() > parseInt(options.height.replace('px', '')) ? options.height : top.$.windowHeight() + 'px';
	parent.layer.open({
		id: options.id,
		type: 2,
		shade: options.shade,
		title: options.title,
		fix: false,
		area: [_width, _height],
		//content: top.contentPath + _url,
		content: _url,
		btn: options.btn,
		yes: function () {
			options.callBack(options.id)
		}, cancel: function () {
			return true;
		}
	});
	top.$(".ajax-loader").remove();
};
dialogOpen = function (options) {
	Loading(true);
	var defaults = {
		id: null,
		title: '系统窗口',
		width: "100px",
		height: "100px",
		url: '',
		shade: 0.3,
		btn: ['确认', '关闭'],
		scrollbar: true,
		callBack: null
	};
	var options = $.extend(defaults, options);
	var _url = options.url;
	if (!(typeof options.width === "string")) {
		options.width = String(options.width);
	}
	if (!(typeof options.height === "string")) {
		options.height = String(options.height);
	}
	var _width = top.$.windowWidth() > parseInt(options.width.replace('px', '')) ? options.width : top.$.windowWidth() + 'px';
	var _height = top.$.windowHeight() > parseInt(options.height.replace('px', '')) ? options.height : top.$.windowHeight() + 'px';
	top.layer.open({
		id: options.id,
		type: 2,
		shade: options.shade,
		title: options.title,
		fix: false,
		area: [_width, _height],
		//content: top.contentPath + _url,
		content: _url,
		scrollbar: options.scrollbar,
		btn: options.btn,
		yes: function () {
			options.callBack(options.id)
		}, cancel: function () {
			return true;
		}, end: options.end
	});
};
dialogContent = function (options) {
	var defaults = {
		id: null,
		title: '系统窗口',
		width: "100px",
		height: "100px",
		content: '',
		btn: ['确认', '关闭'],
		callBack: null
	};
	var options = $.extend(defaults, options);
	top.layer.open({
		id: options.id,
		type: 1,
		title: options.title,
		fix: false,
		area: [options.width, options.height],
		content: options.content,
		btn: options.btn,
		yes: function () {
			options.callBack(options.id)
		}
	});
};
dialogAlert = function (content, options, callBack) {
	var defaultOption = {
		title: "信息提示"
	}
	if (typeof options === "string" || typeof options === "number") {
		if (typeof options === "string") {
			options = parseInt(String(options));
		}
		if (options == -1) {
			options = 2;
		}
		defaultOption = $.extend(defaultOption, {
			icon: options
		});
	} else {
		if (!!options) {
			defaultOption = $.extend(defaultOption, options);
		}
	}
	if (!content) {
		content = "";
	}
	top.layer.alert(content, defaultOption, callBack);
};
dialogConfirm = function (content, callBack) {
	if (content == undefined || content == null) {
		content = "";
	}
	top.layer.confirm(content, {
		icon: 7,
		title: "信息提示",
		btn: ['确认', '取消'],
		yes: function () {
			callBack(true);
		},
		no: function () {
			callBack(false)
		}
	});
};
dialogMsg = function (content, type) {
	if (type == -1) {
		type = 2;
	}
	if (content == undefined || content == null) {
		content = "";
	}
	top.layer.msg(content, { icon: type, time: 4000, shift: 5 });
};
$.dialogMsg = function (options) {
	var defaults = {
		icon: 2,
		time: 4000,
		shift: 5
	};
	if (options.content == undefined || options.content == null) {
		options.content = "";
	}
	options = $.extend(defaults, options);
	top.layer.msg(options.content, options);
};
dialogClose = function () {
	try {
		if (window.name == "") {
			return false;
		}
		var index = top.layer.getFrameIndex(window.name); //先得到当前iframe层的索引
		top.layer.close(index);
	} catch (e) {
		alert(e)
	}
};
reload = function () {
	location.reload();
	return false;
};
newGuid = function () {
	var guid = "";
	for (var i = 1; i <= 32; i++) {
		var n = Math.floor(Math.random() * 16.0).toString(16);
		guid += n;
		if ((i == 8) || (i == 12) || (i == 16) || (i == 20)) guid += "-";
	}
	return guid;
};
formatDate = function (v, format) {
	if (!v) return "";
	var d = v;
	if (typeof v === 'string') {
		if (v.indexOf("/Date(") > -1)
			d = new Date(parseInt(v.replace("/Date(", "").replace(")/", ""), 10));
		else
			d = new Date(Date.parse(v.replace(/-/g, "/").replace("T", " ").split(".")[0]));//.split(".")[0] 用来处理出现毫秒的情况，截取掉.xxx，否则会出错
	}
	var o = {
		"M+": d.getMonth() + 1,  //month
		"d+": d.getDate(),       //day
		"H+": d.getHours(),      //hour
		"m+": d.getMinutes(),    //minute
		"s+": d.getSeconds(),    //second
		"q+": Math.floor((d.getMonth() + 3) / 3),  //quarter
		"S": d.getMilliseconds() //millisecond
	};
	if (/(y+)/.test(format)) {
		format = format.replace(RegExp.$1, (d.getFullYear() + "").substr(4 - RegExp.$1.length));
	}
	for (var k in o) {
		if (new RegExp("(" + k + ")").test(format)) {
			format = format.replace(RegExp.$1, RegExp.$1.length == 1 ? o[k] : ("00" + o[k]).substr(("" + o[k]).length));
		}
	}
	return format;
};
toDecimal = function (num) {
	if (num == null) {
		num = "0";
	}
	num = num.toString().replace(/\$|\,/g, '');
	if (isNaN(num))
		num = "0";
	sign = (num == (num = Math.abs(num)));
	num = Math.floor(num * 100 + 0.50000000001);
	cents = num % 100;
	num = Math.floor(num / 100).toString();
	if (cents < 10)
		cents = "0" + cents;
	for (var i = 0; i < Math.floor((num.length - (1 + i)) / 3) ; i++)
		num = num.substring(0, num.length - (4 * i + 3)) + '' +
num.substring(num.length - (4 * i + 3));
	return (((sign) ? '' : '-') + num + '.' + cents);
};
Date.prototype.DateAdd = function (strInterval, Number) {
	//y年 q季度 m月 d日 w周 h小时 n分钟 s秒 ms毫秒
	var dtTmp = this;
	switch (strInterval) {
		case 's': return new Date(Date.parse(dtTmp) + (1000 * Number));
		case 'n': return new Date(Date.parse(dtTmp) + (60000 * Number));
		case 'h': return new Date(Date.parse(dtTmp) + (3600000 * Number));
		case 'd': return new Date(Date.parse(dtTmp) + (86400000 * Number));
		case 'w': return new Date(Date.parse(dtTmp) + ((86400000 * 7) * Number));
		case 'q': return new Date(dtTmp.getFullYear(), (dtTmp.getMonth()) + Number * 3, dtTmp.getDate(), dtTmp.getHours(), dtTmp.getMinutes(), dtTmp.getSeconds());
		case 'm': return new Date(dtTmp.getFullYear(), (dtTmp.getMonth()) + Number, dtTmp.getDate(), dtTmp.getHours(), dtTmp.getMinutes(), dtTmp.getSeconds());
		case 'y': return new Date((dtTmp.getFullYear() + Number), dtTmp.getMonth(), dtTmp.getDate(), dtTmp.getHours(), dtTmp.getMinutes(), dtTmp.getSeconds());
	}
};
request = function (keyValue) {
	var search = location.search.slice(1);
	var arr = search.split("&");
	for (var i = 0; i < arr.length; i++) {
		var ar = arr[i].split("=");
		if (ar[0] == keyValue) {
			if (unescape(ar[1]) == 'undefined') {
				return "";
			} else {
				return unescape(ar[1]);
			}
		}
	}
	return "";
};
changeUrlParam = function (url, key, value) {
	var newUrl = "";
	var reg = new RegExp("(^|)" + key + "=([^&]*)(|$)");
	var tmp = key + "=" + value;
	if (url.match(reg) != null) {
		newUrl = url.replace(eval(reg), tmp);
	} else {
		if (url.match("[\?]")) {
			newUrl = url + "&" + tmp;
		}
		else {
			newUrl = url + "?" + tmp;
		}
	}
	return newUrl;
};

$.currentIframe = function () {
	//if ($.isbrowsername() == "Chrome" || $.isbrowsername() == "FF") {
	//    return top.frames[tabiframeId()].contentWindow;
	//}
	//else {
	return top.frames[tabiframeId()];
	//}
};
$.isbrowsername = function () {
	var userAgent = navigator.userAgent; //取得浏览器的userAgent字符串
	var isOpera = userAgent.indexOf("Opera") > -1;
	if (isOpera) {
		return "Opera"
	}; //判断是否Opera浏览器
	if (userAgent.indexOf("Firefox") > -1) {
		return "FF";
	} //判断是否Firefox浏览器
	if (userAgent.indexOf("Chrome") > -1) {
		if (window.navigator.webkitPersistentStorage.toString().indexOf('DeprecatedStorageQuota') > -1) {
			return "Chrome";
		} else {
			return "360";
		}
	}//判断是否Chrome浏览器//360浏览器
	if (userAgent.indexOf("Safari") > -1) {
		return "Safari";
	} //判断是否Safari浏览器
	if (userAgent.indexOf("compatible") > -1 && userAgent.indexOf("MSIE") > -1 && !isOpera) {
		return "IE";
	}; //判断是否IE浏览器
};
$.download = function (url, data, method) {
	if (url && data) {
		data = typeof data == 'string' ? data : jQuery.param(data);
		var inputs = '';
		$.each(data.split('&'), function () {
			var pair = this.split('=');
			inputs += '<input type="hidden" name="' + pair[0] + '" value="' + pair[1] + '" />';
		});
		$('<form action="' + url + '" method="' + (method || 'post') + '">' + inputs + '</form>').appendTo('body').submit().remove();
	};
};
$.standTabchange = function (object, forid) {
	$(".standtabactived").removeClass("standtabactived");
	$(object).addClass("standtabactived");
	$('.standtab-pane').css('display', 'none');
	$('#' + forid).css('display', 'block');
};
$.isNullOrEmpty = function (obj) {
	if ((typeof (obj) == "string" && obj == "") || obj == null || obj == undefined) {
		return true;
	}
	else {
		return false;
	}
};
$.arrayClone = function (data) {
	return $.map(data, function (obj) {
		return $.extend(true, {}, obj);
	});
};
$.windowWidth = function () {
	return $(window).width();
};
$.windowHeight = function () {
	return $(window).height();
};
$.SetIframeContent = function (frameId, content) {
	var doc;
	try {
		doc = window.frames[frameId].document;
	} catch (e) { }
	if (doc == undefined) {
		try {
			doc = top.document.getElementById(frameId).contentWindow.document;
		} catch (e) {
			try {
				doc = top.document.getElementById(frameId).document;
			} catch (e) {
				return;
			}
		}
	}
	doc.open();
	doc.designMode = "on";
	doc.write(content);
	doc.designMode = "off";
	doc.close();
};
$.GetIframeElement = function (frameId) {
	var doc;
	try {
		doc = window.frames[frameId].document;
	} catch (e) { }
	if (doc == undefined) {
		try {
			doc = document.getElementById(frameId).contentWindow.document;
		} catch (e) {
			try {
				doc = document.getElementById(frameId).document;
			} catch (e) {
				return;
			}
		}
	}
	return doc.documentElement;
};
$.EncodeHtml = function (html) {
	var div = document.createElement("div");
	div.innerText = html;
	return div.innerHTML;
};
$.DecodeHtml = function (text) {
	var div = document.createElement("div");
	div.innerHTML = text;
	return div.innerText;
};
IsNumber = function (obj) {
	$("#" + obj).bind("contextmenu", function () {
		return false;
	});
	$("#" + obj).css('ime-mode', 'disabled');
	$("#" + obj).keypress(function (e) {
		if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
			return false;
		}
	});
};
IsMoney = function (obj) {
	$("#" + obj).bind("contextmenu", function () {
		return false;
	});
	$("#" + obj).css('ime-mode', 'disabled');
	$("#" + obj).bind("keydown", function (e) {
		var key = window.event ? e.keyCode : e.which;
		if (isFullStop(key)) {
			return $(this).val().indexOf('.') < 0;
		}
		return (isSpecialKey(key)) || ((isNumber(key) && !e.shiftKey));
	});
	function isNumber(key) {
		return key >= 48 && key <= 57
	}
	function isSpecialKey(key) {
		return key == 8 || key == 46 || (key >= 37 && key <= 40) || key == 35 || key == 36 || key == 9 || key == 13
	}
	function isFullStop(key) {
		return key == 190 || key == 110;
	}
};
checkedArray = function (id) {
	var isOK = true;
	if (id == undefined || id == "" || id == 'null' || id == 'undefined') {
		isOK = false;
		dialogMsg('您没有选中任何项,请您选中后再操作。', 0);
	}
	return isOK;
};
checkedRow = function (id) {
	var isOK = true;
	if (id == undefined || id == "" || id == 'null' || id == 'undefined') {
		isOK = false;
		dialogMsg('您没有选中任何数据项,请选中后再操作！', 0);
	}
	//else if (id.split(",").length > 1) {
	//    isOK = false;
	//    dialogMsg('很抱歉,一次只能选择一条记录！', 0);
	//}
	return isOK;
};

function OpenTab(src, tabID, tabName) {
	var menu = '<a href="javascript:;" class="active J_menuTab" id="' + tabID + '" data-id="' + src + '">' + tabName + ' <i class="fa fa-times-circle"></i></a>';//新标签页导航菜单，设为激活张泰
	$(".J_menuTab").removeClass("active");//将原激活状态标签删除
	$(".J_menuTabs .page-tabs-content").append(menu);//加入导航菜单栏
	var content = '<iframe class="J_iframe" name="' + tabID + '" width="100%" height="100%" src="' + src + '" frameborder="0" data-id="' + src + '" seamless></iframe>';//新标签页内容，其name属性是菜单项的ID
	$(".J_mainContent").find("iframe.J_iframe").hide().parents(".J_mainContent").append(content);//加入内容区域
	OpenNewTab($(".J_menuTab.active"));
}
function OpenNewTab(n) {
	var o = f($(n).prevAll())
, q = f($(n).nextAll());
	var l = f($(".content-tabs").children().not(".J_menuTabs"));
	var k = $(".content-tabs").outerWidth(true) - l;
	var p = 0;
	if ($(".page-tabs-content").outerWidth() < k) {
		p = 0
	} else {
		if (q <= (k - $(n).outerWidth(true) - $(n).next().outerWidth(true))) {
			if ((k - $(n).next().outerWidth(true)) > q) {
				p = o;
				var m = n;
				while ((p - $(m).outerWidth()) > ($(".page-tabs-content").outerWidth() - k)) {
					p -= $(m).prev().outerWidth();
					m = $(m).prev()
				}
			}
		} else {
			if (o > (k - $(n).outerWidth(true) - $(n).prev().outerWidth(true))) {
				p = o - $(n).prev().outerWidth(true)
			}
		}
	}
	$(".page-tabs-content").animate({
		marginLeft: 0 - p + "px"
	}, "fast")
}
function f(l) {
	var k = 0;
	$(l).each(function () {
		k += $(this).outerWidth(true)
	});
	return k;
}
function CloseTab() {
	var m = $("a").filter(".active").data("id");
	var j = $("a").filter(".active");
	var l = $(".J_menuTab").width();
	if ($(".J_menuTab").hasClass("active")) {
		if ($(j).next(".J_menuTab").size()) {
			var k = $(j).next(".J_menuTab:eq(0)").data("id");
			$(j).next(".J_menuTab:eq(0)").addClass("active");
			$(".J_mainContent .J_iframe").each(function () {
				if ($(this).data("id") == k) {
					$(this).show().siblings(".J_iframe").hide();
					return false
				}
			});
			var n = parseInt($(".page-tabs-content").css("margin-left"));
			if (n < 0) {
				$(".page-tabs-content").animate({
					marginLeft: (n + l) + "px"
				}, "fast")
			}
			$(j).remove();
			$(".J_mainContent .J_iframe").each(function () {
				if ($(this).data("id") == m) {
					$(this).remove();
					return false
				}
			})
		}
		if ($(j).prev(".J_menuTab").size()) {
			var k = $(j).prev(".J_menuTab:last").data("id");
			$(j).prev(".J_menuTab:last").addClass("active");
			$(".J_mainContent .J_iframe").each(function () {
				if ($(this).data("id") == k) {
					$(this).show().siblings(".J_iframe").hide();
					return false
				}
			});
			$(j).remove();
			$(".J_mainContent .J_iframe").each(function () {
				if ($(this).data("id") == m) {
					$(this).remove();
					return false
				}
			})
		}
	} else {
		$(j).remove();
		$(".J_mainContent .J_iframe").each(function () {
			if ($(this).data("id") == m) {
				$(this).remove();
				return false
			}
		});
		OpenNewTab($(".J_menuTab.active"))
	}
	return false;
}

//载入data-list，使用样例见邮件管理收件人
$.fn.loadDataListItems = function (items, clearOld) {
	if (clearOld != null && clearOld) {
		$(this).empty();
	}
	if (items != null && items.length > 0) {
		var itemArray = items.split(';');
		for (var i = 0; i < itemArray.length; i++) {
			if (new RegExp("(<.*>)").test(itemArray[i])) {
				$(this).addDataListItem(itemArray[i].replace(RegExp.$1, ""), RegExp.$1.replace("<", "").replace(">", ""));
			} else {
				$(this).addDataListItem(itemArray[i], itemArray[i]);
			}
		}
	}
};
//添加data-list子项
$.fn.addDataListItem = function (text, value) {
	var $this = $(this);
	var div = $this.createDataListItem(text, value);
	$this.append(div);
	$(div).tooltip({
		placement: 'bottom',
		container: 'body',
		html: true,
	});
};
//生成data-list子项element
$.fn.createDataListItem = function (text, value) {
	var $this = $(this);
	var div = document.createElement("div");
	div.className = "data-list-item";
	div.setAttribute("data-value", value);
	var textDiv = document.createElement("div");
	textDiv.className = "data-list-item-text";
	textDiv.style.cursor = "default";
	textDiv.innerHTML = text;
	div.appendChild(textDiv);
	div.title = value;
	if (text != value) {
		div.title = "<div style=\"text-align: left;\">名称：" + text + "<br />账号：" + value + "</div>";
	}
	div.onclick = function (e) {
		e.stopPropagation();
		var nodeclick = $this.attr("data-nodeclick");
		if (nodeclick != null && nodeclick.length > 0) {
			eval(nodeclick + "(div)");
		} else {
			if (!$this.hasClass("noinput") && !$this.is('[readonly]')) {
				$(div).hide();
				input = document.createElement("input");
				input.type = "text";
				input.value = text + (text != value ? "<" + value + ">" : "");
				input.placeholder = "请以“文本”或“文本<值>”的格式输入";
				input.onkeypress = function (e) {
					if (e.keyCode == 13) {
						var newText, newValue;
						if (new RegExp("(<.*>)").test(input.value)) {
							newText = input.value.replace(RegExp.$1, "");
							newValue = RegExp.$1.replace("<", "").replace(">", "");
						} else {
							newText = input.value;
							newValue = input.value;
						}
						var newDiv = $this.createDataListItem(newText, newValue);
						$(newDiv).insertBefore(div);
						$(newDiv).tooltip({
							placement: 'bottom',
							container: 'body',
							html: true,
						});
						$(div).tooltip('destroy');
						$(div).remove();
						$(input).remove();
					}
				};
				input.onclick = function (e) {
					e.stopPropagation();
				}
				input.onblur = function () {
					$(div).show();
					$(this).remove();
				};
				$(input).insertBefore(div);
				$(input).focus();
			}
		}
	};
	if (!$this.is('[readonly]')) {
		var span = document.createElement("span");
		span.classList.add("data-list-item-delete");
		span.classList.add("fa");
		span.classList.add("fa-close");
		span.onclick = function (e) {
			e.stopPropagation();
			$(div).tooltip('destroy');
			var nodedelete = $this.attr("data-nodedelete");
			if (nodedelete != null && nodedelete.length > 0) {
				eval(nodedelete + "(div)");
			}
			$(div).remove();
		};
		div.appendChild(span);
	}
	return div;
};
//获取data-list值
$.fn.getDataListValue = function () {
	var rtn = "";
	var items = $(".data-list-item", this);
	for (var i = 0; i < items.length; i++) {
		if (rtn.length > 0) { rtn += ";" }
		var text = $(".data-list-item-text", items[i]).html();
		var value = items[i].getAttribute("data-value");
		rtn += text + (text != value ? "<" + value + ">" : "");
	}
	return rtn;
};
//初始化data-list控件，如果不初始化，则不能实现点击直接输入的功能
$.fn.initDataList = function () {
	$(this).off("click").on("click", function (e) {
		e.stopPropagation();
		if (!$(this).hasClass("noinput")) {
			var input = $("input[type=text]", this);
			if (input.length == 0) {
				input = document.createElement("input");
				input.type = "text";
				input.placeholder = "请以“文本”或“文本<值>”的格式输入";
				input.onkeypress = function (e) {
					if (e.keyCode == 13) {
						$(this).parent().loadDataListItems(input.value, false);
						$(this).remove();
					}
				};
				input.onclick = function (e) {
					e.stopPropagation();
				}
				input.onblur = function () {
					$(this).hide();
				};
				$(this).append(input);
				$(input).focus();
			} else {
				input.show().focus();
			}
		}
	});
};

$.fn.getTableSelectedUniqueId = function () {
	var $table = $(this);
	var data = $table.bootstrapTable('getSelections');
	if (data == null || data.length == 0) {
		return null;
	}
	return data[0][$table.bootstrapTable('getOptions').uniqueId];
};

$.fn.getTableSelectedUniqueIdArray = function () {
	var $table = $(this);
	return $.map($table.bootstrapTable('getSelections'), function (row) {
		return row[$table.bootstrapTable('getOptions').uniqueId];
	});
};

$.CopyObject = function (source, param0, param1) {
	var object = {};
	if (source instanceof Array) {
		object = [];
	}
	var extend;
	var exclusive = null;
	if (param0 instanceof Array) {	//如果第一个参数是数组，则将其作为排除键数组，第二个参数做为扩展属性项
		exclusive = param0;
		extend = param1;
	} else {		//否则第一个参数直接做为扩展属性项
		if (param1 instanceof Array) {	//如果第二个参数是数组，则将其作为排除键数组，否则视为无效参数不予使用
			exclusive = param1;
		}
		extend = param0;
	}
	for (var i in source) {		//循环遍历所有属性，将排除键数组外的所有属性均复制到新对象中
		if (exclusive == null || exclusive.indexOf(i) < 0) {
			object[i] = source[i];
		}
	}
	if (!!extend) {	//如果扩展属性项存在，则将其中的属性复制到新对象中完成扩展动作
		for (var i in extend) {
			object[i] = extend[i];
		}
	}
	return object;
};