function sortear() {
  let quantidade = parseInt(document.getElementById("quantidade").value);
  let numerode = parseInt(document.getElementById("de").value);
  let numeroate = parseInt(document.getElementById("ate").value);

  let numerosSorteados = [];
  let numero;

  for (let i = 0; i < quantidade; i++) {
    numero = numeroAleatório(numerode, numeroate);
    if (numerosSorteados.includes(numero)) {
      i--;
    } else {
      numerosSorteados.push(numero);
    }
  }

  numerosSorteados.sort(function (a, b) {
    return a - b;
  });

  let resultado = document.getElementById("resultado");
  resultado.innerHTML = `<label class="texto__paragrafo">Números sorteados: ${numerosSorteados}</label>`;

  alterarStatusDoBotao();
}

function numeroAleatório(min, max) {
  return Math.floor(Math.random() * (max - min + 1)) + min;
}

function reiniciar() {
  location.reload();
}

function alterarStatusDoBotao() {
  let botao = document.getElementById("btn-reiniciar");
  if (botao.classList.contains("container__botao-desabilitado")) {
    botao.classList.remove("container__botao-desabilitado");
    botao.classList.add("container__botao");
  } else {
    botao.classList.remove("container__botao");
    botao.classList.add("container__botao-desabilitado");
  }
}
