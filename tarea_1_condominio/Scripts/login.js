$(document).ready(function () {

    $("#btnAuth").click(function (e) {

        let correo = $("#CondCorreo").val().trim();
        let label = $("#lblMensaje");

        let regexCorreo = /^[a-zA-Z0-9._-]+@[a-zA-Z]+\.[a-zA-Z]{2,}$/;

        if (correo === "") {
            label.text("El correo es obligatorio").css("color", "red");
            e.preventDefault();
            return false;
        }

        if (!regexCorreo.test(correo)) {
            label.text("Formato de correo inválido. Ej: usuario@dominio.com")
                .css("color", "red");
            e.preventDefault();
            return false;
        }

        label.text("");
    });

});
