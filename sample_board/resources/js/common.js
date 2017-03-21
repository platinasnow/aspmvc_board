$(function () {
    $('.search_text').keyup(function (e) {
        if (e.keyCode == 13) {
            searchList();
        }
    });
});
function searchList() {
    $('#page').val(1);
    $('form').submit();
};