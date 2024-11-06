function input_Run(y) {
    document.getElementById("textBar").value += y;
}

function backspace() {
    document.getElementById("textBar").value = document.getElementById("textBar").value.slice(0, -1);
}

function saveName() {
    const name = document.getElementById("textBar").value;
    if (name) {
        localStorage.setItem('playerName', name);
        alert(`Name "${name}" has been saved locally.`);
    } else {
        alert("Please enter a name before saving.");
    }
}

window.onload = function() {
    const savedName = localStorage.getItem('playerName');
    if (savedName) {
        document.getElementById("textBar").value = savedName;
        alert(`Welcome back, ${savedName}!`);
    }
};
