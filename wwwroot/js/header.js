let dropDown = document.querySelector("#myDropdown");


function myFunction() {
    if (dropDown.classList.contains("show")) {
        dropDown.classList.remove("show")
    }
    else {
        dropDown.classList.toggle("show");
    }

  }


// https://www.w3schools.com/howto/howto_js_dropdown.asp
window.onclick = function(event) {
if (!event.target.matches('.dropbtn')) {
    var dropdowns = document.getElementsByClassName("dropdown-content");
    var i;
    for (i = 0; i < dropdowns.length; i++) {
    var openDropdown = dropdowns[i];
    if (openDropdown.classList.contains('show')) {
        openDropdown.classList.remove('show');
    }
    }
}
}

