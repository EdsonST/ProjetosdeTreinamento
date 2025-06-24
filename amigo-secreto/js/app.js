let listaAmigos = [];

function adicionar() {
  let pessoas = document.getElementById("nome-amigo").value.trim();

  if (pessoas === "") {
    alert(`Nome não encontrado!`);
  } else if (listaAmigos.includes(pessoas)) {
    alert(`${pessoas} já está incluso`);
  } else {
    listaAmigos.push(pessoas);
    atualizarLista();
    console.log(`Lista de Amigos: ${listaAmigos}`);
  }

  document.getElementById("nome-amigo").value = "";
}

function atualizarLista() {
  let listaHTML = "";
  for (let amigo of listaAmigos) {
    listaHTML += `<li>${amigo}</li>`;
  }
  document.getElementById("lista-amigos").innerHTML = listaHTML;
}

function sortear() {
  if (listaAmigos.length < 2) {
    alert("Adicione pelo menos 2 amigos para sortear.");
    return;
  }

  listRandom(listaAmigos);

  let sorteio = document.getElementById("lista-sorteio");
  sorteio.innerHTML = "";

  for (let i = 0; i < listaAmigos.length; i++) {
    if (i === listaAmigos.length - 1) {
      sorteio.innerHTML += `${listaAmigos[i]} --> ${listaAmigos[0]}<br>`;
    } else {
      sorteio.innerHTML += `${listaAmigos[i]} --> ${listaAmigos[i + 1]}<br>`;
    }
  }
}

function reiniciar() {
  location.reload();
}

function listRandom(listaAmigos) {
  for (let i = listaAmigos.length; i; i--) {
    let aleatorio = Math.floor(Math.random() * i);
    [listaAmigos[i - 1], listaAmigos[aleatorio]] = [
      listaAmigos[aleatorio],
      listaAmigos[i - 1],
    ];
  }
}

function atualizarLista() {
  const ul = document.getElementById("lista-amigos");
  ul.innerHTML = ""; // Limpa antes de exibir novamente

  listaAmigos.forEach((amigo, index) => {
    const li = document.createElement("li");
    li.textContent = amigo;

    // Adiciona um evento de clique para remover o amigo
    li.style.cursor = "pointer"; // muda o mouse para indicar que é clicável
    li.title = "Clique para remover";
    li.onclick = () => {
      removerAmigo(index);
    };

    ul.appendChild(li);
  });
}

function removerAmigo(index) {
  listaAmigos.splice(index, 1); // Remove da lista
  atualizarLista(); // Atualiza a visualização
}
