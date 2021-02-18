/// <summary>
/// För att hantera sökfunktionen
// </summary>

console.log("search-engine.js is loaded")
const searchBar = document.getElementById("search-input")
const searchButton = document.getElementById("search-btn")
const searchResponse = document.getElementById("search-suggestions")
const searchResult = document.getElementById("searchresultbox")

// För att visa/gömma autoslutför på sökfunktionen
searchBar.addEventListener("focus", function () {
    if (searchBar.value != "") { searchResult.className = "search-result visible"; }
})
searchBar.addEventListener("blur", function () {
    setTimeout(function () {
        searchResult.className = "search-result hidden";
    }, 200);
})

// När man skriver något på sökruta
searchBar.addEventListener("input", function (event) {
    if (searchBar.value != "") {
        searchResult.className = "search-result hidden"
        searchAll()
    }
    else searchResult.className = "search-result hidden" } )

let html;
async function searchAll(){
    
    html = "";
    await searchCollections()
    await searchTags()
    searchResponse.innerHTML = html;
}

// Koppling till API som hanterar databasen om utställningar
async function searchCollections() {
    let link = "https://grupp8.dsvkurs.miun.se/api/Collections/";
        link += searchBar.value;
    let response = await fetch(link);
    let data = await response.json()
    let arrayLength = Object.keys(data).length;
    if (Object.keys(data).length >=1) {
        searchResult.className = "search-result visible";
    }
    showSearchResponse(data, arrayLength)
}

// Visar data som hämtat från APIn
async function showSearchResponse(data, length) {

    console.log(length)
    if (length > 0) {
        html += `<li style="pointer-events:none !important; font-weight: bold;" >Utställningar: <li>`;
    }

    for (let i = 0; i < length; i++) {
        html += `<li><a href="/exhibitions/${data[i].id}">${data[i].name}</a></li>`
    }

}

// Koppling till API som hanterar databasen om kategorier
async function searchTags() {
    let link = "https://grupp8.dsvkurs.miun.se/api/Tags/";
    link += searchBar.value;
    let response = await fetch(link);
    let data = await response.json()
    let arrayLenght = Object.keys(data).length;
    showTagSearchResponse(data, arrayLenght)
}

// Visar data som hämtat från APIn
async function showTagSearchResponse(data, length) {

    if (length > 0) {
        html += `<li style="pointer-events:none !important; font-weight: bold;" >Kategori: <li>`;
    }

    for (let i = 0; i < length; i++) {
        html += `<li><a href="/Categories/${data[i].title}">${data[i].title}</a></li>`
    }
    if (Object.keys(data).length >= 1) {
        searchResult.className = "search-result visible";
    }
    console.log(html)
}






