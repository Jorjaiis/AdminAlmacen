$(document).ready(function () {


    $("#changeStore").click(function () {
        var id_store = document.getElementById("id_store").value;
        var id_user = document.getElementById("id_user").value;
        var stores = null;
        debugger;
        $.ajax({
            type: 'GET',
            url: '/api/StoreApi/getStore/?id_user=' + id_user + "&id_store=" + id_store,
            contentType: 'application/x-www-form-urlencoded',
            //data: "",
            success: function (data) {
                debugger;
                if (data.result == 0) {
                    stores = data.data;
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


