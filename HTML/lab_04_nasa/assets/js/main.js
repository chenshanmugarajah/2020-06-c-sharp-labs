searchNasa();

function searchNasa (query = "rover") {
    fetch("https://images-api.nasa.gov/search?q=" + query)
    .then(
        function(response) {
        if (response.status !== 200) {
            console.log('Looks like there was a problem. Status Code: ' +
            response.status);
            return;
        }
        response.json().then(function(data) {
            displayInfo(data.collection.items)
        });
        }
    )
    .catch(function(err) {
        console.log('Fetch Error :-S', err);
    });
}

function displayInfo(nasadata) {

    var nasainfo = document.getElementById("nasa-info");
    nasainfo.innerHTML = "";

    for (var i=0; i<nasadata.length / 10 - 2; i++) {

        var title = nasadata[i].data[0].title
        var description = nasadata[i].data[0].description
        var imagesrc = nasadata[i].links[0].href

        // modal
        var modalMain = document.createElement("div")
        modalMain.id = "modal0" + i
        modalMain.style.display = "none";

        modalMain.onclick = () => {
            var test = modalMain.id;
            document.getElementById(test).innerHTML = ""
        }

        var modalSub = document.createElement("div")
        var modalImg = document.createElement("img")
        modalImg.src = imagesrc

        // main items
        var heading = document.createElement("h3")
        heading.innerText = title
        var info = document.createElement("p")
        info.innerText = description.substring(0, 150)
        if (description.length > 150) info.innerText += "..."
        var image = document.createElement("img")
        image.src = imagesrc
        
        var infoDiv = document.createElement("div");
        infoDiv.className = "info-item";
        infoDiv.id = "info-div-" + i;
        infoDiv.appendChild(heading)
        infoDiv.appendChild(info)
        infoDiv.appendChild(image)
        infoDiv.onclick = function () {
            var test1 = modalMain.id;
            document.getElementById(test1).style.display = 'block'
        }

        

        // append modal to div
        modalSub.appendChild(modalImg)
        modalMain.appendChild(modalSub)
        infoDiv.appendChild(modalMain)

        nasainfo.appendChild(infoDiv)
    }
}

var searchQuery = document.getElementById("searchQuery");
var searchButton = document.getElementById("submitSearch");

searchButton.onclick = () => { searchNasa(searchQuery.value) }