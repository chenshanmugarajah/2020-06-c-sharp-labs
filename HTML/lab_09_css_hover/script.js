
var div = document.getElementById("js-css");

div.addEventListener('mouseover', () => {
    div.style.backgroundColor = "cornflowerblue"
    div.style.height = "200px"
    div.style.width = "200px"
    div.color = "white"
})

div.addEventListener('mouseout', () => {
    div.style.backgroundColor = "red"
    div.style.height = "100px"
    div.style.width = "100px"
    div.color = "black"
})