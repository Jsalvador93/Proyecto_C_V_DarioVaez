
function mostrar(id) {
    if (id == "Natural") {
        $("#Natural").show();
        $("#Juridica").hide();
    }

    if (id == "Juridica") {
        $("#Natural").hide();
        $("#Juridica").show();
    }
    if (id == "Ticket") {
        $("#Factura").hide();
        $("#Boleta").hide();
        $("#Ticket").show();
    }
    if (id == "Boleta") {
        $("#Factura").hide();
        $("#Boleta").show();
        $("#Ticket").hide();
    }
    if (id == "Factura") {
        $("#Factura").show();
        $("#Boleta").hide();
        $("#Ticket").hide();
    }
 
}
