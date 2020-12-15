function InclinarCabecaParaBaixo() {
    
    $.ajax
        ({
            type: 'POST',
            datatype: 'json',
            cache: false,
            url: '/Cabeca/InclinarCabecaParaBaixo',
            traditional: true,
            success: function (result) {
                $("#Status").text(result.Status);
                $("#Mensagem").text(result.Mensagem);
                $("#EstadoAtual").text(result.EstadoAtual);
                console.log(result);
            },
            error: function (xhr) {
                console.log(xhr);
            }
        });
}

function InclinarCabecaParaCima() {

    $.ajax
        ({
            type: 'POST',
            datatype: 'json',
            cache: false,
            url: '/Cabeca/InclinarCabecaParaCima',
            traditional: true,
            success: function (result) {
                $("#Status").text(result.Status);
                $("#Mensagem").text(result.Mensagem);
                $("#EstadoAtual").text(result.EstadoAtual);
                console.log(result);
            },
            error: function (xhr) {
                console.log(xhr);
            }
        });
}

function RotacionarCabecaPositivo() {

    $.ajax
        ({
            type: 'POST',
            datatype: 'json',
            cache: false,
            url: '/Cabeca/RotacionarCabecaPositivo',
            traditional: true,
            success: function (result) {
                $("#Status").text(result.Status);
                $("#Mensagem").text(result.Mensagem);
                $("#EstadoAtual").text(result.EstadoAtual);
                console.log(result);
            },
            error: function (xhr) {
                console.log(xhr);
            }
        });
}

function RotacionarCabecaNegativo() {

    $.ajax
        ({
            type: 'POST',
            datatype: 'json',
            cache: false,
            url: '/Cabeca/RotacionarCabecaNegativo',
            traditional: true,
            success: function (result) {
                $("#Status").text(result.Status);
                $("#Mensagem").text(result.Mensagem);
                $("#EstadoAtual").text(result.EstadoAtual);
                console.log(result);
            },
            error: function (xhr) {
                console.log(xhr);
            }
        });
}

function RotacionarPulsoEsquerdoNegativo() {

    $.ajax
        ({
            type: 'POST',
            datatype: 'json',
            cache: false,
            url: '/Pulso/RotacionarPulsoEsquerdoNegativo',
            traditional: true,
            success: function (result) {
                $("#Status").text(result.Status);
                $("#Mensagem").text(result.Mensagem);
                $("#EstadoAtual").text(result.EstadoAtual);
                console.log(result);
            },
            error: function (xhr) {
                console.log(xhr);
            }
        });
}

function RotacionarPulsoDireitoNegativo() {

    $.ajax
        ({
            type: 'POST',
            datatype: 'json',
            cache: false,
            url: '/Pulso/RotacionarPulsoDireitoNegativo',
            traditional: true,
            success: function (result) {
                $("#Status").text(result.Status);
                $("#Mensagem").text(result.Mensagem);
                $("#EstadoAtual").text(result.EstadoAtual);
                console.log(result);
            },
            error: function (xhr) {
                console.log(xhr);
            }
        });
}

function RotacionarPulsoEsquerdoPositivo() {

    $.ajax
        ({
            type: 'POST',
            datatype: 'json',
            cache: false,
            url: '/Pulso/RotacionarPulsoEsquerdoPositivo',
            traditional: true,
            success: function (result) {
                $("#Status").text(result.Status);
                $("#Mensagem").text(result.Mensagem);
                $("#EstadoAtual").text(result.EstadoAtual);
                console.log(result);
            },
            error: function (xhr) {
                console.log(xhr);
            }
        });
}

function RotacionarPulsoDireitoPositivo() {

    $.ajax
        ({
            type: 'POST',
            datatype: 'json',
            cache: false,
            url: '/Pulso/RotacionarPulsoDireitoPositivo',
            traditional: true,
            success: function (result) {
                $("#Status").text(result.Status);
                $("#Mensagem").text(result.Mensagem);
                $("#EstadoAtual").text(result.EstadoAtual);
                console.log(result);
            },
            error: function (xhr) {
                console.log(xhr);
            }
        });
}


function ContrairCotoveloEsquerdo() {

    $.ajax
        ({
            type: 'POST',
            datatype: 'json',
            cache: false,
            url: '/Cotovelo/ContrairCotoveloEsquerdo',
            traditional: true,
            success: function (result) {
                $("#Status").text(result.Status);
                $("#Mensagem").text(result.Mensagem);
                $("#EstadoAtual").text(result.EstadoAtual);
                console.log(result);
            },
            error: function (xhr) {
                console.log(xhr);
            }
        });
}

function ContrairCotoveloDireito() {

    $.ajax
        ({
            type: 'POST',
            datatype: 'json',
            cache: false,
            url: '/Cotovelo/ContrairCotoveloDireito',
            traditional: true,
            success: function (result) {
                $("#Status").text(result.Status);
                $("#Mensagem").text(result.Mensagem);
                $("#EstadoAtual").text(result.EstadoAtual);
                console.log(result);
            },
            error: function (xhr) {
                console.log(xhr);
            }
        });
}

function DescontrairCotoveloEsquerdo() {

    $.ajax
        ({
            type: 'POST',
            datatype: 'json',
            cache: false,
            url: '/Cotovelo/DescontrairCotoveloEsquerdo',
            traditional: true,
            success: function (result) {
                $("#Status").text(result.Status);
                $("#Mensagem").text(result.Mensagem);
                $("#EstadoAtual").text(result.EstadoAtual);
                console.log(result);
            },
            error: function (xhr) {
                console.log(xhr);
            }
        });
}

function DescontrairCotoveloDireito() {

    $.ajax
        ({
            type: 'POST',
            datatype: 'json',
            cache: false,
            url: '/Cotovelo/DescontrairCotoveloDireito',
            traditional: true,
            success: function (result) {
                $("#Status").text(result.Status);
                $("#Mensagem").text(result.Mensagem);
                $("#EstadoAtual").text(result.EstadoAtual);
                console.log(result);
            },
            error: function (xhr) {
                console.log(xhr);
            }
        });
}