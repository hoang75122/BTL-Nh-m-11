$().ready(function () {
    $('#formRegister').submit(function (e) {
        e.preventDefault();
        $.ajax({
            url: '/account/register',
            type: 'POST',
            data: new FormData(this),
            contentData: false,
            processData: false,
            cache: false,
            success: function (data) {
                alert(data.ms);
            },
            error: function (err) {
                alert(err.statusText);
            }
        });
    });
});