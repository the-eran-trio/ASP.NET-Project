var howOften = 5; //number often in seconds to rotate
var current = 0; //start the counter at 0
var ns6 = document.getElementById && !document.all; //detect netscape 6

var items = new Array();
items[0] = "<img alt='image0' src='/Content/images/all-the-formulas.jpg'/>"; 
items[1] = "<img alt='image1' src='/Content/images/interesting-computer.jpg' />";
items[2] = "<img alt='image2' src='/Content/images/two-devices-at-once.jpg'/>";
items[3] = "<img alt='image3' src='/Content/images/why-yes-thats-fascinating.jpg'/>";

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

    current = (current == items.length - 1) ? 0 : current + 1; 
    setTimeout("rotater()", howOften * 1000);
}
window.onload = rotater;
