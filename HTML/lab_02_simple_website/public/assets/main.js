console.log("Hello from Main.js");

var imageContainer = document.getElementById("image-gallery");

setTimeout(() => {
    for (var i=0; i<20; i++) {
        var img = document.createElement("img");
        img.src = "https://picsum.photos/200/300?random="+i;
        img.className = "col-md-3 mb-3";
        imageContainer.appendChild(img);
    }
}, 500)

