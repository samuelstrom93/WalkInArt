

function showDescription1(arrow) {

    var hide1 = document.getElementById("hide1");
    var readmoreTxt1 = document.getElementById("readmoreTxt1");


    if (arrow.classList.toggle("fa-chevron-up")) {
        readmoreTxt1.style.display = "inline";
        hide1.style.display = "none";
    }
    else {
        readmoreTxt1.style.display = "none";
        hide1.style.display = "inline";
    }
}

function showDescription2(arrow) {

    var hide2 = document.getElementById("hide2");
    var readmoreTxt2 = document.getElementById("readmoreTxt2");


    if (arrow.classList.toggle("fa-chevron-up")) {
        readmoreTxt2.style.display = "inline";
        hide2.style.display = "none";
    }
    else {
        readmoreTxt2.style.display = "none";
        hide2.style.display = "inline";
    }
}

function showDescription3(arrow) {

    var hide3 = document.getElementById("hide3");
    var readmoreTxt3 = document.getElementById("readmoreTxt3");


    if (arrow.classList.toggle("fa-chevron-up")) {
        readmoreTxt3.style.display = "inline";
        hide3.style.display = "none";
    }
    else {
        readmoreTxt3.style.display = "none";
        hide3.style.display = "inline";
    }
}

function showDescription4(arrow) {

    var hide4 = document.getElementById("hide4");
    var readmoreTxt4 = document.getElementById("readmoreTxt4");


    if (arrow.classList.toggle("fa-chevron-up")) {
        readmoreTxt4.style.display = "inline";
        hide4.style.display = "none";
    }
    else {
        readmoreTxt4.style.display = "none";
        hide4.style.display = "inline";
    }
}



//function showDescription(arrow) {

//    var hide = document.getElementById("hide");
//    var readmoreTxt = document.getElementById("readmoreTxt");

//    for (var i = 0; i < 4; i++) {
//        if (arrow.classList.toggle("fa-chevron-up")) {
//            readmoreTxt[i].style.display = "inline";
//            hide[i].style.display = "none";
//        }
//        else {
//            readmoreTxt[i].style.display = "none";
//            hide[i].style.display = "inline";
//        }
//    }

//}

//function readmore() {

//    var hide = document.getElementById("hide");
//    var readmoreTxt = document.getElementById("readmore1");

//    if (readmoreTxt.style.display === "none") {
//        readmoreTxt.style.display = "inline";
//        hide.style.display = "none";

//    } else {
//        readmoreTxt.style.display = "none";
//        hide.style.display = "inline";
//    }
//}

//function showArrowUp() {
//    var arrowup = document.getElementsByClassName("arrowup");
//    var arrowdown = document.getElementsByClassName("arrowdown");
//    var readmore1 = document.getElementById("readmore1");

//    if (readmore1.style.display === "none") {
//        arrowdown.style.display = "inline";
//        arrowup.style.display = "none";
//    }
//    else {
//        arrowup.style.display = "inline";
//        arrowdown.style.display = "none";
//    }
//}

//function readmore_2() {
//    var hide2 = document.getElementById("hide2");
//    var readmore2 = document.getElementById("readmore2");

//    if (readmore2.style.display === "none") {
//        readmore2.style.display = "inline";
//        hide2.style.display = "none";

//    } else {
//        readmore2.style.display = "none";
//        hide2.style.display = "inline";
//    }

//    showArrowUp()
//}

//function readmore_3() {
//    var hide3 = document.getElementById("hide3");
//    var readmore3 = document.getElementById("readmore3");

//    if (readmore3.style.display === "none") {
//        readmore3.style.display = "inline";
//        hide3.style.display = "none";

//    } else {
//        readmore3.style.display = "none";
//        hide3.style.display = "inline";
//    }
//}

//function readmore_4() {
//    var hide4 = document.getElementById("hide4");
//    var readmore4 = document.getElementById("readmore4");

//    if (readmore4.style.display === "none") {
//        readmore4.style.display = "inline";
//        hide4.style.display = "none";

//    } else {
//        readmore4.style.display = "none";
//        hide4.style.display = "inline";
//    }
//}

//function arrowup() {

//    //var arrow = document.getElementById('.rotate')
//    //arrow.addEventListener('click')
//    //readmore_1()

//    $(".rotate").click(function () {
//        $(this).toggleClass("up");
//    })

//}