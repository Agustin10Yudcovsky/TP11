function ObtenerEntradasPorPartido2(idPartido) {
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: '/Home/Partidos',
        data: { PartidoId: idPartido },
        success: function (response) {
            $("#IdPartido").html("ID del Partido: " + idPartido);
        },
        error: function (error) {
            console.error("Error en la solicitud AJAX", error);
        }
    });
}
