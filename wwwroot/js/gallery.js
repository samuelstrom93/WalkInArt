console.log('gallery.js')


let picture = document.querySelector(".gallery img");
let pictures = document.querySelectorAll(".gallery img");
let pictureText = document.querySelectorAll(".picture-text p");



let buttons = document.querySelectorAll('.button-overlay');
let overlays = document.querySelectorAll("#overlay")
let overlayClose = document.querySelectorAll("#overlay span")



for (let i = 0; i < buttons.length; i++) {
    buttons[i].addEventListener('click', function (event) {
        overlays[i].style.visibility = (overlays[i].style.visibility == "visible") ? "hidden" : "visible";
    })

}

for (let i = 0; i < overlayClose.length; i++) {
    overlayClose[i].addEventListener("click", function (event) {
        overlays[i].style.visibility = (overlays[i].style.visibility == "visible") ? "hidden" : "visible";
    })
    
}



// Vid addEventListener "click" blir bilden stor
// Håller koll på ifall man klickat på en av bilderna. 
// Ifall man klickat på bilden blir flag inte sann, klickar man igen blir den sann
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




