//validação1
if (numerode >= numeroate) {
  alert(
    "O número inicial deve ser menor que o número final. Por favor, corrija os valores."
  );
  document.getElementById("de").value = "";
  document.getElementById("ate").value = "";
}

function sortear() {
  let quantidade = parseInt(document.getElementById("quantidade").value);
  let numerode = parseInt(document.getElementById("de").value);
  let numeroate = parseInt(document.getElementById("ate").value);

//validação2
  let quantidadeNumerosPossiveis = numeroate - numerode + 1;
  if (quantidade > quantidadeNumerosPossiveis) {
    alert(
      "Não é possível sortear essa quantidade de números. Existem apenas " +
        quantidadeNumerosPossiveis +
        " números possíveis no intervalo escolhido."
    );
    reiniciar();
    return;
  }

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
