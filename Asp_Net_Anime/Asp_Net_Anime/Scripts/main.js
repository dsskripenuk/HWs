var checkbox = document.querySelector('.custom-checkbox-input');

document.documentElement.setAttribute('data-theme', localStorage.getItem('theme'));

if (localStorage.getItem('checkbox_state') === true)
    checkbox.checked = true;
else
    checkbox.checked = false;

checkbox.addEventListener('change', function () {
    transition();

    if (this.checked) {
        document.documentElement.setAttribute('data-theme', 'light');
        localStorage.setItem('theme', 'light');
        localStorage.setItem('checkbox_state', true);
    } else {
        document.documentElement.setAttribute('data-theme', 'dark');
        localStorage.setItem('theme', 'dark');
        localStorage.setItem('checkbox_state', false);
    }
})

function transition() {
    document.documentElement.classList.add('transition');
    setTimeout(function () {
        document.documentElement.classList.remove('transition');
    }, 1000)
}