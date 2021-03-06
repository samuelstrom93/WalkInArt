/// <summary>
/// För att kontrollera karusel för 2d-rums konstverk och rumlista 
/// </summary>

console.log("swipe.js is loaded")

//Karusel för utställningar
var gallerySwiper = new Swiper('.gallerylist', {
        loop: true,
        spaceBetween: 20,
        allowTouchMove: false,

        speed: 1000,
        pagination: {
            el: '.swiper-pagination',
            type: 'bullets',
            clickable: true,
        },
        navigation: {
            nextEl: '.swiper-button-next',
            prevEl: '.swiper-button-prev',
        },

});

//Karusel för rumlista
var roomsSwiper = new Swiper('.roomlist', {
        spaceBetween: 20,
        allowTouchMove: false,
        speed: 750,
        

        navigation: {
            nextEl: '.swiper-button-next',
            prevEl: '.swiper-button-prev',
        },

        breakpoints: {
            // window width <= 499px
            499: {
                slidesPerView: 1,
                spaceBetweenSlides: 20
            },
            // window width <= 999px
            999: {
                slidesPerView: 2,
                spaceBetweenSlides: 20
            },
            // window width <= 1199px
            1199: {
                slidesPerView: 3,
                spaceBetweenSlides: 20
            },
            // window width <= 1599px

            1599: {
                slidesPerView: 4,
                spaceBetweenSlides: 20
            }
        }

    });


