$(document).ready(function () {
    $('#first').animate({ bottom: '0%' }, 1000)
    $('#first').animate({ bottom: '-1%' }, 300)
    setTimeout(500)
    $('#second').animate({ bottom: '0%' }, 1000)
    $('#second').animate({ bottom: '-1%' }, 300)
});