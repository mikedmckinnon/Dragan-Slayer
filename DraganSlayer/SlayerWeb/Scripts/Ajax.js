var ajax = {
    checkStatusInterval: 2000,
    onSucess: null,

    post: function (url, params, onSucess, onFailure) {
        ajax.onSucess = onSucess;
        
        $.ajax({
            url: url,
            type: "GET",
            data: JSON.stringify(params),
            cache: false,
            contentType: "application/json; charset=utf-8",
            dataType: "jsonp",
            crossDomain: true,
            error: function (xhr, textStatus, error) {
                if (onFailure)
                    onFailure(error);
                else
                    alert(error);
            },
            jsonpCallback: 'ajaxSucess'
        });
    },
};
function ajaxSucess() {
    if (ajax.onSucess)
        ajax.onSucess();
}