let carrinho = 0;
let valorTotalCompras = document.getElementById("valor-total");
let listaDeCompras = document.getElementById("lista-produtos");
let quantidade = document.getElementById("quantidade");
let estoque = document.getElementById("produto");

listaDeCompras.innerHTML = "";
estoque.selectedIndex = 0;

function adicionar() {
  if (estoque.value === "") {
    alert("Por favor, selecione um produto válido!");
    return;
  }
  let quantidadeEscolhida = parseInt(quantidade.value);

  if (quantidadeEscolhida > 0) {
    let itemSelecionado = estoque.value;
    let registro = itemSelecionado.split(" - R$");

    let descritivo = registro[0];
    let custo = parseFloat(registro[1]);

    let totalDaCompra = custo * quantidadeEscolhida;

    let itemExistente = null;
    let itens = listaDeCompras.querySelectorAll(".carrinho__produtos__produto");

    itens.forEach(function (item) {
      if (item.textContent.includes(descritivo)) {
        itemExistente = item;
      }
    });

    if (itemExistente) {
      let confirmar = confirm(
        "Você já adquiriu este item, deseja selecionar aumentar a quantidade ?"
      );

      if (!confirmar) return;

      let spans = itemExistente.querySelectorAll(".texto-azul");
      let quantidadeAtual = parseInt(spans[0].textContent);
      let novaQuantidade = quantidadeAtual + quantidadeEscolhida;
      let novoTotal = custo * novaQuantidade;

      spans[0].textContent = `${novaQuantidade}x`;
      spans[1].textContent = `R$${novoTotal.toFixed(2)}`;
    } else {
      let novoItem = document.createElement("section");
      novoItem.classList.add("carrinho__produtos__produto");
      novoItem.innerHTML = `<span class="texto-azul">${quantidadeEscolhida}x</span> ${descritivo} <span class="texto-azul">R$${totalDaCompra.toFixed(
        2
      )}</span>`;
      listaDeCompras.appendChild(novoItem);
      quantidade.value = 0;
      estoque.selectedIndex = 0;
    }

    carrinho += totalDaCompra;
    valorTotalCompras.textContent = `R$${carrinho.toFixed(2)}`;
  } else {
    alert("Você não selecionou a quantidade de itens que deseja.");
    return;
  }
}

function limpar() {
  listaDeCompras.innerHTML = "";
  carrinho = 0;
  valorTotalCompras.textContent = "R$0";
  quantidade.value = "";
  estoque.selectedIndex = 0;
}
