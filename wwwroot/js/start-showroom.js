
modifyFrames()
//modifyTitles()

function modifyFrames(){
    let elementsToScaleForBigFrames = document.getElementsByClassName("big-frames")
    let elementsWithImg = document.getElementsByClassName("pictures")
    console.log(elementsWithImg)

    for (let i = 0; i < elementsWithImg.length; i++) {
        getMetaForBigFrames(elementsWithImg[i], elementsToScaleForBigFrames[i])
    }
}

function modifyTitles() {
    let elementsToScaleForTitleFrames = document.getElementsByClassName("title-frames")
    let elementsWithTitle = document.getElementsByClassName("titles")
    console.log(elementsWithTitle)

    for (let i = 0; i < elementsWithTitle.length; i++) {
        getMetaFoTitleFrames(elementsWithTitle[i], elementsToScaleForTitleFrames[i])
    }
}

function getMetaForBigFrames(elementWithImg, elementsToScaleForBigFrames) {
    var img = new Image();
    img.onload = function () {
        let ratio = (this.height / this.width)*1;
        elementsToScaleForBigFrames.attributes.scale.value = `1 ${ratio} 1`
    };
    img.src = elementWithImg.attributes.src.value;
}

/*function getMetaFoTitleFrames(elementsWithTitle, elementsToScaleForTitle) {
    var title = elementsWithTitle.textContent;
    title.onload = function () {
        let ratio = (this.height / this.width) * 1;
        elementsToScaleForTitle.attributes.scale.value = `1 ${ratio} 1`
    };
    //img.src = elementWithImg.attributes.src.value;
}*/
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