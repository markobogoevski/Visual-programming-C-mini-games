

$(document).ready(function () {
    console.log("Hey!");
    var theForm = $("#theForm");
    theForm.hide();

    var myButton = $("#buyButton");
    myButton.on("click", function () {
        console.log("Buying item!");
    });

    var productListItems = $(".productInfo li"); //gets a collection 
    productListItems.on("click", function () { //puts func on every item in collection
        console.log("You clicked on " + $(this).text());
    });


    var $toggleLogin = $("#loginToggle");
    var $popupForm = $(".popupForm");
    $popupForm.hide();

    $toggleLogin.on("click", function () {
        $popupForm.fadeToggle(500);
    });
});


