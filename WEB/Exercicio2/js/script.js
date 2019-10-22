$(document).ready(
    function () {
        $('button[id="btnconverter"]').click(function () {
            var valordolar = 4.16;
            var valoreal = $('input[id="real"]').val();

            var conversao = valoreal / valordolar;

            $('input[id="dolar"]').val(conversao);
        });
    }
);