﻿let buttons = document.querySelectorAll('.button-overlay');
let overlays = document.querySelectorAll("#overlay")
let overlayClose = document.querySelectorAll("#overlay span")

let btnreadmoregallery = document.querySelectorAll('.btn-readmoregallery');
let info = document.querySelectorAll('.object-info');


// Visar mer info om konsten vid knapptryck
for (let i = 0; i < btnreadmoregallery.length; i++) {
    btnreadmoregallery[i].addEventListener('click', function (event) {
        info[i].style.display = (info[i].style.display == "none") ? "block" : "none";
    })
}

// �ndrar knappen visa mer och visa mindre p� konstverk vid knapptryck.
function change(showhide) {
    if (showhide.value === "Visa info")
        showhide.value = "Visa bild";
    else
        showhide.value = "Visa info";
}

// Visar overlay med mer info vid knapptryck "mer info"-knapp
for (let i = 0; i < buttons.length; i++) {
    buttons[i].addEventListener('click', function (event) {
        overlays[i].style.visibility = (overlays[i].style.visibility == "visible") ? "hidden" : "visible";
        buttons[i].style.visibility = "hidden";
    })
}

// St�nger overlay genom att klicka p� krysset i overlay eller "mer info"-knappen igen
for (let i = 0; i < overlayClose.length; i++) {
    overlayClose[i].addEventListener("click", function (event) {
        overlays[i].style.visibility = (overlays[i].style.visibility == "visible") ? "hidden" : "visible";
        buttons[i].style.visibility = "visible";
    })
    
}



// Kopierar url via share-icon (anv�nds med onclick p� share-elementet)
function copyUrl() {
    let textDummy = document.createElement('input'),
    text = window.location.href;
    document.body.appendChild(textDummy);
    textDummy.value = text;
    textDummy.select();
    document.execCommand('copy');
    document.body.removeChild(textDummy);
    alert('Nu kan du dela webbadressen!');
}

// S�tter data-href till nuvarande url s� att dela-knappen delar den sidan du �r inne p�
fbButton.setAttribute('data-href', url);


