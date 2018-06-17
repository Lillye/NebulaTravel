// This code function is to hide navbar when scrolling down and show it again when scrolling up
const navBarHeight = "45px";
var prevScrollpos = window.pageYOffset;
var nav = document.getElementById("access-nav");
var navState = "closed";
nav.addEventListener("click", () => {
    if(navState == "closed"){
        navState = "open";
    }
    else{
        navState = "closed";
    }
})
window.onscroll = () => {
    var currentScrollPos = window.pageYOffset;
    if(navState == "closed"){
        if (prevScrollpos > currentScrollPos) {
            document.getElementById("header-bar").style.top = "0";
        } 
        else {
            document.getElementById("header-bar").style.top = "-" + navBarHeight;
        }
    }
    prevScrollpos = currentScrollPos;
}
