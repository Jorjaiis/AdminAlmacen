$("document").ready(function () {
    //Cargar el Select
}); 

function faddContact() {
    debugger;
    var chk = document.getElementById("chkContact");
    var prueba = $("#chkContact").is(":checked");
    if (chk.checked) {
        //$("#formContact").show();
        document.getElementById("formContact").style.display = "block";
    }
    else {
        //$("#formContact").hide();
        document.getElementById("formContact").style.display = "none";
    }
}