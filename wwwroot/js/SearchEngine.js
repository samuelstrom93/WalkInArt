const searchBar = document.getElementById("search-input")
const searchButton = document.getElementById("search-btn")
const searchResponse = document.getElementById("search-suggestions")
const searchResult = document.getElementById("searchresultbox")
searchButton.addEventListener("click", searchTags)

searchBar.addEventListener("input", function (event) {
    if (searchBar.value != "") {
        searchResult.className = "search-result hidden"
        searchCollections()
    }
    else searchResult.className = "search-result hidden" }   
    )


async function showSearchResponse(data, lenght) {
    let html = ""
    for (let i = 0; i < lenght; i++) {
        html += `<li><a href="/exhibitions/${data[i].id}">${data[i].name}</a></li>`
    }
    searchResponse.innerHTML = html;
}

async function searchCollections() {
    let link = "https://localhost:44305/api/Collections/";
        link += searchBar.value;
    let response = await fetch(link);
    let data = await response.json()
    let arrayLenght = Object.keys(data).length;
    if (Object.keys(data).length >=1) {
        searchResult.className = "search-result visible";
    }
    showSearchResponse(data, arrayLenght)
}

async function searchTags() {
    let link = "https://localhost:44305/api/Tags/";
    link += searchBar.value;
    let response = await fetch(link);
    let data = await response.json()
    let arrayLenght = Object.keys(data).length;
    showTagSearchResponse(data, arrayLenght)
}

async function showTagSearchResponse(data, lenght) {
    let html = ""
    for (let i = 0; i < lenght; i++) {
        html += `<li><a href="/exhibitions/${data[i].id}">${data[i].title}</a></li>`
    }
    console.log(html)
    searchResponse.innerHTML = html;
}






