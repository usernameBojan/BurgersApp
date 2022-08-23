const btns = document.querySelectorAll('.btn-lg');
const categories = document.querySelectorAll('.menu-container');

for (let i = 0; i < 4; i++) {
    btns[i].addEventListener('click', () => {
        categories.forEach(el => el.classList.add('hidden'));
        categories[i].classList.remove('hidden');
    });
};