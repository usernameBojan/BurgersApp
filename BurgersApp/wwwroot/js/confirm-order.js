const confirmOrder = document.querySelector('.confirm-order');
const payment = document.querySelector('.payment');

confirmOrder.addEventListener('click', () => {
    payment.classList.remove('hidden');
});