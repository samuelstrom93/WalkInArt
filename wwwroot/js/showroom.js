
function modifyFrames(scale) {
    let elementsToScale = document.getElementsByClassName("frames")
    let elementsWithImg = document.getElementsByClassName("pictures")
    console.log(elementsWithImg)
    for (let i = 0; i < elementsWithImg.length; i++) {
        getMeta(elementsWithImg[i], elementsToScale[i], scale)
    }
    for (let i = elementsWithImg.length; i < elementsToScale.length; i++) {
        elementsToScale[i].innerHTML = "";
    }
}

function getMeta(elementWithImg, elementToScale, scale) {
    var img = new Image();
    img.onload = function () {
        let ratio = (this.height / this.width) * scale;
        elementToScale.attributes.scale.value = `${scale} ${ratio} ${scale}`
    };
    img.src = elementWithImg.attributes.src.value;
}