var button = document.getElementById("access-inner-box");
var nav = document.getElementById("nav-holder");
var isOpen = false;
button.addEventListener("click", () => {
    if(isOpen){
        nav.classList.remove("nav-open");
        nav.classList.add("nav-closed");
        isOpen = false;
    }
    else{
        nav.classList.remove("nav-closed");
        nav.classList.add("nav-open");
        isOpen = true;
    }
});