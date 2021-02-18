/// <summary>
/// Används för 3d-rum på startsidan
/// </summary>

console.log("start-showroom.js is loaded")
modifyFrames()

// Ram justerar beroende på konstverks storlek
function modifyFrames(){
    let elementsToScaleForBigFrames = document.getElementsByClassName("big-frames")
    let elementsWithImg = document.getElementsByClassName("pictures")
    console.log(elementsWithImg)

    for (let i = 0; i < elementsWithImg.length; i++) {
        getMetaForBigFrames(elementsWithImg[i], elementsToScaleForBigFrames[i])
    }
}

function getMetaForBigFrames(elementWithImg, elementsToScaleForBigFrames) {
    var img = new Image();
    img.onload = function () {
        let ratio = (this.height / this.width)*1.1;
        elementsToScaleForBigFrames.attributes.scale.value = `1.1 ${ratio} 1.1`
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
            window.parent.location.href = data.url;
        });
    }
}); 