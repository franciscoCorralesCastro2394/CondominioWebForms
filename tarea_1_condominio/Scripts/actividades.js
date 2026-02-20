$(document).ready(function () {

    $("#ddlTipoActividad").change(function () {

        let tipo = $(this).val();

        $("#panelReunion").hide();
        $("#panelSocial").hide();
        $("#panelRecordatorio").hide();

        if (tipo === "Reunion") {
            $("#panelReunion").show();
        }
        else if (tipo === "Social") {
            $("#panelSocial").show();
        }
        else if (tipo === "Recordatorio") {
            $("#panelRecordatorio").show();
        }

    });

});
