function checkInput() {
    let amountOfFigures = document.getElementById("input").value;

    if (amountOfFigures < 0) {
        alert('Количество фигур не может быть отрицательным');
        return false;
    }
    else if (amountOfFigures > 15) {
        alert('Количество фигур не может быть больше 15')
        return false;
    }
    else return true;
}