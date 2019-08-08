
XA.component.slick = (function ($, document) {

    function init() {
        $('.slick-carousel').each(function (i, e) {
            if (!$(e).hasClass('slick-initialized')) {
                configure(e);
            }
            else {
                $(e).slick('reinit');
            }
        });
    }

    function configure(e) {
        if (typeof Sitecore !== typeof undefined) {
            //Infinite breaks Experience Editor, so we disable if defined.
            $(e).slick({ slide: ".slick-carousel-Item", infinite: false });
        }
        else {
            $(e).slick({ slide: ".slick-carousel-Item" });
        }
    }

    var pub = {};

    pub.init = function () {
        init();
    };

    return pub;

}(jQuery, document));

XA.register("slick", XA.component.slick);