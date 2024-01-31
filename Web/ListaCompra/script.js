const lista = document.getElementById('listaCompras');
const input = document.getElementById('itemInput');

function agregarItem() {
    const item = input.value.trim();
    if (item !== '') {
        const li = document.createElement('li');
        li.innerText = item;
        lista.appendChild(li);
        input.value = '';
    }
}

lista.addEventListener('click', (e) => {
    if (e.target.tagName === 'LI') {
        e.target.remove();
    }
});
