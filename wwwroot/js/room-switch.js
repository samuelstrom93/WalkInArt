console.log('room-switch.js')

let gallery = document.querySelector(".gallery-wrapper");

let room2d = document.querySelector("#2d-room-template");
let room3d = document.querySelector("#3d-room-template");

let button2d = document.querySelector("#BTNS ID");
let button3d = document.querySelector("#BTNS ID");

button2d.addEventListener("click", function () {
    gallery.innerHTML = "";

    //TO DO: LÄS IN TEMPLETE 2D
})

button3d.addEventListener("click", function () {
    gallery.innerHTML = "";
    //TO DO: LÄS IN TEMPLETE 3D
})