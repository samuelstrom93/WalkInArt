const searchBar = document.getElementById("search-input")
const searchButton = document.getElementById("search-btn")
const searchResponse = document.getElementById("search-response")
searchButton.addEventListener("click", searchArtists)
console.log('hi')

 async function searchArtists () {
    let response = await fetch('https://localhost:44305/api/Artists');
     let data = await response.json()
     let arrayLenght = Object.keys(data).length;
    console.log(data)
    showSearchResponse(data, arrayLenght)
}
//searchArtists().then(data => searchResponse(data));

async function showSearchResponse(data, lenght) {
    console.log("vi kom hit")
    //let data = await searchArtists();
    let html = ""
    for (let i = 0; i < lenght; i++) {
        html += `<li>
                    <p>${data[i].name}</p>
                 </li>`
    }
    console.log(html)
    searchResponse.innerHTML = html;
}






