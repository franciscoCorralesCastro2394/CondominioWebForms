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

$(document).ready(function () {

    $("#btnRegistrar").click(function (e) {

        let actividad = $("#ddlTipoActividad").val();
        let label = $("#lblMensaje");
        let titulo = $("#txtTitulo").val();
        let fechaPubli = $("#txtFechaPublicacion").val();
        let fechaCierre = $("#txtFechaCierre").val();


        if (fechaPubli >= fechaCierre) {
            label.text("La fecha de inicio debe ser menor que la fecha final").css("color", "red");
            e.preventDefault(); // evita postback
            return;
        }

        //Validaciones para campos geenrales 
        if (actividad === "") {
            label.text("Debe seleccionar un tipo de Actividad").css("color", "red");
            e.preventDefault();
            return;
        }


        if (titulo === "") {
            label.text("Debe ingresar un titulo").css("color", "red");
            e.preventDefault();
            return;
        }

        if (fechaPubli === "") {
            label.text("La fecha de Publicación es obligatoria").css("color", "red");
            e.preventDefault();
            return;
        }

        if (fechaCierre === "") {
            label.text("La fecha de Cierre es obligatoria").css("color", "red");
            e.preventDefault();
            return;
        }

    //Validaciones para reuniones 
        if (actividad == "Reunion") {

            let fechaReunion = $("#txtFechaReunion").val();
            let duracion = $("#txtDuracion").val();
            let agenda = $("#txtAgenda").val();
            let ubicacion = $("#txtUbicacionPresencial").val();
            let enlace = $("#txtEnlaceVirtual").val();


            if (fechaReunion === "") {
                label.text("Debe ingresar una fecha de Reunión").css("color", "red");
                e.preventDefault();
                return false;
            }


            if (duracion === "") {
                label.text("Debe ingresar una duración de Reunión").css("color", "red");
                e.preventDefault();
                return;
            }

            if (agenda === "") {
                label.text("Debe ingresar una egenda  de Reunión").css("color", "red");
                e.preventDefault();
                return;
            }

            if (ubicacion === "") {
                label.text("Debe ingresar una ubicación  de Reunión").css("color", "red");
                e.preventDefault();
                return;
            }

            if (enlace === "") {
                label.text("Debe ingresar un elace de Reunión").css("color", "red");
                e.preventDefault();
                return;
            }




        }

        //actividades sociales 
        if (actividad == "Social") {

            let fechaActividadInicio = $("#txtFechaInicio").val();
            let fechaActividadFin = $("#txtFechaFin").val();
            //let formato = $("#ddlFormato").val();
            let ubicacionActividad = $("#txtUbicacionSocial").val();
            let intrucciones = $("#txtInstrucciones").val();


            if (fechaActividadInicio === "") {
                label.text("Debe ingresar una fecha de Inicio para actividad").css("color", "red");
                e.preventDefault();
                return false;
            }


            if (fechaActividadFin === "") {
                label.text("Debe ingresar una fecha de Fin para actividad").css("color", "red");
                e.preventDefault();
                return;
            }

            if (ubicacionActividad === "") {
                label.text("Debe ingresar una ubicación para la Actividad").css("color", "red");
                e.preventDefault();
                return;
            }

            if (ubicacion === "") {
                label.text("Debe ingresar una ubicación  de Reunión").css("color", "red");
                e.preventDefault();
                return;
            }

            if (intrucciones === "") {
                label.text("Debe ingresar las instrucciones").css("color", "red");
                e.preventDefault();
                return;
            }




        }

        if (actividad == "Recordatorio") {

            let texto = $("#txtDescripcionRecordatorio").val();

            if (texto === "") {
                label.text("Debe ingresar el Recordatorio").css("color", "red");
                e.preventDefault();
                return;
            }
        }


        label.text("");
    });

});
