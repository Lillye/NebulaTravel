// This code prevents background animation spin effect from resetting
var currentTime = new Date().getTime();
if(sessionStorage.startTime !== "undefined"){
    var animStartTime = sessionStorage.startTime;
    var diff = currentTime - animStartTime;
    diff = (diff/1000).toString();
    diff = "-" + diff + "s";
    document.getElementById("space").style.animationDelay = diff; 
    sessionStorage.setItem("startTime",animStartTime);
}
else{
    sessionStorage.setItem("startTime",currentTime);
}



