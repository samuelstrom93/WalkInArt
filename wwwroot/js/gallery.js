

let picture = document.querySelector(".gallery img");
let pictures = document.querySelectorAll(".gallery img");
let pictureText = document.querySelectorAll(".picture-text p");


// Sätter första bild som stor när sidan laddas in
picture.style.height = "650px";
picture.style.width = "500px";


// Titeln blir fetmarkerad vid mouseover och går tillbaka när musen lämnar mouseover
for (let i = 0; i < pictures.length; i++) {
    pictures[i].addEventListener("mouseover", function (event){
        pictureText[i].style.fontWeight = "bold";
    })
    pictures[i].addEventListener("mouseleave", function(event){
        pictureText[i].style.fontWeight = "";
    } )
}



// Vid addEventListener "click" blir bilden stor
// Håller koll på ifall man klickat på en av bilderna. 
// Ifall man klickat på bilden blir flag inte sann, klickar man igen blir den sann
var flag = true;
for (let i = 0; i < pictures.length; i++) {
    pictures[i].addEventListener("click", function (event){
        pictures.forEach(element => {
            if (element.style.height = "650px") {
                element.style.height = "";
                element.style.width = "";    
            }
        })
        if (flag) {
            pictures[i].style.height = "650px";
            pictures[i].style.width = "500px";
        }
    })
}

