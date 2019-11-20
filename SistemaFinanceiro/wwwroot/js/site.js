$(window).scroll(function () {
    if ($(window).scrollTop() >= 61) {
        $('.navbar-default').addClass('navbar-scroll');
    }
    else {
        $('.navbar-default').removeClass('navbar-scroll');
    }
});
