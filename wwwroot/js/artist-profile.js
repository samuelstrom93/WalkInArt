let exhibitionTitles = document.querySelectorAll('.exhibition-title');
let artworks = document.querySelectorAll(".artworks");
let arrowIcons = document.querySelectorAll("#arrow");
let editBtns = document.querySelectorAll(".edit-btn");

// Hanterar lägg till ny utställning
let addExhibitionFormBtn = document.querySelector(".add-exhibition");
let exhibitionForm = document.querySelector(".exhibition-form");

// Hanterar lägg till nytt objekt
let addObjectFormBtn = document.querySelectorAll(".add-object");
let objectForm = document.querySelectorAll(".object-form");


// Knapptryck på objekttiteln visas alla objekt under den utställningen. Klick igen för att dölja
for (let i = 0; i < exhibitionTitles.length; i++) {
    exhibitionTitles[i].addEventListener('click', () => {
        artworks[i].style.display = (artworks[i].style.display === "block") ? "none" : "block";
        arrowIcons[i].className = (arrowIcons[i].className === "fa fa-chevron-down") ? "fa fa-chevron-right" : "fa fa-chevron-down";
    });
}

// Knapptryck på "Hantera"-knappen visas alla objekt under den utställningen. Klick igen för att dölja
for (let i = 0; i < editBtns.length; i++) {
    editBtns[i].addEventListener('click', () => {
        artworks[i].style.display = (artworks[i].style.display === "block") ? "none" : "block";
        arrowIcons[i].className = (arrowIcons[i].className === "fa fa-chevron-down") ? "fa fa-chevron-right" : "fa fa-chevron-down";
    });
}

// Hanterar nytt utställning
addExhibitionFormBtn.addEventListener("click", function (event) {
    exhibitionForm.style.display = (exhibitionForm.style.display === "block") ? "none" : "block";
});

// Hanterar nytt objekt
for (let i = 0; i < addObjectFormBtn.length; i++) {
    addObjectFormBtn[i].addEventListener("click", function (event) {
        objectForm[i].style.display = (objectForm[i].style.display === "block") ? "none" : "block";
    });
}





