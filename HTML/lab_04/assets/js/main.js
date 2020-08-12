
fetch("https://images-api.nasa.gov/search?q=rover")
  .then(
    function(response) {
      if (response.status !== 200) {
        console.log('Looks like there was a problem. Status Code: ' +
          response.status);
        return;
      }
      response.json().then(function(data) {
        console.log(data.collection.items)
        displayInfo(data.collection.items)
      });
    }
  )
  .catch(function(err) {
    console.log('Fetch Error :-S', err);
  });

  function displayInfo(nasadata) {

    var nasainfo = document.getElementById("nasa-info");

    for (var i=0; i<nasadata.length / 4; i++) {

        var title = nasadata[i].data[0].title
        var description = nasadata[i].data[0].description
        var imagesrc = nasadata[i].links[0].href

        
        var heading = document.createElement("h3")
        heading.innerText = title
        var info = document.createElement("p")
        info.innerText = description
        var image = document.createElement("img")
        image.src = imagesrc
        
        var infoDiv = document.createElement("div");
        infoDiv.appendChild(heading)
        infoDiv.appendChild(info)
        infoDiv.appendChild(image)

        nasainfo.appendChild(infoDiv)
    }
  }