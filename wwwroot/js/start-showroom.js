
modifyFrames()

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
        let ratio = (this.height / this.width)*1.3;
        elementsToScaleForBigFrames.attributes.scale.value = `1.3 ${ratio} 1.3`
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