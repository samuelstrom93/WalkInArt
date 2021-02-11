
modifyFrames()
function modifyFrames(){
    let elementsToScale = document.getElementsByClassName("frames")
    let elementsToScaleForBigFrames = document.getElementsByClassName("big-frames")
    let elementsWithImg = document.getElementsByClassName("pictures")
    console.log(elementsWithImg)
    for (let i = 0; i  < elementsWithImg.length; i++){
        getMeta(elementsWithImg[i], elementsToScale[i])
    }
    for (let i = 0; i < elementsWithImg.length; i++) {
        getMetaForBigFrames(elementsWithImg[i], elementsToScaleForBigFrames[i])
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

function getMetaForBigFrames(elementWithImg, elementsToScaleForBigFrames) {
    var img = new Image();
    img.onload = function () {
        let ratio = (this.height / this.width)*1;
        elementsToScaleForBigFrames.attributes.scale.value = `1 ${ratio} 1`
    };
    img.src = elementWithImg.attributes.src.value;
}

//För att flytta till en annan sida i ett VR rum
AFRAME.registerComponent('navigate-on-click', {
    schema: {
        url: { default: '' }
    },

    init: function () {
        var data = this.data;
        var el = this.el;

        el.addEventListener('click', function () {
            window.location.href = data.url;
        });
    }
}); 