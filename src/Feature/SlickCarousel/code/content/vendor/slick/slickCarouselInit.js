jQuery(document).ready(function () {
    // Slick hates the code items as children, so we move to sibling and
    // Everything works properly.
    jQuery(".slick-carousel").children("code").each(function (index, value) {
        var item = jQuery(value);
        item.appendTo(item.parent().parent());
    });

    jQuery('.slick-carousel').slick();
});