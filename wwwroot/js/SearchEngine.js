const searchBar = document.getElementById("search-input")
const searchButton = document.getElementById("search-btn")
const searchResponse = document.getElementById("search-suggestions")
searchButton.addEventListener("click", searchTags)
searchBar.addEventListener("input", searchCollections)
console.log(searchResponse)

// async function searchArtists () {
//    let response = await fetch('https://localhost:44305/api/Artists');
//     let data = await response.json()
//     let arrayLenght = Object.keys(data).length;
//    console.log(data)
//    showSearchResponse(data, arrayLenght)
//}
//searchArtists().then(data => searchResponse(data));

async function showSearchResponse(data, lenght) {
    console.log("vi kom hi")
    //let data = await searchArtists();
    let html = ""
    for (let i = 0; i < lenght; i++) {
        html += `<li><a href="/exhibitions/${data[i].id}">${data[i].name}</a></li>`
        //html += `<option value = "${data[i].name}"><a href="/exhibitions/22"></a></option>`
    }
    console.log(html)
    searchResponse.innerHTML = html;
}

async function searchCollections() {
    let link = "https://localhost:44305/api/Collections/";
        link += searchBar.value;
    let response = await fetch(link);
    let data = await response.json()
    let arrayLenght = Object.keys(data).length;
    console.log(data)
    showSearchResponse(data, arrayLenght)
}

async function searchTags() {
    let link = "https://localhost:44305/api/Tags/";
    link += searchBar.value;
    let response = await fetch(link);
    let data = await response.json()
    let arrayLenght = Object.keys(data).length;
    console.log(data)
    showTagSearchResponse(data, arrayLenght)
}

async function showTagSearchResponse(data, lenght) {
    console.log("vi kom hi")
    //let data = await searchArtists();
    let html = ""
    for (let i = 0; i < lenght; i++) {
        html += `<option value ="${data[i].Title}"></option>`
        //html += `<option value = "${data[i].name}"><a href="/exhibitions/22"></a></option>`
    }
    console.log(html)
    searchResponse.innerHTML = html;
}






