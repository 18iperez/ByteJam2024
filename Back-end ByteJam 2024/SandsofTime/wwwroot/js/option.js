function saveOptions() {
    const selectedColor = document.querySelector('input[name="Box-Format"]:checked');
    const autoTypeEnabled = document.getElementById('auto-type').checked;

    if (selectedColor) {
        localStorage.setItem('textBoxColor', selectedColor.value);
    }
    localStorage.setItem('autoType', autoTypeEnabled);

    alert('Options saved successfully!');
}

window.onload = function() {
    const savedColor = localStorage.getItem('textBoxColor');
    const savedAutoType = localStorage.getItem('autoType');

    if (savedColor) {
        document.querySelector(`input[name="Box-Format"][value="${savedColor}"]`).checked = true;
        /* Need to get colors from options form. Then, colors are loaded for text boxes. */
    }

    if (savedAutoType === 'true') {
        document.getElementById('auto-type').checked = true;
    }
};

document.getElementById('optionsForm').addEventListener('submit', function(event) {
    event.preventDefault();
    saveOptions();
});