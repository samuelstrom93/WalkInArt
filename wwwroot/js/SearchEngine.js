﻿const searchBar = document.getElementById("search-input")
const searchButton = document.getElementById("search-btn")
const searchResponse = document.getElementById("search-suggestions")
const searchResult = document.getElementById("searchresultbox")
searchButton.addEventListener("click", searchTags)


searchBar.addEventListener("input", function (event) {
    if (searchBar.value != "") {
        searchResult.className = "search-result hidden"
        searchAll()
    }
    else searchResult.className = "search-result hidden" }   
    )
let html;
async function searchAll(){
    
    html = "";
    await searchCollections()
    await searchTags()
    searchResponse.innerHTML = html;
}
async function showSearchResponse(data, lenght) {
    //let html = ""

    console.log(lenght)
    if (lenght > 0) {
        html += `<li style="pointer-events:none !important" >Utställningar: <li>`;
    }

    for (let i = 0; i < lenght; i++) {
        html += `<li><a href="/exhibitions/${data[i].id}">${data[i].name}</a></li>`
    }
    //searchResponse.innerHTML = html;
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

    if (lenght > 0) {
        html += `<li style="pointer-events:none !important" >Kategori: <li>`;
    }

    for (let i = 0; i < lenght; i++) {
        html += `<li><a href="/Categories/${data[i].title}">${data[i].title}</a></li>`
    }
    if (Object.keys(data).length >= 1) {
        searchResult.className = "search-result visible";
    }
    console.log(html)
    //searchResponse.innerHTML = html;
}






