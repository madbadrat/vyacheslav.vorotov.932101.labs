function focus() {
    rabbit.classList.toggle("inTheHat");
    rabbit.classList.toggle("outOfHat");

    pigeon.classList.toggle("inTheHat");
    pigeon.classList.toggle("outOfHat");
}

rabbit.addEventListener("click", focus);
pigeon.addEventListener("click", focus);