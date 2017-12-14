$(document).ready(function () {
    var Menu = {
        el: {
            ham: $('.menu-header'),
            menuTop: $('.menu-top'),
            menuMiddle: $('.menu-middle'),
            menuBottom: $('.menu-bottom')
        },

        init: function () {
            Menu.bindUIactions();
        },

        bindUIactions: function () {
            Menu.el.ham
                .on(
                  'click',
                function (event) {
                    Menu.activateMenu(event);
                    event.preventDefault();
                    if ($('.menu-list').position().left == 0) {
                        $('.menu-list').animate({ left: '-315px' }, 'slow');
                    }
                    else {
                        $('.menu-list').animate({ left: '0' }, 'slow');
                    }
                }
            );
        },

        activateMenu: function () {
            Menu.el.menuTop.toggleClass('menu-top-click');
            Menu.el.menuMiddle.toggleClass('menu-middle-click');
            Menu.el.menuBottom.toggleClass('menu-bottom-click');
        }
    };

    Menu.init();
});
