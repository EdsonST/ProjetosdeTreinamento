let alugados = [];
let disponiveis = [];

function alterarStatus(id) {
  let jogoEscolhido = document.getElementById(`game-${id}`);
  let nomeDoJogo = jogoEscolhido.querySelector("p").innerText;
  let imagem = jogoEscolhido.querySelector(".dashboard__item__img");
  let botao = jogoEscolhido.querySelector(".dashboard__item__button");
  let botaoStatus = jogoEscolhido.querySelector("a").innerText;

  let confirmacao = confirm(
    `Você deseja ${botaoStatus} o jogo ${nomeDoJogo} ?`
  );

  if (!confirmacao) return;

  if (imagem.classList.contains("dashboard__item__img--rented")) {
    imagem.classList.remove("dashboard__item__img--rented");
    botao.classList.remove("dashboard__item__button--return");
    botao.textContent = "Alugar";
    console.log(`O ${nomeDoJogo} foi devolvido.`);
    disponiveis.push(nomeDoJogo);
    alugados = alugados.filter((jogo) => jogo !== nomeDoJogo);
  } else {
    imagem.classList.add("dashboard__item__img--rented");
    botao.classList.add("dashboard__item__button--return");
    botao.textContent = "Devolver";
    console.log(`O ${nomeDoJogo} foi alugado.`);
    alugados.push(nomeDoJogo);
    disponiveis = disponiveis.filter((jogo) => jogo !== nomeDoJogo);
  }

  contarJogos();
}

function contarJogos() {
  let alugados = document.querySelectorAll(".dashboard__item__img--rented");
  let total = document.querySelectorAll(".dashboard__item__img").length;

  console.log("Alugados:", alugados.length);
  console.log("Disponíveis:", total - alugados.length);
}
