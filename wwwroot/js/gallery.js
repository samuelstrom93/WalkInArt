let pictures = document.querySelectorAll(".gallery img");
let pictureText = document.querySelectorAll(".picture-text p");


let buttons = document.querySelectorAll('.button-overlay');
let overlays = document.querySelectorAll("#overlay")
let overlayClose = document.querySelectorAll("#overlay span")



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


// Förstorar bilden genom knapptryck på respektive bild (konstverk)
for (let i = 0; i < pictures.length; i++) {
    pictures[i].addEventListener("click", function (event){

        pictures.forEach(picture => {
            if (picture.style.height = "650px") {
                picture.style.height = "";
                picture.style.width = "";
            }
        });

        event.target.style.width = "500px";
        event.target.style.height = "650px";
    })
}

// Kopierar url via share-icon (används med onclick på share-elementet)
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



