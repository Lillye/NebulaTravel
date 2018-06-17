window.addEventListener("scroll",scrollFunction);
var scrollButton = document.getElementById("scrollToTopButton");

function scrollFunction() {
    if (document.documentElement.scrollTop >= 700){
        scrollButton.style.opacity = "1";
    }
    else{
        scrollButton.style.opacity = "0";
    }
}

scrollButton.addEventListener("click", () => {
    document.documentElement.scrollTop = 0;
})
