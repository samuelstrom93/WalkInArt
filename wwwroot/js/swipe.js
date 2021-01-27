console.log('swipe.js')

//Karusel
const swiper = makeSwiper()
function makeSwiper() {
    var swiper = new Swiper('.swiper-container', {
        spaceBetween: 20,

        loop: true,
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
    console.log('swiper made')

}
