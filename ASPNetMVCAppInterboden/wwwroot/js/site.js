openPopup = (url, title) => {
    $.ajax({
        type: "GET",
        url: url,
        success: (res) => {
            $("#popup .modal-title").html(title);
            $("#popup .modal-body").html(res);
            $("#popup").modal('show');
        }
    })
}

saveForm = form => {
    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {
                    $('#content').html('').html(res.html)
                    $('#popup .modal-body').html('');
                    $('#popup .modal-title').html('');
                    $('#popup').modal('hide');
                }
                else
                    $('#popup .modal-body').html(res.html);
            },
            error: function (err) {
                console.log(err)
            }
        })
        //to prevent default form submit event
        return false;
    } catch (ex) {
        console.log(ex)
    }
}
