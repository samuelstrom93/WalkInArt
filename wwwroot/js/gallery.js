﻿/// <summary>
/// Används för 2D-rum på utställningssidor
/// </summary>

console.log("gallery.js is loaded")

let buttons = document.querySelectorAll('.button-overlay');
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

// Ändrar knappen visa mer och visa mindre på konstverk vid knapptryck.
function showPictureOnly(showhide) {
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

// Stänger overlay genom att klicka på krysset i overlay eller "mer info"-knappen igen
for (let i = 0; i < overlayClose.length; i++) {
    overlayClose[i].addEventListener("click", function (event) {
        overlays[i].style.visibility = (overlays[i].style.visibility == "visible") ? "hidden" : "visible";
        buttons[i].style.visibility = "visible";
    })
    
}

let fbBtn = document.querySelector(".fb-share-button");
let url = window.location.href;

// Sätter data-href till nuvarande url så att dela-knappen delar den sidan du är inne på
fbBtn.setAttribute('data-href', url);


