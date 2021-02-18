    /// <summary>
    /// 
    /// </summary>
let answers = document.querySelectorAll('#answer');
let questions = document.querySelectorAll('#question');
let arrowIcons = document.querySelectorAll("#arrow");
let questionDivs = document.querySelectorAll('.question-wrapper');

for (let i = 0; i < questions.length; i++) {
    questionDivs[i].addEventListener('click', function (event) {
        answers[i].style.display = (answers[i].style.display === "block") ? "none" : "block";
        arrowIcons[i].className = (arrowIcons[i].className === "fa fa-chevron-down") ? "fa fa-chevron-up" : "fa fa-chevron-down";
    })

}





