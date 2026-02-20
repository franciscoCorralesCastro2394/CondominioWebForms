$(document).ready(function () {

    $("#btnRegistrar").click(function (e) {

        let label = $("#lblMensaje");
        let correo = $("#txtCorreo").val();
        let password = $("#txtPassword").val();
        let confirm = $("#txtConfirmPassword").val();
        let fecha = $("#txtFechaNacimiento").val();
        let check = $("#chkTerminos").is(":checked");

        if (fecha === "") {
            label.text("La fecha de nacimiento es obligatoria").css("color", "red");
            e.preventDefault();
            return;
        }

        if (password !== confirm) {
            label.text("Las contraseñas no coinciden").css("color", "red");
            e.preventDefault();
            return;
        }

        if (!check) {
            label.text("Debe aceptar los términos y condiciones").css("color", "red");
            e.preventDefault();
            return;

        }
    
    });
});
