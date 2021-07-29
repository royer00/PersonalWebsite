
$(function () { 
//starting intro title effects
$("#first-name").hide().slideDown(1000);
$("#last-name").hide().show("slide", { direction: "up" }, 1000);
$("#intro").hide().fadeIn(4000);
$("#subtitle").hide().show("slide", { direction: "right" }, 1000);
});


//page loading
$(document).ready(function () {
    //changing value of resume button 
    $("#resume-button").on("click", function () {
        $(this).text("Thanks for viewing!");
    });
    $("#resume-button").on("blur", function () {
        $(this).text("Download Resume");
    });

    //changing css on selected project card
    $(".project-card").on("mouseover", function () {
        $(this).removeClass("bg-dark").addClass("bg-primary").css("box-shadow", "5px 2px 2px black");
    });
    $(".project-card").on("mouseout", function () {
        $(this).removeClass("bg-primary").addClass("bg-dark").css("box-shadow", "5px 2px 2px #bd5d38");
    });

    //changing css on mobile cards
    $(".small-card").on("mouseover", function () {
        $(this).removeClass("bg-dark").addClass("bg-primary");
    });
    $(".small-card").on("mouseout", function() {
        $(this).removeClass("bg-primary").addClass("bg-dark");
    });


   
})


//changing personal pic on nav bar hover
function changePic() {
    document.getElementById("mepic").src = "assets/img/kevinwebpic.jpg";
}
function restorePic() {
    document.getElementById("mepic").src = "assets/img/me (3).jpg";
}
//modal 
function showModal() {
    let modal = document.getElementById("modal");
    modal.style.display = "block";

}
let btnModalVisible = document.getElementById("contact-btn");
btnModalVisible.addEventListener("click", showModal);

//close modal
function closeModal() {
    let modal = document.getElementById("modal");
    modal.style.display = "none";
}
let closeBtn = document.getElementById("closebtn");
closeBtn.addEventListener("click", closeModal);

