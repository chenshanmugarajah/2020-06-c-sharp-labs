console.log("Hello from Main.js")

var nasadata;

fetch("https://images-api.nasa.gov/search?q=rover")
  .then(
    function(response) {
      if (response.status !== 200) {
        console.log('Looks like there was a problem. Status Code: ' +
          response.status);
        return;
      }
      response.json().then(function(data) {
        nasadata = data.collection.items;
      });
    }
  )
  .catch(function(err) {
    console.log('Fetch Error :-S', err);
  });

document.getElementById()