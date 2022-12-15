function criaHoraSegundos(segundos) {
    const data = new Date(segundos * 1000);
    return data.toLocaleTimeString('pt-BR', {
        hour12: false,
        timeZone: 'GMT' // UTC
    })
}

const relogio = document.querySelector('.relogio');
const iniciar = document.querySelector('.iniciar');
const pausar = document.querySelector('.pausar');
const zerar = document.querySelector('.zerar');
let segundos = 0;
let timer;

function iniciaRelogio() {
    timer = setInterval(function() {
        segundos++;
        relogio.innerHTML = criaHoraSegundos(segundos);
    }, 1000);
}

// iniciar.addEventListener('click', function(event) {
//     relogio.classList.remove('pausado');
//     clearInterval(timer);
//     iniciaRelogio();
// })
// pausar.addEventListener('click', function(event) {
//     relogio.classList.add('pausado');
//     clearInterval(timer);
// })
// zerar.addEventListener('click', function(event) {
//     relogio.classList.remove('pausado');
//     clearInterval(timer);
//     relogio.innerHTML = '00:00:00';
//     segundos = 0;
// })

// Modo mais performático:
document.addEventListener('click', function(e) {
    //console.log(e.target);
    const el = e.target;

    if (el.classList.contains('zerar')) {
        relogio.classList.remove('pausado');
        clearInterval(timer);
        relogio.innerHTML = '00:00:00';
        segundos = 0;
    }
    if (el.classList.contains('pausar')) {
        relogio.classList.add('pausado');
        clearInterval(timer);
    }
    if (el.classList.contains('iniciar')) {
        relogio.classList.remove('pausado');
        clearInterval(timer);
        iniciaRelogio();
    }
});