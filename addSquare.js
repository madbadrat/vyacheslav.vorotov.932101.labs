document.getElementById("square-button").addEventListener(
    "click",
    function() {
        const test = document.createElement("h1");
        const testText = document.createTextNode("Square add");
        test.appendChild(testText);

        document.body.appendChild(test);
    }
)