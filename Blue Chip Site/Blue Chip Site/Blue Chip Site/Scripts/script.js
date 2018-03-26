/*
    Example of a multi-line comment just like in C#/Java    
*/

// Single line comment

var howOften = 5; //number often in seconds to rotate
var current = 0; //start the counter at 0
var ns6 = document.getElementById && !document.all; //detect netscape 6

// place your images, text, etc in the array elements here
var items = new Array();
items[0] = "<img alt='image0' src='images/all-the-formulas.jpg'/>"; //a linked image
items[1] = "<img alt='image1' src='~/interesting-computer.jpg' />"; //a linked image
items[2] = "<img alt='image2' src='~/two-devices-at-once.jpg'/>"; //a linked image
items[3] = "<img alt='image3 ' src='~/why-yes-thats-fascinating.jpg'/>"; //a linked image

function rotater() {
    document.getElementById("placeholder").innerHTML = items[current];
    current = (current == items.length - 1) ? 0 : current + 1;
    setTimeout("rotater()", howOften * 1000);
}

function rotater() {
    if (document.layers) {
        document.placeholderlayer.document.write(items[current]);
        document.placeholderlayer.document.close();
    }
    if (ns6) document.getElementById("placeholderdiv").innerHTML = items[current]
    if (document.all)
        placeholderdiv.innerHTML = items[current];

    current = (current == items.length - 1) ? 0 : current + 1; //increment or reset
    setTimeout("rotater()", howOften * 1000);
}
window.onload = rotater;
//-->