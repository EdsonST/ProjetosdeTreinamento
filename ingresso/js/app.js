let ingressosPista = parseInt(document.getElementById("qtd-pista").textContent);
let ingressosSuperior = parseInt(
  document.getElementById("qtd-superior").textContent
);
let ingressosInferior = parseInt(
  document.getElementById("qtd-inferior").textContent
);

function comprar() {
  let ingressoSelecionado = document.getElementById("tipo-ingresso").value;
  let quantidade = parseInt(document.getElementById("qtd").value);

  if (quantidade == 0 || isNaN(quantidade) || quantidade < 0) {
    alert("Insira a quantidade de ingressos!");
    return;
  }

  if (ingressoSelecionado === "pista") {
    if (ingressosPista - quantidade < 0) {
      semIngresso(ingressoSelecionado);
    } else {
      ingressosPista = ingressosPista - quantidade;
      document.getElementById("qtd-pista").textContent = `${ingressosPista}`;
      compraRealizada(quantidade, ingressoSelecionado, ingressosPista);
    }
  }

  if (ingressoSelecionado === "superior") {
    if (ingressosSuperior - quantidade < 0) {
      semIngresso(ingressoSelecionado);
    } else {
      ingressosSuperior = ingressosSuperior - quantidade;
      document.getElementById(
        "qtd-superior"
      ).textContent = `${ingressosSuperior}`;
      compraRealizada(quantidade, ingressoSelecionado, ingressosSuperior);
    }
  }

  if (ingressoSelecionado === "inferior") {
    if (ingressosInferior - quantidade < 0) {
      semIngresso(ingressoSelecionado);
    } else {
      ingressosInferior = ingressosInferior - quantidade;
      document.getElementById(
        "qtd-inferior"
      ).textContent = `${ingressosInferior}`;
      compraRealizada(quantidade, ingressoSelecionado, ingressosInferior);
    }
  }

  //logs
  console.log(
    `Foram adquirido(os) ${quantidade} ingresso(os) para ${ingressoSelecionado}.`
  );
  console.log("O Saldo atual é:");
  console.log(`Pista: ${ingressosPista}`);
  console.log(`Superior: ${ingressosSuperior}`);
  console.log(`Inferior: ${ingressosInferior}`);
}

function semIngresso(ingressoSelecionado) {
  alert(`Não temos mais ingressos para ${ingressoSelecionado} disponíveis.`);
}

function compraRealizada(quantidade, ingressoSelecionado, saldoAtual) {
  document.getElementById("qtd").value = "";
  alert(
    `Parabéns, você adquiriu ${quantidade} ingresso(s) para a ${ingressoSelecionado}. Temos mais ${saldoAtual} disponíveis!`
  );
}
