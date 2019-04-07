﻿'use strict';
// ==============================================================================
// 框架全局对象
// ==============================================================================
let _zkFramework_ = {
    // ==========================================================================
    // 变量设置
    // ==========================================================================
    _zkSetting_: {
        _iCssZIndex_: 10000//页面元素的Zindex值，堆放顺序，通过_fnGetCssZIndex_获取，不可直接访问
        , _fnGetCssZIndex_: function () {
            let setting = _zkFramework_._zkSetting_;
            return setting._iCssZIndex_++;
        }
        , _sTabViewTabItemIconPrefix_: 'zk-icon-16-'//标签栏标签图标类名前缀
        , _sMainMenuItemIconPrefix_: 'zk-icon-16-'//主菜单图标类名前缀
        , _sTitleBarIconPrefix_: 'zk-icon-16-'//标题栏图标类名前缀
        , _sPanelBigIconPrefix_: 'zk-icon-64-'//面板大图标前缀
        , _sPanelBigIcon_: 'question'//面板大图标
        , _sTitleBarIcon_: 'info'//标题栏图标类名
        , _sTitleBarText_: '面板'//标题栏文字
        , _iTabViewAllowedMaxTabOpenedCount_: 5 //允许打开的最大选项卡数量
        , _iAnimationTransitionTime_: 200//动画过度时间
        , _sLoadingText_: '请稍候...'
        // ======================================================================
        // 初始化变量，可从外部接受参数
        // ======================================================================
        , _zkInitialize_: function (options) {
        }
    }
    // ==========================================================================
    // 页面DOM元素快捷引用
    // ==========================================================================
    , _zkDom_: {
        _zkHtmlTag_: null//Html标签
        , _zkBodyTag_: null//Body标签
        , _zkWrapper_: null//整体包裹器
        , _zkHeaderWrapper_: null//头部包裹器
        , _zkBodyWrapper_: null//身体包裹器
        , _zkMainMenuWrapper_: null//主菜单包裹器
        , _zkContentWrapper_: null//内容包裹器
        , _zkLoadingWrapper_: null//加载包裹器
        , _zkInitialize_: function () {
            let dom = _zkFramework_._zkDom_;
            dom._zkHtmlTag_ = $('#ZkHtmlTag');
            dom._zkBodyTag_ = $('#ZkBodyTag');
            dom._zkWrapper_ = $('#ZkWrapper');
            dom._zkHeaderWrapper_ = $('#ZkHeaderWrapper');
            dom._zkBodyWrapper_ = $('#ZkBodyWrapper');
            dom._zkMainMenuWrapper_ = $('#ZkMainMenuWrapper');
            dom._zkContentWrapper_ = $('#ZkContentWrapper');
            dom._zkLoadingWrapper_ = $('#ZkLoadingWrapper');
        }
    }
    // ==========================================================================
    // UI控件，最小的UI单元
    // ==========================================================================
    , _zkUiControl_: {
        // ======================================================================
        // 文字 Text
        // ======================================================================
        _zkUiControlText_: function (options) {
            //设置参数默认值
            let defaults = {
                id: ''
                , class: ''
                , text: ''
            };

            //判断参数是否为字符串
            if (typeof (options) === 'string') {
                defaults.text = options;
            }

            //参数赋值
            options = $.extend(defaults, options);

            //组装Dom元素
            let $text = $('<span class="zk-text">' + options.text + '</span>');

            //添加属性
            if (options.id) {
                $text.attr('id', options.id);
            }
            if (options.class) {
                $text.addClass(options.class);
            }

            return $text;
        }
        // ======================================================================
        // 图标 Icon
        // ======================================================================
        , _zkUiControlIcon_: function (options) {
            //设置参数默认值
            let defaults = {
                id: ''
                , clsss: ''
                , title: ''
            };

            //判断参数是否为字符串
            if (typeof (options) === 'string') {
                defaults.class = options;
            }

            //参数赋值
            options = $.extend(defaults, options);

            //组装Dom元素
            let $icon = $('<i class="zk-icon"></i>');

            //添加属性
            if (options.id) {
                $icon.attr('id', options.id);
            }
            if (options.class) {
                $icon.addClass(options.class);
            }
            if (options.title) {
                $icon.attr('title', options.title);
            }

            return $icon;
        }
        // ======================================================================
        // 按钮 Button
        // ======================================================================
        , _zkUiControlButton_: function (options) {
            //设置参数默认值
            let defaults = {
                id: ''
                , clsss: 'btn-primary'
                , title: ''
                , text: ''
            };

            //参数赋值
            options = $.extend(defaults, options);

            //组装Dom元素
            let $button = $('<button type="button" class="zk-button btn"></button>');

            //添加属性
            if (options.id) {
                $button.attr('id', options.id);
            }
            if (options.class) {
                $button.addClass(options.class);
            }
            if (options.title) {
                $button.attr('title', options.title);
            }
            if (options.text) {
                $button.text(options.text);
            }

            return $button;
        }
        // ======================================================================
        // 水平分隔线 Hr
        // ======================================================================
        , _zkUiControlHr_: function () {
            let $hr = $('<div class="zk-hr"></div>');
            return $hr;
        }
        // ======================================================================
        // 加载动画层 Loading
        // ======================================================================
        , _zkUiControlLoading_: function () {
            let $loading = $('<div class="loadingIcon"><i></i></div>');
            return $loading;
        }
        // ======================================================================
        // 透明遮罩层 Mask
        // ======================================================================
        , _zkUiControlMask_: function () {
            let setting = _zkFramework_._zkSetting_;

            let $mask = $('<div class="zk-mask"></div>')._zkGetZIndex_();
            return $mask;
        }
        // ======================================================================
        // 边框 Border
        // ======================================================================
        , _zkUiControlBorder_: function (options) {
            let defaults = {
                id: ''
                , clsss: ''
                , title: ''
            };
            options = $.extend(defaults, options);

            let $border = $('<div class="zk-border"></div>');

            if (options.id) {
                $border.attr('id', options.id);
            }
            if (options.class) {
                $border.addClass(options.class);
            }
            if (options.class) {
                $border.attr('title', options.title);
            }

            return $border;
        }
        // ======================================================================
        // 框架结构 Iframe
        // ======================================================================
        , _zkUiControlIframe_: function (options) {
            let defaults = {
                id: ''
                , clsss: ''
                , src: ''
            };
            options = $.extend(defaults, options);

            let $border = $('<iframe class="zk-iframe"></iframe>');

            if (options.id) {
                $border.attr('id', options.id);
            }
            if (options.class) {
                $border.addClass(options.class);
            }

            if (options.src) {
                $border.attr('src', options.src);
            }

            return $border;
        }
    }
    // ==========================================================================
    // UI组件，由UI控件组合而成
    // ==========================================================================
    , _zkUiComponent_: {
        // ======================================================================
        // 信息框 Alert
        // ======================================================================
        _zkUiAlert_: function (options) {
            //快捷引用
            let dom = _zkFramework_._zkDom_;
            let control = _zkFramework_._zkUiControl_;
            let component = _zkFramework_._zkUiComponent_;
            let setting = _zkFramework_._zkSetting_;

            //设置默认值
            let defaults = {
                id: ''
                , clsss: ''
                , title: '信息'
                , icon: setting._sTitleBarIcon_
                , bigIcon: setting._sPanelBigIcon_
                , message: ''
                , desc: ''
                , okText: '确定'
                , callback: null
            };
            options = $.extend(defaults, options);

            //拼装元素
            let $overallMask = control._zkUiControlMask_();
            let panel = component._zkUiPanel_._create_({
                class: 'zk-panel-alert'
                , title: options.title
                , icon: options.icon
                , closeCallback: function () {
                    $overallMask._zkFadeOut_(setting._iAnimationTransitionTime_);
                    if (options.callback) {
                        options.callback();
                    }
                }
            });
            let $wrapper = panel._component_._wrapper_;
            let $titlebar = panel._component_._titlebar_;
            let $contentwrapper = panel._component_._contentwrapper_;

            dom._zkBodyTag_.append($overallMask);
            dom._zkBodyTag_.append($wrapper);

            $wrapper.css({
                'margin-top': -$wrapper.outerHeight() / 2
                , 'margin-left': -$wrapper.outerWidth() / 2
            });
            let $bigicon = control._zkUiControlIcon_({
                class: setting._sPanelBigIconPrefix_ + options.bigIcon + ' zk-panel-alert-bigicon'
            });
            let $infolist = control._zkUiControlBorder_({
                class: 'zk-panel-alert-infolist'
            });
            let $messagelist = control._zkUiControlBorder_({
                class: 'zk-panel-alert-messagelist'
            });
            let $message = control._zkUiControlText_({
                class: 'zk-panel-alert-message'
                , text: options.message
            });
            $messagelist.append($message);
            let $desclist = control._zkUiControlBorder_({
                class: 'zk-panel-alert-desclist'
            });
            let $desc = control._zkUiControlText_({
                class: 'zk-panel-alert-desc'
                , text: options.desc
            });
            $desclist.append($desc);
            let $btnlist = control._zkUiControlBorder_({
                class: 'zk-panel-alert-btnlist'
            });
            let $okbtn = control._zkUiControlButton_({
                class: 'btn btn-primary btn-sm zk-panel-alert-okbtn',
                text: options.okText
            });
            $btnlist.append($okbtn);
            $okbtn.click(function () {
                $(this).blur();
                $wrapper._zkFadeOut_(setting._iAnimationTransitionTime_, function () {
                    $overallMask._zkFadeOut_(setting._iAnimationTransitionTime_);
                    if (options.callback) {
                        options.callback();
                    }
                })
            });
            $infolist.append($messagelist).append($desclist).append($btnlist);
            $contentwrapper.append($bigicon).append($infolist);
            $wrapper.fadeIn(setting._iAnimationTransitionTime_, function () {
                $okbtn.focus();
            });
        }
        // ======================================================================
        // 询问框 Confirm
        // ======================================================================
        , _zkUiConfirm_: function (options) { }
        // ======================================================================
        // 消息框 Message，可自动关闭
        // ======================================================================
        , _zkUiMessage_: function (options) { }
        // ======================================================================
        // 弹出提示框 Popup
        // ======================================================================
        , _zkUiPopup_: function (options) { }
        // ======================================================================
        // 标签视图 TabView
        // ======================================================================
        , _zkUiTabView_: {
            // ==================================================================
            // 添加标签项
            // ==================================================================
            _addTabItem_: function (options) {
                let setting = _zkFramework_._zkSetting_;
                let member = _zkFramework_._zkUiComponent_._zkUiTabView_._member_;
                let tvComponent = _zkFramework_._zkUiComponent_._zkUiTabView_;
                let component = _zkFramework_._zkUiComponent_;

                let defaults = {
                    id: ''
                    , title: ''
                    , icon: 'list'
                    , src: ''
                    , isIframe: false
                    , isClosable: true
                };
                options = $.extend(defaults, options);

                if ($._zkIsInArray_(member._aOpendTabs_, options.id)) {
                    if (member._sFocusTabId_ === options.id) {
                        component._zkUiAlert_({
                            title: '标签页已打开'
                            , message: '标签页已打开'
                            , bigIcon: 'tab'
                            , okText: '我知道了'
                        });
                    } else {
                        tvComponent._focusTabItem_(options.id);
                    }
                } else {
                    if (member._aOpendTabs_.length >= setting._iTabViewAllowedMaxTabOpenedCount_) {
                        component._zkUiAlert_({
                            title: '限制'
                            , message: '打开最大数限制'
                            , desc: '出于浏览器性能的考虑，本系统最多只允许同时打开【' + setting._iTabViewAllowedMaxTabOpenedCount_ + '】个标签页面'
                            , bigIcon: 'tab'
                            , okText: '我知道了'
                        });
                    }
                    else {
                        tvComponent._createTabItem_(options);
                    }
                }
            }
            // ==================================================================
            // 聚焦标签项
            // ==================================================================
            , _focusTabItem_: function (tabId) {
                let control = _zkFramework_._zkUiControl_;
                let setting = _zkFramework_._zkSetting_;
                let ui = _zkFramework_._zkUiComponent_;
                let tvComponent = _zkFramework_._zkUiComponent_._zkUiTabView_._component_;
                let member = _zkFramework_._zkUiComponent_._zkUiTabView_._member_;

                tvComponent._tabViewTabBarTagGroupInnerWrapper_.find('#Tab_TabBar_' + tabId).addClass('on').siblings().removeClass('on');
                tvComponent._tabViewContentViewWrapper_.find('#Tab_Content_' + tabId).show().addClass('on').siblings().removeClass('on').hide();
                member._sFocusTabId_ = tabId;
            }
            // ==================================================================
            // 关闭标签项
            // ==================================================================
            , _closeTabItem_: function (tabId) {
                let control = _zkFramework_._zkUiControl_;
                let setting = _zkFramework_._zkSetting_;
                let ui = _zkFramework_._zkUiComponent_;
                let tvComponent = _zkFramework_._zkUiComponent_._zkUiTabView_._component_;
                let member = _zkFramework_._zkUiComponent_._zkUiTabView_._member_;

                //移除标签和内容
                tvComponent._tabViewTabBarTagGroupInnerWrapper_.find('#Tab_TabBar_' + tabId).remove();
                tvComponent._tabViewContentViewWrapper_.find('#Tab_Content_' + tabId).remove();

                //从打开列表中移除相应项
                let tabIndex = 0;
                for (let i = 0, len = member._aOpendTabs_.length; i < len; i++) {
                    let item = member._aOpendTabs_[i];
                    if (item.id === tabId && item.isClosable === true) {
                        member._aOpendTabs_.splice(i, 1);
                        tabIndex = i;
                        break;
                    }
                }
                if (tabId === member._sFocusTabId_) {
                    if (tabIndex === member._aOpendTabs_.length) {
                        tabIndex--;
                    }
                    ui._zkUiTabView_._focusTabItem_(member._aOpendTabs_[tabIndex].id);
                }
            }
            // ==================================================================
            // 刷新标签项
            // ==================================================================
            , _refreshTabItem_: function (tabId) { }
            // ==================================================================
            // 创建标签项
            // ==================================================================
            , _createTabItem_: function (options) {
                let control = _zkFramework_._zkUiControl_;
                let setting = _zkFramework_._zkSetting_;
                let ui = _zkFramework_._zkUiComponent_;
                let tvComponent = _zkFramework_._zkUiComponent_._zkUiTabView_._component_;
                let member = _zkFramework_._zkUiComponent_._zkUiTabView_._member_;

                //构建标签
                let $tabItemWrapper = control._zkUiControlBorder_({
                    id: 'Tab_TabBar_' + options.id
                    , class: 'zk-tvtb-item-wrapper'
                });
                let $icon = control._zkUiControlIcon_({
                    class: 'zk-tvtb-item-icon ' + setting._sTabViewTabItemIconPrefix_ + options.icon
                });
                let $text = control._zkUiControlText_(options.title);
                let $closeIcon = control._zkUiControlIcon_({
                    class: 'zk-tvtb-item-closeIcon ' + setting._sTabViewTabItemIconPrefix_ + 'tabViewTagOpitionClose'
                    , title: '关闭该标签页'
                });
                $tabItemWrapper.append($icon).append($text);

                if (options.isClosable) {
                    $tabItemWrapper.append($closeIcon);
                    $closeIcon.click(function (e) {
                        e.stopPropagation();
                        ui._zkUiTabView_._closeTabItem_(options.id);
                    });
                }

                tvComponent._tabViewTabBarTagGroupInnerWrapper_.append($tabItemWrapper);

                $tabItemWrapper
                    //单击聚焦
                    .click(function (e) {
                        if (e.which === 1) {
                            ui._zkUiTabView_._focusTabItem_(options.id);
                        }
                    })
                    //右键菜单
                    .mouseup(function (e) {
                    });

                //构建内容
                if (options.isIframe) {
                    //Iframe
                    let $iframe = control._zkUiControlIframe_({
                        id: 'Tab_Content_' + options.id
                        , class: 'zk-iframe-tvc'
                        , src: options.src
                    })._zkGetZIndex_();
                    tvComponent._tabViewContentViewWrapper_.append($iframe);
                } else {
                    //单页面
                    let $panelPage = control._zkUiControlBorder_({
                        id: 'Tab_Content_' + options.id
                        , class: 'zk-page-tvc'
                    })._zkGetZIndex_();
                    tvComponent._tabViewContentViewWrapper_.append($panelPage);
                    _zkFramework_._zkHttp_._zkHttpGet_({
                        url: options.src
                        , dataType: 'html'
                        , mask: true
                        , loadingTxt: '页面加载中，请稍候...'
                        , done: function (htmlText) {
                            $panelPage.append(htmlText);
                        }
                    });
                }

                //添加至成员变量中
                member._aOpendTabs_.push(options);
                ui._zkUiTabView_._focusTabItem_(options.id);
            }
            // ==================================================================
            // 关闭所有标签项
            // ==================================================================
            , _closeAllTabItems_: function () { }
            // ==================================================================
            // 关闭左侧标签项
            // ==================================================================
            , _closeLeftTabItems_: function (tabId) { }
            // ==================================================================
            // 关闭右侧标签项
            // ==================================================================
            , _closeRightTabItems_: function (tabId) { }
            // ==================================================================
            // 关闭其它标签项
            // ==================================================================
            , _closeOtherTabItems_: function (tabId) { }
            // ==================================================================
            // TabView组件
            // ==================================================================
            , _component_: {
                _tabViewWrapper_: null//整体包裹器
                , _tabViewTabBarWrapper_: null//标签栏包裹器
                , _tabViewTabBarTagGroupWrapper_: null//标签栏标签组包裹器
                , _tabViewTabBarTagGroupInnerWrapper_: null//标签栏标签组内层包裹器
                , _tabViewTabBarOptionWrapper_: null//标签栏选项栏包裹器
                , _tabViewContentViewWrapper_: null//标签内容试图包裹器
                , _zkInitialize_: function () {
                    //快捷引用
                    let dom = _zkFramework_._zkDom_;
                    let control = _zkFramework_._zkUiControl_;
                    let component = _zkFramework_._zkUiComponent_;

                    this._tabViewWrapper_ = control._zkUiControlBorder_({
                        id: 'ZkTabViewWrapper'
                    });
                    this._tabViewTabBarWrapper_ = control._zkUiControlBorder_({
                        id: 'ZkTabViewTabBarWrapper'
                    });
                    this._tabViewTabBarTagGroupWrapper_ = control._zkUiControlBorder_({
                        id: 'ZkTabViewTabBarTagGroupWrapper'
                    });
                    this._tabViewTabBarTagGroupInnerWrapper_ = control._zkUiControlBorder_({
                        id: 'ZkTabViewTabBarTagGroupInnerWrapper'
                    });
                    this._tabViewTabBarOptionWrapper_ = control._zkUiControlBorder_({
                        id: 'ZkTabViewTabBarOptionWrapper'
                    });
                    this._tabViewContentViewWrapper_ = control._zkUiControlBorder_({
                        id: 'ZkTabViewContentViewWrapper'
                    });
                    this._tabViewWrapper_
                        .append(this._tabViewTabBarWrapper_
                            .append(this._tabViewTabBarTagGroupWrapper_
                                .append(this._tabViewTabBarTagGroupInnerWrapper_)
                            )
                            .append(this._tabViewTabBarOptionWrapper_)
                            .contextmenu(function () {
                                //屏蔽右键
                                return false;
                            })
                        )
                        .append(this._tabViewContentViewWrapper_);
                    let $optionIcon = control
                        ._zkUiControlIcon_({
                            id: 'ZkTvtbbOptionIcon'
                            , class: 'zk-icon-24-list'
                        });
                    this._tabViewTabBarOptionWrapper_
                        .append($optionIcon)
                        .attr('title', '已打开标签页列表')
                        .click(function () {
                            let $me = $(this);
                            let isOpendCm = $('#ZkTvtbbOptionIconCm');
                            if (isOpendCm.length > 0) {
                                isOpendCm._zkFadeOut_();
                                return;
                            }
                            let iTop = $me.offset().top + $me.height();
                            let tabview = _zkFramework_._zkUiComponent_._zkUiTabView_;
                            let opendTabs = _zkFramework_._zkUiComponent_._zkUiTabView_._member_._aOpendTabs_;
                            let focusTabId = _zkFramework_._zkUiComponent_._zkUiTabView_._member_._sFocusTabId_;
                            let contextmenu = component._zkUiContextMenu_._create_({
                                id: 'ZkTvtbbOptionIconCm'
                                , top: iTop
                                , right: 10
                            });
                            for (let i = 0, len = opendTabs.length; i < len; i++) {
                                contextmenu._addItem_(component._zkUiContextMenuItem_._create_({
                                    title: opendTabs[i].title
                                    , icon: opendTabs[i].icon
                                    , option: opendTabs[i].isClosable ? 'close' : null
                                    , isActivated: opendTabs[i].id == focusTabId ? true : false
                                    , clickCallback: function () {
                                        tabview._focusTabItem_(opendTabs[i].id);
                                    }
                                    , optionCallback: function () {
                                        tabview._closeTabItem_(opendTabs[i].id);
                                    }
                                }));
                            }
                            contextmenu._show_();
                        });
                }
            }
            // ==================================================================
            // TabView成员变量
            // ==================================================================
            , _member_: {
                _aOpendTabs_: []//已打开标签列表
                , _sFocusTabId_: ''//当前聚焦的标签页Id
            }
            // ==================================================================
            // 初始化方法
            // ==================================================================
            , _zkInitialize_: function () {
                let dom = _zkFramework_._zkDom_;
                this._component_._zkInitialize_();
                dom._zkContentWrapper_.append(this._component_._tabViewWrapper_);
            }
        }
        // ======================================================================
        // 菜单视图 MenuView
        // ======================================================================
        , _zkUiMenuView_: {
            // ==================================================================
            // 创建菜单
            // ==================================================================
            _createMenu_: function (options) {
                for (let i = 0, len = options.length; i < len; i++) {
                    this._addMenuItem_(options[i]);
                }
            }
            // ==================================================================
            // 添加菜单项
            // ==================================================================
            , _addMenuItem_: function (options) {
                let control = _zkFramework_._zkUiControl_;
                let component = _zkFramework_._zkUiComponent_;
                let setting = _zkFramework_._zkSetting_;

                let menuItemWrapper = control._zkUiControlBorder_({
                    class: 'zk-mainmenuitem-wrapper'
                });
                let menuItemInnerWrapper = control._zkUiControlBorder_({
                    class: 'zk-mainmenuitem-innerwrapper'
                });
                let miIcon = control._zkUiControlIcon_({
                    class: setting._sMainMenuItemIconPrefix_ + options.Icon + ' zk-mainmenuitem-icon'
                });
                let miTitle = control._zkUiControlText_({
                    class: 'zk-mainmenuitem-text'
                    , text: options.Title
                });
                menuItemInnerWrapper.append(miIcon).append(miTitle);
                menuItemWrapper.append(menuItemInnerWrapper);
                component._zkUiMenuView_._component_._MenuViewWrapper_.append(menuItemWrapper);

                if (options.IsLeaf) {
                    menuItemWrapper.click(function () {
                        component._zkUiTabView_._addTabItem_({
                            id: options.Code
                            , icon: options.Icon
                            , title: options.Title
                            , isIframe: true
                            , isClosable: true
                            , src: options.Url
                        })
                    });
                    return;
                }

                let menuItemGroupWraper = control._zkUiControlBorder_({
                    class: 'zk-mainmenusubitem-groupwrapper'
                });

                for (let i = 0, len = options.NodeList.length; i < len; i++) {
                    this._addMenuSubItem_(options.NodeList[i], menuItemGroupWraper)
                }
                if (menuItemGroupWraper.children().length > 0) {
                    menuItemWrapper.append(menuItemGroupWraper);
                    menuItemInnerWrapper.click(function () {
                        menuItemGroupWraper.slideToggle(setting._iAnimationTransitionTime_);
                    });
                }
            }
            // ==================================================================
            // 添加子菜单项
            // ==================================================================
            , _addMenuSubItem_: function (options, groupwrapper) {
                let control = _zkFramework_._zkUiControl_;
                let component = _zkFramework_._zkUiComponent_;
                let setting = _zkFramework_._zkSetting_;

                let menuSubItemWrapper = control._zkUiControlBorder_({
                    class: 'zk-mainmenusubitem-wrapper'
                });
                let menuSubItemInnerWrapper = control._zkUiControlBorder_({
                    class: 'zk-mainmenusubitem-innerwrapper'
                });
                let miIcon = control._zkUiControlIcon_({
                    class: setting._sMainMenuItemIconPrefix_ + options.Icon + ' zk-mainmenusubitem-icon'
                });
                let miTitle = control._zkUiControlText_({
                    class: 'zk-mainmenusubitem-text'
                    , text: options.Title
                });

                menuSubItemInnerWrapper.append(miIcon).append(miTitle);
                menuSubItemWrapper.append(menuSubItemInnerWrapper);
                groupwrapper.append(menuSubItemWrapper).hide();

                if (options.IsLeaf) {
                    menuSubItemWrapper.click(function () {
                        component._zkUiTabView_._addTabItem_({
                            id: options.Code
                            , icon: options.Icon
                            , title: options.Title
                            , isIframe: options.IsIframe
                            , isClosable: true
                            , src: options.Url
                        })
                    });
                }
            }
            // ==================================================================
            // MenuView组件
            // ==================================================================
            , _component_: {
                _MenuViewWrapper_: null//整体包裹器
                , _zkInitialize_: function (options) {
                    //快捷引用
                    let dom = _zkFramework_._zkDom_;
                    let control = _zkFramework_._zkUiControl_;
                    let component = _zkFramework_._zkUiComponent_;

                    this._MenuViewWrapper_ = control._zkUiControlBorder_({
                        id: 'ZkMenuViewWrapper'
                    });
                    component._zkUiMenuView_._createMenu_(options);
                }
            }
            // ==================================================================
            // 初始化方法
            // ==================================================================
            , _zkInitialize_: function (options) {
                let dom = _zkFramework_._zkDom_;
                this._component_._zkInitialize_(options);
                dom._zkMainMenuWrapper_.append(this._component_._MenuViewWrapper_);
            }
        }
        // ======================================================================
        // 上下文菜单 ContextMenu
        // ======================================================================
        , _zkUiContextMenu_: {
            _create_: function (options) {
                //快捷引用
                let control = _zkFramework_._zkUiControl_;
                let dom = _zkFramework_._zkDom_;
                let comp = this._component_;
                let setting = _zkFramework_._zkSetting_;

                //设置参数默认值
                let defaults = {
                    id: ''
                    , class: ''
                    , top: null
                    , left: null
                    , right: null
                    , bottom: null
                };

                //参数赋值
                options = $.extend(defaults, options);

                let $cm = control._zkUiControlBorder_({
                    class: 'zk-contextmenu-wrapper'
                });

                //添加属性
                if (options.id) {
                    $cm.attr('id', options.id);
                }
                if (options.class) {
                    $cm.addClass(options.class);
                }
                if (options.top) {
                    $cm.css({ top: options.top });
                }
                if (options.left) {
                    $cm.css({ left: options.left });
                }
                if (options.right) {
                    $cm.css({ right: options.right });
                }
                if (options.bottom) {
                    $cm.css({ bottom: options.bottom });
                }

                dom._zkBodyTag_.append($cm)
                comp._wrapper_ = $cm;

                return this;
            }
            , _show_: function () {
                if (this._component_._wrapper_ == undefined) {
                    return;
                }
                //快捷引用
                let dom = _zkFramework_._zkDom_;
                let setting = _zkFramework_._zkSetting_;
                let $this = this;
                this._component_._wrapper_.fadeIn(setting._iAnimationTransitionTime_, function () {
                    dom._zkBodyTag_.one('click', function () {
                        $this._hide_();
                    });
                });
            }
            , _hide_: function () {
                if (this._component_._wrapper_ == undefined) {
                    return;
                }
                let setting = _zkFramework_._zkSetting_;
                this._component_._wrapper_._zkFadeOut_(setting._iAnimationTransitionTime_);
            }
            , _addItem_: function (item) {
                this._component_._wrapper_.append(item._component_._wrapper_);
            }
            , _component_: {
                _wrapper_: null
            }
        }
        // ======================================================================
        // 上下文菜单项 ContextMenuItem
        // ======================================================================
        , _zkUiContextMenuItem_: {
            _create_: function (options) {
                //快捷引用
                let control = _zkFramework_._zkUiControl_;
                let dom = _zkFramework_._zkDom_;
                let comp = this._component_;
                let setting = _zkFramework_._zkSetting_;

                //设置参数默认值
                let defaults = {
                    id: ''
                    , class: ''
                    , icon: 'file'
                    , title: ''
                    , isActivated: false
                    , option: null
                    , clickCallback: null
                    , optionCallback: null
                };

                //参数赋值
                options = $.extend(defaults, options);

                let $cmi = control._zkUiControlBorder_({
                    class: 'zk-contextmenuitem-wrapper'
                });
                let $cmiWrapper = control._zkUiControlBorder_({
                    class: 'zk-contextmenuitem-innerwrapper'
                });
                $cmi.append($cmiWrapper);

                //添加属性
                if (options.id) {
                    $cmi.attr('id', options.id);
                }
                if (options.class) {
                    $cmi.addClass(options.class);
                }
                if (options.icon) {
                    comp._icon_ = control._zkUiControlIcon_({
                        class: setting._sTabViewTabItemIconPrefix_ + options.icon
                    });
                    $cmiWrapper.append(comp._icon_);
                }
                if (options.title) {
                    comp._text_ = control._zkUiControlText_({
                        text: options.title
                    });
                    $cmiWrapper.append(comp._text_);
                }
                if (options.isActivated) {
                    $cmiWrapper.addClass('zk-on');
                }
                if (options.option) {
                    comp._option_ = control._zkUiControlIcon_({
                        class: setting._sTabViewTabItemIconPrefix_ + 'tabViewTagOpitionClose'
                    }).addClass('zk-contextmenuitem-option');
                    $cmi.append(comp._option_);
                    if (options.optionCallback) {
                        comp._option_.click(function () {
                            options.optionCallback();
                        });
                    }
                }
                comp._wrapper_ = $cmi;

                if (options.clickCallback) {
                    $cmiWrapper.click(function () {
                        options.clickCallback();
                    });
                }
                return this;
            }
            , _component_: {
                _wrapper_: null
                , _itemWrapper_: null
                , _icon_: null
                , _text_: null
                , _option_: null
            }
        }
        // ======================================================================
        // 加载面板 LoadingPanel
        // ======================================================================
        , _zkUiLoadingPanel_: function (options) {
            let control = _zkFramework_._zkUiControl_;
            let setting = _zkFramework_._zkSetting_;
            let ui = _zkFramework_._zkUiComponent_;

            let defaults = {
                id: ''
                , clsss: ''
                , text: ''
            };
            options = $.extend(defaults, options);

            let $wrapper = control._zkUiControlBorder_({
                id: options.id
                , class: options.class
            }).addClass('zk-loadingPanel');

            let $loadingIcon = control._zkUiControlLoading_();
            let $text = control._zkUiControlText_(options.text);

            $wrapper.append($loadingIcon);

            if (options.text) {
                $loadingIcon.css({
                    'margin-right': '10px'
                });
                $wrapper.append($text);
            }

            return $wrapper;
        }
        // ======================================================================
        // 面板 Panel
        // ======================================================================
        , _zkUiPanel_: {
            _create_: function (options) {
                //快捷引用
                let control = _zkFramework_._zkUiControl_;
                let dom = _zkFramework_._zkDom_;
                let component = this._component_;
                let setting = _zkFramework_._zkSetting_;

                //设置参数默认值
                let defaults = {
                    id: ''
                    , class: ''
                    , title: setting._sTitleBarText_
                    , icon: setting._sTitleBarIcon_
                    , isClosable: true
                    , openCallback: null
                    , closeCallback: null
                };

                //参数赋值
                options = $.extend(defaults, options);

                let $panel = control._zkUiControlBorder_({
                    class: 'zk-panel'
                });

                //添加属性
                if (options.id) {
                    $panel.attr('id', options.id);
                }
                if (options.class) {
                    $panel.addClass(options.class);
                }

                let $titleBar = control._zkUiControlBorder_({
                    class: 'zk-panel-titlebar'
                });
                let $titleBarInner = control._zkUiControlBorder_({
                    class: 'zk-panel-titlebarinner'
                });
                let $titleBarIcon = control._zkUiControlIcon_({
                    class: setting._sTitleBarIconPrefix_ + options.icon + ' zk-panel-titlebaricon'
                });
                let $titleBarText = control._zkUiControlText_({
                    class: 'zk-panel-titlebartext',
                    text: options.title
                });
                $titleBarInner.append($titleBarText);
                $titleBar.append($titleBarInner).append($titleBarIcon);
                $panel.append($titleBar);
                if (options.isClosable) {
                    let $titleBarOption = control._zkUiControlBorder_({
                        class: 'zk-panel-titlebarOption'
                        , title: '关闭'
                    }).html('<span>X</span>');
                    $titleBar.append($titleBarOption);
                    $titleBarOption.click(function () {
                        $panel._zkFadeOut_(setting._iAnimationTransitionTime_, function () {
                            if (options.closeCallback) {
                                options.closeCallback();
                            }
                        });
                    });
                }
                let $contentwrapper = control._zkUiControlBorder_({
                    class: 'zk-panel-contentwrapper'
                });
                $panel.append($contentwrapper);
                component._wrapper_ = $panel._zkGetZIndex_();
                component._titlebar_ = $titleBar;
                component._contentwrapper_ = $contentwrapper;
                return this;
            }
            , _component_: {
                _wrapper_: null,
                _titlebar_: null,
                _contentwrapper_: null
            }
        }
    }
    // ==========================================================================
    // Ajax请求快捷方式
    // ==========================================================================
    , _zkHttp_: {
        // ======================================================================
        // Ajax请求
        // ======================================================================
        _zkHttpAjax_: function (options) {
            let control = _zkFramework_._zkUiControl_;
            let setting = _zkFramework_._zkSetting_;
            let ui = _zkFramework_._zkUiComponent_;
            let dom = _zkFramework_._zkDom_;

            let defaults = {
                url: null//访问路径
                , type: 'POST'//访问方式POST或者GET
                , dataType: 'json'//返回数据格式
                , data: null//提交数据
                , mask: false//是否需要全屏遮罩层
                , loadingTxt: setting._sLoadingText_//全屏遮罩层加载文字
                , done: null//Http请求成功时的回调
                , fail: null//Http请求失败时的回调
                , always: null//始终执行的回调
            };
            options = $.extend(defaults, options);

            let $mask = null;
            let $loadingPanel = null;
            let showLoadingIntervalId = 0;

            //需要添加遮罩层
            if (options.mask) {
                $mask = control._zkUiControlMask_();
                $loadingPanel = ui._zkUiLoadingPanel_({
                    text: options.loadingTxt
                })._zkGetZIndex_().css({ opacity: 0 });
                dom._zkBodyTag_.append($mask).append($loadingPanel);
                showLoadingIntervalId = setTimeout(showLoadingMask, 1000);
            }

            $.ajax({
                url: options.url
                , type: options.type
                , timeout: setting._iHttpAjaxTimeout_
                , dataType: options.dataType
                , data: options.data
                , cache: false
            })
                .done(function (data) {
                    if (options.done) {
                        options.done(data);
                    }
                })
                .fail(function (data) {
                    if (options.fail) {
                        let errorMessage = '请求失败，请稍候重试';
                        if (data.statusText === 'timeout') {
                            errorMessage = '请求超时，请重试';
                        } else if (data.statusText === 'error') {
                            if (data.status === 404) {
                                errorMessage = '你请求的资源不存在';
                            } else if (data.status === 500) {
                                errorMessage = '服务器发生错误，请稍候重试';
                            }
                        }
                        options.fail(errorMessage);
                    }
                })
                .always(function () {
                    if (options.always) {
                        options.always();
                    }
                    if ($mask) {
                        $mask._zkFadeOut_(setting._iAnimationTransitionTime_);
                    }
                    if ($loadingPanel) {
                        $loadingPanel._zkFadeOut_(setting._iAnimationTransitionTime_);
                    }
                    if (showLoadingIntervalId > 0) {
                        clearTimeout(showLoadingIntervalId);
                    }
                });
            function showLoadingMask() {
                $loadingPanel
                    .css({ 'margin-left': -($loadingPanel.outerWidth() / 2) })
                    .animate({ 'opacity': 1 });
                $mask.animate({ 'opacity': 0.7 });
            }
        }
        // ======================================================================
        // Post请求
        // ======================================================================
        , _zkHttpPost_: function (options) {
            options.type = 'POST';
            _zkFramework_._zkHttp_._zkHttpAjax_(options);
        }
        // ======================================================================
        // Get请求
        // ======================================================================
        , _zkHttpGet_: function (options) {
            options.type = 'GET';
            _zkFramework_._zkHttp_._zkHttpAjax_(options);
        }
    }
    // ==========================================================================
    // 帮助方法
    // ==========================================================================
    , _zkHelper_: {}
    // ==========================================================================
    // 整体初始化
    // ==========================================================================
    , _zkInitialize_: function (options) {
        let dom = _zkFramework_._zkDom_;
        let setting = _zkFramework_._zkSetting_;
        let component = _zkFramework_._zkUiComponent_;
        let post = _zkFramework_._zkHttp_._zkHttpPost_;

        dom._zkInitialize_();
        setting._zkInitialize_(options);
        component._zkUiTabView_._zkInitialize_();
        component._zkUiTabView_._addTabItem_({
            id: 'ZkMyHomePage'
            , icon: 'desktop'
            , title: '我的首页'
            , isIframe: true
            , isClosable: false
            , src: 'http://map.baidu.com/'
        });

        post({
            'url': '/MainMenu/GetList/'
            , 'done': function (json) {
                if (json.IsSuccess) {
                    component._zkUiMenuView_._zkInitialize_(json.Datas);
                    dom._zkLoadingWrapper_._zkFadeOut_();
                } else {
                    alert(json.Message);
                }
            }
        });
    }
};

// ==============================================================================
// 暴露相应的方法
// ==============================================================================
let zk = {
    initialize: _zkFramework_._zkInitialize_
    , alert: _zkFramework_._zkUiComponent_._zkUiAlert_
    , confirm: _zkFramework_._zkUiComponent_._zkUiConfirm_
    , popup: _zkFramework_._zkUiComponent_._zkUiPopup_
    , Message: _zkFramework_._zkUiComponent_._zkUiMessage_
    , addTabItem: _zkFramework_._zkUiComponent_._zkUiTabView_._addTabItem_
    , post: _zkFramework_._zkHttp_._zkHttpPost_
    , get: _zkFramework_._zkHttp_._zkHttpGet_
};

// ==================================================================================
// jquery的扩展方法
// ==================================================================================
(function ($) {
    // ==============================================================================
    // 实例扩展方方法
    // ==============================================================================
    $.fn.extend({
        // ==========================================================================
        // 元素消失后，将其从DOM树中删除掉
        // ==========================================================================
        _zkFadeOut_: function (duration, callback) {
            let $this = $(this);
            $this.fadeOut(duration, function () {
                $this.remove();
                if (callback) {
                    callback();
                }
            });
        }
        // ==========================================================================
        // 给元素添加zIndex，并将其返回
        // ==========================================================================
        , _zkGetZIndex_: function () {
            let setting = _zkFramework_._zkSetting_;
            let $this = $(this);
            $this.css({ 'z-index': setting._fnGetCssZIndex_() });
            return $this;
        }
        // ==========================================================================
        // 鼠标进入元素，然后离开
        // 在second时间内回到元素中，则不执行callback
        // 否则执行callback
        // ==========================================================================
        , _zkStayOn_: function (callback, second) {
            let $this = $(this);
            let iTimeoutId = 0;
            $this.on('mouseenter', function () {
                if (iTimeoutId > 0) {
                    clearTimeout(iTimeoutId);
                }
            }).on('mouseleave', function () {
                iTimeoutId = setTimeout(callback, second);
            });
            return $this;
        }
        , _zkPopup_: function (callback, second) {
            let $this = $(this);
            $this.fadeIn(500);
        }
    });

    // ==============================================================================
    // 静态扩展方方法
    // ==============================================================================
    $.extend({
        // ==========================================================================
        // 判断value是否存在于数组中
        // ==========================================================================
        _isInArray_: function (arr, value) {
            let index = $.inArray(value, arr);
            if (index >= 0) {
                return true;
            }
            return false;
        }
        // ==========================================================================
        // 判断value是否存在于数组项的Id中(不通用)
        // ==========================================================================
        , _zkIsInArray_: function (arr, value) {
            for (let i = 0, len = arr.length; i < len; i++) {
                if (arr[i].id === value) {
                    return true;
                }
            }
            return false;
        }
    });
})(jQuery);