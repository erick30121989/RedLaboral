$(document).ready(menu_effect);

function menu_effect() {

    $('#Button_Home').click(function () {

        // alert("hola mundo");
        //$('#popup_box').css("transition", "3s");
        //$('#popup_box').css("visibility", "visible");
        //$('#header').css("color", "red");
        $('#popup_box').fadeIn();

    })


    $('#popup_box').click(function () {

        // alert("hola mundo");
        //$('#popup_box').css("transition", "3s");
        //$('#popup_box').css("visibility", "visible");
        //$('#header').css("color", "red");
        // $('#popup_box').fadeOut();

    })


    $('#btn_salir').click(function () {

        //alert("hola mundo");
        $('#popup_box').fadeOut();

    })

    $('#btn_salir_per').click(function () {

        //alert("hola mundo");
        $('#pop_up_menu').fadeOut();

    })

    $('#btn_persona').click(function () {

        //alert("hola mundo");
        $('#pop_up_menu').fadeOut();

    })

    $('#btn_empresa').click(function () {

        //alert("hola mundo");
        $('#pop_up_menu').fadeOut();
        window.location.href = "../Mantenimientos/EmpresaMan01.aspx";

    })

    //btn_ingresar

    //$('#btn_ingresar').click(function () {

    //    alert("");

    //})

    function mostrarAlerta(){

        alert("Hola mundo");

    }

};