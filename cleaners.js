function deleteAll() {
    display.children[0].innerHTML = "0";
}

function deleteOneChar() {
    let existingText = display.children[0].innerHTML;

    if (existingText.length==1) {
        display.children[0].innerHTML = 0;
    }
    else {
        display.children[0].innerHTML = existingText.replace(
            existingText[existingText.length-1],
            ""
        )
    }
}