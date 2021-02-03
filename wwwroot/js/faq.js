

function showDescription() {
    let hide = document.querySelectorAll("#hide")
    let answer = document.querySelectorAll("#readmoreTxt")
    let question = document.querySelectorAll('.question')
    

    for (let i = 0; i < question.length; i++) {
        question[i].addEventListener('click', function () {
            if (answer[i].style.display === "none") {
                answer[i].style.display = "inline"
                hide.style.display = "none"
            }
            else{
                answer[i].style.display = "none"
                hide.style.display = "inline"
            }
        })
    }

}


//Denna gör så att pilen pekar uppåt när man klickat på den..Men det funkar inte att koppla ihop..

//function arrowUp(arrow) {
//  arrow.classList.toggle("fa-chevron-up")
//}

