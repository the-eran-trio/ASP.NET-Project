var howOften = 5;
var current = 0; 
var ns6 = document.getElementById && !document.all; 

var images = new Array();
images[0] = "<img class='image' alt='image0' src='/Content/images/all-the-formulas.jpg'/>"; 
images[1] = "<img class='image' alt='image1' src='/Content/images/interesting-computer.jpg' />";
images[2] = "<img class='image' alt='image2' src='/Content/images/two-devices-at-once.jpg'/>";
images[3] = "<img class='image' alt='image3' src='/Content/images/why-yes-thats-fascinating.jpg'/>";

var links = new Array();
links[0] = "<a class='learnMoreButton' href='https://www.bluechip-llc.com/blog/post/why-readiness-management-increases-end-user-adoption/'>Learn More</a>";
links[1] = "<a class='learnMoreButton' href='https://www.bluechip-llc.com/blog/post/automate-your-way-to-sharepoint-online-using-powershell/'>Learn More</a>";
links[2] = "<a class='learnMoreButton' href='https://www.bluechip-llc.com/blog/post/why-you-should-manage-mobile-devices-with-intune/'>Learn More</a>";
links[3] = "<a class='learnMoreButton' href='https://www.bluechip-llc.com/blog/post/5-reasons-to-outsource-mim-administration/'>Learn More</a>";


function rotater() {
    document.getElementById("image").innerHTML = images[current];
    fadeIn(document.getElementById("image"), 500);
    document.getElementById("learnMoreLinkDiv").innerHTML = links[current];

    current = (current == images.length - 1) ? 0 : current + 1;
    setTimeout("rotater()", howOften * 1000);
}

function rotater() {
    if (ns6) {
        document.getElementById("imageDiv").innerHTML = images[current];
        fadeIn(document.getElementById("imageDiv"), 500);
        document.getElementById("learnMoreLinkDiv").innerHTML = links[current];
    }
    if (document.all) {
        imageDiv.innerHTML = images[current];
        fadeIn(document.getElementById("imageDiv"), 500);
        learnMoreLinkDiv.innerHTML = links[current];
    }
    
    current = (current == images.length - 1) ? 0 : current + 1; 
    setTimeout("rotater()", howOften * 1000);

}

window.onload = rotater;

function fadeIn(el, time) {
    el.style.opacity = 0;
    el.style.display = "block";

    var last = +new Date();
    var tick = function () {
        el.style.opacity = +el.style.opacity + (new Date() - last) / time;
        last = +new Date();

        if (+el.style.opacity < 1) {
            (window.requestAnimationFrame && requestAnimationFrame(tick)) || setTimeout(tick, 16)
        }
    };

    tick();
}

