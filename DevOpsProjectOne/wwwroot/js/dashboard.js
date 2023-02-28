// Get the menu icon and navbar
var menuIcon = document.querySelector(".menu-icon");
var navbar = document.querySelector(".navbar");
var closeBtn = document.querySelector(".closebtn");

// Add an event listener to the menu icon
menuIcon.addEventListener("click", function () {
    // Toggle the "show" class
    navbar.classList.toggle("show");
});

// Add an event listener to the close button
function closeNav() {
    navbar.classList.remove("show");
}
