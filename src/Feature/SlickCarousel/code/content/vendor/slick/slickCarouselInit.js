
jQuery(document).ready(function () {
    if (typeof Sitecore !== typeof undefined) {
        //Infinite breaks Experience Editor, so we disable if defined.
        jQuery('.slick-carousel').slick({ slide: ".slick-carousel-Item", infinite: false });
    }
    else {
        jQuery('.slick-carousel').slick({ slide: ".slick-carousel-Item" });
    }

 });

