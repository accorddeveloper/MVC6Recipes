(function blink(n) {
    var blinks = document.getElementsByTagName("blink"),
        visibility = n % 2 === 0 ? "visible" : "hidden";
    for (var i = 0; i < blinks.length; i++) {
        blinks[i].style.visibility = visibility;
    }
    setTimeout(function () {
        blink(n + 1);
    }, 500);
})(0);