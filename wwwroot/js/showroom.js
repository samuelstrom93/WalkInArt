
modifyFrames()
function modifyFrames(){
    let elementsToScale = document.getElementsByClassName("frames")
    let elementsWithImg = document.getElementsByClassName("pictures")
    console.log(elementsWithImg)
    for (let i = 0; i  < elementsWithImg.length; i++){
        getMeta(elementsWithImg[i], elementsToScale[i])
    }
    for (let i = elementsWithImg.length; i < elementsToScale.length; i++) {
        elementsToScale[i].innerHTML = "";
    }
}

function getMeta(elementWithImg,elementToScale){   
    var img = new Image();
    img.onload = function(){
        let ratio =(this.height/this.width)*0.7;
        elementToScale.attributes.scale.value=`0.7 ${ratio} 0.7`
    };
    img.src = elementWithImg.attributes.src.value;
}