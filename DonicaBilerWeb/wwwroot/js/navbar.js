// navbar.js
<Script>
    $(document).ready(function () {
        $(window).on('scroll', function () {
            var gap = 50;
            if ($(window).scrollTop() > gap) {
                $('header').addClass('active');
            } else {
                $('header').removeClass('active');
            }
        })
});
</Script>

