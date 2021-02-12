
function modifyFrames(scale){
    console.log("here")
    let elementsToScale = document.getElementsByClassName("frames")
    let elementsWithImg = document.getElementsByClassName("pictures")
    console.log(elementsWithImg)
    for (let i = 0; i  < elementsWithImg.length; i++){
        getMeta(elementsWithImg[i], elementsToScale[i],scale)
    }
    for (let i = elementsWithImg.length; i < elementsToScale.length; i++) {
        elementsToScale[i].innerHTML = "";
    }
}

function getMeta(elementWithImg,elementToScale,scale){   
    var img = new Image();
    img.onload = function(){
        let ratio =(this.height/this.width)*scale;
        elementToScale.attributes.scale.value = `${scale} ${ratio} ${scale}`
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