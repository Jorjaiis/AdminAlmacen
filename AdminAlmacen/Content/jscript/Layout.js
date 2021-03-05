$(document).ready(function () {


    $("#changeStore").click(function () {
        var id_store = document.getElementById("id_store").value;
        var id_user = document.getElementById("id_user").value;
        //var a = $("#id_store").val();
        //var b = $("#id_user").val();
        var stores = [];
        //borrar elementos(Hijos) del Modal
        
        let bodyModal = document.getElementById("storeModal_body");
        //let childs = bodyModal.childElementCount;


        bodyModal.innerHTML = '';


        /*if (childs != 0)
            for (var i = 0; i < childs; i++)
                bodyModal.removeChild(bodyModal.childNodes[0]);
            
        */
        $.ajax({
            type: 'GET',
            url: '/api/StoreApi/getStore/?id_user=' + id_user + "&id_store=" + id_store,
            contentType: 'application/x-www-form-urlencoded',
            //data: "",
            success: function (data) {
                //debugger;
                if (data.result == 0) {
                    stores = data.data;
                    stores.forEach(function (x) {
                        //let label = '<a class="btn btn-default" href="/Layout/changeStore/' + String(x.id) + '"> <i class="fas fa-fw fa-building"></i> ' + x.name.toUpperCase() + '</a></br><hr> ';
                        let label = '<button class="btn btn-default" onclick="changeStore2(' + x.id + ')"> <i class="fas fa-fw fa-building"></i> ' + x.name.toUpperCase() + '</button></br><hr> ';
                        //$("#storeModal_body").append(label);
                        document.getElementById("storeModal_body").innerHTML += label;
                    });
                    $("#storeModal").modal();
                }
                else {
                    alert(data.message);
                }
                //location.href('/Home/Index');
            },
            error: function(xhr, desc, err) {
                alert("Error en Layout.js");
            }


        });

        
    });

    


});

function changeStore2(id_store) {
    var idStore = id_store;
    $.ajax({
        url: '/Layout/changeStore2/',
        method: 'GET',
        async: false,
        dataType: 'json',
        data: { id: idStore },
        success: function (response) {
            if (response.result == 0) {
                location.href='/Home/Index';
            }
            else {
                err_dataCont();
            }
        },
        error(xhr, desc, err) {
            err_dataCont();
        }
    });
}

function err_dataCont() {
    $("#storeModal").modal("hide");
    $('#alert_errStore').show();
}
