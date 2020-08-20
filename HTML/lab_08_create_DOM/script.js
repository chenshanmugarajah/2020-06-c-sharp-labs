
var content = document.getElementById("content");

var CreateDiv = () => {
    
    console.log("creating div")

    var number = Math.floor(Math.random() * 5);
    var color = "";
    if (number == 0) {
        color = "pink"
    } else if (number == 1) {
        color = "blue"
    } else if (number == 2) {
        color = "orange"
    } else if (number == 3) {
        color = "red"
    } else {
        color = "purple"
    }

    var div = document.createElement("div")
    div.style.backgroundColor = color;
    div.style.margin = "10px"
    div.style.height = "100px"
    div.style.width = "100px"
    div.innerHTML = "Click me to remove me";
    div.onclick = (e) => {
       if (confirm("Are you sure?")) {
           div.parentNode.removeChild(div)
       } else {
           div.style.backgroundColor = "green"
       }
    }

    content.appendChild(div);

}