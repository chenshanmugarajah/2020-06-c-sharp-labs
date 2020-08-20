var keys = new Array();

for(let i = 0; i < 256; i++){
	keys.push(false);
}

window.addEventListener('keydown', function(e){
	keys[e.keyCode] = true;
});

window.addEventListener('keyup', function(e){
	keys[e.keyCode] = false;
});

function isKeyDown(code){
	if(typeof code === "string"){
		switch(code){
			case "a":
				code = 65;
				break;
			case "s":
				code = 83;
				break;
			case "d":
				code = 68;
				break;
			case "w":
				code = 87;
				break;
			case "left":
				code = 37;
				break;
			case "right":
				code = 39;
				break;
			case "up":
				code = 38;
				break;
			case "down":
				code = 40;
				break;
			case "space":
				code = 32;
				break;
			case "enter":
				code = 13;
				break;
			case "q":
				code = 81;
				break;
			case "e":
				code = 69;
				break;
			case "shift":
				code = 16;
				break;
		}
	}
	
	if(typeof code === "number"){
		return keys[code];
	}
	else{
		return null;
	}
}