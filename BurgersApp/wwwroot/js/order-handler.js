const confirmOrder = document.querySelector('.confirm-order');
const cancelOrder = document.querySelector('.cancel-order');
const cancel = document.querySelector('.cancel');
const payment = document.querySelector('.payment');
const message = document.querySelector('.message-container');
const confirm = document.querySelector('.confirm-container');
const payBtn = document.querySelector('.order');

confirmOrder.addEventListener('click', () => {
    payment.classList.remove('hidden');
});

cancelOrder.addEventListener('click', () => {
    cancel.classList.remove('hidden');
});

payBtn.addEventListener('click', () => {
    confirm.classList.add('hidden');
    message.classList.remove('hidden');
});