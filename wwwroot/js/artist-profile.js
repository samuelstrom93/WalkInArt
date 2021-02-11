// Hanterar lägg till ny utställning
let addExhibitionFormBtn = document.querySelector(".add-exhibition");
let exhibitionForm = document.querySelector(".exhibition-form");

// Hanterar lägg till nytt objekt
let addObjectFormBtn = document.querySelectorAll(".add-object");
let objectForm = document.querySelectorAll(".object-form");


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





