$(document).ready(
    function () {
        $('button[id="botao"]').click(function () {
            var nome = $('input[id="nome"]').val();
            alert("Seja bem vindo " + nome + " ao nosso sistema de cervejaria.");
        });
    }
);